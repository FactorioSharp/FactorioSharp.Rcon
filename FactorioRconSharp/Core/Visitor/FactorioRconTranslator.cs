﻿using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.v1_1_104.Model;

namespace FactorioRconSharp.Core.Visitor;

class FactorioRconTranslator : ExpressionVisitor
{
    StringBuilder _acc = null!;

    public string BuildExpression(Expression<Action<FactorioRconGlobals>> action)
    {
        _acc = new StringBuilder();

        Visit(action.Body);

        return _acc.ToString();
    }

    public string BuildExpression<T>(Expression<Func<FactorioRconGlobals, T>> func)
    {
        _acc = new StringBuilder();

        Visit(func.Body);

        return _acc.ToString();
    }

    protected override Expression VisitUnary(UnaryExpression node)
    {
        _acc.Append('(');

        switch (node.NodeType)
        {
            case ExpressionType.Not:
                _acc.Append("not ");
                break;
            case ExpressionType.Negate:
            case ExpressionType.NegateChecked:
                _acc.Append("- ");
                break;
            default:
                throw new NotSupportedException($"The unary operator {node.NodeType} is not supported");
        }

        Visit(node.Operand);

        _acc.Append(')');

        return node;
    }

    protected override Expression VisitBinary(BinaryExpression node)
    {
        _acc.Append('(');

        Visit(node.Left);

        switch (node.NodeType)
        {
            case ExpressionType.And:
            case ExpressionType.AndAlso:
                _acc.Append(" and ");
                break;
            case ExpressionType.Or:
            case ExpressionType.OrElse:
                _acc.Append(" or ");
                break;
            case ExpressionType.Add:
            case ExpressionType.AddChecked:
                if (node.Left.Type == typeof(string))
                {
                    _acc.Append(" .. ");
                }
                else
                {
                    _acc.Append(" + ");
                }
                break;
            case ExpressionType.Subtract:
            case ExpressionType.SubtractChecked:
                _acc.Append(" - ");
                break;
            case ExpressionType.Multiply:
            case ExpressionType.MultiplyChecked:
                _acc.Append(" * ");
                break;
            case ExpressionType.Divide:
                _acc.Append(" / ");
                break;
            case ExpressionType.Power:
                _acc.Append(" ^ ");
                break;
            case ExpressionType.GreaterThan:
                _acc.Append(" > ");
                break;
            case ExpressionType.GreaterThanOrEqual:
                _acc.Append(" >= ");
                break;
            case ExpressionType.LessThan:
                _acc.Append(" < ");
                break;
            case ExpressionType.LessThanOrEqual:
                _acc.Append(" <= ");
                break;
            case ExpressionType.Equal:
                _acc.Append(" == ");
                break;
            case ExpressionType.NotEqual:
                _acc.Append(" ~= ");
                break;
            default:
                throw new NotSupportedException($"The binary operator {node.NodeType} is not supported");
        }

        Visit(node.Right);

        _acc.Append(')');

        return node;
    }

    protected override Expression VisitMember(MemberExpression node)
    {
        List<MemberExpression> memberChain = new();
        Expression current = node;
        while (current is MemberExpression expr)
        {
            memberChain.Add(expr);
            current = expr.Expression;
        }
        memberChain.Reverse();

        for (int index = 0; index < memberChain.Count; index++)
        {
            MemberExpression member = memberChain[index];
            FactorioRconAttributeAttribute? attribute = member.Member.GetCustomAttribute<FactorioRconAttributeAttribute>();
            if (attribute == null)
            {
                throw new InvalidOperationException(
                    $"The member {member} cannot be used in an RCON expression because it is not marked with the [FactorioRconAttribute] attribute"
                );
            }

            if (index > 0)
            {
                _acc.Append('.');
            }

            _acc.Append(attribute.Name);
        }

        return node;
    }

    protected override Expression VisitMethodCall(MethodCallExpression node)
    {
        if (node.Arguments.Any())
        {
            throw new NotSupportedException("Method calls with parameters not supported yet");
        }

        FactorioRconMethodAttribute? attribute = node.Method.GetCustomAttribute<FactorioRconMethodAttribute>();
        if (attribute == null)
        {
            throw new InvalidOperationException($"The method {node} cannot be used in an RCON expression because it is not marked with the [FactorioRconMethod] attribute");
        }

        Visit(node.Object);

        _acc.Append('.');

        _acc.Append(attribute.Name);

        _acc.Append('(');
        _acc.Append(')');

        return node;
    }

    protected override Expression VisitNewArray(NewArrayExpression node)
    {
        _acc.Append("ARRAY");

        return node;
    }
}
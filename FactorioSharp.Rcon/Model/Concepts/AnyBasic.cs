#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Builtins;
using OneOf;

namespace FactorioSharp.Rcon.Model.Concepts;

/// <summary>
///     Any basic type (string, number, boolean) or table.
/// </summary>
[GenerateOneOf]
[FactorioRconConcept("AnyBasic")]
public partial class AnyBasic : OneOfBase<string, bool, double, LuaTable>
{
}
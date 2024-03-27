#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Anonymous;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using FactorioRconSharp.Model.Utils;
using OneOf;

namespace FactorioRconSharp.Model.Concepts;

/// <summary>
/// A force may be specified in one of three ways.
/// </summary>
[GenerateOneOf]
[FactorioRconConcept("ForceIdentification")]
public abstract partial class ForceIdentification: OneOfBase<byte, string, LuaForce>
{
}


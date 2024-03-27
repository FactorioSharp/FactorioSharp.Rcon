#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Utils;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using OneOf;

namespace FactorioRconSharp.Model.Concepts;

/// <summary>
/// A surface may be specified in one of three ways.
/// </summary>
[GenerateOneOf]
[FactorioRconConcept("SurfaceIdentification")]
public abstract partial class SurfaceIdentification: OneOfBase<uint, string, LuaSurface>
{
}

[GenerateOneOf]
public abstract partial class Union11433865: OneOfBase<uint, string, LuaSurface>
{
}


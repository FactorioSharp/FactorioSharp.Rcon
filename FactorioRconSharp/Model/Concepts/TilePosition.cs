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
/// Coordinates of a tile on a <see cref="MapPosition" />, except it rounds any non-integer `x`/`y` down to whole numbers. It can be specified either with or without explicit keys.
/// </summary>
[GenerateOneOf]
[FactorioRconConcept("TilePosition")]
public abstract partial class TilePosition: OneOfBase<Type1421203362, Type1421203362>
{
}


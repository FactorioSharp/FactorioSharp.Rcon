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
/// Coordinates of a chunk in a <see cref="MapPosition" /> can be translated to a ChunkPosition by dividing the `x`/`y` values by 32.
/// </summary>
[FactorioRconConcept("ChunkPosition")]
public class ChunkPosition
{
}


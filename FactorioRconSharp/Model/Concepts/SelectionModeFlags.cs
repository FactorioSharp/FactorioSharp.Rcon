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
/// A set of flags on a selection tool that define how entities and tiles are selected. Active flags are in the dictionary as `true`, while inactive flags aren't present at all.
/// </summary>
[FactorioRconConcept("SelectionModeFlags")]
public class SelectionModeFlags
{
}

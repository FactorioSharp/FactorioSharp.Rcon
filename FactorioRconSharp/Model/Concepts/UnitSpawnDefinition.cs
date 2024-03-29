#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Anonymous;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using FactorioRconSharp.Model.Utils;

namespace FactorioRconSharp.Model.Concepts;

[FactorioRconConcept("UnitSpawnDefinition")]
public class UnitSpawnDefinition
{
  /// <summary>
  /// Prototype name of the unit that would be spawned.
  /// </summary>
  [FactorioRconAttribute("unit")]
  public string Unit { get; set; }

  /// <summary>
  /// The points at which to spawn the unit.
  /// </summary>
  [FactorioRconAttribute("spawn_points")]
  public List<SpawnPointDefinition> SpawnPoints { get; set; }

}


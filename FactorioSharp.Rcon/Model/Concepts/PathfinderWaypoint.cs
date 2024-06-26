#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Anonymous;
using FactorioSharp.Rcon.Model.Builtins;
using FactorioSharp.Rcon.Model.Classes;
using FactorioSharp.Rcon.Model.Definitions;
using FactorioSharp.Rcon.Model.Utils;

namespace FactorioSharp.Rcon.Model.Concepts;

[FactorioRconConcept("PathfinderWaypoint")]
public class PathfinderWaypoint
{
  /// <summary>
  /// The position of the waypoint on its surface.
  /// </summary>
  [FactorioRconAttribute("position")]
  public MapPosition Position { get; set; }

  /// <summary>
  /// `true` if the path from the previous waypoint to this one goes through an entity that must be destroyed.
  /// </summary>
  [FactorioRconAttribute("needs_destroy_to_reach")]
  public bool NeedsDestroyToReach { get; set; }

}


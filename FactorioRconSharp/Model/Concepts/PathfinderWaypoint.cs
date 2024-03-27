#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Utils;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using OneOf;

namespace FactorioRconSharp.Model.Concepts;

[FactorioRconConcept("PathfinderWaypoint")]
public abstract class PathfinderWaypoint
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

public abstract class Table15003156
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


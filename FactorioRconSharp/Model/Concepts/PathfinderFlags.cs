#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Utils;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using OneOf;

namespace FactorioRconSharp.Model.Concepts;

[FactorioRconConcept("PathfinderFlags")]
public abstract class PathfinderFlags
{
  /// <summary>
  /// Allows pathing through friendly entities. Defaults to `false`.
  /// </summary>
  [FactorioRconAttribute("allow_destroy_friendly_entities")]
  public bool AllowDestroyFriendlyEntities { get; set; }

  /// <summary>
  /// Allows the pathfinder to path through entities of the same force. Defaults to `false`.
  /// </summary>
  [FactorioRconAttribute("allow_paths_through_own_entities")]
  public bool AllowPathsThroughOwnEntities { get; set; }

  /// <summary>
  /// Enables path caching. This can be more efficient, but might fail to respond to changes in the environment. Defaults to `true`.
  /// </summary>
  [FactorioRconAttribute("cache")]
  public bool Cache { get; set; }

  /// <summary>
  /// Makes the pathfinder try to path in straight lines. Defaults to `false`.
  /// </summary>
  [FactorioRconAttribute("prefer_straight_paths")]
  public bool PreferStraightPaths { get; set; }

  /// <summary>
  /// Sets lower priority on the path request, meaning it might take longer to find a path at the expense of speeding up others. Defaults to `false`.
  /// </summary>
  [FactorioRconAttribute("low_priority")]
  public bool LowPriority { get; set; }

  /// <summary>
  /// Makes the pathfinder not break in the middle of processing this pathfind, no matter how much work is needed. Defaults to `false`.
  /// </summary>
  [FactorioRconAttribute("no_break")]
  public bool NoBreak { get; set; }

}

public abstract class Table517350
{
  /// <summary>
  /// Allows pathing through friendly entities. Defaults to `false`.
  /// </summary>
  [FactorioRconAttribute("allow_destroy_friendly_entities")]
  public bool AllowDestroyFriendlyEntities { get; set; }

  /// <summary>
  /// Allows the pathfinder to path through entities of the same force. Defaults to `false`.
  /// </summary>
  [FactorioRconAttribute("allow_paths_through_own_entities")]
  public bool AllowPathsThroughOwnEntities { get; set; }

  /// <summary>
  /// Enables path caching. This can be more efficient, but might fail to respond to changes in the environment. Defaults to `true`.
  /// </summary>
  [FactorioRconAttribute("cache")]
  public bool Cache { get; set; }

  /// <summary>
  /// Makes the pathfinder try to path in straight lines. Defaults to `false`.
  /// </summary>
  [FactorioRconAttribute("prefer_straight_paths")]
  public bool PreferStraightPaths { get; set; }

  /// <summary>
  /// Sets lower priority on the path request, meaning it might take longer to find a path at the expense of speeding up others. Defaults to `false`.
  /// </summary>
  [FactorioRconAttribute("low_priority")]
  public bool LowPriority { get; set; }

  /// <summary>
  /// Makes the pathfinder not break in the middle of processing this pathfind, no matter how much work is needed. Defaults to `false`.
  /// </summary>
  [FactorioRconAttribute("no_break")]
  public bool NoBreak { get; set; }

}


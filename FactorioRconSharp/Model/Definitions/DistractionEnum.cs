#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Utils;

namespace FactorioRconSharp.Model.Definitions;

[FactorioRconDefinition("distraction")]
public enum DistractionEnum
{
  /// <summary>
  /// Perform command even if someone attacks the unit.
  /// </summary>
  [FactorioRconDefinitionValue("none")]
  None,

  /// <summary>
  /// Attack closer enemy entities with force.
  /// </summary>
  [FactorioRconDefinitionValue("by_enemy")]
  ByEnemy,

  /// <summary>
  /// Attack closer enemy entities, including entities "built" by player (belts, inserters, chests).
  /// </summary>
  [FactorioRconDefinitionValue("by_anything")]
  ByAnything,

  /// <summary>
  /// Attack when attacked.
  /// </summary>
  [FactorioRconDefinitionValue("by_damage")]
  ByDamage,

}


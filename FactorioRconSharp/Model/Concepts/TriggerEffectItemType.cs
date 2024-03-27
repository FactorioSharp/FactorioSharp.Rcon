#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Anonymous;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using FactorioRconSharp.Model.Utils;

namespace FactorioRconSharp.Model.Concepts;

/// <summary>
/// Used by <see cref="TriggerEffectItem" />.
/// </summary>
[FactorioRconDefinition("TriggerEffectItemType")]
public enum TriggerEffectItemType
{
  /// <summary>
  /// Literal value: damage
  /// </summary>
  [FactorioRconDefinitionValue("damage")]
  Damage,

  /// <summary>
  /// Literal value: create-entity
  /// </summary>
  [FactorioRconDefinitionValue("create-entity")]
  Createsubtractentity,

  /// <summary>
  /// Literal value: create-explosion
  /// </summary>
  [FactorioRconDefinitionValue("create-explosion")]
  Createsubtractexplosion,

  /// <summary>
  /// Literal value: create-fire
  /// </summary>
  [FactorioRconDefinitionValue("create-fire")]
  Createsubtractfire,

  /// <summary>
  /// Literal value: create-smoke
  /// </summary>
  [FactorioRconDefinitionValue("create-smoke")]
  Createsubtractsmoke,

  /// <summary>
  /// Literal value: create-trivial-smoke
  /// </summary>
  [FactorioRconDefinitionValue("create-trivial-smoke")]
  Createsubtracttrivialsubtractsmoke,

  /// <summary>
  /// Literal value: create-particle
  /// </summary>
  [FactorioRconDefinitionValue("create-particle")]
  Createsubtractparticle,

  /// <summary>
  /// Literal value: create-sticker
  /// </summary>
  [FactorioRconDefinitionValue("create-sticker")]
  Createsubtractsticker,

  /// <summary>
  /// Literal value: create-decorative
  /// </summary>
  [FactorioRconDefinitionValue("create-decorative")]
  Createsubtractdecorative,

  /// <summary>
  /// Literal value: nested-result
  /// </summary>
  [FactorioRconDefinitionValue("nested-result")]
  Nestedsubtractresult,

  /// <summary>
  /// Literal value: play-sound
  /// </summary>
  [FactorioRconDefinitionValue("play-sound")]
  Playsubtractsound,

  /// <summary>
  /// Literal value: push-back
  /// </summary>
  [FactorioRconDefinitionValue("push-back")]
  Pushsubtractback,

  /// <summary>
  /// Literal value: destroy-cliffs
  /// </summary>
  [FactorioRconDefinitionValue("destroy-cliffs")]
  Destroysubtractcliffs,

  /// <summary>
  /// Literal value: show-explosion-on-chart
  /// </summary>
  [FactorioRconDefinitionValue("show-explosion-on-chart")]
  Showsubtractexplosionsubtractonsubtractchart,

  /// <summary>
  /// Literal value: insert-item
  /// </summary>
  [FactorioRconDefinitionValue("insert-item")]
  Insertsubtractitem,

  /// <summary>
  /// Literal value: script
  /// </summary>
  [FactorioRconDefinitionValue("script")]
  Script,

  /// <summary>
  /// Literal value: set-tile
  /// </summary>
  [FactorioRconDefinitionValue("set-tile")]
  Setsubtracttile,

  /// <summary>
  /// Literal value: invoke-tile-trigger
  /// </summary>
  [FactorioRconDefinitionValue("invoke-tile-trigger")]
  Invokesubtracttilesubtracttrigger,

  /// <summary>
  /// Literal value: destroy-decoratives
  /// </summary>
  [FactorioRconDefinitionValue("destroy-decoratives")]
  Destroysubtractdecoratives,

  /// <summary>
  /// Literal value: camera-effect
  /// </summary>
  [FactorioRconDefinitionValue("camera-effect")]
  Camerasubtracteffect,

}


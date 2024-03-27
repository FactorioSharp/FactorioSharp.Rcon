#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Utils;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using OneOf;

namespace FactorioRconSharp.Model.Concepts;

[FactorioRconConcept("AttackParameters")]
public abstract class AttackParameters
{
  /// <summary>
  /// The type of AttackParameter.
  /// </summary>
  [FactorioRconAttribute("type")]
  public Union26445479 Type { get; set; }

  /// <summary>
  /// Maximum range of attack.
  /// </summary>
  [FactorioRconAttribute("range")]
  public float Range { get; set; }

  /// <summary>
  /// Minimum range of attack. Used with flamethrower turrets to prevent self-immolation.
  /// </summary>
  [FactorioRconAttribute("min_range")]
  public float MinRange { get; set; }

  /// <summary>
  /// Defines how the range is determined.
  /// </summary>
  [FactorioRconAttribute("range_mode")]
  public Union28721410 RangeMode { get; set; }

  /// <summary>
  /// When searching for the nearest enemy to attack, `fire_penalty` is added to the enemy's distance if they are on fire.
  /// </summary>
  [FactorioRconAttribute("fire_penalty")]
  public float FirePenalty { get; set; }

  /// <summary>
  /// When searching for an enemy to attack, a higher `rotate_penalty` will discourage targeting enemies that would take longer to turn to face.
  /// </summary>
  [FactorioRconAttribute("rotate_penalty")]
  public float RotatePenalty { get; set; }

  /// <summary>
  /// When searching for an enemy to attack, a higher `health_penalty` will discourage targeting enemies with high health. A negative penalty will do the opposite.
  /// </summary>
  [FactorioRconAttribute("health_penalty")]
  public float HealthPenalty { get; set; }

  /// <summary>
  /// If less than `range`, the entity will choose a random distance between `range` and `min_attack_distance` and attack from that distance. Used for spitters.
  /// </summary>
  [FactorioRconAttribute("min_attack_distance")]
  public float MinAttackDistance { get; set; }

  /// <summary>
  /// The arc that the entity can attack in as a fraction of a circle. A value of `1` means the full 360 degrees.
  /// </summary>
  [FactorioRconAttribute("turn_range")]
  public float TurnRange { get; set; }

  /// <summary>
  /// Multiplier applied to the damage of an attack.
  /// </summary>
  [FactorioRconAttribute("damage_modifier")]
  public float DamageModifier { get; set; }

  /// <summary>
  /// Multiplier applied to the ammo consumption of an attack.
  /// </summary>
  [FactorioRconAttribute("ammo_consumption_modifier")]
  public float AmmoConsumptionModifier { get; set; }

  /// <summary>
  /// Minimum amount of ticks between shots. If this is less than `1`, multiple shots can be performed per tick.
  /// </summary>
  [FactorioRconAttribute("cooldown")]
  public float Cooldown { get; set; }

  /// <summary>
  /// Number of ticks it takes for the weapon to actually shoot after it has been ordered to do so.
  /// </summary>
  [FactorioRconAttribute("warmup")]
  public uint Warmup { get; set; }

  [FactorioRconAttribute("movement_slow_down_factor")]
  public double MovementSlowDownFactor { get; set; }

  [FactorioRconAttribute("movement_slow_down_cooldown")]
  public float MovementSlowDownCooldown { get; set; }

  [FactorioRconAttribute("ammo_type")]
  public AmmoType AmmoType { get; set; }

  /// <summary>
  /// List of the names of compatible <see cref="LuaAmmoCategoryPrototype" />.
  /// </summary>
  [FactorioRconAttribute("ammo_categories")]
  public List<string> AmmoCategories { get; set; }

}

public abstract class Table17110604
{
  /// <summary>
  /// The type of AttackParameter.
  /// </summary>
  [FactorioRconAttribute("type")]
  public Union26445479 Type { get; set; }

  /// <summary>
  /// Maximum range of attack.
  /// </summary>
  [FactorioRconAttribute("range")]
  public float Range { get; set; }

  /// <summary>
  /// Minimum range of attack. Used with flamethrower turrets to prevent self-immolation.
  /// </summary>
  [FactorioRconAttribute("min_range")]
  public float MinRange { get; set; }

  /// <summary>
  /// Defines how the range is determined.
  /// </summary>
  [FactorioRconAttribute("range_mode")]
  public Union28721410 RangeMode { get; set; }

  /// <summary>
  /// When searching for the nearest enemy to attack, `fire_penalty` is added to the enemy's distance if they are on fire.
  /// </summary>
  [FactorioRconAttribute("fire_penalty")]
  public float FirePenalty { get; set; }

  /// <summary>
  /// When searching for an enemy to attack, a higher `rotate_penalty` will discourage targeting enemies that would take longer to turn to face.
  /// </summary>
  [FactorioRconAttribute("rotate_penalty")]
  public float RotatePenalty { get; set; }

  /// <summary>
  /// When searching for an enemy to attack, a higher `health_penalty` will discourage targeting enemies with high health. A negative penalty will do the opposite.
  /// </summary>
  [FactorioRconAttribute("health_penalty")]
  public float HealthPenalty { get; set; }

  /// <summary>
  /// If less than `range`, the entity will choose a random distance between `range` and `min_attack_distance` and attack from that distance. Used for spitters.
  /// </summary>
  [FactorioRconAttribute("min_attack_distance")]
  public float MinAttackDistance { get; set; }

  /// <summary>
  /// The arc that the entity can attack in as a fraction of a circle. A value of `1` means the full 360 degrees.
  /// </summary>
  [FactorioRconAttribute("turn_range")]
  public float TurnRange { get; set; }

  /// <summary>
  /// Multiplier applied to the damage of an attack.
  /// </summary>
  [FactorioRconAttribute("damage_modifier")]
  public float DamageModifier { get; set; }

  /// <summary>
  /// Multiplier applied to the ammo consumption of an attack.
  /// </summary>
  [FactorioRconAttribute("ammo_consumption_modifier")]
  public float AmmoConsumptionModifier { get; set; }

  /// <summary>
  /// Minimum amount of ticks between shots. If this is less than `1`, multiple shots can be performed per tick.
  /// </summary>
  [FactorioRconAttribute("cooldown")]
  public float Cooldown { get; set; }

  /// <summary>
  /// Number of ticks it takes for the weapon to actually shoot after it has been ordered to do so.
  /// </summary>
  [FactorioRconAttribute("warmup")]
  public uint Warmup { get; set; }

  [FactorioRconAttribute("movement_slow_down_factor")]
  public double MovementSlowDownFactor { get; set; }

  [FactorioRconAttribute("movement_slow_down_cooldown")]
  public float MovementSlowDownCooldown { get; set; }

  [FactorioRconAttribute("ammo_type")]
  public AmmoType AmmoType { get; set; }

  /// <summary>
  /// List of the names of compatible <see cref="LuaAmmoCategoryPrototype" />.
  /// </summary>
  [FactorioRconAttribute("ammo_categories")]
  public List<string> AmmoCategories { get; set; }

}

[GenerateOneOf]
public abstract partial class Union28721410: OneOfBase<Literal27614525, Literal62623739>
{
}

/// <summary>
/// Literal value: center-to-center
/// </summary>
public enum Literal27614525
{
  /// <summary>
  /// Literal value: center-to-center
  /// </summary>
  [FactorioRconDefinitionValue("center-to-center")]
  CenterToCenter,

}

/// <summary>
/// Literal value: bounding-box-to-bounding-box
/// </summary>
public enum Literal62623739
{
  /// <summary>
  /// Literal value: bounding-box-to-bounding-box
  /// </summary>
  [FactorioRconDefinitionValue("bounding-box-to-bounding-box")]
  BoundingBoxToBoundingBox,

}

[GenerateOneOf]
public abstract partial class Union26445479: OneOfBase<Literal4149120, Literal53215622, Literal66858053>
{
}

/// <summary>
/// Literal value: projectile
/// </summary>
public enum Literal4149120
{
  /// <summary>
  /// Literal value: projectile
  /// </summary>
  [FactorioRconDefinitionValue("projectile")]
  Projectile,

}

/// <summary>
/// Literal value: stream
/// </summary>
public enum Literal53215622
{
  /// <summary>
  /// Literal value: stream
  /// </summary>
  [FactorioRconDefinitionValue("stream")]
  Stream,

}

/// <summary>
/// Literal value: beam
/// </summary>
public enum Literal66858053
{
  /// <summary>
  /// Literal value: beam
  /// </summary>
  [FactorioRconDefinitionValue("beam")]
  Beam,

}


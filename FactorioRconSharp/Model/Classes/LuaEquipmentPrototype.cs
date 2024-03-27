#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Utils;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Concepts;
using FactorioRconSharp.Model.Definitions;
using OneOf;

namespace FactorioRconSharp.Model.Classes;

/// <summary>
/// Prototype of a modular equipment.
/// </summary>
[FactorioRconClass("LuaEquipmentPrototype")]
public abstract class LuaEquipmentPrototype: LuaObject
{
  /// <summary>
  /// Name of this prototype.
  /// </summary>
  [FactorioRconAttribute("name")]
  public string Name { get; private set; }

  /// <summary>
  /// Type of this equipment prototype.
  /// </summary>
  [FactorioRconAttribute("type")]
  public string Type { get; private set; }

  /// <summary>
  /// The string used to alphabetically sort these prototypes. It is a simple string that has no additional semantic meaning.
  /// </summary>
  [FactorioRconAttribute("order")]
  public string Order { get; private set; }

  [FactorioRconAttribute("localised_name")]
  public LocalisedString LocalisedName { get; private set; }

  [FactorioRconAttribute("localised_description")]
  public LocalisedString LocalisedDescription { get; private set; }

  /// <summary>
  /// Shape of this equipment prototype.
  /// </summary>
  [FactorioRconAttribute("shape")]
  public Table16023056 Shape { get; private set; }

  /// <summary>
  /// The result item when taking this equipment out of an equipment grid, if any.
  /// </summary>
  [FactorioRconAttribute("take_result")]
  public LuaItemPrototype TakeResult { get; private set; }

  /// <summary>
  /// The max power generated by this equipment.
  /// </summary>
  [FactorioRconAttribute("energy_production")]
  public double EnergyProduction { get; private set; }

  /// <summary>
  /// The shield value of this equipment. 0 for non-shield equipment.
  /// </summary>
  [FactorioRconAttribute("shield")]
  public float Shield { get; private set; }

  /// <summary>
  /// The energy per shield point restored. 0 for non-shield equipment.
  /// </summary>
  [FactorioRconAttribute("energy_per_shield")]
  public double EnergyPerShield { get; private set; }

  /// <summary>
  /// The logistic parameters for this roboport equipment.
  /// </summary>
  [FactorioRconAttribute("logistic_parameters")]
  public Table58998806 LogisticParameters { get; private set; }

  [FactorioRconAttribute("energy_consumption")]
  public double EnergyConsumption { get; private set; }

  [FactorioRconAttribute("movement_bonus")]
  public float MovementBonus { get; private set; }

  /// <summary>
  /// The energy source prototype for the equipment.
  /// </summary>
  [FactorioRconAttribute("energy_source")]
  public LuaElectricEnergySourcePrototype EnergySource { get; private set; }

  /// <summary>
  /// Category names for this equipment. These <see cref="LuaEquipmentGridPrototype.EquipmentCategories" /> will be used to determine whether this equipment is allowed in a particular equipment grid.
  /// </summary>
  [FactorioRconAttribute("equipment_categories")]
  public List<string> EquipmentCategories { get; private set; }

  /// <summary>
  /// The burner energy source prototype this equipment uses, if any.
  /// </summary>
  [FactorioRconAttribute("burner_prototype")]
  public LuaBurnerPrototype BurnerPrototype { get; private set; }

  /// <summary>
  /// The electric energy source prototype this equipment uses, if any.
  /// </summary>
  [FactorioRconAttribute("electric_energy_source_prototype")]
  public LuaElectricEnergySourcePrototype ElectricEnergySourcePrototype { get; private set; }

  /// <summary>
  /// The background color of this equipment prototype.
  /// </summary>
  [FactorioRconAttribute("background_color")]
  public Color BackgroundColor { get; private set; }

  /// <summary>
  /// The equipment attack parameters.
  /// </summary>
  [FactorioRconAttribute("attack_parameters")]
  public AttackParameters AttackParameters { get; private set; }

  /// <summary>
  /// Whether this active defense equipment is automatic. Returns false if not active defense equipment.
  /// </summary>
  [FactorioRconAttribute("automatic")]
  public bool Automatic { get; private set; }

  /// <summary>
  /// Is this object valid? This Lua object holds a reference to an object within the game engine. It is possible that the game-engine object is removed whilst a mod still holds the corresponding Lua object. If that happens, the object becomes invalid, i.e. this attribute will be `false`. Mods are advised to check for object validity if any change to the game state might have occurred between the creation of the Lua object and its access.
  /// </summary>
  [FactorioRconAttribute("valid")]
  public bool Valid { get; private set; }

  /// <summary>
  /// The class name of this object. Available even when `valid` is false. For LuaStruct objects it may also be suffixed with a dotted path to a member of the struct.
  /// </summary>
  [FactorioRconAttribute("object_name")]
  public string ObjectName { get; private set; }

  /// <summary>
  /// All methods and properties that this object supports.
  /// </summary>
  [FactorioRconMethod("help")]
  public abstract string Help();

}

public abstract class Table58998806
{
  [FactorioRconAttribute("spawn_and_station_height")]
  public float SpawnAndStationHeight { get; set; }

  [FactorioRconAttribute("spawn_and_station_shadow_height_offset")]
  public float SpawnAndStationShadowHeightOffset { get; set; }

  [FactorioRconAttribute("charge_approach_distance")]
  public float ChargeApproachDistance { get; set; }

  [FactorioRconAttribute("logistic_radius")]
  public float LogisticRadius { get; set; }

  [FactorioRconAttribute("construction_radius")]
  public float ConstructionRadius { get; set; }

  [FactorioRconAttribute("charging_station_count")]
  public uint ChargingStationCount { get; set; }

  [FactorioRconAttribute("charging_distance")]
  public float ChargingDistance { get; set; }

  [FactorioRconAttribute("charging_station_shift")]
  public Vector ChargingStationShift { get; set; }

  [FactorioRconAttribute("charging_energy")]
  public double ChargingEnergy { get; set; }

  [FactorioRconAttribute("charging_threshold_distance")]
  public float ChargingThresholdDistance { get; set; }

  [FactorioRconAttribute("robot_vertical_acceleration")]
  public float RobotVerticalAcceleration { get; set; }

  [FactorioRconAttribute("stationing_offset")]
  public Vector StationingOffset { get; set; }

  [FactorioRconAttribute("robot_limit")]
  public uint RobotLimit { get; set; }

  [FactorioRconAttribute("logistics_connection_distance")]
  public float LogisticsConnectionDistance { get; set; }

  [FactorioRconAttribute("robots_shrink_when_entering_and_exiting")]
  public bool RobotsShrinkWhenEnteringAndExiting { get; set; }

}

public abstract class Table16023056
{
  [FactorioRconAttribute("width")]
  public uint Width { get; set; }

  [FactorioRconAttribute("height")]
  public uint Height { get; set; }

  /// <summary>
  /// Only set when the shape is "manual"
  /// </summary>
  [FactorioRconAttribute("points")]
  public List<EquipmentPoint> Points { get; set; }

}


#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Anonymous;
using FactorioSharp.Rcon.Model.Builtins;
using FactorioSharp.Rcon.Model.Concepts;
using FactorioSharp.Rcon.Model.Definitions;
using FactorioSharp.Rcon.Model.Utils;

namespace FactorioSharp.Rcon.Model.Classes;

/// <summary>
/// An equipment grid is for example the inside of a power armor.
/// </summary>
[FactorioRconClass("LuaEquipmentGrid")]
public abstract class LuaEquipmentGrid: LuaObject
{
  [FactorioRconAttribute("prototype")]
  public LuaEquipmentGridPrototype Prototype { get; private set; }

  /// <summary>
  /// Width of the equipment grid.
  /// </summary>
  [FactorioRconAttribute("width")]
  public uint Width { get; private set; }

  /// <summary>
  /// Height of the equipment grid.
  /// </summary>
  [FactorioRconAttribute("height")]
  public uint Height { get; private set; }

  /// <summary>
  /// All the equipment in this grid.
  /// </summary>
  [FactorioRconAttribute("equipment")]
  public List<LuaEquipment> Equipment { get; private set; }

  /// <summary>
  /// Total energy per tick generated by the equipment inside this grid.
  /// </summary>
  [FactorioRconAttribute("generator_energy")]
  public double GeneratorEnergy { get; private set; }

  /// <summary>
  /// Maximum energy per tick that can be created by any solar panels in the equipment grid. Actual generated energy varies depending on the daylight levels.
  /// </summary>
  [FactorioRconAttribute("max_solar_energy")]
  public double MaxSolarEnergy { get; private set; }

  /// <summary>
  /// The total energy stored in all batteries in the equipment grid.
  /// </summary>
  [FactorioRconAttribute("available_in_batteries")]
  public double AvailableInBatteries { get; private set; }

  /// <summary>
  /// Total energy storage capacity of all batteries in the equipment grid.
  /// </summary>
  [FactorioRconAttribute("battery_capacity")]
  public double BatteryCapacity { get; private set; }

  /// <summary>
  /// The amount of shields this equipment grid has.
  /// </summary>
  [FactorioRconAttribute("shield")]
  public float Shield { get; private set; }

  /// <summary>
  /// The maximum amount of shields this equipment grid has.
  /// </summary>
  [FactorioRconAttribute("max_shield")]
  public float MaxShield { get; private set; }

  /// <summary>
  /// Whether this grid's equipment movement bonus is active.
  /// </summary>
  [FactorioRconAttribute("inhibit_movement_bonus")]
  public bool InhibitMovementBonus { get; set; }

  /// <summary>
  /// Unique identifier of this equipment grid.
  /// </summary>
  [FactorioRconAttribute("unique_id")]
  public uint UniqueId { get; private set; }

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
  /// Remove an equipment from the grid.
  /// </summary>
  /// <param name="position">Lua name: position</param>
  /// <param name="equipment">Lua name: equipment</param>
  /// <param name="byPlayer">Lua name: by_player</param>
  [FactorioRconMethod("take")]
  public abstract SimpleItemStack? Take(EquipmentPosition? position = null, LuaEquipment? equipment = null, PlayerIdentification? byPlayer = null);

  /// <summary>
  /// Remove all equipment from the grid.
  /// </summary>
  /// <param name="byPlayer">Lua name: by_player</param>
  [FactorioRconMethod("take_all")]
  public abstract Dictionary<string, uint> TakeAll(PlayerIdentification? byPlayer = null);

  /// <summary>
  /// Clear all equipment from the grid, removing it without actually returning it.
  /// </summary>
  /// <param name="byPlayer">Lua name: by_player</param>
  [FactorioRconMethod("clear")]
  public abstract void Clear(PlayerIdentification? byPlayer = null);

  /// <summary>
  /// Insert an equipment into the grid.
  /// </summary>
  /// <param name="name">Lua name: name</param>
  /// <param name="position">Lua name: position</param>
  /// <param name="byPlayer">Lua name: by_player</param>
  [FactorioRconMethod("put")]
  public abstract LuaEquipment? Put(string name, EquipmentPosition? position = null, PlayerIdentification? byPlayer = null);

  /// <summary>
  /// Check whether moving an equipment would succeed.
  /// </summary>
  /// <param name="equipment">Lua name: equipment</param>
  /// <param name="position">Lua name: position</param>
  [FactorioRconMethod("can_move")]
  public abstract bool CanMove(LuaEquipment equipment, EquipmentPosition position);

  /// <summary>
  /// Move an equipment within this grid.
  /// </summary>
  /// <param name="equipment">Lua name: equipment</param>
  /// <param name="position">Lua name: position</param>
  [FactorioRconMethod("move")]
  public abstract bool Move(LuaEquipment equipment, EquipmentPosition position);

  /// <summary>
  /// Find equipment in the Equipment Grid based off a position.
  /// </summary>
  /// <param name="position">Lua name: position</param>
  [FactorioRconMethod("get")]
  public abstract LuaEquipment? Get(EquipmentPosition position);

  /// <summary>
  /// Get counts of all equipment in this grid.
  /// </summary>
  [FactorioRconMethod("get_contents")]
  public abstract Dictionary<string, uint> GetContents();

  /// <summary>
  /// Find equipment by name.
  /// </summary>
  /// <param name="equipment">Lua name: equipment</param>
  [FactorioRconMethod("find")]
  public abstract LuaEquipment? Find(string equipment);

  /// <summary>
  /// Get the number of all or some equipment in this grid.
  /// </summary>
  /// <param name="equipment">Lua name: equipment</param>
  [FactorioRconMethod("count")]
  public abstract uint Count(string? equipment = null);

  /// <summary>
  /// All methods and properties that this object supports.
  /// </summary>
  [FactorioRconMethod("help")]
  public abstract string Help();

}


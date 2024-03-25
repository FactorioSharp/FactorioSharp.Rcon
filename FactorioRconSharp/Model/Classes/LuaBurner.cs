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
/// A reference to the burner energy source owned by a specific <see cref="LuaEquipment" />.
/// </summary>
[FactorioRconClass("LuaBurner")]
public class LuaBurner
{
  /// <summary>
  /// The owner of this burner energy source
  /// </summary>
  [FactorioRconAttribute("owner")]
  public OneOf<LuaEntity, LuaEquipment> Owner { get; private set; }

  /// <summary>
  /// The fuel inventory.
  /// </summary>
  [FactorioRconAttribute("inventory")]
  public LuaInventory Inventory { get; private set; }

  /// <summary>
  /// The burnt result inventory.
  /// </summary>
  [FactorioRconAttribute("burnt_result_inventory")]
  public LuaInventory BurntResultInventory { get; private set; }

  /// <summary>
  /// The current heat (energy) stored in this burner.
  /// </summary>
  [FactorioRconAttribute("heat")]
  public double Heat { get; set; }

  /// <summary>
  /// The maximum heat (maximum energy) that this burner can store.
  /// </summary>
  [FactorioRconAttribute("heat_capacity")]
  public double HeatCapacity { get; private set; }

  /// <summary>
  /// The amount of energy left in the currently-burning fuel item.
  /// </summary>
  [FactorioRconAttribute("remaining_burning_fuel")]
  public double RemainingBurningFuel { get; set; }

  /// <summary>
  /// The currently burning item. Writing `nil` will void the currently burning item without producing a <see cref="LuaBurner.BurntResult" />.
  /// </summary>
  [FactorioRconAttribute("currently_burning")]
  public LuaItemPrototype CurrentlyBurning { get; set; }

  /// <summary>
  /// The fuel categories this burner uses.
  /// </summary>
  [FactorioRconAttribute("fuel_categories")]
  public Dictionary<string, bool> FuelCategories { get; private set; }

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
  public string Help() => throw FactorioModelUtils.UseClientReadAsyncMethod();

}

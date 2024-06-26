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
/// Prototype of a mod setting.
/// </summary>
[FactorioRconClass("LuaModSettingPrototype")]
public abstract class LuaModSettingPrototype: LuaObject
{
  /// <summary>
  /// Type of this prototype.
  /// </summary>
  [FactorioRconAttribute("type")]
  public string Type { get; private set; }

  /// <summary>
  /// Name of this prototype.
  /// </summary>
  [FactorioRconAttribute("name")]
  public string Name { get; private set; }

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
  /// The mod that owns this setting.
  /// </summary>
  [FactorioRconAttribute("mod")]
  public string Mod { get; private set; }

  [FactorioRconAttribute("setting_type")]
  public string SettingType { get; private set; }

  /// <summary>
  /// The default value of this setting.
  /// </summary>
  [FactorioRconAttribute("default_value")]
  public Union2102353990 DefaultValue { get; private set; }

  /// <summary>
  /// The minimum value for this setting. `nil` if this setting type doesn't support a minimum.
  /// </summary>
  [FactorioRconAttribute("minimum_value")]
  public Union1418734391 MinimumValue { get; private set; }

  /// <summary>
  /// The maximum value for this setting. `nil` if this setting type doesn't support a maximum.
  /// </summary>
  [FactorioRconAttribute("maximum_value")]
  public Union1418734391 MaximumValue { get; private set; }

  /// <summary>
  /// The allowed values for this setting. `nil` if this setting doesn't use the a fixed set of values.
  /// </summary>
  [FactorioRconAttribute("allowed_values")]
  public Union1188015788 AllowedValues { get; private set; }

  /// <summary>
  /// Whether this string setting allows blank values. `nil` if not a string setting.
  /// </summary>
  [FactorioRconAttribute("allow_blank")]
  public bool AllowBlank { get; private set; }

  /// <summary>
  /// Whether this string setting auto-trims values. `nil` if not a string setting
  /// </summary>
  [FactorioRconAttribute("auto_trim")]
  public bool AutoTrim { get; private set; }

  /// <summary>
  /// Whether this setting is hidden from the GUI.
  /// </summary>
  [FactorioRconAttribute("hidden")]
  public bool Hidden { get; private set; }

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


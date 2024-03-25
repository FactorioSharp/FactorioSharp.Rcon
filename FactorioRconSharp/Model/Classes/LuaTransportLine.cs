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
/// One line on a transport belt.
/// </summary>
[FactorioRconClass("LuaTransportLine")]
public class LuaTransportLine
{
  /// <summary>
  /// The entity this transport line belongs to.
  /// </summary>
  [FactorioRconAttribute("owner")]
  public LuaEntity Owner { get; private set; }

  /// <summary>
  /// The transport lines that this transport line outputs items to or an empty table if none.
  /// </summary>
  [FactorioRconAttribute("output_lines")]
  public LuaTransportLine[] OutputLines { get; private set; }

  /// <summary>
  /// The transport lines that this transport line is fed by or an empty table if none.
  /// </summary>
  [FactorioRconAttribute("input_lines")]
  public LuaTransportLine[] InputLines { get; private set; }

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
  /// Get the number of items on this transport line.
  /// </summary>
  [FactorioRconAttribute("length")]
  public uint Length { get; private set; }

  /// <summary>
  /// The indexing operator.
  /// </summary>
  public LuaItemStack this[uint key] { get => throw FactorioModelUtils.UseClientReadAsyncMethod(); private set => throw FactorioModelUtils.UseClientExecuteAsyncMethod(); }

  /// <summary>
  /// Remove all items from this transport line.
  /// </summary>
  [FactorioRconMethod("clear")]
  public void Clear() => throw FactorioModelUtils.UseClientExecuteAsyncMethod();

  /// <summary>
  /// Count some or all items on this line, similar to how <see cref="LuaInventory.GetItemCount" /> does.
  /// </summary>
  /// <param name="item">Lua name: item</param>
  [FactorioRconMethod("get_item_count")]
  public uint GetItemCount(string? item = null) => throw FactorioModelUtils.UseClientReadAsyncMethod();

  /// <summary>
  /// Remove some items from this line.
  /// </summary>
  /// <param name="items">Lua name: items</param>
  [FactorioRconMethod("remove_item")]
  public uint RemoveItem(ItemStackIdentification items) => throw FactorioModelUtils.UseClientReadAsyncMethod();

  /// <summary>
  /// Can an item be inserted at a given position?
  /// </summary>
  /// <param name="position">Lua name: position</param>
  [FactorioRconMethod("can_insert_at")]
  public bool CanInsertAt(float position) => throw FactorioModelUtils.UseClientReadAsyncMethod();

  /// <summary>
  /// Can an item be inserted at the back of this line?
  /// </summary>
  [FactorioRconMethod("can_insert_at_back")]
  public bool CanInsertAtBack() => throw FactorioModelUtils.UseClientReadAsyncMethod();

  /// <summary>
  /// Insert items at a given position.
  /// </summary>
  /// <param name="position">Lua name: position</param>
  /// <param name="items">Lua name: items</param>
  [FactorioRconMethod("insert_at")]
  public bool InsertAt(float position, ItemStackIdentification items) => throw FactorioModelUtils.UseClientReadAsyncMethod();

  /// <summary>
  /// Insert items at the back of this line.
  /// </summary>
  /// <param name="items">Lua name: items</param>
  [FactorioRconMethod("insert_at_back")]
  public bool InsertAtBack(ItemStackIdentification items) => throw FactorioModelUtils.UseClientReadAsyncMethod();

  /// <summary>
  /// Get counts of all items on this line, similar to how <see cref="LuaInventory.GetContents" /> does.
  /// </summary>
  [FactorioRconMethod("get_contents")]
  public Dictionary<string, uint> GetContents() => throw FactorioModelUtils.UseClientReadAsyncMethod();

  /// <summary>
  /// Returns whether the associated internal transport line of this line is the same as the others associated internal transport line.
  /// </summary>
  /// <remarks>
  /// This can return true even when the <see cref="LuaTransportLine.Owner)SAreDifferent(So`This==Other`IsFalse" />, because the internal transport lines can span multiple tiles.
  /// </remarks>
  /// <param name="other">Lua name: other</param>
  [FactorioRconMethod("line_equals")]
  public bool LineEquals(LuaTransportLine other) => throw FactorioModelUtils.UseClientReadAsyncMethod();

  /// <summary>
  /// All methods and properties that this object supports.
  /// </summary>
  [FactorioRconMethod("help")]
  public string Help() => throw FactorioModelUtils.UseClientReadAsyncMethod();

}

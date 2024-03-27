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
/// A single logistic network of a given force on a given surface.
/// </summary>
[FactorioRconClass("LuaLogisticNetwork")]
public abstract class LuaLogisticNetwork: LuaObject
{
  /// <summary>
  /// The force this logistic network belongs to.
  /// </summary>
  [FactorioRconAttribute("force")]
  public LuaForce Force { get; private set; }

  /// <summary>
  /// Number of logistic robots available for a job.
  /// </summary>
  [FactorioRconAttribute("available_logistic_robots")]
  public uint AvailableLogisticRobots { get; private set; }

  /// <summary>
  /// The total number of logistic robots in the network (idle and active + in roboports).
  /// </summary>
  [FactorioRconAttribute("all_logistic_robots")]
  public uint AllLogisticRobots { get; private set; }

  /// <summary>
  /// Number of construction robots available for a job.
  /// </summary>
  [FactorioRconAttribute("available_construction_robots")]
  public uint AvailableConstructionRobots { get; private set; }

  /// <summary>
  /// The total number of construction robots in the network (idle and active + in roboports).
  /// </summary>
  [FactorioRconAttribute("all_construction_robots")]
  public uint AllConstructionRobots { get; private set; }

  /// <summary>
  /// Maximum number of robots the network can work with. Currently only used for the personal roboport.
  /// </summary>
  [FactorioRconAttribute("robot_limit")]
  public uint RobotLimit { get; private set; }

  /// <summary>
  /// All cells in this network.
  /// </summary>
  [FactorioRconAttribute("cells")]
  public List<LuaLogisticCell> Cells { get; private set; }

  /// <summary>
  /// All entities that have logistic provider points in this network.
  /// </summary>
  [FactorioRconAttribute("providers")]
  public List<LuaEntity> Providers { get; private set; }

  /// <summary>
  /// All entities that have empty logistic provider points in this network.
  /// </summary>
  [FactorioRconAttribute("empty_providers")]
  public List<LuaEntity> EmptyProviders { get; private set; }

  /// <summary>
  /// All entities that have logistic requester points in this network.
  /// </summary>
  [FactorioRconAttribute("requesters")]
  public List<LuaEntity> Requesters { get; private set; }

  /// <summary>
  /// All entities that have logistic storage points in this network.
  /// </summary>
  [FactorioRconAttribute("storages")]
  public List<LuaEntity> Storages { get; private set; }

  /// <summary>
  /// All other entities that have logistic points in this network (inserters mostly).
  /// </summary>
  [FactorioRconAttribute("logistic_members")]
  public List<LuaEntity> LogisticMembers { get; private set; }

  /// <summary>
  /// All things that have provider points in this network.
  /// </summary>
  [FactorioRconAttribute("provider_points")]
  public List<LuaLogisticPoint> ProviderPoints { get; private set; }

  /// <summary>
  /// All passive provider points in this network.
  /// </summary>
  [FactorioRconAttribute("passive_provider_points")]
  public List<LuaLogisticPoint> PassiveProviderPoints { get; private set; }

  /// <summary>
  /// All active provider points in this network.
  /// </summary>
  [FactorioRconAttribute("active_provider_points")]
  public List<LuaLogisticPoint> ActiveProviderPoints { get; private set; }

  /// <summary>
  /// All things that have empty provider points in this network.
  /// </summary>
  [FactorioRconAttribute("empty_provider_points")]
  public List<LuaLogisticPoint> EmptyProviderPoints { get; private set; }

  /// <summary>
  /// All things that have requester points in this network.
  /// </summary>
  [FactorioRconAttribute("requester_points")]
  public List<LuaLogisticPoint> RequesterPoints { get; private set; }

  /// <summary>
  /// All things that have storage points in this network.
  /// </summary>
  [FactorioRconAttribute("storage_points")]
  public List<LuaLogisticPoint> StoragePoints { get; private set; }

  /// <summary>
  /// All robots in this logistic network.
  /// </summary>
  [FactorioRconAttribute("robots")]
  public List<LuaEntity> Robots { get; private set; }

  /// <summary>
  /// All construction robots in this logistic network.
  /// </summary>
  [FactorioRconAttribute("construction_robots")]
  public List<LuaEntity> ConstructionRobots { get; private set; }

  /// <summary>
  /// All logistic robots in this logistic network.
  /// </summary>
  [FactorioRconAttribute("logistic_robots")]
  public List<LuaEntity> LogisticRobots { get; private set; }

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
  /// Count given or all items in the network or given members.
  /// </summary>
  /// <param name="item">Lua name: item</param>
  /// <param name="member">Lua name: member</param>
  [FactorioRconMethod("get_item_count")]
  public abstract int GetItemCount(string? item = null, Union64612267? member = null);

  /// <summary>
  /// Get item counts for the entire network, similar to how <see cref="LuaInventory.GetContents" /> does.
  /// </summary>
  [FactorioRconMethod("get_contents")]
  public abstract Dictionary<string, uint> GetContents();

  /// <summary>
  /// Remove items from the logistic network. This will actually remove the items from some logistic chests.
  /// </summary>
  /// <param name="item">Lua name: item</param>
  /// <param name="members">Lua name: members</param>
  [FactorioRconMethod("remove_item")]
  public abstract uint RemoveItem(ItemStackIdentification item, Union61816437? members = null);

  /// <summary>
  /// Insert items into the logistic network. This will actually insert the items into some logistic chests.
  /// </summary>
  /// <param name="item">Lua name: item</param>
  /// <param name="members">Lua name: members</param>
  [FactorioRconMethod("insert")]
  public abstract uint Insert(ItemStackIdentification item, Union47846228? members = null);

  /// <summary>
  /// Find logistic cell closest to a given position.
  /// </summary>
  /// <param name="position">Lua name: position</param>
  [FactorioRconMethod("find_cell_closest_to")]
  public abstract LuaLogisticCell? FindCellClosestTo(MapPosition position);

  /// <summary>
  /// Find the 'best' logistic point with this item ID and from the given position or from given chest type.
  /// </summary>
  /// <param name="name">Lua name: name</param>
  /// <param name="position">Lua name: position</param>
  /// <param name="includeBuffers">Lua name: include_buffers</param>
  /// <param name="members">Lua name: members</param>
  [FactorioRconMethod("select_pickup_point")]
  public abstract LuaLogisticPoint? SelectPickupPoint(string name, MapPosition? position = null, bool? includeBuffers = null, Union45363346? members = null);

  /// <summary>
  /// Find a logistic point to drop the specific item stack.
  /// </summary>
  /// <param name="stack">Lua name: stack</param>
  /// <param name="members">Lua name: members</param>
  [FactorioRconMethod("select_drop_point")]
  public abstract LuaLogisticPoint? SelectDropPoint(ItemStackIdentification stack, Union40468632? members = null);

  /// <summary>
  /// Can the network satisfy a request for a given item and count.
  /// </summary>
  /// <param name="item">Lua name: item</param>
  /// <param name="count">Lua name: count</param>
  /// <param name="includeBuffers">Lua name: include_buffers</param>
  [FactorioRconMethod("can_satisfy_request")]
  public abstract bool CanSatisfyRequest(string item, uint? count = null, bool? includeBuffers = null);

  /// <summary>
  /// Get the amount of items of the given type indexed by the storage member.
  /// </summary>
  /// <param name="item">Lua name: item</param>
  [FactorioRconMethod("get_supply_counts")]
  public abstract LogisticsNetworkSupplyCounts GetSupplyCounts(string item);

  /// <summary>
  /// Gets the logistic points with of the given type indexed by the storage member.
  /// </summary>
  /// <param name="item">Lua name: item</param>
  [FactorioRconMethod("get_supply_points")]
  public abstract LogisticsNetworkSupplyPoints GetSupplyPoints(string item);

  /// <summary>
  /// All methods and properties that this object supports.
  /// </summary>
  [FactorioRconMethod("help")]
  public abstract string Help();

}

[GenerateOneOf]
public abstract partial class Union64612267: OneOfBase<Literal32739668, Literal9926279>
{
}

/// <summary>
/// Literal value: storage
/// </summary>
public enum Literal32739668
{
  /// <summary>
  /// Literal value: storage
  /// </summary>
  [FactorioRconDefinitionValue("storage")]
  Storage,

}

/// <summary>
/// Literal value: providers
/// </summary>
public enum Literal9926279
{
  /// <summary>
  /// Literal value: providers
  /// </summary>
  [FactorioRconDefinitionValue("providers")]
  Providers,

}

[GenerateOneOf]
public abstract partial class Union47846228: OneOfBase<Literal19426640, Literal26501661, Literal30350669, Literal7754184>
{
}

/// <summary>
/// Literal value: storage
/// </summary>
public enum Literal19426640
{
  /// <summary>
  /// Literal value: storage
  /// </summary>
  [FactorioRconDefinitionValue("storage")]
  Storage,

}

/// <summary>
/// Literal value: storage-empty
/// </summary>
public enum Literal26501661
{
  /// <summary>
  /// Literal value: storage-empty
  /// </summary>
  [FactorioRconDefinitionValue("storage-empty")]
  StorageEmpty,

}

/// <summary>
/// Literal value: storage-empty-slot
/// </summary>
public enum Literal30350669
{
  /// <summary>
  /// Literal value: storage-empty-slot
  /// </summary>
  [FactorioRconDefinitionValue("storage-empty-slot")]
  StorageEmptySlot,

}

/// <summary>
/// Literal value: requester
/// </summary>
public enum Literal7754184
{
  /// <summary>
  /// Literal value: requester
  /// </summary>
  [FactorioRconDefinitionValue("requester")]
  Requester,

}

[GenerateOneOf]
public abstract partial class Union61816437: OneOfBase<Literal23544769, Literal11709672, Literal4036177, Literal49940297>
{
}

/// <summary>
/// Literal value: active-provider
/// </summary>
public enum Literal23544769
{
  /// <summary>
  /// Literal value: active-provider
  /// </summary>
  [FactorioRconDefinitionValue("active-provider")]
  ActiveProvider,

}

/// <summary>
/// Literal value: passive-provider
/// </summary>
public enum Literal11709672
{
  /// <summary>
  /// Literal value: passive-provider
  /// </summary>
  [FactorioRconDefinitionValue("passive-provider")]
  PassiveProvider,

}

/// <summary>
/// Literal value: buffer
/// </summary>
public enum Literal4036177
{
  /// <summary>
  /// Literal value: buffer
  /// </summary>
  [FactorioRconDefinitionValue("buffer")]
  Buffer,

}

/// <summary>
/// Literal value: storage
/// </summary>
public enum Literal49940297
{
  /// <summary>
  /// Literal value: storage
  /// </summary>
  [FactorioRconDefinitionValue("storage")]
  Storage,

}

[GenerateOneOf]
public abstract partial class Union40468632: OneOfBase<Literal38982485, Literal56750250, Literal35144529, Literal12558393>
{
}

/// <summary>
/// Literal value: storage
/// </summary>
public enum Literal38982485
{
  /// <summary>
  /// Literal value: storage
  /// </summary>
  [FactorioRconDefinitionValue("storage")]
  Storage,

}

/// <summary>
/// Literal value: storage-empty
/// </summary>
public enum Literal56750250
{
  /// <summary>
  /// Literal value: storage-empty
  /// </summary>
  [FactorioRconDefinitionValue("storage-empty")]
  StorageEmpty,

}

/// <summary>
/// Literal value: storage-empty-slot
/// </summary>
public enum Literal35144529
{
  /// <summary>
  /// Literal value: storage-empty-slot
  /// </summary>
  [FactorioRconDefinitionValue("storage-empty-slot")]
  StorageEmptySlot,

}

/// <summary>
/// Literal value: requester
/// </summary>
public enum Literal12558393
{
  /// <summary>
  /// Literal value: requester
  /// </summary>
  [FactorioRconDefinitionValue("requester")]
  Requester,

}

[GenerateOneOf]
public abstract partial class Union45363346: OneOfBase<Literal28649084, Literal25517075, Literal1797691, Literal52133063>
{
}

/// <summary>
/// Literal value: active-provider
/// </summary>
public enum Literal28649084
{
  /// <summary>
  /// Literal value: active-provider
  /// </summary>
  [FactorioRconDefinitionValue("active-provider")]
  ActiveProvider,

}

/// <summary>
/// Literal value: passive-provider
/// </summary>
public enum Literal25517075
{
  /// <summary>
  /// Literal value: passive-provider
  /// </summary>
  [FactorioRconDefinitionValue("passive-provider")]
  PassiveProvider,

}

/// <summary>
/// Literal value: buffer
/// </summary>
public enum Literal1797691
{
  /// <summary>
  /// Literal value: buffer
  /// </summary>
  [FactorioRconDefinitionValue("buffer")]
  Buffer,

}

/// <summary>
/// Literal value: storage
/// </summary>
public enum Literal52133063
{
  /// <summary>
  /// Literal value: storage
  /// </summary>
  [FactorioRconDefinitionValue("storage")]
  Storage,

}


#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Anonymous;
using FactorioSharp.Rcon.Model.Builtins;
using FactorioSharp.Rcon.Model.Classes;
using FactorioSharp.Rcon.Model.Definitions;
using FactorioSharp.Rcon.Model.Utils;

namespace FactorioSharp.Rcon.Model.Concepts;

/// <summary>
/// It can be either the name of a [SoundPrototype](prototype:SoundPrototype) defined in the data stage, or a path in the form `"type/name"`. The latter option can be sorted into three categories.
/// 
/// The validity of a SoundPath can be verified at runtime using <see cref="LuaGameScript.IsValidSoundPath" />.
/// 
/// The utility and ambient types each contain general use sound prototypes defined by the game itself.
/// - `"utility"` - Uses [UtilitySounds](prototype:UtilitySounds). Example: `"utility/wire_connect_pole"`
/// - `"ambient"` - Uses [AmbientSound](prototype:AmbientSound). Example: `"ambient/resource-deficiency"`
/// 
/// The following types can be combined with any tile name as long as its prototype defines the
///     corresponding sound.
/// - `"tile-walking"` - Uses [TilePrototype::walking_sound](prototype:TilePrototype::walking_sound). Example: `"tile-walking/concrete"`
/// - `"tile-mined"` - Uses [TilePrototype::mined_sound](prototype:TilePrototype::mined_sound)
/// - `"tile-build-small"` - Uses [TilePrototype::build_sound](prototype:TilePrototype::build_sound). Example: `"tile-build-small/concrete"`
/// - `"tile-build-medium"` - Uses [TilePrototype::build_sound](prototype:TilePrototype::build_sound)
/// - `"tile-build-large"` - Uses [TilePrototype::build_sound](prototype:TilePrototype::build_sound)
/// 
/// The following types can be combined with any entity name as long as its prototype defines the
///     corresponding sound.
/// - `"entity-build"` - Uses [Entity::build_sound](prototype:EntityPrototype::build_sound). Example: `"entity-build/wooden-chest"`
/// - `"entity-mined"` - Uses [Entity::mined_sound](prototype:EntityPrototype::mined_sound)
/// - `"entity-mining"` - Uses [Entity::mining_sound](prototype:EntityPrototype::mining_sound)
/// - `"entity-vehicle_impact"` - Uses [EntityPrototype::vehicle_impact_sound](prototype:EntityPrototype::vehicle_impact_sound)
/// - `"entity-rotated"` - Uses [EntityPrototype::rotated_sound](prototype:EntityPrototype::rotated_sound)
/// - `"entity-open"` - Uses [Entity::open_sound](prototype:EntityPrototype::open_sound)
/// - `"entity-close"` - Uses [Entity::close_sound](prototype:EntityPrototype::close_sound)
/// </summary>
[FactorioRconConcept("SoundPath")]
public class SoundPath: Alias<string>
{
}


#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Utils;

namespace FactorioSharp.Rcon.Model.Definitions;

[FactorioRconDefinition("deconstruction_item")]
public enum DeconstructionItemEnum
{
}

[FactorioRconDefinition("deconstruction_item.entity_filter_mode")]
public enum DeconstructionItemEntityFilterModeEnum
{
  [FactorioRconDefinitionValue("whitelist")]
  Whitelist,

  [FactorioRconDefinitionValue("blacklist")]
  Blacklist,

}

[FactorioRconDefinition("deconstruction_item.tile_filter_mode")]
public enum DeconstructionItemTileFilterModeEnum
{
  [FactorioRconDefinitionValue("whitelist")]
  Whitelist,

  [FactorioRconDefinitionValue("blacklist")]
  Blacklist,

}

[FactorioRconDefinition("deconstruction_item.tile_selection_mode")]
public enum DeconstructionItemTileSelectionModeEnum
{
  [FactorioRconDefinitionValue("normal")]
  Normal,

  [FactorioRconDefinitionValue("always")]
  Always,

  [FactorioRconDefinitionValue("never")]
  Never,

  [FactorioRconDefinitionValue("only")]
  Only,

}


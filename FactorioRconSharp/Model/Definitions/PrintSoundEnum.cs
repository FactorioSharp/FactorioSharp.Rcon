#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Utils;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Concepts;

namespace FactorioRconSharp.Model.Definitions;

[FactorioRconDefinition("print_sound")]
public enum PrintSoundEnum
{
  [FactorioRconDefinitionValue("always")]
  Always,

  [FactorioRconDefinitionValue("never")]
  Never,

  [FactorioRconDefinitionValue("use_player_settings")]
  UsePlayerSettings,

}

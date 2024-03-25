#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Utils;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Concepts;

namespace FactorioRconSharp.Model.Definitions;

[FactorioRconDefinition("wire_connection_id")]
public enum WireConnectionIdEnum
{
  [FactorioRconDefinitionValue("electric_pole")]
  ElectricPole,

  [FactorioRconDefinitionValue("power_switch_left")]
  PowerSwitchLeft,

  [FactorioRconDefinitionValue("power_switch_right")]
  PowerSwitchRight,

}


#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Utils;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Concepts;

namespace FactorioRconSharp.Model.Definitions;

[FactorioRconDefinition("riding")]
public enum RidingEnum
{
}

[FactorioRconDefinition("riding.acceleration")]
public enum RidingAccelerationEnum
{
  [FactorioRconDefinitionValue("nothing")]
  Nothing,

  [FactorioRconDefinitionValue("accelerating")]
  Accelerating,

  [FactorioRconDefinitionValue("braking")]
  Braking,

  [FactorioRconDefinitionValue("reversing")]
  Reversing,

}

[FactorioRconDefinition("riding.direction")]
public enum RidingDirectionEnum
{
  [FactorioRconDefinitionValue("left")]
  Left,

  [FactorioRconDefinitionValue("straight")]
  Straight,

  [FactorioRconDefinitionValue("right")]
  Right,

}

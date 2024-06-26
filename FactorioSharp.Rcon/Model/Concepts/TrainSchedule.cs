#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Anonymous;
using FactorioSharp.Rcon.Model.Builtins;
using FactorioSharp.Rcon.Model.Classes;
using FactorioSharp.Rcon.Model.Definitions;
using FactorioSharp.Rcon.Model.Utils;

namespace FactorioSharp.Rcon.Model.Concepts;

[FactorioRconConcept("TrainSchedule")]
public class TrainSchedule
{
  /// <summary>
  /// Index of the currently active record
  /// </summary>
  [FactorioRconAttribute("current")]
  public uint Current { get; set; }

  [FactorioRconAttribute("records")]
  public LuaArray<TrainScheduleRecord> Records { get; set; }

}


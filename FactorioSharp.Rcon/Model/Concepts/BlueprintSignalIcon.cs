#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Anonymous;
using FactorioSharp.Rcon.Model.Builtins;
using FactorioSharp.Rcon.Model.Classes;
using FactorioSharp.Rcon.Model.Definitions;
using FactorioSharp.Rcon.Model.Utils;

namespace FactorioSharp.Rcon.Model.Concepts;

[FactorioRconConcept("BlueprintSignalIcon")]
public class BlueprintSignalIcon
{
  /// <summary>
  /// The icon to use. It can be any item icon as well as any virtual signal icon.
  /// </summary>
  [FactorioRconAttribute("signal")]
  public SignalID Signal { get; set; }

  /// <summary>
  /// Index of the icon in the blueprint icons slots. Has to be an integer in the range [1, 4].
  /// </summary>
  [FactorioRconAttribute("index")]
  public uint Index { get; set; }

}


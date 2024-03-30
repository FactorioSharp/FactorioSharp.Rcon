#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;

namespace FactorioSharp.Rcon.Model.Concepts;

[FactorioRconConcept("PrototypeHistory")]
public class PrototypeHistory
{
  /// <summary>
  ///     The mod that created this prototype.
  /// </summary>
  [FactorioRconAttribute("created")]
    public string Created { get; set; }

  /// <summary>
  ///     The mods that changed this prototype in the order they changed it.
  /// </summary>
  [FactorioRconAttribute("changed")]
    public List<string> Changed { get; set; }
}
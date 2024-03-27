#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Anonymous;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using FactorioRconSharp.Model.Utils;

namespace FactorioRconSharp.Model.Concepts;

[FactorioRconConcept("RollingStockDrawData")]
public abstract class RollingStockDrawData
{
  [FactorioRconAttribute("position")]
  public MapPosition Position { get; set; }

  [FactorioRconAttribute("orientaton")]
  public RealOrientation Orientaton { get; set; }

}


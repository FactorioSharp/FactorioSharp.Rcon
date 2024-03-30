#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Anonymous;

namespace FactorioSharp.Rcon.Model.Concepts;

/// <summary>
///     Depending on the value of `filter`, the table may take additional fields. `filter` may be one of the following:
/// </summary>
[FactorioRconConcept("TechnologyPrototypeFilter")]
public class TechnologyPrototypeFilter
{
  /// <summary>
  ///     The condition to filter on. One of `"enabled"`, `"hidden"`, `"upgrade"`, `"visible-when-disabled"`, `"has-effects"`, `"has-prerequisites"`, `"research-unit-ingredient"`,
  ///     `"unlocks-recipe"`, `"level"`, `"max-level"`, `"time"`.
  /// </summary>
  [FactorioRconAttribute("filter")]
    public string Filter { get; set; }

  /// <summary>
  ///     How to combine this with the previous filter. Defaults to `"or"`. When evaluating the filters, `"and"` has higher precedence than `"or"`.
  /// </summary>
  [FactorioRconAttribute("mode")]
    public Literals476267896 Mode { get; set; }

  /// <summary>
  ///     Inverts the condition. Default is `false`.
  /// </summary>
  [FactorioRconAttribute("invert")]
    public bool Invert { get; set; }
}
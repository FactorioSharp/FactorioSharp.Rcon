#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Utils;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using OneOf;

namespace FactorioRconSharp.Model.Concepts;

/// <summary>
/// Depending on the value of `filter`, the table may take additional fields. `filter` may be one of the following:
/// </summary>
[FactorioRconConcept("RecipePrototypeFilter")]
public abstract class RecipePrototypeFilter
{
  /// <summary>
  /// The condition to filter on. One of `"enabled"`, `"hidden"`, `"hidden-from-flow-stats"`, `"hidden-from-player-crafting"`, `"allow-as-intermediate"`, `"allow-intermediates"`, `"allow-decomposition"`, `"always-show-made-in"`, `"always-show-products"`, `"show-amount-in-title"`, `"has-ingredients"`, `"has-products"`, `"has-ingredient-item"`, `"has-ingredient-fluid"`, `"has-product-item"`, `"has-product-fluid"`, `"subgroup"`, `"category"`, `"energy"`, `"emissions-multiplier"`, `"request-paste-multiplier"`, `"overload-multiplier"`.
  /// </summary>
  [FactorioRconAttribute("filter")]
  public string Filter { get; set; }

  /// <summary>
  /// How to combine this with the previous filter. Defaults to `"or"`. When evaluating the filters, `"and"` has higher precedence than `"or"`.
  /// </summary>
  [FactorioRconAttribute("mode")]
  public Union59133613 Mode { get; set; }

  /// <summary>
  /// Inverts the condition. Default is `false`.
  /// </summary>
  [FactorioRconAttribute("invert")]
  public bool Invert { get; set; }

}

/// <summary>
/// Union of literals:
///   - or
///   - and
/// </summary>
public enum Union59133613
{
  /// <summary>
  /// Literal value: or
  /// </summary>
  [FactorioRconDefinitionValue("or")]
  Or,

  /// <summary>
  /// Literal value: and
  /// </summary>
  [FactorioRconDefinitionValue("and")]
  And,

}


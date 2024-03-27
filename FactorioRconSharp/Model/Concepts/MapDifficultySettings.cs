#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Utils;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using OneOf;

namespace FactorioRconSharp.Model.Concepts;

[FactorioRconConcept("MapDifficultySettings")]
public abstract class MapDifficultySettings
{
  [FactorioRconAttribute("recipe_difficulty")]
  public DifficultySettingsRecipeDifficultyEnum RecipeDifficulty { get; set; }

  [FactorioRconAttribute("technology_difficulty")]
  public DifficultySettingsTechnologyDifficultyEnum TechnologyDifficulty { get; set; }

  /// <summary>
  /// A value in range [0.001, 1000].
  /// </summary>
  [FactorioRconAttribute("technology_price_multiplier")]
  public double TechnologyPriceMultiplier { get; set; }

  /// <summary>
  /// Changing this to `"always"` or `"after-victory"` does not automatically unlock the research queue. See <see cref="LuaForce.ResearchQueueEnabled" /> for that.
  /// </summary>
  [FactorioRconAttribute("research_queue_setting")]
  public Union48624990 ResearchQueueSetting { get; set; }

}

/// <summary>
/// Union of literals:
///   - after-victory
///   - always
///   - never
/// </summary>
public enum Union48624990
{
  /// <summary>
  /// Literal value: after-victory
  /// </summary>
  [FactorioRconDefinitionValue("after-victory")]
  AfterVictory,

  /// <summary>
  /// Literal value: always
  /// </summary>
  [FactorioRconDefinitionValue("always")]
  Always,

  /// <summary>
  /// Literal value: never
  /// </summary>
  [FactorioRconDefinitionValue("never")]
  Never,

}


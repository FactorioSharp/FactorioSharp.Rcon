#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Anonymous;
using FactorioSharp.Rcon.Model.Builtins;
using FactorioSharp.Rcon.Model.Classes;
using FactorioSharp.Rcon.Model.Definitions;
using FactorioSharp.Rcon.Model.Utils;

namespace FactorioSharp.Rcon.Model.Concepts;

/// <summary>
/// Technology and recipe difficulty settings. Updating any of the attributes will immediately take effect in the game engine.
/// </summary>
[FactorioRconConcept("DifficultySettings")]
public class DifficultySettings
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
  public Literals1213222642 ResearchQueueSetting { get; set; }

}


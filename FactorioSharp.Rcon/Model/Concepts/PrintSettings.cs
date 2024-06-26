#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Anonymous;
using FactorioSharp.Rcon.Model.Builtins;
using FactorioSharp.Rcon.Model.Classes;
using FactorioSharp.Rcon.Model.Definitions;
using FactorioSharp.Rcon.Model.Utils;

namespace FactorioSharp.Rcon.Model.Concepts;

[FactorioRconConcept("PrintSettings")]
public class PrintSettings
{
  /// <summary>
  /// Color of the message to print. Defaults to white.
  /// </summary>
  [FactorioRconAttribute("color")]
  public Color Color { get; set; }

  /// <summary>
  /// If a sound should be emitted for this message. Defaults to `defines.print_sound.use_player_settings`.
  /// </summary>
  [FactorioRconAttribute("sound")]
  public PrintSoundEnum Sound { get; set; }

  /// <summary>
  /// Condition when to skip adding message. Defaults to `defines.print_skip.if_redundant`.
  /// </summary>
  [FactorioRconAttribute("skip")]
  public PrintSkipEnum Skip { get; set; }

  /// <summary>
  /// The sound to play. If not given, [UtilitySounds::console_message](prototype:UtilitySounds::console_message) will be used instead.
  /// </summary>
  [FactorioRconAttribute("sound_path")]
  public SoundPath SoundPath { get; set; }

  /// <summary>
  /// The volume of the sound to play. Must be between 0 and 1 inclusive. Defaults to 1.
  /// </summary>
  [FactorioRconAttribute("volume_modifier")]
  public double VolumeModifier { get; set; }

  /// <summary>
  /// If set to false, message will not be part of game state and will dissapear from output console after save-load. Defaults to `true`.
  /// </summary>
  [FactorioRconAttribute("game_state")]
  public bool GameState { get; set; }

}


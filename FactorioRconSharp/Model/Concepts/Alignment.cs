#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Anonymous;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using FactorioRconSharp.Model.Utils;

namespace FactorioRconSharp.Model.Concepts;

/// <summary>
/// A <see cref="String" /> that specifies where a GUI element should be.
/// </summary>
[FactorioRconDefinition("Alignment")]
public enum Alignment
{
  /// <summary>
  /// Literal value: top-left
  /// </summary>
  [FactorioRconDefinitionValue("top-left")]
  TopLeft,

  /// <summary>
  /// Literal value: middle-left
  /// </summary>
  [FactorioRconDefinitionValue("middle-left")]
  MiddleLeft,

  /// <summary>
  /// Literal value: left
  /// </summary>
  [FactorioRconDefinitionValue("left")]
  Left,

  /// <summary>
  /// Literal value: bottom-left
  /// </summary>
  [FactorioRconDefinitionValue("bottom-left")]
  BottomLeft,

  /// <summary>
  /// Literal value: top-center
  /// </summary>
  [FactorioRconDefinitionValue("top-center")]
  TopCenter,

  /// <summary>
  /// Literal value: middle-center
  /// </summary>
  [FactorioRconDefinitionValue("middle-center")]
  MiddleCenter,

  /// <summary>
  /// Literal value: center
  /// </summary>
  [FactorioRconDefinitionValue("center")]
  Center,

  /// <summary>
  /// Literal value: bottom-center
  /// </summary>
  [FactorioRconDefinitionValue("bottom-center")]
  BottomCenter,

  /// <summary>
  /// Literal value: top-right
  /// </summary>
  [FactorioRconDefinitionValue("top-right")]
  TopRight,

  /// <summary>
  /// Literal value: right
  /// </summary>
  [FactorioRconDefinitionValue("right")]
  Right,

  /// <summary>
  /// Literal value: bottom-right
  /// </summary>
  [FactorioRconDefinitionValue("bottom-right")]
  BottomRight,

}


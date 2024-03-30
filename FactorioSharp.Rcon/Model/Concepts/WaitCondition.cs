#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Anonymous;

namespace FactorioSharp.Rcon.Model.Concepts;

[FactorioRconConcept("WaitCondition")]
public class WaitCondition
{
    [FactorioRconAttribute("type")]
    public WaitConditionType Type { get; set; }

    /// <summary>
    ///     Specifies how this condition is to be compared with the preceding conditions in the corresponding `wait_conditions` array.
    /// </summary>
    [FactorioRconAttribute("compare_type")]
    public Literals790578066 CompareType { get; set; }

    /// <summary>
    ///     Number of ticks to wait when `type` is `"time"`, or number of ticks of inactivity when `type` is `"inactivity"`.
    /// </summary>
    [FactorioRconAttribute("ticks")]
    public uint Ticks { get; set; }

    /// <summary>
    ///     Only present when `type` is `"item_count"`, `"circuit"` or `"fluid_count"`, and a circuit condition is configured.
    /// </summary>
    [FactorioRconAttribute("condition")]
    public CircuitCondition Condition { get; set; }
}
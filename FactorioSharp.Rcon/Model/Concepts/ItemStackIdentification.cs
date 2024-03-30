#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Classes;
using OneOf;

namespace FactorioSharp.Rcon.Model.Concepts;

/// <summary>
///     An item may be specified in one of two ways.
/// </summary>
[GenerateOneOf]
[FactorioRconConcept("ItemStackIdentification")]
public partial class ItemStackIdentification : OneOfBase<SimpleItemStack, LuaItemStack>
{
}
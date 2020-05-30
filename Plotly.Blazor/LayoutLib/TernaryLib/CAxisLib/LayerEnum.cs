/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Runtime.Serialization;

namespace Plotly.Blazor.LayoutLib.TernaryLib.CAxisLib
{
    /// <summary>
    ///     Sets the layer on which this axis is displayed. If *above traces*, this
    ///     axis is displayed above all the subplot&#39;s traces If *below traces*,
    ///     this axis is displayed below all the subplot&#39;s traces, but above the
    ///     grid lines. Useful when used together with scatter-like traces with `cliponaxis`
    ///     set to *false* to show markers and/or text nodes above this axis.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    [JsonConverter(typeof(EnumConverter))]
    public enum LayerEnum
    {
        [EnumMember(Value=@"above traces")]
        AboveTraces = 0,
        [EnumMember(Value=@"below traces")]
        BelowTraces
    }
}
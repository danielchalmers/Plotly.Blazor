/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;

namespace Plotly.Blazor.LayoutLib.LegendLib
{
    /// <summary>
    ///     Determines the order at which the legend items are displayed. If *normal*,
    ///     the items are displayed top-to-bottom in the same order as the input data.
    ///     If *reversed*, the items are displayed in the opposite order as *normal*.
    ///     If *grouped*, the items are displayed in groups (when a trace `legendgroup`
    ///     is provided). if *grouped+reversed*, the items are displayed in the opposite
    ///     order as *grouped*.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    [Flags]
    [JsonConverter(typeof(EnumConverter))]
    public enum TraceOrderFlag
    {
        [EnumMember(Value=@"normal")]
        Normal = 0,
        [EnumMember(Value=@"reversed")]
        Reversed = 1,
        [EnumMember(Value=@"grouped")]
        Grouped = 2
    }
}
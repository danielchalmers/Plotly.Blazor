/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;

namespace Plotly.Blazor.LayoutLib.XAxisLib
{
    /// <summary>
    ///     Determines the drawing mode for the spike line If *toaxis*, the line is
    ///     drawn from the data point to the axis the  series is plotted on. If *across*,
    ///     the line is drawn across the entire plot area, and supercedes *toaxis*.
    ///     If *marker*, then a marker dot is drawn on the axis the series is plotted
    ///     on
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    [Flags]
    [JsonConverter(typeof(EnumConverter))]
    public enum SpikeModeFlag
    {
        [EnumMember(Value=@"toaxis")]
        ToAxis = 0,
        [EnumMember(Value=@"across")]
        Across = 1,
        [EnumMember(Value=@"marker")]
        Marker = 2
    }
}
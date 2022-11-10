/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Runtime.Serialization;
#pragma warning disable 1591

namespace Plotly.Blazor.LayoutLib
{
    /// <summary>
    ///     Determines how bars at the same location coordinate are displayed on the
    ///     graph. With <c>stack</c>, the bars are stacked on top of one another With
    ///     <c>relative</c>, the bars are stacked on top of one another, with negative
    ///     values below the axis, positive values above With <c>group</c>, the bars
    ///     are plotted next to one another centered around the shared location. With
    ///     <c>overlay</c>, the bars are plotted over one another, you might need to
    ///     reduce <c>opacity</c> to see multiple bars.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    [JsonConverter(typeof(EnumConverter))]
    public enum BarModeEnum
    {
        [EnumMember(Value=@"group")]
        Group = 0,
        [EnumMember(Value=@"stack")]
        Stack,
        [EnumMember(Value=@"overlay")]
        Overlay,
        [EnumMember(Value=@"relative")]
        Relative
    }
}
/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Runtime.Serialization;
#pragma warning disable 1591

namespace Plotly.Blazor.LayoutLib.LegendLib
{
    /// <summary>
    ///     Determines what entrywidth means.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    [JsonConverter(typeof(EnumConverter))]
    public enum EntryWidthModeEnum
    {
        [EnumMember(Value=@"pixels")]
        Pixels = 0,
        [EnumMember(Value=@"fraction")]
        Fraction
    }
}
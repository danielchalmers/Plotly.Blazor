/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Runtime.Serialization;

namespace Plotly.Blazor.Traces.ScatterPolarLib.MarkerLib.ColorBarLib
{
    /// <summary>
    ///     If *all*, all tick labels are displayed with a prefix. If *first*, only
    ///     the first tick is displayed with a prefix. If *last*, only the last tick
    ///     is displayed with a suffix. If *none*, tick prefixes are hidden.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    [JsonConverter(typeof(EnumConverter))]
    public enum ShowTickPrefixEnum
    {
        [EnumMember(Value=@"all")]
        All = 0,
        [EnumMember(Value=@"first")]
        First,
        [EnumMember(Value=@"last")]
        Last,
        [EnumMember(Value=@"none")]
        None
    }
}
/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Runtime.Serialization;

namespace Plotly.Blazor.Traces.ConeLib.ColorBarLib
{
    /// <summary>
    ///     Same as `showtickprefix` but for tick suffixes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    [JsonConverter(typeof(EnumConverter))]
    public enum ShowTickSuffixEnum
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
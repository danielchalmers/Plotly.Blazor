/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Runtime.Serialization;

namespace Plotly.Blazor.Traces.ParCatsLib.LineLib.ColorBarLib
{
    /// <summary>
    ///     Sets this color bar&#39;s horizontal position anchor. This anchor binds
    ///     the `x` position to the *left*, *center* or *right* of the color bar.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    [JsonConverter(typeof(EnumConverter))]
    public enum XAnchorEnum
    {
        [EnumMember(Value=@"left")]
        Left = 0,
        [EnumMember(Value=@"center")]
        Center,
        [EnumMember(Value=@"right")]
        Right
    }
}
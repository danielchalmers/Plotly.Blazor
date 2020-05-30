/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Runtime.Serialization;

namespace Plotly.Blazor.LayoutLib.LegendLib
{
    /// <summary>
    ///     Sets the legend&#39;s horizontal position anchor. This anchor binds the
    ///     `x` position to the *left*, *center* or *right* of the legend. Value *auto*
    ///     anchors legends to the right for `x` values greater than or equal to 2/3,
    ///     anchors legends to the left for `x` values less than or equal to 1/3 and
    ///     anchors legends with respect to their center otherwise.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    [JsonConverter(typeof(EnumConverter))]
    public enum XAnchorEnum
    {
        [EnumMember(Value=@"left")]
        Left = 0,
        [EnumMember(Value=@"auto")]
        Auto,
        [EnumMember(Value=@"center")]
        Center,
        [EnumMember(Value=@"right")]
        Right
    }
}
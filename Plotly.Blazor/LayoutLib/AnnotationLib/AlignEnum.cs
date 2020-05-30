/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Runtime.Serialization;

namespace Plotly.Blazor.LayoutLib.AnnotationLib
{
    /// <summary>
    ///     Sets the horizontal alignment of the `text` within the box. Has an effect
    ///     only if `text` spans two or more lines (i.e. `text` contains one or more
    ///     &lt;br&gt; HTML tags) or if an explicit width is set to override the text
    ///     width.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    [JsonConverter(typeof(EnumConverter))]
    public enum AlignEnum
    {
        [EnumMember(Value=@"center")]
        Center = 0,
        [EnumMember(Value=@"left")]
        Left,
        [EnumMember(Value=@"right")]
        Right
    }
}
/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Runtime.Serialization;

namespace Plotly.Blazor.LayoutLib.SceneLib.AnnotationLib
{
    /// <summary>
    ///     Sets the vertical alignment of the `text` within the box. Has an effect
    ///     only if an explicit height is set to override the text height.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    [JsonConverter(typeof(EnumConverter))]
    public enum VAlignEnum
    {
        [EnumMember(Value=@"middle")]
        Middle = 0,
        [EnumMember(Value=@"top")]
        Top,
        [EnumMember(Value=@"bottom")]
        Bottom
    }
}
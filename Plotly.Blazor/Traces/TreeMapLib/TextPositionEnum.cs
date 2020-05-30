/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Runtime.Serialization;

namespace Plotly.Blazor.Traces.TreeMapLib
{
    /// <summary>
    ///     Sets the positions of the `text` elements.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    [JsonConverter(typeof(EnumConverter))]
    public enum TextPositionEnum
    {
        [EnumMember(Value=@"top left")]
        TopLeft = 0,
        [EnumMember(Value=@"top center")]
        TopCenter,
        [EnumMember(Value=@"top right")]
        TopRight,
        [EnumMember(Value=@"middle left")]
        MiddleLeft,
        [EnumMember(Value=@"middle center")]
        MiddleCenter,
        [EnumMember(Value=@"middle right")]
        MiddleRight,
        [EnumMember(Value=@"bottom left")]
        BottomLeft,
        [EnumMember(Value=@"bottom center")]
        BottomCenter,
        [EnumMember(Value=@"bottom right")]
        BottomRight
    }
}
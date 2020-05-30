/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Plotly.Blazor.Traces.TreeMapLib.MarkerLib
{
    /// <summary>
    ///     The Line class.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    public class Line 
    {
        /// <summary>
        ///     Sets the color of the line enclosing each sector. Defaults to the `paper_bgcolor`
        ///     value.
        /// </summary>
        [JsonPropertyName(@"color")]
        public object Color { get; set;} 

        /// <summary>
        ///     Sets the width (in px) of the line enclosing each sector.
        /// </summary>
        [JsonPropertyName(@"width")]
        public float? Width { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  color .
        /// </summary>
        [JsonPropertyName(@"colorsrc")]
        public string ColorSrc { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  width .
        /// </summary>
        [JsonPropertyName(@"widthsrc")]
        public string WidthSrc { get; set;} 

    }
}
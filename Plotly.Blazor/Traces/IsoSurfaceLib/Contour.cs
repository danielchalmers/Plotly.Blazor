/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Plotly.Blazor.Traces.IsoSurfaceLib
{
    /// <summary>
    ///     The Contour class.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    public class Contour 
    {
        /// <summary>
        ///     Sets whether or not dynamic contours are shown on hover
        /// </summary>
        [JsonPropertyName(@"show")]
        public bool? Show { get; set;} 

        /// <summary>
        ///     Sets the color of the contour lines.
        /// </summary>
        [JsonPropertyName(@"color")]
        public object Color { get; set;} 

        /// <summary>
        ///     Sets the width of the contour lines.
        /// </summary>
        [JsonPropertyName(@"width")]
        public float? Width { get; set;} 

    }
}
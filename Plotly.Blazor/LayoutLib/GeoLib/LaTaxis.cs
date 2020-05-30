/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Plotly.Blazor.LayoutLib.GeoLib
{
    /// <summary>
    ///     The LaTaxis class.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    public class LaTaxis 
    {
        /// <summary>
        ///     Sets the range of this axis (in degrees), sets the map's clipped coordinates.
        /// </summary>
        [JsonPropertyName(@"range")]
        public IList<object> Range { get; set;} 

        /// <summary>
        ///     Sets whether or not graticule are shown on the map.
        /// </summary>
        [JsonPropertyName(@"showgrid")]
        public bool? ShowGrid { get; set;} 

        /// <summary>
        ///     Sets the graticule's starting tick longitude/latitude.
        /// </summary>
        [JsonPropertyName(@"tick0")]
        public float? Tick0 { get; set;} 

        /// <summary>
        ///     Sets the graticule's longitude/latitude tick step.
        /// </summary>
        [JsonPropertyName(@"dtick")]
        public float? DTick { get; set;} 

        /// <summary>
        ///     Sets the graticule's stroke color.
        /// </summary>
        [JsonPropertyName(@"gridcolor")]
        public object GridColor { get; set;} 

        /// <summary>
        ///     Sets the graticule's stroke width (in px).
        /// </summary>
        [JsonPropertyName(@"gridwidth")]
        public float? GridWidth { get; set;} 

    }
}
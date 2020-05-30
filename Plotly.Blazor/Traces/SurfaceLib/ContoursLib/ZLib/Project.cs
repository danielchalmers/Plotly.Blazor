/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Plotly.Blazor.Traces.SurfaceLib.ContoursLib.ZLib
{
    /// <summary>
    ///     The Project class.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    public class Project 
    {
        /// <summary>
        ///     Determines whether or not these contour lines are projected on the x plane.
        ///     If `highlight` is set to *true* (the default), the projected lines are shown
        ///     on hover. If `show` is set to *true*, the projected lines are shown in permanence.
        /// </summary>
        [JsonPropertyName(@"x")]
        public bool? X { get; set;} 

        /// <summary>
        ///     Determines whether or not these contour lines are projected on the y plane.
        ///     If `highlight` is set to *true* (the default), the projected lines are shown
        ///     on hover. If `show` is set to *true*, the projected lines are shown in permanence.
        /// </summary>
        [JsonPropertyName(@"y")]
        public bool? Y { get; set;} 

        /// <summary>
        ///     Determines whether or not these contour lines are projected on the z plane.
        ///     If `highlight` is set to *true* (the default), the projected lines are shown
        ///     on hover. If `show` is set to *true*, the projected lines are shown in permanence.
        /// </summary>
        [JsonPropertyName(@"z")]
        public bool? Z { get; set;} 

    }
}
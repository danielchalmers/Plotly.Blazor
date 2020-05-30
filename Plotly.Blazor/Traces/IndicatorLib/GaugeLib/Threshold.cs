/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Collections.Generic;
using Plotly.Blazor.Traces.IndicatorLib.GaugeLib.ThresholdLib;

namespace Plotly.Blazor.Traces.IndicatorLib.GaugeLib
{
    /// <summary>
    ///     The Threshold class.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    public class Threshold 
    {
        /// <summary>
        ///     Gets or sets the Line.
        /// </summary>
        [JsonPropertyName(@"line")]
        public Line Line { get; set;} 

        /// <summary>
        ///     Sets the thickness of the threshold line as a fraction of the thickness
        ///     of the gauge.
        /// </summary>
        [JsonPropertyName(@"thickness")]
        public float? Thickness { get; set;} 

        /// <summary>
        ///     Sets a treshold value drawn as a line.
        /// </summary>
        [JsonPropertyName(@"value")]
        public float? Value { get; set;} 

    }
}
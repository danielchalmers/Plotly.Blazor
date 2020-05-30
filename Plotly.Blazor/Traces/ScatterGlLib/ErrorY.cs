/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Collections.Generic;
using Plotly.Blazor.Traces.ScatterGlLib.ErrorYLib;

namespace Plotly.Blazor.Traces.ScatterGlLib
{
    /// <summary>
    ///     The ErrorY class.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    public class ErrorY 
    {
        /// <summary>
        ///     Determines whether or not this set of error bars is visible.
        /// </summary>
        [JsonPropertyName(@"visible")]
        public bool? Visible { get; set;} 

        /// <summary>
        ///     Determines the rule used to generate the error bars. If *constant`, the
        ///     bar lengths are of a constant value. Set this constant in `value`. If *percent*,
        ///     the bar lengths correspond to a percentage of underlying data. Set this
        ///     percentage in `value`. If *sqrt*, the bar lengths correspond to the sqaure
        ///     of the underlying data. If *data*, the bar lengths are set with data set
        ///     `array`.
        /// </summary>
        [JsonPropertyName(@"type")]
        public TypeEnum? Type { get; set;} 

        /// <summary>
        ///     Determines whether or not the error bars have the same length in both direction
        ///     (top/bottom for vertical bars, left/right for horizontal bars.
        /// </summary>
        [JsonPropertyName(@"symmetric")]
        public bool? Symmetric { get; set;} 

        /// <summary>
        ///     Sets the data corresponding the length of each error bar. Values are plotted
        ///     relative to the underlying data.
        /// </summary>
        [JsonPropertyName(@"array")]
        public IList<object> Array { get; set;} 

        /// <summary>
        ///     Sets the data corresponding the length of each error bar in the bottom (left)
        ///     direction for vertical (horizontal) bars Values are plotted relative to
        ///     the underlying data.
        /// </summary>
        [JsonPropertyName(@"arrayminus")]
        public IList<object> ArrayMinus { get; set;} 

        /// <summary>
        ///     Sets the value of either the percentage (if `type` is set to *percent*)
        ///     or the constant (if `type` is set to *constant*) corresponding to the lengths
        ///     of the error bars.
        /// </summary>
        [JsonPropertyName(@"value")]
        public float? Value { get; set;} 

        /// <summary>
        ///     Sets the value of either the percentage (if `type` is set to *percent*)
        ///     or the constant (if `type` is set to *constant*) corresponding to the lengths
        ///     of the error bars in the bottom (left) direction for vertical (horizontal)
        ///     bars
        /// </summary>
        [JsonPropertyName(@"valueminus")]
        public float? ValueMinus { get; set;} 

        /// <summary>
        ///     Gets or sets the TraceRef.
        /// </summary>
        [JsonPropertyName(@"traceref")]
        public int? TraceRef { get; set;} 

        /// <summary>
        ///     Gets or sets the TraceRefMinus.
        /// </summary>
        [JsonPropertyName(@"tracerefminus")]
        public int? TraceRefMinus { get; set;} 

        /// <summary>
        ///     Sets the stoke color of the error bars.
        /// </summary>
        [JsonPropertyName(@"color")]
        public object Color { get; set;} 

        /// <summary>
        ///     Sets the thickness (in px) of the error bars.
        /// </summary>
        [JsonPropertyName(@"thickness")]
        public float? Thickness { get; set;} 

        /// <summary>
        ///     Sets the width (in px) of the cross-bar at both ends of the error bars.
        /// </summary>
        [JsonPropertyName(@"width")]
        public float? Width { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  array .
        /// </summary>
        [JsonPropertyName(@"arraysrc")]
        public string ArraySrc { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  arrayminus .
        /// </summary>
        [JsonPropertyName(@"arrayminussrc")]
        public string ArrayMinusSrc { get; set;} 

    }
}
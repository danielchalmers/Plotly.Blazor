/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Collections.Generic;
using Plotly.Blazor.LayoutLib.UniformTextLib;

namespace Plotly.Blazor.LayoutLib
{
    /// <summary>
    ///     The UniformText class.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    public class UniformText 
    {
        /// <summary>
        ///     Determines how the font size for various text elements are uniformed between
        ///     each trace type. If the computed text sizes were smaller than the minimum
        ///     size defined by `uniformtext.minsize` using *hide* option hides the text;
        ///     and using *show* option shows the text without further downscaling. Please
        ///     note that if the size defined by `minsize` is greater than the font size
        ///     defined by trace, then the `minsize` is used.
        /// </summary>
        [JsonPropertyName(@"mode")]
        public ModeEnum? Mode { get; set;} 

        /// <summary>
        ///     Sets the minimum text size between traces of the same type.
        /// </summary>
        [JsonPropertyName(@"minsize")]
        public float? MinSize { get; set;} 

    }
}
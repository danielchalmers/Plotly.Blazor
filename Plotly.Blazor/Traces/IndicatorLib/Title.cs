/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Collections.Generic;
using Plotly.Blazor.Traces.IndicatorLib.TitleLib;

namespace Plotly.Blazor.Traces.IndicatorLib
{
    /// <summary>
    ///     The Title class.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    public class Title 
    {
        /// <summary>
        ///     Sets the title of this indicator.
        /// </summary>
        [JsonPropertyName(@"text")]
        public string Text { get; set;} 

        /// <summary>
        ///     Sets the horizontal alignment of the title. It defaults to `center` except
        ///     for bullet charts for which it defaults to right.
        /// </summary>
        [JsonPropertyName(@"align")]
        public AlignEnum? Align { get; set;} 

        /// <summary>
        ///     Set the font used to display the title
        /// </summary>
        [JsonPropertyName(@"font")]
        public Font Font { get; set;} 

    }
}
/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Plotly.Blazor.Traces.ScatterGlLib.MarkerLib.ColorBarLib.TitleLib
{
    /// <summary>
    ///     The Font class.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    public class Font 
    {
        /// <summary>
        ///     HTML font family - the typeface that will be applied by the web browser.
        ///     The web browser will only be able to apply a font if it is available on
        ///     the system which it operates. Provide multiple font families, separated
        ///     by commas, to indicate the preference in which to apply fonts if they aren't
        ///     available on the system. The Chart Studio Cloud (at https://chart-studio.plotly.com
        ///     or on-premise) generates images on a server, where only a select number
        ///     of fonts are installed and supported. These include *Arial*, *Balto*, *Courier
        ///     New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old
        ///     Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times
        ///     New Roman*.
        /// </summary>
        [JsonPropertyName(@"family")]
        public string Family { get; set;} 

        /// <summary>
        ///     Gets or sets the Size.
        /// </summary>
        [JsonPropertyName(@"size")]
        public float? Size { get; set;} 

        /// <summary>
        ///     Gets or sets the Color.
        /// </summary>
        [JsonPropertyName(@"color")]
        public object Color { get; set;} 

    }
}
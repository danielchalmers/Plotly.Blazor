/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Collections.Generic;
using Plotly.Blazor.LayoutLib.XAxisLib.RangeSelectorLib;

namespace Plotly.Blazor.LayoutLib.XAxisLib
{
    /// <summary>
    ///     The RangeSelector class.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    public class RangeSelector 
    {
        /// <summary>
        ///     Determines whether or not this range selector is visible. Note that range
        ///     selectors are only available for x axes of `type` set to or auto-typed to
        ///     *date*.
        /// </summary>
        [JsonPropertyName(@"visible")]
        public bool? Visible { get; set;} 

        /// <summary>
        ///     Gets or sets the Buttons.
        /// </summary>
        [JsonPropertyName(@"buttons")]
        public IList<Button> Buttons { get; set;} 

        /// <summary>
        ///     Sets the x position (in normalized coordinates) of the range selector.
        /// </summary>
        [JsonPropertyName(@"x")]
        public float? X { get; set;} 

        /// <summary>
        ///     Sets the range selector's horizontal position anchor. This anchor binds
        ///     the `x` position to the *left*, *center* or *right* of the range selector.
        /// </summary>
        [JsonPropertyName(@"xanchor")]
        public XAnchorEnum? XAnchor { get; set;} 

        /// <summary>
        ///     Sets the y position (in normalized coordinates) of the range selector.
        /// </summary>
        [JsonPropertyName(@"y")]
        public float? Y { get; set;} 

        /// <summary>
        ///     Sets the range selector's vertical position anchor This anchor binds the
        ///     `y` position to the *top*, *middle* or *bottom* of the range selector.
        /// </summary>
        [JsonPropertyName(@"yanchor")]
        public YAnchorEnum? YAnchor { get; set;} 

        /// <summary>
        ///     Sets the font of the range selector button text.
        /// </summary>
        [JsonPropertyName(@"font")]
        public Font Font { get; set;} 

        /// <summary>
        ///     Sets the background color of the range selector buttons.
        /// </summary>
        [JsonPropertyName(@"bgcolor")]
        public object BgColor { get; set;} 

        /// <summary>
        ///     Sets the background color of the active range selector button.
        /// </summary>
        [JsonPropertyName(@"activecolor")]
        public object ActiveColor { get; set;} 

        /// <summary>
        ///     Sets the color of the border enclosing the range selector.
        /// </summary>
        [JsonPropertyName(@"bordercolor")]
        public object BorderColor { get; set;} 

        /// <summary>
        ///     Sets the width (in px) of the border enclosing the range selector.
        /// </summary>
        [JsonPropertyName(@"borderwidth")]
        public float? BorderWidth { get; set;} 

    }
}
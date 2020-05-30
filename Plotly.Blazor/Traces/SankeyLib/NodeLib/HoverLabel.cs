/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Collections.Generic;
using Plotly.Blazor.Traces.SankeyLib.NodeLib.HoverLabelLib;

namespace Plotly.Blazor.Traces.SankeyLib.NodeLib
{
    /// <summary>
    ///     The HoverLabel class.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    public class HoverLabel 
    {
        /// <summary>
        ///     Sets the background color of the hover labels for this trace
        /// </summary>
        [JsonPropertyName(@"bgcolor")]
        public object BgColor { get; set;} 

        /// <summary>
        ///     Sets the border color of the hover labels for this trace.
        /// </summary>
        [JsonPropertyName(@"bordercolor")]
        public object BorderColor { get; set;} 

        /// <summary>
        ///     Sets the font used in hover labels.
        /// </summary>
        [JsonPropertyName(@"font")]
        public Font Font { get; set;} 

        /// <summary>
        ///     Sets the horizontal alignment of the text content within hover label box.
        ///     Has an effect only if the hover label text spans more two or more lines
        /// </summary>
        [JsonPropertyName(@"align")]
        public AlignEnum? Align { get; set;} 

        /// <summary>
        ///     Sets the default length (in number of characters) of the trace name in the
        ///     hover labels for all traces. -1 shows the whole name regardless of length.
        ///     0-3 shows the first 0-3 characters, and an integer >3 will show the whole
        ///     name if it is less than that many characters, but if it is longer, will
        ///     truncate to `namelength - 3` characters and add an ellipsis.
        /// </summary>
        [JsonPropertyName(@"namelength")]
        public int? NameLength { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  bgcolor .
        /// </summary>
        [JsonPropertyName(@"bgcolorsrc")]
        public string BgColorSrc { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  bordercolor .
        /// </summary>
        [JsonPropertyName(@"bordercolorsrc")]
        public string BorderColorSrc { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  align .
        /// </summary>
        [JsonPropertyName(@"alignsrc")]
        public string AlignSrc { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  namelength .
        /// </summary>
        [JsonPropertyName(@"namelengthsrc")]
        public string NameLengthSrc { get; set;} 

    }
}
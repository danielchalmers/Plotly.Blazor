/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Collections.Generic;
using Plotly.Blazor.LayoutLib.ShapeLib;

namespace Plotly.Blazor.LayoutLib
{
    /// <summary>
    ///     The Shape class.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    public class Shape 
    {
        /// <summary>
        ///     Determines whether or not this shape is visible.
        /// </summary>
        [JsonPropertyName(@"visible")]
        public bool? Visible { get; set;} 

        /// <summary>
        ///     Specifies the shape type to be drawn. If *line*, a line is drawn from (`x0`,`y0`)
        ///     to (`x1`,`y1`) with respect to the axes' sizing mode. If *circle*, a circle
        ///     is drawn from ((`x0`+`x1`)/2, (`y0`+`y1`)/2)) with radius (|(`x0`+`x1`)/2
        ///     - `x0`|, |(`y0`+`y1`)/2 -`y0`)|) with respect to the axes' sizing mode.
        ///     If *rect*, a rectangle is drawn linking (`x0`,`y0`), (`x1`,`y0`), (`x1`,`y1`),
        ///     (`x0`,`y1`), (`x0`,`y0`) with respect to the axes' sizing mode. If *path*,
        ///     draw a custom SVG path using `path`. with respect to the axes' sizing mode.
        /// </summary>
        [JsonPropertyName(@"type")]
        public TypeEnum? Type { get; set;} 

        /// <summary>
        ///     Specifies whether shapes are drawn below or above traces.
        /// </summary>
        [JsonPropertyName(@"layer")]
        public LayerEnum? Layer { get; set;} 

        /// <summary>
        ///     Sets the shape's x coordinate axis. If set to an x axis id (e.g. *x* or
        ///     *x2*), the `x` position refers to an x coordinate. If set to *paper*, the
        ///     `x` position refers to the distance from the left side of the plotting area
        ///     in normalized coordinates where *0* (*1*) corresponds to the left (right)
        ///     side. If the axis `type` is *log*, then you must take the log of your desired
        ///     range. If the axis `type` is *date*, then you must convert the date to unix
        ///     time in milliseconds.
        /// </summary>
        [JsonPropertyName(@"xref")]
        public string Xref { get; set;} 

        /// <summary>
        ///     Sets the shapes's sizing mode along the x axis. If set to *scaled*, `x0`,
        ///     `x1` and x coordinates within `path` refer to data values on the x axis
        ///     or a fraction of the plot area's width (`xref` set to *paper*). If set to
        ///     *pixel*, `xanchor` specifies the x position in terms of data or plot fraction
        ///     but `x0`, `x1` and x coordinates within `path` are pixels relative to `xanchor`.
        ///     This way, the shape can have a fixed width while maintaining a position
        ///     relative to data or plot fraction.
        /// </summary>
        [JsonPropertyName(@"xsizemode")]
        public XSizeModeEnum? XSizeMode { get; set;} 

        /// <summary>
        ///     Only relevant in conjunction with `xsizemode` set to *pixel*. Specifies
        ///     the anchor point on the x axis to which `x0`, `x1` and x coordinates within
        ///     `path` are relative to. E.g. useful to attach a pixel sized shape to a certain
        ///     data value. No effect when `xsizemode` not set to *pixel*.
        /// </summary>
        [JsonPropertyName(@"xanchor")]
        public object XAnchor { get; set;} 

        /// <summary>
        ///     Sets the shape's starting x position. See `type` and `xsizemode` for more
        ///     info.
        /// </summary>
        [JsonPropertyName(@"x0")]
        public object X0 { get; set;} 

        /// <summary>
        ///     Sets the shape's end x position. See `type` and `xsizemode` for more info.
        /// </summary>
        [JsonPropertyName(@"x1")]
        public object X1 { get; set;} 

        /// <summary>
        ///     Sets the annotation's y coordinate axis. If set to an y axis id (e.g. *y*
        ///     or *y2*), the `y` position refers to an y coordinate If set to *paper*,
        ///     the `y` position refers to the distance from the bottom of the plotting
        ///     area in normalized coordinates where *0* (*1*) corresponds to the bottom
        ///     (top).
        /// </summary>
        [JsonPropertyName(@"yref")]
        public string YRef { get; set;} 

        /// <summary>
        ///     Sets the shapes's sizing mode along the y axis. If set to *scaled*, `y0`,
        ///     `y1` and y coordinates within `path` refer to data values on the y axis
        ///     or a fraction of the plot area's height (`yref` set to *paper*). If set
        ///     to *pixel*, `yanchor` specifies the y position in terms of data or plot
        ///     fraction but `y0`, `y1` and y coordinates within `path` are pixels relative
        ///     to `yanchor`. This way, the shape can have a fixed height while maintaining
        ///     a position relative to data or plot fraction.
        /// </summary>
        [JsonPropertyName(@"ysizemode")]
        public YSizeModeEnum? YSizeMode { get; set;} 

        /// <summary>
        ///     Only relevant in conjunction with `ysizemode` set to *pixel*. Specifies
        ///     the anchor point on the y axis to which `y0`, `y1` and y coordinates within
        ///     `path` are relative to. E.g. useful to attach a pixel sized shape to a certain
        ///     data value. No effect when `ysizemode` not set to *pixel*.
        /// </summary>
        [JsonPropertyName(@"yanchor")]
        public object YAnchor { get; set;} 

        /// <summary>
        ///     Sets the shape's starting y position. See `type` and `ysizemode` for more
        ///     info.
        /// </summary>
        [JsonPropertyName(@"y0")]
        public object Y0 { get; set;} 

        /// <summary>
        ///     Sets the shape's end y position. See `type` and `ysizemode` for more info.
        /// </summary>
        [JsonPropertyName(@"y1")]
        public object Y1 { get; set;} 

        /// <summary>
        ///     For `type` *path* - a valid SVG path with the pixel values replaced by data
        ///     values in `xsizemode`/`ysizemode` being *scaled* and taken unmodified as
        ///     pixels relative to `xanchor` and `yanchor` in case of *pixel* size mode.
        ///     There are a few restrictions / quirks only absolute instructions, not relative.
        ///     So the allowed segments are: M, L, H, V, Q, C, T, S, and Z arcs (A) are
        ///     not allowed because radius rx and ry are relative. In the future we could
        ///     consider supporting relative commands, but we would have to decide on how
        ///     to handle date and log axes. Note that even as is, Q and C Bezier paths
        ///     that are smooth on linear axes may not be smooth on log, and vice versa.
        ///     no chained "polybezier" commands - specify the segment type for each one.
        ///     On category axes, values are numbers scaled to the serial numbers of categories
        ///     because using the categories themselves there would be no way to describe
        ///     fractional positions On data axes: because space and T are both normal components
        ///     of path strings, we can't use either to separate date from time parts. Therefore
        ///     we'll use underscore for this purpose: 2015-02-21_13:45:56.789
        /// </summary>
        [JsonPropertyName(@"path")]
        public string Path { get; set;} 

        /// <summary>
        ///     Sets the opacity of the shape.
        /// </summary>
        [JsonPropertyName(@"opacity")]
        public float? Opacity { get; set;} 

        /// <summary>
        ///     Gets or sets the Line.
        /// </summary>
        [JsonPropertyName(@"line")]
        public Line Line { get; set;} 

        /// <summary>
        ///     Sets the color filling the shape's interior. Only applies to closed shapes.
        /// </summary>
        [JsonPropertyName(@"fillcolor")]
        public object FillColor { get; set;} 

        /// <summary>
        ///     Determines which regions of complex paths constitute the interior. For more
        ///     info please visit https://developer.mozilla.org/en-US/docs/Web/SVG/Attribute/fill-rule
        /// </summary>
        [JsonPropertyName(@"fillrule")]
        public FillRuleEnum? FillRule { get; set;} 

        /// <summary>
        ///     Determines whether the shape could be activated for edit or not. Has no
        ///     effect when the older editable shapes mode is enabled via `config.editable`
        ///     or `config.edits.shapePosition`.
        /// </summary>
        [JsonPropertyName(@"editable")]
        public bool? Editable { get; set;} 

        /// <summary>
        ///     When used in a template, named items are created in the output figure in
        ///     addition to any items the figure already has in this array. You can modify
        ///     these items in the output figure by making your own item with `templateitemname`
        ///     matching this `name` alongside your modifications (including `visible: false`
        ///     or `enabled: false` to hide it). Has no effect outside of a template.
        /// </summary>
        [JsonPropertyName(@"name")]
        public string Name { get; set;} 

        /// <summary>
        ///     Used to refer to a named item in this array in the template. Named items
        ///     from the template will be created even without a matching item in the input
        ///     figure, but you can modify one by making an item with `templateitemname`
        ///     matching its `name`, alongside your modifications (including `visible: false`
        ///     or `enabled: false` to hide it). If there is no template or no matching
        ///     item, this item will be hidden unless you explicitly show it with `visible:
        ///     true`.
        /// </summary>
        [JsonPropertyName(@"templateitemname")]
        public string TemplateItemName { get; set;} 

    }
}
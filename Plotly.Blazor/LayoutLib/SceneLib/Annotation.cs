/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Collections.Generic;
using Plotly.Blazor.LayoutLib.SceneLib.AnnotationLib;

namespace Plotly.Blazor.LayoutLib.SceneLib
{
    /// <summary>
    ///     The Annotation class.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    public class Annotation 
    {
        /// <summary>
        ///     Determines whether or not this annotation is visible.
        /// </summary>
        [JsonPropertyName(@"visible")]
        public bool? Visible { get; set;} 

        /// <summary>
        ///     Sets the annotation's x position.
        /// </summary>
        [JsonPropertyName(@"x")]
        public object X { get; set;} 

        /// <summary>
        ///     Sets the annotation's y position.
        /// </summary>
        [JsonPropertyName(@"y")]
        public object Y { get; set;} 

        /// <summary>
        ///     Sets the annotation's z position.
        /// </summary>
        [JsonPropertyName(@"z")]
        public object Z { get; set;} 

        /// <summary>
        ///     Sets the x component of the arrow tail about the arrow head (in pixels).
        /// </summary>
        [JsonPropertyName(@"ax")]
        public float? Ax { get; set;} 

        /// <summary>
        ///     Sets the y component of the arrow tail about the arrow head (in pixels).
        /// </summary>
        [JsonPropertyName(@"ay")]
        public float? Ay { get; set;} 

        /// <summary>
        ///     Sets the text box's horizontal position anchor This anchor binds the `x`
        ///     position to the *left*, *center* or *right* of the annotation. For example,
        ///     if `x` is set to 1, `xref` to *paper* and `xanchor` to *right* then the
        ///     right-most portion of the annotation lines up with the right-most edge of
        ///     the plotting area. If *auto*, the anchor is equivalent to *center* for data-referenced
        ///     annotations or if there is an arrow, whereas for paper-referenced with no
        ///     arrow, the anchor picked corresponds to the closest side.
        /// </summary>
        [JsonPropertyName(@"xanchor")]
        public XAnchorEnum? XAnchor { get; set;} 

        /// <summary>
        ///     Shifts the position of the whole annotation and arrow to the right (positive)
        ///     or left (negative) by this many pixels.
        /// </summary>
        [JsonPropertyName(@"xshift")]
        public float? XShift { get; set;} 

        /// <summary>
        ///     Sets the text box's vertical position anchor This anchor binds the `y` position
        ///     to the *top*, *middle* or *bottom* of the annotation. For example, if `y`
        ///     is set to 1, `yref` to *paper* and `yanchor` to *top* then the top-most
        ///     portion of the annotation lines up with the top-most edge of the plotting
        ///     area. If *auto*, the anchor is equivalent to *middle* for data-referenced
        ///     annotations or if there is an arrow, whereas for paper-referenced with no
        ///     arrow, the anchor picked corresponds to the closest side.
        /// </summary>
        [JsonPropertyName(@"yanchor")]
        public YAnchorEnum? YAnchor { get; set;} 

        /// <summary>
        ///     Shifts the position of the whole annotation and arrow up (positive) or down
        ///     (negative) by this many pixels.
        /// </summary>
        [JsonPropertyName(@"yshift")]
        public float? YShift { get; set;} 

        /// <summary>
        ///     Sets the text associated with this annotation. Plotly uses a subset of HTML
        ///     tags to do things like newline (<br>), bold (<b></b>), italics (<i></i>),
        ///     hyperlinks (<a href='...'></a>). Tags <em>, <sup>, <sub> <span> are also
        ///     supported.
        /// </summary>
        [JsonPropertyName(@"text")]
        public string Text { get; set;} 

        /// <summary>
        ///     Sets the angle at which the `text` is drawn with respect to the horizontal.
        /// </summary>
        [JsonPropertyName(@"textangle")]
        public float? TextAngle { get; set;} 

        /// <summary>
        ///     Sets the annotation text font.
        /// </summary>
        [JsonPropertyName(@"font")]
        public Font Font { get; set;} 

        /// <summary>
        ///     Sets an explicit width for the text box. null (default) lets the text set
        ///     the box width. Wider text will be clipped. There is no automatic wrapping;
        ///     use <br> to start a new line.
        /// </summary>
        [JsonPropertyName(@"width")]
        public float? Width { get; set;} 

        /// <summary>
        ///     Sets an explicit height for the text box. null (default) lets the text set
        ///     the box height. Taller text will be clipped.
        /// </summary>
        [JsonPropertyName(@"height")]
        public float? Height { get; set;} 

        /// <summary>
        ///     Sets the opacity of the annotation (text + arrow).
        /// </summary>
        [JsonPropertyName(@"opacity")]
        public float? Opacity { get; set;} 

        /// <summary>
        ///     Sets the horizontal alignment of the `text` within the box. Has an effect
        ///     only if `text` spans two or more lines (i.e. `text` contains one or more
        ///     <br> HTML tags) or if an explicit width is set to override the text width.
        /// </summary>
        [JsonPropertyName(@"align")]
        public AlignEnum? Align { get; set;} 

        /// <summary>
        ///     Sets the vertical alignment of the `text` within the box. Has an effect
        ///     only if an explicit height is set to override the text height.
        /// </summary>
        [JsonPropertyName(@"valign")]
        public VAlignEnum? VAlign { get; set;} 

        /// <summary>
        ///     Sets the background color of the annotation.
        /// </summary>
        [JsonPropertyName(@"bgcolor")]
        public object BgColor { get; set;} 

        /// <summary>
        ///     Sets the color of the border enclosing the annotation `text`.
        /// </summary>
        [JsonPropertyName(@"bordercolor")]
        public object BorderColor { get; set;} 

        /// <summary>
        ///     Sets the padding (in px) between the `text` and the enclosing border.
        /// </summary>
        [JsonPropertyName(@"borderpad")]
        public float? BorderPad { get; set;} 

        /// <summary>
        ///     Sets the width (in px) of the border enclosing the annotation `text`.
        /// </summary>
        [JsonPropertyName(@"borderwidth")]
        public float? BorderWidth { get; set;} 

        /// <summary>
        ///     Determines whether or not the annotation is drawn with an arrow. If *true*,
        ///     `text` is placed near the arrow's tail. If *false*, `text` lines up with
        ///     the `x` and `y` provided.
        /// </summary>
        [JsonPropertyName(@"showarrow")]
        public bool? ShowArrow { get; set;} 

        /// <summary>
        ///     Sets the color of the annotation arrow.
        /// </summary>
        [JsonPropertyName(@"arrowcolor")]
        public object ArrowColor { get; set;} 

        /// <summary>
        ///     Sets the end annotation arrow head style.
        /// </summary>
        [JsonPropertyName(@"arrowhead")]
        public int? Arrowhead { get; set;} 

        /// <summary>
        ///     Sets the start annotation arrow head style.
        /// </summary>
        [JsonPropertyName(@"startarrowhead")]
        public int? StartArrowhead { get; set;} 

        /// <summary>
        ///     Sets the annotation arrow head position.
        /// </summary>
        [JsonPropertyName(@"arrowside")]
        public ArrowSideFlag? ArrowSide { get; set;} 

        /// <summary>
        ///     Sets the size of the end annotation arrow head, relative to `arrowwidth`.
        ///     A value of 1 (default) gives a head about 3x as wide as the line.
        /// </summary>
        [JsonPropertyName(@"arrowsize")]
        public float? ArrowSize { get; set;} 

        /// <summary>
        ///     Sets the size of the start annotation arrow head, relative to `arrowwidth`.
        ///     A value of 1 (default) gives a head about 3x as wide as the line.
        /// </summary>
        [JsonPropertyName(@"startarrowsize")]
        public float? StartArrowSize { get; set;} 

        /// <summary>
        ///     Sets the width (in px) of annotation arrow line.
        /// </summary>
        [JsonPropertyName(@"arrowwidth")]
        public float? ArrowWidth { get; set;} 

        /// <summary>
        ///     Sets a distance, in pixels, to move the end arrowhead away from the position
        ///     it is pointing at, for example to point at the edge of a marker independent
        ///     of zoom. Note that this shortens the arrow from the `ax` / `ay` vector,
        ///     in contrast to `xshift` / `yshift` which moves everything by this amount.
        /// </summary>
        [JsonPropertyName(@"standoff")]
        public float? Standoff { get; set;} 

        /// <summary>
        ///     Sets a distance, in pixels, to move the start arrowhead away from the position
        ///     it is pointing at, for example to point at the edge of a marker independent
        ///     of zoom. Note that this shortens the arrow from the `ax` / `ay` vector,
        ///     in contrast to `xshift` / `yshift` which moves everything by this amount.
        /// </summary>
        [JsonPropertyName(@"startstandoff")]
        public float? StartStandoff { get; set;} 

        /// <summary>
        ///     Sets text to appear when hovering over this annotation. If omitted or blank,
        ///     no hover label will appear.
        /// </summary>
        [JsonPropertyName(@"hovertext")]
        public string HoverText { get; set;} 

        /// <summary>
        ///     Gets or sets the HoverLabel.
        /// </summary>
        [JsonPropertyName(@"hoverlabel")]
        public HoverLabel HoverLabel { get; set;} 

        /// <summary>
        ///     Determines whether the annotation text box captures mouse move and click
        ///     events, or allows those events to pass through to data points in the plot
        ///     that may be behind the annotation. By default `captureevents` is *false*
        ///     unless `hovertext` is provided. If you use the event `plotly_clickannotation`
        ///     without `hovertext` you must explicitly enable `captureevents`.
        /// </summary>
        [JsonPropertyName(@"captureevents")]
        public bool? CaptureEvents { get; set;} 

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
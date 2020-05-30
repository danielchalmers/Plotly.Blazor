/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Collections.Generic;
using Plotly.Blazor.Traces.CarpetLib;

namespace Plotly.Blazor.Traces
{
    /// <summary>
    ///     The Carpet class.
    ///     Implements the <see cref="ITrace" />
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    public class Carpet : ITrace
    {
        /// <inheritdoc/>
        [JsonPropertyName(@"type")]
        public TraceTypeEnum Type { get; } = TraceTypeEnum.Carpet;

        /// <summary>
        ///     Determines whether or not this trace is visible. If *legendonly*, the trace
        ///     is not drawn, but can appear as a legend item (provided that the legend
        ///     itself is visible).
        /// </summary>
        [JsonPropertyName(@"visible")]
        public VisibleEnum? Visible { get; set;} 

        /// <summary>
        ///     Sets the opacity of the trace.
        /// </summary>
        [JsonPropertyName(@"opacity")]
        public float? Opacity { get; set;} 

        /// <summary>
        ///     Sets the trace name. The trace name appear as the legend item and on hover.
        /// </summary>
        [JsonPropertyName(@"name")]
        public string Name { get; set;} 

        /// <summary>
        ///     Assign an id to this trace, Use this to provide object constancy between
        ///     traces during animations and transitions.
        /// </summary>
        [JsonPropertyName(@"uid")]
        public string UId { get; set;} 

        /// <summary>
        ///     Assigns id labels to each datum. These ids for object constancy of data
        ///     points during animation. Should be an array of strings, not numbers or any
        ///     other type.
        /// </summary>
        [JsonPropertyName(@"ids")]
        public IList<object> Ids { get; set;} 

        /// <summary>
        ///     Assigns extra data each datum. This may be useful when listening to hover,
        ///     click and selection events. Note that, *scatter* traces also appends customdata
        ///     items in the markers DOM elements
        /// </summary>
        [JsonPropertyName(@"customdata")]
        public IList<object> CustomData { get; set;} 

        /// <summary>
        ///     Assigns extra meta information associated with this trace that can be used
        ///     in various text attributes. Attributes such as trace `name`, graph, axis
        ///     and colorbar `title.text`, annotation `text` `rangeselector`, `updatemenues`
        ///     and `sliders` `label` text all support `meta`. To access the trace `meta`
        ///     values in an attribute in the same trace, simply use `%{meta[i]}` where
        ///     `i` is the index or key of the `meta` item in question. To access trace
        ///     `meta` in layout attributes, use `%{data[n[.meta[i]}` where `i` is the index
        ///     or key of the `meta` and `n` is the trace index.
        /// </summary>
        [JsonPropertyName(@"meta")]
        public object Meta { get; set;} 

        /// <summary>
        ///     Gets or sets the Stream.
        /// </summary>
        [JsonPropertyName(@"stream")]
        public Stream Stream { get; set;} 

        /// <summary>
        ///     Controls persistence of some user-driven changes to the trace: `constraintrange`
        ///     in `parcoords` traces, as well as some `editable: true` modifications such
        ///     as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that
        ///     other user-driven trace attribute changes are controlled by `layout` attributes:
        ///     `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints`
        ///     is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible
        ///     with `config: {editable: true}`) is controlled by `layout.editrevision`.
        ///     Trace changes are tracked by `uid`, which only falls back on trace index
        ///     if no `uid` is provided. So if your app can add/remove traces before the
        ///     end of the `data` array, such that the same trace has a different index,
        ///     you can still preserve user-driven changes if you give each trace a `uid`
        ///     that stays with it as it moves.
        /// </summary>
        [JsonPropertyName(@"uirevision")]
        public object UiRevision { get; set;} 

        /// <summary>
        ///     An identifier for this carpet, so that `scattercarpet` and `contourcarpet`
        ///     traces can specify a carpet plot on which they lie
        /// </summary>
        [JsonPropertyName(@"carpet")]
        public string _Carpet { get; set;} 

        /// <summary>
        ///     A two dimensional array of x coordinates at each carpet point. If ommitted,
        ///     the plot is a cheater plot and the xaxis is hidden by default.
        /// </summary>
        [JsonPropertyName(@"x")]
        public IList<object> X { get; set;} 

        /// <summary>
        ///     A two dimensional array of y coordinates at each carpet point.
        /// </summary>
        [JsonPropertyName(@"y")]
        public IList<object> Y { get; set;} 

        /// <summary>
        ///     An array containing values of the first parameter value
        /// </summary>
        [JsonPropertyName(@"a")]
        public IList<object> A { get; set;} 

        /// <summary>
        ///     Alternate to `a`. Builds a linear space of a coordinates. Use with `da`
        ///     where `a0` is the starting coordinate and `da` the step.
        /// </summary>
        [JsonPropertyName(@"a0")]
        public float? A0 { get; set;} 

        /// <summary>
        ///     Sets the a coordinate step. See `a0` for more info.
        /// </summary>
        [JsonPropertyName(@"da")]
        public float? DA { get; set;} 

        /// <summary>
        ///     A two dimensional array of y coordinates at each carpet point.
        /// </summary>
        [JsonPropertyName(@"b")]
        public IList<object> B { get; set;} 

        /// <summary>
        ///     Alternate to `b`. Builds a linear space of a coordinates. Use with `db`
        ///     where `b0` is the starting coordinate and `db` the step.
        /// </summary>
        [JsonPropertyName(@"b0")]
        public float? B0 { get; set;} 

        /// <summary>
        ///     Sets the b coordinate step. See `b0` for more info.
        /// </summary>
        [JsonPropertyName(@"db")]
        public float? Db { get; set;} 

        /// <summary>
        ///     The shift applied to each successive row of data in creating a cheater plot.
        ///     Only used if `x` is been ommitted.
        /// </summary>
        [JsonPropertyName(@"cheaterslope")]
        public float? CheaterSlope { get; set;} 

        /// <summary>
        ///     Gets or sets the AAxis.
        /// </summary>
        [JsonPropertyName(@"aaxis")]
        public AAxis AAxis { get; set;} 

        /// <summary>
        ///     Gets or sets the BAxis.
        /// </summary>
        [JsonPropertyName(@"baxis")]
        public BAxis BAxis { get; set;} 

        /// <summary>
        ///     The default font used for axis & tick labels on this carpet
        /// </summary>
        [JsonPropertyName(@"font")]
        public Font Font { get; set;} 

        /// <summary>
        ///     Sets default for all colors associated with this axis all at once: line,
        ///     font, tick, and grid colors. Grid color is lightened by blending this with
        ///     the plot background Individual pieces can override this.
        /// </summary>
        [JsonPropertyName(@"color")]
        public object Color { get; set;} 

        /// <summary>
        ///     Sets a reference between this trace's x coordinates and a 2D cartesian x
        ///     axis. If *x* (the default value), the x coordinates refer to `layout.xaxis`.
        ///     If *x2*, the x coordinates refer to `layout.xaxis2`, and so on.
        /// </summary>
        [JsonPropertyName(@"xaxis")]
        public string XAxis { get; set;} 

        /// <summary>
        ///     Sets a reference between this trace's y coordinates and a 2D cartesian y
        ///     axis. If *y* (the default value), the y coordinates refer to `layout.yaxis`.
        ///     If *y2*, the y coordinates refer to `layout.yaxis2`, and so on.
        /// </summary>
        [JsonPropertyName(@"yaxis")]
        public string YAxis { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  ids .
        /// </summary>
        [JsonPropertyName(@"idssrc")]
        public string IdsSrc { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  customdata .
        /// </summary>
        [JsonPropertyName(@"customdatasrc")]
        public string CustomDataSrc { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  meta .
        /// </summary>
        [JsonPropertyName(@"metasrc")]
        public string MetaSrc { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  x .
        /// </summary>
        [JsonPropertyName(@"xsrc")]
        public string XSrc { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  y .
        /// </summary>
        [JsonPropertyName(@"ysrc")]
        public string YSrc { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  a .
        /// </summary>
        [JsonPropertyName(@"asrc")]
        public string ASrc { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  b .
        /// </summary>
        [JsonPropertyName(@"bsrc")]
        public string BSrc { get; set;} 

    }
}
/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Collections.Generic;
using Plotly.Blazor.Traces.IsoSurfaceLib;

namespace Plotly.Blazor.Traces
{
    /// <summary>
    ///     The IsoSurface class.
    ///     Implements the <see cref="ITrace" />
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    public class IsoSurface : ITrace
    {
        /// <inheritdoc/>
        [JsonPropertyName(@"type")]
        public TraceTypeEnum Type { get; } = TraceTypeEnum.IsoSurface;

        /// <summary>
        ///     Determines whether or not this trace is visible. If *legendonly*, the trace
        ///     is not drawn, but can appear as a legend item (provided that the legend
        ///     itself is visible).
        /// </summary>
        [JsonPropertyName(@"visible")]
        public VisibleEnum? Visible { get; set;} 

        /// <summary>
        ///     Sets the legend group for this trace. Traces part of the same legend group
        ///     hide/show at the same time when toggling legend items.
        /// </summary>
        [JsonPropertyName(@"legendgroup")]
        public string LegendGroup { get; set;} 

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
        ///     Gets or sets the HoverLabel.
        /// </summary>
        [JsonPropertyName(@"hoverlabel")]
        public HoverLabel HoverLabel { get; set;} 

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
        ///     Sets the X coordinates of the vertices on X axis.
        /// </summary>
        [JsonPropertyName(@"x")]
        public IList<object> X { get; set;} 

        /// <summary>
        ///     Sets the Y coordinates of the vertices on Y axis.
        /// </summary>
        [JsonPropertyName(@"y")]
        public IList<object> Y { get; set;} 

        /// <summary>
        ///     Sets the Z coordinates of the vertices on Z axis.
        /// </summary>
        [JsonPropertyName(@"z")]
        public IList<object> Z { get; set;} 

        /// <summary>
        ///     Sets the 4th dimension (value) of the vertices.
        /// </summary>
        [JsonPropertyName(@"value")]
        public IList<object> Value { get; set;} 

        /// <summary>
        ///     Sets the minimum boundary for iso-surface plot.
        /// </summary>
        [JsonPropertyName(@"isomin")]
        public float? IsoMin { get; set;} 

        /// <summary>
        ///     Sets the maximum boundary for iso-surface plot.
        /// </summary>
        [JsonPropertyName(@"isomax")]
        public float? IsoMax { get; set;} 

        /// <summary>
        ///     Gets or sets the Surface.
        /// </summary>
        [JsonPropertyName(@"surface")]
        public Surface Surface { get; set;} 

        /// <summary>
        ///     Gets or sets the SpaceFrame.
        /// </summary>
        [JsonPropertyName(@"spaceframe")]
        public SpaceFrame SpaceFrame { get; set;} 

        /// <summary>
        ///     Gets or sets the Slices.
        /// </summary>
        [JsonPropertyName(@"slices")]
        public Slices Slices { get; set;} 

        /// <summary>
        ///     Gets or sets the Caps.
        /// </summary>
        [JsonPropertyName(@"caps")]
        public Caps Caps { get; set;} 

        /// <summary>
        ///     Sets the text elements associated with the vertices. If trace `hoverinfo`
        ///     contains a *text* flag and *hovertext* is not set, these elements will be
        ///     seen in the hover labels.
        /// </summary>
        [JsonPropertyName(@"text")]
        public string Text { get; set;} 

        /// <summary>
        ///     Same as `text`.
        /// </summary>
        [JsonPropertyName(@"hovertext")]
        public string HoverText { get; set;} 

        /// <summary>
        ///     Template string used for rendering the information that appear on hover
        ///     box. Note that this will override `hoverinfo`. Variables are inserted using
        ///     %{variable}, for example "y: %{y}". Numbers are formatted using d3-format's
        ///     syntax %{variable:d3-format}, for example "Price: %{y:$.2f}". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
        ///     for details on the formatting syntax. Dates are formatted using d3-time-format's
        ///     syntax %{variable|d3-time-format}, for example "Day: %{2019-01-01|%A}".
        ///     https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format
        ///     for details on the date formatting syntax. The variables available in `hovertemplate`
        ///     are the ones emitted as event data described at this link https://plotly.com/javascript/plotlyjs-events/#event-data.
        ///     Additionally, every attributes that can be specified per-point (the ones
        ///     that are `arrayOk: true`) are available.  Anything contained in tag `<extra>`
        ///     is displayed in the secondary box, for example "<extra>{fullData.name}</extra>".
        ///     To hide the secondary box completely, use an empty tag `<extra></extra>`.
        /// </summary>
        [JsonPropertyName(@"hovertemplate")]
        public string HoverTemplate { get; set;} 

        /// <summary>
        ///     Determines whether or not an item corresponding to this trace is shown in
        ///     the legend.
        /// </summary>
        [JsonPropertyName(@"showlegend")]
        public bool? ShowLegend { get; set;} 

        /// <summary>
        ///     Determines whether or not the color domain is computed with respect to the
        ///     input data (here `value`) or the bounds set in `cmin` and `cmax`  Defaults
        ///     to `false` when `cmin` and `cmax` are set by the user.
        /// </summary>
        [JsonPropertyName(@"cauto")]
        public bool? CAuto { get; set;} 

        /// <summary>
        ///     Sets the lower bound of the color domain. Value should have the same units
        ///     as `value` and if set, `cmax` must be set as well.
        /// </summary>
        [JsonPropertyName(@"cmin")]
        public float? CMin { get; set;} 

        /// <summary>
        ///     Sets the upper bound of the color domain. Value should have the same units
        ///     as `value` and if set, `cmin` must be set as well.
        /// </summary>
        [JsonPropertyName(@"cmax")]
        public float? CMax { get; set;} 

        /// <summary>
        ///     Sets the mid-point of the color domain by scaling `cmin` and/or `cmax` to
        ///     be equidistant to this point. Value should have the same units as `value`.
        ///     Has no effect when `cauto` is `false`.
        /// </summary>
        [JsonPropertyName(@"cmid")]
        public float? CMid { get; set;} 

        /// <summary>
        ///     Sets the colorscale. The colorscale must be an array containing arrays mapping
        ///     a normalized value to an rgb, rgba, hex, hsl, hsv, or named color string.
        ///     At minimum, a mapping for the lowest (0) and highest (1) values are required.
        ///     For example, `[[0, 'rgb(0,0,255)'], [1, 'rgb(255,0,0)']]`. To control the
        ///     bounds of the colorscale in color space, use`cmin` and `cmax`. Alternatively,
        ///     `colorscale` may be a palette name string of the following list: Greys,YlGnBu,Greens,YlOrRd,Bluered,RdBu,Reds,Blues,Picnic,Rainbow,Portland,Jet,Hot,Blackbody,Earth,Electric,Viridis,Cividis.
        /// </summary>
        [JsonPropertyName(@"colorscale")]
        public object ColorScale { get; set;} 

        /// <summary>
        ///     Determines whether the colorscale is a default palette (`autocolorscale:
        ///     true`) or the palette determined by `colorscale`. In case `colorscale` is
        ///     unspecified or `autocolorscale` is true, the default  palette will be chosen
        ///     according to whether numbers in the `color` array are all positive, all
        ///     negative or mixed.
        /// </summary>
        [JsonPropertyName(@"autocolorscale")]
        public bool? AutoColorScale { get; set;} 

        /// <summary>
        ///     Reverses the color mapping if true. If true, `cmin` will correspond to the
        ///     last color in the array and `cmax` will correspond to the first color.
        /// </summary>
        [JsonPropertyName(@"reversescale")]
        public bool? ReverseScale { get; set;} 

        /// <summary>
        ///     Determines whether or not a colorbar is displayed for this trace.
        /// </summary>
        [JsonPropertyName(@"showscale")]
        public bool? ShowScale { get; set;} 

        /// <summary>
        ///     Gets or sets the ColorBar.
        /// </summary>
        [JsonPropertyName(@"colorbar")]
        public ColorBar ColorBar { get; set;} 

        /// <summary>
        ///     Sets a reference to a shared color axis. References to these shared color
        ///     axes are *coloraxis*, *coloraxis2*, *coloraxis3*, etc. Settings for these
        ///     shared color axes are set in the layout, under `layout.coloraxis`, `layout.coloraxis2`,
        ///     etc. Note that multiple color scales can be linked to the same color axis.
        /// </summary>
        [JsonPropertyName(@"coloraxis")]
        public string ColorAxis { get; set;} 

        /// <summary>
        ///     Sets the opacity of the surface. Please note that in the case of using high
        ///     `opacity` values for example a value greater than or equal to 0.5 on two
        ///     surfaces (and 0.25 with four surfaces), an overlay of multiple transparent
        ///     surfaces may not perfectly be sorted in depth by the webgl API. This behavior
        ///     may be improved in the near future and is subject to change.
        /// </summary>
        [JsonPropertyName(@"opacity")]
        public float? Opacity { get; set;} 

        /// <summary>
        ///     Gets or sets the LightPosition.
        /// </summary>
        [JsonPropertyName(@"lightposition")]
        public LightPosition LightPosition { get; set;} 

        /// <summary>
        ///     Gets or sets the Lighting.
        /// </summary>
        [JsonPropertyName(@"lighting")]
        public Lighting Lighting { get; set;} 

        /// <summary>
        ///     Determines whether or not normal smoothing is applied to the meshes, creating
        ///     meshes with an angular, low-poly look via flat reflections.
        /// </summary>
        [JsonPropertyName(@"flatshading")]
        public bool? FlatShading { get; set;} 

        /// <summary>
        ///     Gets or sets the Contour.
        /// </summary>
        [JsonPropertyName(@"contour")]
        public Contour Contour { get; set;} 

        /// <summary>
        ///     Determines which trace information appear on hover. If `none` or `skip`
        ///     are set, no information is displayed upon hovering. But, if `none` is set,
        ///     click and hover events are still fired.
        /// </summary>
        [JsonPropertyName(@"hoverinfo")]
        public HoverInfoFlag? HoverInfo { get; set;} 

        /// <summary>
        ///     Sets a reference between this trace's 3D coordinate system and a 3D scene.
        ///     If *scene* (the default value), the (x,y,z) coordinates refer to `layout.scene`.
        ///     If *scene2*, the (x,y,z) coordinates refer to `layout.scene2`, and so on.
        /// </summary>
        [JsonPropertyName(@"scene")]
        public string Scene { get; set;} 

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
        ///     Sets the source reference on Chart Studio Cloud for  z .
        /// </summary>
        [JsonPropertyName(@"zsrc")]
        public string ZSrc { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  value .
        /// </summary>
        [JsonPropertyName(@"valuesrc")]
        public string ValueSrc { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  text .
        /// </summary>
        [JsonPropertyName(@"textsrc")]
        public string TextSrc { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  hovertext .
        /// </summary>
        [JsonPropertyName(@"hovertextsrc")]
        public string HoverTextSrc { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  hovertemplate .
        /// </summary>
        [JsonPropertyName(@"hovertemplatesrc")]
        public string HoverTemplateSrc { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  hoverinfo .
        /// </summary>
        [JsonPropertyName(@"hoverinfosrc")]
        public string HoverInfoSrc { get; set;} 

    }
}
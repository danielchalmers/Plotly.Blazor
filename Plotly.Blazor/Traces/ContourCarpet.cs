/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json.Serialization;

namespace Plotly.Blazor.Traces
{
    /// <summary>
    ///     The ContourCarpet class.
    ///     Implements the <see cref="ITrace" />.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    [JsonConverter(typeof(PlotlyConverter))]
    [Serializable]
    public class ContourCarpet : ITrace, IEquatable<ContourCarpet>
    {
        /// <inheritdoc/>
        [JsonPropertyName(@"type")]
        public TraceTypeEnum? Type { get; } = TraceTypeEnum.ContourCarpet;

        /// <summary>
        ///     Sets the x coordinates.
        /// </summary>
        [JsonPropertyName(@"a")]
        public IList<object> A { get; set;} 

        /// <summary>
        ///     Alternate to <c>x</c>. Builds a linear space of x coordinates. Use with
        ///     <c>dx</c> where <c>x0</c> is the starting coordinate and <c>dx</c> the step.
        /// </summary>
        [JsonPropertyName(@"a0")]
        public object A0 { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for <c>a</c>.
        /// </summary>
        [JsonPropertyName(@"asrc")]
        public string ASrc { get; set;} 

        /// <summary>
        ///     If <c>array</c>, the heatmap&#39;s x coordinates are given by <c>x</c> (the
        ///     default behavior when <c>x</c> is provided). If <c>scaled</c>, the heatmap&#39;s
        ///     x coordinates are given by <c>x0</c> and <c>dx</c> (the default behavior
        ///     when <c>x</c> is not provided).
        /// </summary>
        [JsonPropertyName(@"atype")]
        public Plotly.Blazor.Traces.ContourCarpetLib.ATypeEnum? AType { get; set;} 

        /// <summary>
        ///     Determines whether the colorscale is a default palette (&#39;autocolorscale:
        ///     true&#39;) or the palette determined by <c>colorscale</c>. In case <c>colorscale</c>
        ///     is unspecified or <c>autocolorscale</c> is true, the default palette will
        ///     be chosen according to whether numbers in the <c>color</c> array are all
        ///     positive, all negative or mixed.
        /// </summary>
        [JsonPropertyName(@"autocolorscale")]
        public bool? AutoColorScale { get; set;} 

        /// <summary>
        ///     Determines whether or not the contour level attributes are picked by an
        ///     algorithm. If <c>true</c>, the number of contour levels can be set in <c>ncontours</c>.
        ///     If <c>false</c>, set the contour level attributes in <c>contours</c>.
        /// </summary>
        [JsonPropertyName(@"autocontour")]
        public bool? AutoContour { get; set;} 

        /// <summary>
        ///     Sets the y coordinates.
        /// </summary>
        [JsonPropertyName(@"b")]
        public IList<object> B { get; set;} 

        /// <summary>
        ///     Alternate to <c>y</c>. Builds a linear space of y coordinates. Use with
        ///     <c>dy</c> where <c>y0</c> is the starting coordinate and <c>dy</c> the step.
        /// </summary>
        [JsonPropertyName(@"b0")]
        public object B0 { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for <c>b</c>.
        /// </summary>
        [JsonPropertyName(@"bsrc")]
        public string BSrc { get; set;} 

        /// <summary>
        ///     If <c>array</c>, the heatmap&#39;s y coordinates are given by <c>y</c> (the
        ///     default behavior when <c>y</c> is provided) If <c>scaled</c>, the heatmap&#39;s
        ///     y coordinates are given by <c>y0</c> and <c>dy</c> (the default behavior
        ///     when <c>y</c> is not provided)
        /// </summary>
        [JsonPropertyName(@"btype")]
        public Plotly.Blazor.Traces.ContourCarpetLib.BTypeEnum? BType { get; set;} 

        /// <summary>
        ///     The <c>carpet</c> of the carpet axes on which this contour trace lies
        /// </summary>
        [JsonPropertyName(@"carpet")]
        public string Carpet { get; set;} 

        /// <summary>
        ///     Sets a reference to a shared color axis. References to these shared color
        ///     axes are <c>coloraxis</c>, <c>coloraxis2</c>, <c>coloraxis3</c>, etc. Settings
        ///     for these shared color axes are set in the layout, under <c>layout.coloraxis</c>,
        ///     <c>layout.coloraxis2</c>, etc. Note that multiple color scales can be linked
        ///     to the same color axis.
        /// </summary>
        [JsonPropertyName(@"coloraxis")]
        public string ColorAxis { get; set;} 

        /// <summary>
        ///     Gets or sets the ColorBar.
        /// </summary>
        [JsonPropertyName(@"colorbar")]
        public Plotly.Blazor.Traces.ContourCarpetLib.ColorBar ColorBar { get; set;} 

        /// <summary>
        ///     Sets the colorscale. The colorscale must be an array containing arrays mapping
        ///     a normalized value to an rgb, rgba, hex, hsl, hsv, or named color string.
        ///     At minimum, a mapping for the lowest (0) and highest (1) values are required.
        ///     For example, &#39;[[0, <c>rgb(0,0,255)</c>], [1, <c>rgb(255,0,0)</c>]]&#39;.
        ///     To control the bounds of the colorscale in color space, use <c>zmin</c>
        ///     and <c>zmax</c>. Alternatively, <c>colorscale</c> may be a palette name
        ///     string of the following list: Blackbody,Bluered,Blues,Cividis,Earth,Electric,Greens,Greys,Hot,Jet,Picnic,Portland,Rainbow,RdBu,Reds,Viridis,YlGnBu,YlOrRd.
        /// </summary>
        [JsonPropertyName(@"colorscale")]
        public object ColorScale { get; set;} 

        /// <summary>
        ///     Gets or sets the Contours.
        /// </summary>
        [JsonPropertyName(@"contours")]
        public Plotly.Blazor.Traces.ContourCarpetLib.Contours Contours { get; set;} 

        /// <summary>
        ///     Assigns extra data each datum. This may be useful when listening to hover,
        ///     click and selection events. Note that, <c>scatter</c> traces also appends
        ///     customdata items in the markers DOM elements
        /// </summary>
        [JsonPropertyName(@"customdata")]
        public IList<object> CustomData { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for <c>customdata</c>.
        /// </summary>
        [JsonPropertyName(@"customdatasrc")]
        public string CustomDataSrc { get; set;} 

        /// <summary>
        ///     Sets the x coordinate step. See <c>x0</c> for more info.
        /// </summary>
        [JsonPropertyName(@"da")]
        public decimal? DA { get; set;} 

        /// <summary>
        ///     Sets the y coordinate step. See <c>y0</c> for more info.
        /// </summary>
        [JsonPropertyName(@"db")]
        public decimal? Db { get; set;} 

        /// <summary>
        ///     Sets the fill color if <c>contours.type</c> is <c>constraint</c>. Defaults
        ///     to a half-transparent variant of the line color, marker color, or marker
        ///     line color, whichever is available.
        /// </summary>
        [JsonPropertyName(@"fillcolor")]
        public object FillColor { get; set;} 

        /// <summary>
        ///     Same as <c>text</c>.
        /// </summary>
        [JsonPropertyName(@"hovertext")]
        public IList<object> HoverText { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for <c>hovertext</c>.
        /// </summary>
        [JsonPropertyName(@"hovertextsrc")]
        public string HoverTextSrc { get; set;} 

        /// <summary>
        ///     Assigns id labels to each datum. These ids for object constancy of data
        ///     points during animation. Should be an array of strings, not numbers or any
        ///     other type.
        /// </summary>
        [JsonPropertyName(@"ids")]
        public IList<object> Ids { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for <c>ids</c>.
        /// </summary>
        [JsonPropertyName(@"idssrc")]
        public string IdsSrc { get; set;} 

        /// <summary>
        ///     Sets the legend group for this trace. Traces part of the same legend group
        ///     hide/show at the same time when toggling legend items.
        /// </summary>
        [JsonPropertyName(@"legendgroup")]
        public string LegendGroup { get; set;} 

        /// <summary>
        ///     Gets or sets the LegendGroupTitle.
        /// </summary>
        [JsonPropertyName(@"legendgrouptitle")]
        public Plotly.Blazor.Traces.ContourCarpetLib.LegendGroupTitle LegendGroupTitle { get; set;} 

        /// <summary>
        ///     Sets the legend rank for this trace. Items and groups with smaller ranks
        ///     are presented on top/left side while with `<c>reversed</c> <c>legend.traceorder</c>
        ///     they are on bottom/right side. The default legendrank is 1000, so that you
        ///     can use ranks less than 1000 to place certain items before all unranked
        ///     items, and ranks greater than 1000 to go after all unranked items.
        /// </summary>
        [JsonPropertyName(@"legendrank")]
        public decimal? LegendRank { get; set;} 

        /// <summary>
        ///     Sets the width (in px or fraction) of the legend for this trace.
        /// </summary>
        [JsonPropertyName(@"legendwidth")]
        public decimal? LegendWidth { get; set;} 

        /// <summary>
        ///     Gets or sets the Line.
        /// </summary>
        [JsonPropertyName(@"line")]
        public Plotly.Blazor.Traces.ContourCarpetLib.Line Line { get; set;} 

        /// <summary>
        ///     Assigns extra meta information associated with this trace that can be used
        ///     in various text attributes. Attributes such as trace <c>name</c>, graph,
        ///     axis and colorbar <c>title.text</c>, annotation <c>text</c> <c>rangeselector</c>,
        ///     <c>updatemenues</c> and <c>sliders</c> <c>label</c> text all support <c>meta</c>.
        ///     To access the trace <c>meta</c> values in an attribute in the same trace,
        ///     simply use <c>%{meta[i]}</c> where <c>i</c> is the index or key of the <c>meta</c>
        ///     item in question. To access trace <c>meta</c> in layout attributes, use
        ///     <c>%{data[n[.meta[i]}</c> where <c>i</c> is the index or key of the <c>meta</c>
        ///     and <c>n</c> is the trace index.
        /// </summary>
        [JsonPropertyName(@"meta")]
        public object Meta { get; set;} 

        /// <summary>
        ///     Assigns extra meta information associated with this trace that can be used
        ///     in various text attributes. Attributes such as trace <c>name</c>, graph,
        ///     axis and colorbar <c>title.text</c>, annotation <c>text</c> <c>rangeselector</c>,
        ///     <c>updatemenues</c> and <c>sliders</c> <c>label</c> text all support <c>meta</c>.
        ///     To access the trace <c>meta</c> values in an attribute in the same trace,
        ///     simply use <c>%{meta[i]}</c> where <c>i</c> is the index or key of the <c>meta</c>
        ///     item in question. To access trace <c>meta</c> in layout attributes, use
        ///     <c>%{data[n[.meta[i]}</c> where <c>i</c> is the index or key of the <c>meta</c>
        ///     and <c>n</c> is the trace index.
        /// </summary>
        [JsonPropertyName(@"meta")]
        [Array]
        public IList<object> MetaArray { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for <c>meta</c>.
        /// </summary>
        [JsonPropertyName(@"metasrc")]
        public string MetaSrc { get; set;} 

        /// <summary>
        ///     Sets the trace name. The trace name appear as the legend item and on hover.
        /// </summary>
        [JsonPropertyName(@"name")]
        public string Name { get; set;} 

        /// <summary>
        ///     Sets the maximum number of contour levels. The actual number of contours
        ///     will be chosen automatically to be less than or equal to the value of <c>ncontours</c>.
        ///     Has an effect only if <c>autocontour</c> is <c>true</c> or if <c>contours.size</c>
        ///     is missing.
        /// </summary>
        [JsonPropertyName(@"ncontours")]
        public int? NContours { get; set;} 

        /// <summary>
        ///     Sets the opacity of the trace.
        /// </summary>
        [JsonPropertyName(@"opacity")]
        public decimal? Opacity { get; set;} 

        /// <summary>
        ///     Reverses the color mapping if true. If true, <c>zmin</c> will correspond
        ///     to the last color in the array and <c>zmax</c> will correspond to the first
        ///     color.
        /// </summary>
        [JsonPropertyName(@"reversescale")]
        public bool? ReverseScale { get; set;} 

        /// <summary>
        ///     Determines whether or not an item corresponding to this trace is shown in
        ///     the legend.
        /// </summary>
        [JsonPropertyName(@"showlegend")]
        public bool? ShowLegend { get; set;} 

        /// <summary>
        ///     Determines whether or not a colorbar is displayed for this trace.
        /// </summary>
        [JsonPropertyName(@"showscale")]
        public bool? ShowScale { get; set;} 

        /// <summary>
        ///     Gets or sets the Stream.
        /// </summary>
        [JsonPropertyName(@"stream")]
        public Plotly.Blazor.Traces.ContourCarpetLib.Stream Stream { get; set;} 

        /// <summary>
        ///     Sets the text elements associated with each z value.
        /// </summary>
        [JsonPropertyName(@"text")]
        public IList<object> Text { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for <c>text</c>.
        /// </summary>
        [JsonPropertyName(@"textsrc")]
        public string TextSrc { get; set;} 

        /// <summary>
        ///     Transposes the z data.
        /// </summary>
        [JsonPropertyName(@"transpose")]
        public bool? Transpose { get; set;} 

        /// <summary>
        ///     Assign an id to this trace, Use this to provide object constancy between
        ///     traces during animations and transitions.
        /// </summary>
        [JsonPropertyName(@"uid")]
        public string UId { get; set;} 

        /// <summary>
        ///     Controls persistence of some user-driven changes to the trace: <c>constraintrange</c>
        ///     in <c>parcoords</c> traces, as well as some &#39;editable: true&#39; modifications
        ///     such as <c>name</c> and <c>colorbar.title</c>. Defaults to <c>layout.uirevision</c>.
        ///     Note that other user-driven trace attribute changes are controlled by <c>layout</c>
        ///     attributes: <c>trace.visible</c> is controlled by <c>layout.legend.uirevision</c>,
        ///     <c>selectedpoints</c> is controlled by <c>layout.selectionrevision</c>,
        ///     and <c>colorbar.(x|y)</c> (accessible with &#39;config: {editable: true}&#39;)
        ///     is controlled by <c>layout.editrevision</c>. Trace changes are tracked by
        ///     <c>uid</c>, which only falls back on trace index if no <c>uid</c> is provided.
        ///     So if your app can add/remove traces before the end of the <c>data</c> array,
        ///     such that the same trace has a different index, you can still preserve user-driven
        ///     changes if you give each trace a <c>uid</c> that stays with it as it moves.
        /// </summary>
        [JsonPropertyName(@"uirevision")]
        public object UiRevision { get; set;} 

        /// <summary>
        ///     Determines whether or not this trace is visible. If <c>legendonly</c>, the
        ///     trace is not drawn, but can appear as a legend item (provided that the legend
        ///     itself is visible).
        /// </summary>
        [JsonPropertyName(@"visible")]
        public Plotly.Blazor.Traces.ContourCarpetLib.VisibleEnum? Visible { get; set;} 

        /// <summary>
        ///     Sets a reference between this trace&#39;s x coordinates and a 2D cartesian
        ///     x axis. If <c>x</c> (the default value), the x coordinates refer to <c>layout.xaxis</c>.
        ///     If <c>x2</c>, the x coordinates refer to <c>layout.xaxis2</c>, and so on.
        /// </summary>
        [JsonPropertyName(@"xaxis")]
        public string XAxis { get; set;} 

        /// <summary>
        ///     Sets a reference between this trace&#39;s y coordinates and a 2D cartesian
        ///     y axis. If <c>y</c> (the default value), the y coordinates refer to <c>layout.yaxis</c>.
        ///     If <c>y2</c>, the y coordinates refer to <c>layout.yaxis2</c>, and so on.
        /// </summary>
        [JsonPropertyName(@"yaxis")]
        public string YAxis { get; set;} 

        /// <summary>
        ///     Sets the z data.
        /// </summary>
        [JsonPropertyName(@"z")]
        public IList<object> Z { get; set;} 

        /// <summary>
        ///     Determines whether or not the color domain is computed with respect to the
        ///     input data (here in <c>z</c>) or the bounds set in <c>zmin</c> and <c>zmax</c>
        ///     Defaults to <c>false</c> when <c>zmin</c> and <c>zmax</c> are set by the
        ///     user.
        /// </summary>
        [JsonPropertyName(@"zauto")]
        public bool? ZAuto { get; set;} 

        /// <summary>
        ///     Sets the upper bound of the color domain. Value should have the same units
        ///     as in <c>z</c> and if set, <c>zmin</c> must be set as well.
        /// </summary>
        [JsonPropertyName(@"zmax")]
        public decimal? ZMax { get; set;} 

        /// <summary>
        ///     Sets the mid-point of the color domain by scaling <c>zmin</c> and/or <c>zmax</c>
        ///     to be equidistant to this point. Value should have the same units as in
        ///     <c>z</c>. Has no effect when <c>zauto</c> is <c>false</c>.
        /// </summary>
        [JsonPropertyName(@"zmid")]
        public decimal? ZMid { get; set;} 

        /// <summary>
        ///     Sets the lower bound of the color domain. Value should have the same units
        ///     as in <c>z</c> and if set, <c>zmax</c> must be set as well.
        /// </summary>
        [JsonPropertyName(@"zmin")]
        public decimal? ZMin { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for <c>z</c>.
        /// </summary>
        [JsonPropertyName(@"zsrc")]
        public string ZSrc { get; set;} 

        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            if (!(obj is ContourCarpet other)) return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        /// <inheritdoc />
        public bool Equals([AllowNull] ContourCarpet other)
        {
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Type == other.Type ||
                    Type != null &&
                    Type.Equals(other.Type)
                ) && 
                (
                    Equals(A, other.A) ||
                    A != null && other.A != null &&
                    A.SequenceEqual(other.A)
                ) &&
                (
                    A0 == other.A0 ||
                    A0 != null &&
                    A0.Equals(other.A0)
                ) && 
                (
                    ASrc == other.ASrc ||
                    ASrc != null &&
                    ASrc.Equals(other.ASrc)
                ) && 
                (
                    AType == other.AType ||
                    AType != null &&
                    AType.Equals(other.AType)
                ) && 
                (
                    AutoColorScale == other.AutoColorScale ||
                    AutoColorScale != null &&
                    AutoColorScale.Equals(other.AutoColorScale)
                ) && 
                (
                    AutoContour == other.AutoContour ||
                    AutoContour != null &&
                    AutoContour.Equals(other.AutoContour)
                ) && 
                (
                    Equals(B, other.B) ||
                    B != null && other.B != null &&
                    B.SequenceEqual(other.B)
                ) &&
                (
                    B0 == other.B0 ||
                    B0 != null &&
                    B0.Equals(other.B0)
                ) && 
                (
                    BSrc == other.BSrc ||
                    BSrc != null &&
                    BSrc.Equals(other.BSrc)
                ) && 
                (
                    BType == other.BType ||
                    BType != null &&
                    BType.Equals(other.BType)
                ) && 
                (
                    Carpet == other.Carpet ||
                    Carpet != null &&
                    Carpet.Equals(other.Carpet)
                ) && 
                (
                    ColorAxis == other.ColorAxis ||
                    ColorAxis != null &&
                    ColorAxis.Equals(other.ColorAxis)
                ) && 
                (
                    ColorBar == other.ColorBar ||
                    ColorBar != null &&
                    ColorBar.Equals(other.ColorBar)
                ) && 
                (
                    ColorScale == other.ColorScale ||
                    ColorScale != null &&
                    ColorScale.Equals(other.ColorScale)
                ) && 
                (
                    Contours == other.Contours ||
                    Contours != null &&
                    Contours.Equals(other.Contours)
                ) && 
                (
                    Equals(CustomData, other.CustomData) ||
                    CustomData != null && other.CustomData != null &&
                    CustomData.SequenceEqual(other.CustomData)
                ) &&
                (
                    CustomDataSrc == other.CustomDataSrc ||
                    CustomDataSrc != null &&
                    CustomDataSrc.Equals(other.CustomDataSrc)
                ) && 
                (
                    DA == other.DA ||
                    DA != null &&
                    DA.Equals(other.DA)
                ) && 
                (
                    Db == other.Db ||
                    Db != null &&
                    Db.Equals(other.Db)
                ) && 
                (
                    FillColor == other.FillColor ||
                    FillColor != null &&
                    FillColor.Equals(other.FillColor)
                ) && 
                (
                    Equals(HoverText, other.HoverText) ||
                    HoverText != null && other.HoverText != null &&
                    HoverText.SequenceEqual(other.HoverText)
                ) &&
                (
                    HoverTextSrc == other.HoverTextSrc ||
                    HoverTextSrc != null &&
                    HoverTextSrc.Equals(other.HoverTextSrc)
                ) && 
                (
                    Equals(Ids, other.Ids) ||
                    Ids != null && other.Ids != null &&
                    Ids.SequenceEqual(other.Ids)
                ) &&
                (
                    IdsSrc == other.IdsSrc ||
                    IdsSrc != null &&
                    IdsSrc.Equals(other.IdsSrc)
                ) && 
                (
                    LegendGroup == other.LegendGroup ||
                    LegendGroup != null &&
                    LegendGroup.Equals(other.LegendGroup)
                ) && 
                (
                    LegendGroupTitle == other.LegendGroupTitle ||
                    LegendGroupTitle != null &&
                    LegendGroupTitle.Equals(other.LegendGroupTitle)
                ) && 
                (
                    LegendRank == other.LegendRank ||
                    LegendRank != null &&
                    LegendRank.Equals(other.LegendRank)
                ) && 
                (
                    LegendWidth == other.LegendWidth ||
                    LegendWidth != null &&
                    LegendWidth.Equals(other.LegendWidth)
                ) && 
                (
                    Line == other.Line ||
                    Line != null &&
                    Line.Equals(other.Line)
                ) && 
                (
                    Meta == other.Meta ||
                    Meta != null &&
                    Meta.Equals(other.Meta)
                ) && 
                (
                    Equals(MetaArray, other.MetaArray) ||
                    MetaArray != null && other.MetaArray != null &&
                    MetaArray.SequenceEqual(other.MetaArray)
                ) &&
                (
                    MetaSrc == other.MetaSrc ||
                    MetaSrc != null &&
                    MetaSrc.Equals(other.MetaSrc)
                ) && 
                (
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
                ) && 
                (
                    NContours == other.NContours ||
                    NContours != null &&
                    NContours.Equals(other.NContours)
                ) && 
                (
                    Opacity == other.Opacity ||
                    Opacity != null &&
                    Opacity.Equals(other.Opacity)
                ) && 
                (
                    ReverseScale == other.ReverseScale ||
                    ReverseScale != null &&
                    ReverseScale.Equals(other.ReverseScale)
                ) && 
                (
                    ShowLegend == other.ShowLegend ||
                    ShowLegend != null &&
                    ShowLegend.Equals(other.ShowLegend)
                ) && 
                (
                    ShowScale == other.ShowScale ||
                    ShowScale != null &&
                    ShowScale.Equals(other.ShowScale)
                ) && 
                (
                    Stream == other.Stream ||
                    Stream != null &&
                    Stream.Equals(other.Stream)
                ) && 
                (
                    Equals(Text, other.Text) ||
                    Text != null && other.Text != null &&
                    Text.SequenceEqual(other.Text)
                ) &&
                (
                    TextSrc == other.TextSrc ||
                    TextSrc != null &&
                    TextSrc.Equals(other.TextSrc)
                ) && 
                (
                    Transpose == other.Transpose ||
                    Transpose != null &&
                    Transpose.Equals(other.Transpose)
                ) && 
                (
                    UId == other.UId ||
                    UId != null &&
                    UId.Equals(other.UId)
                ) && 
                (
                    UiRevision == other.UiRevision ||
                    UiRevision != null &&
                    UiRevision.Equals(other.UiRevision)
                ) && 
                (
                    Visible == other.Visible ||
                    Visible != null &&
                    Visible.Equals(other.Visible)
                ) && 
                (
                    XAxis == other.XAxis ||
                    XAxis != null &&
                    XAxis.Equals(other.XAxis)
                ) && 
                (
                    YAxis == other.YAxis ||
                    YAxis != null &&
                    YAxis.Equals(other.YAxis)
                ) && 
                (
                    Equals(Z, other.Z) ||
                    Z != null && other.Z != null &&
                    Z.SequenceEqual(other.Z)
                ) &&
                (
                    ZAuto == other.ZAuto ||
                    ZAuto != null &&
                    ZAuto.Equals(other.ZAuto)
                ) && 
                (
                    ZMax == other.ZMax ||
                    ZMax != null &&
                    ZMax.Equals(other.ZMax)
                ) && 
                (
                    ZMid == other.ZMid ||
                    ZMid != null &&
                    ZMid.Equals(other.ZMid)
                ) && 
                (
                    ZMin == other.ZMin ||
                    ZMin != null &&
                    ZMin.Equals(other.ZMin)
                ) && 
                (
                    ZSrc == other.ZSrc ||
                    ZSrc != null &&
                    ZSrc.Equals(other.ZSrc)
                );
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (Type != null) hashCode = hashCode * 59 + Type.GetHashCode();
                if (A != null) hashCode = hashCode * 59 + A.GetHashCode();
                if (A0 != null) hashCode = hashCode * 59 + A0.GetHashCode();
                if (ASrc != null) hashCode = hashCode * 59 + ASrc.GetHashCode();
                if (AType != null) hashCode = hashCode * 59 + AType.GetHashCode();
                if (AutoColorScale != null) hashCode = hashCode * 59 + AutoColorScale.GetHashCode();
                if (AutoContour != null) hashCode = hashCode * 59 + AutoContour.GetHashCode();
                if (B != null) hashCode = hashCode * 59 + B.GetHashCode();
                if (B0 != null) hashCode = hashCode * 59 + B0.GetHashCode();
                if (BSrc != null) hashCode = hashCode * 59 + BSrc.GetHashCode();
                if (BType != null) hashCode = hashCode * 59 + BType.GetHashCode();
                if (Carpet != null) hashCode = hashCode * 59 + Carpet.GetHashCode();
                if (ColorAxis != null) hashCode = hashCode * 59 + ColorAxis.GetHashCode();
                if (ColorBar != null) hashCode = hashCode * 59 + ColorBar.GetHashCode();
                if (ColorScale != null) hashCode = hashCode * 59 + ColorScale.GetHashCode();
                if (Contours != null) hashCode = hashCode * 59 + Contours.GetHashCode();
                if (CustomData != null) hashCode = hashCode * 59 + CustomData.GetHashCode();
                if (CustomDataSrc != null) hashCode = hashCode * 59 + CustomDataSrc.GetHashCode();
                if (DA != null) hashCode = hashCode * 59 + DA.GetHashCode();
                if (Db != null) hashCode = hashCode * 59 + Db.GetHashCode();
                if (FillColor != null) hashCode = hashCode * 59 + FillColor.GetHashCode();
                if (HoverText != null) hashCode = hashCode * 59 + HoverText.GetHashCode();
                if (HoverTextSrc != null) hashCode = hashCode * 59 + HoverTextSrc.GetHashCode();
                if (Ids != null) hashCode = hashCode * 59 + Ids.GetHashCode();
                if (IdsSrc != null) hashCode = hashCode * 59 + IdsSrc.GetHashCode();
                if (LegendGroup != null) hashCode = hashCode * 59 + LegendGroup.GetHashCode();
                if (LegendGroupTitle != null) hashCode = hashCode * 59 + LegendGroupTitle.GetHashCode();
                if (LegendRank != null) hashCode = hashCode * 59 + LegendRank.GetHashCode();
                if (LegendWidth != null) hashCode = hashCode * 59 + LegendWidth.GetHashCode();
                if (Line != null) hashCode = hashCode * 59 + Line.GetHashCode();
                if (Meta != null) hashCode = hashCode * 59 + Meta.GetHashCode();
                if (MetaArray != null) hashCode = hashCode * 59 + MetaArray.GetHashCode();
                if (MetaSrc != null) hashCode = hashCode * 59 + MetaSrc.GetHashCode();
                if (Name != null) hashCode = hashCode * 59 + Name.GetHashCode();
                if (NContours != null) hashCode = hashCode * 59 + NContours.GetHashCode();
                if (Opacity != null) hashCode = hashCode * 59 + Opacity.GetHashCode();
                if (ReverseScale != null) hashCode = hashCode * 59 + ReverseScale.GetHashCode();
                if (ShowLegend != null) hashCode = hashCode * 59 + ShowLegend.GetHashCode();
                if (ShowScale != null) hashCode = hashCode * 59 + ShowScale.GetHashCode();
                if (Stream != null) hashCode = hashCode * 59 + Stream.GetHashCode();
                if (Text != null) hashCode = hashCode * 59 + Text.GetHashCode();
                if (TextSrc != null) hashCode = hashCode * 59 + TextSrc.GetHashCode();
                if (Transpose != null) hashCode = hashCode * 59 + Transpose.GetHashCode();
                if (UId != null) hashCode = hashCode * 59 + UId.GetHashCode();
                if (UiRevision != null) hashCode = hashCode * 59 + UiRevision.GetHashCode();
                if (Visible != null) hashCode = hashCode * 59 + Visible.GetHashCode();
                if (XAxis != null) hashCode = hashCode * 59 + XAxis.GetHashCode();
                if (YAxis != null) hashCode = hashCode * 59 + YAxis.GetHashCode();
                if (Z != null) hashCode = hashCode * 59 + Z.GetHashCode();
                if (ZAuto != null) hashCode = hashCode * 59 + ZAuto.GetHashCode();
                if (ZMax != null) hashCode = hashCode * 59 + ZMax.GetHashCode();
                if (ZMid != null) hashCode = hashCode * 59 + ZMid.GetHashCode();
                if (ZMin != null) hashCode = hashCode * 59 + ZMin.GetHashCode();
                if (ZSrc != null) hashCode = hashCode * 59 + ZSrc.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left ContourCarpet and the right ContourCarpet.
        /// </summary>
        /// <param name="left">Left ContourCarpet.</param>
        /// <param name="right">Right ContourCarpet.</param>
        /// <returns>Boolean</returns>
        public static bool operator == (ContourCarpet left, ContourCarpet right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left ContourCarpet and the right ContourCarpet.
        /// </summary>
        /// <param name="left">Left ContourCarpet.</param>
        /// <param name="right">Right ContourCarpet.</param>
        /// <returns>Boolean</returns>
        public static bool operator != (ContourCarpet left, ContourCarpet right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>ContourCarpet</returns>
        public ContourCarpet DeepClone()
        {
            return this.Copy();
        }
    }
}
/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Collections.Generic;
using Plotly.Blazor.LayoutLib.SceneLib.XAxisLib;

namespace Plotly.Blazor.LayoutLib.SceneLib
{
    /// <summary>
    ///     The XAxis class.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    public class XAxis 
    {
        /// <summary>
        ///     A single toggle to hide the axis while preserving interaction like dragging.
        ///     Default is true when a cheater plot is present on the axis, otherwise false
        /// </summary>
        [JsonPropertyName(@"visible")]
        public bool? Visible { get; set;} 

        /// <summary>
        ///     Sets whether or not spikes starting from data points to this axis' wall
        ///     are shown on hover.
        /// </summary>
        [JsonPropertyName(@"showspikes")]
        public bool? ShowSpikes { get; set;} 

        /// <summary>
        ///     Sets whether or not spikes extending from the projection data points to
        ///     this axis' wall boundaries are shown on hover.
        /// </summary>
        [JsonPropertyName(@"spikesides")]
        public bool? SpikeSides { get; set;} 

        /// <summary>
        ///     Sets the thickness (in px) of the spikes.
        /// </summary>
        [JsonPropertyName(@"spikethickness")]
        public float? SpikeThickness { get; set;} 

        /// <summary>
        ///     Sets the color of the spikes.
        /// </summary>
        [JsonPropertyName(@"spikecolor")]
        public object SpikeColor { get; set;} 

        /// <summary>
        ///     Sets whether or not this axis' wall has a background color.
        /// </summary>
        [JsonPropertyName(@"showbackground")]
        public bool? ShowBackground { get; set;} 

        /// <summary>
        ///     Sets the background color of this axis' wall.
        /// </summary>
        [JsonPropertyName(@"backgroundcolor")]
        public object BackgroundColor { get; set;} 

        /// <summary>
        ///     Sets whether or not this axis is labeled
        /// </summary>
        [JsonPropertyName(@"showaxeslabels")]
        public bool? ShowAxesLabels { get; set;} 

        /// <summary>
        ///     Sets default for all colors associated with this axis all at once: line,
        ///     font, tick, and grid colors. Grid color is lightened by blending this with
        ///     the plot background Individual pieces can override this.
        /// </summary>
        [JsonPropertyName(@"color")]
        public object Color { get; set;} 

        /// <summary>
        ///     Specifies the ordering logic for the case of categorical variables. By default,
        ///     plotly uses *trace*, which specifies the order that is present in the data
        ///     supplied. Set `categoryorder` to *category ascending* or *category descending*
        ///     if order should be determined by the alphanumerical order of the category
        ///     names. Set `categoryorder` to *array* to derive the ordering from the attribute
        ///     `categoryarray`. If a category is not found in the `categoryarray` array,
        ///     the sorting behavior for that attribute will be identical to the *trace*
        ///     mode. The unspecified categories will follow the categories in `categoryarray`.
        ///     Set `categoryorder` to *total ascending* or *total descending* if order
        ///     should be determined by the numerical order of the values. Similarly, the
        ///     order can be determined by the min, max, sum, mean or median of all the
        ///     values.
        /// </summary>
        [JsonPropertyName(@"categoryorder")]
        public CategoryOrderEnum? CategoryOrder { get; set;} 

        /// <summary>
        ///     Sets the order in which categories on this axis appear. Only has an effect
        ///     if `categoryorder` is set to *array*. Used with `categoryorder`.
        /// </summary>
        [JsonPropertyName(@"categoryarray")]
        public IList<object> CategoryArray { get; set;} 

        /// <summary>
        ///     Gets or sets the Title.
        /// </summary>
        [JsonPropertyName(@"title")]
        public Title Title { get; set;} 

        /// <summary>
        ///     Sets the axis type. By default, plotly attempts to determined the axis type
        ///     by looking into the data of the traces that referenced the axis in question.
        /// </summary>
        [JsonPropertyName(@"type")]
        public TypeEnum? Type { get; set;} 

        /// <summary>
        ///     Determines whether or not the range of this axis is computed in relation
        ///     to the input data. See `rangemode` for more info. If `range` is provided,
        ///     then `autorange` is set to *false*.
        /// </summary>
        [JsonPropertyName(@"autorange")]
        public AutoRangeEnum? AutoRange { get; set;} 

        /// <summary>
        ///     If *normal*, the range is computed in relation to the extrema of the input
        ///     data. If *tozero*`, the range extends to 0, regardless of the input data
        ///     If *nonnegative*, the range is non-negative, regardless of the input data.
        ///     Applies only to linear axes.
        /// </summary>
        [JsonPropertyName(@"rangemode")]
        public RangeModeEnum? RangeMode { get; set;} 

        /// <summary>
        ///     Sets the range of this axis. If the axis `type` is *log*, then you must
        ///     take the log of your desired range (e.g. to set the range from 1 to 100,
        ///     set the range from 0 to 2). If the axis `type` is *date*, it should be date
        ///     strings, like date data, though Date objects and unix milliseconds will
        ///     be accepted and converted to strings. If the axis `type` is *category*,
        ///     it should be numbers, using the scale where each category is assigned a
        ///     serial number from zero in the order it appears.
        /// </summary>
        [JsonPropertyName(@"range")]
        public IList<object> Range { get; set;} 

        /// <summary>
        ///     Sets the tick mode for this axis. If *auto*, the number of ticks is set
        ///     via `nticks`. If *linear*, the placement of the ticks is determined by a
        ///     starting position `tick0` and a tick step `dtick` (*linear* is the default
        ///     value if `tick0` and `dtick` are provided). If *array*, the placement of
        ///     the ticks is set via `tickvals` and the tick text is `ticktext`. (*array*
        ///     is the default value if `tickvals` is provided).
        /// </summary>
        [JsonPropertyName(@"tickmode")]
        public TickModeEnum? TickMode { get; set;} 

        /// <summary>
        ///     Specifies the maximum number of ticks for the particular axis. The actual
        ///     number of ticks will be chosen automatically to be less than or equal to
        ///     `nticks`. Has an effect only if `tickmode` is set to *auto*.
        /// </summary>
        [JsonPropertyName(@"nticks")]
        public int? NTicks { get; set;} 

        /// <summary>
        ///     Sets the placement of the first tick on this axis. Use with `dtick`. If
        ///     the axis `type` is *log*, then you must take the log of your starting tick
        ///     (e.g. to set the starting tick to 100, set the `tick0` to 2) except when
        ///     `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*,
        ///     it should be a date string, like date data. If the axis `type` is *category*,
        ///     it should be a number, using the scale where each category is assigned a
        ///     serial number from zero in the order it appears.
        /// </summary>
        [JsonPropertyName(@"tick0")]
        public object Tick0 { get; set;} 

        /// <summary>
        ///     Sets the step in-between ticks on this axis. Use with `tick0`. Must be a
        ///     positive number, or special strings available to *log* and *date* axes.
        ///     If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where
        ///     n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000,
        ///     ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to
        ///     2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5),
        ///     or 0.69897000433. *log* has several special values; *L<f>*, where `f` is
        ///     a positive number, gives ticks linearly spaced in value (but not position).
        ///     For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6,
        ///     1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all
        ///     digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If
        ///     the axis `type` is *date*, then you must convert the time to milliseconds.
        ///     For example, to set the interval between ticks to one day, set `dtick` to
        ///     86400000.0. *date* also has special values *M<n>* gives ticks spaced by
        ///     a number of months. `n` must be a positive integer. To set ticks on the
        ///     15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*.
        ///     To set ticks every 4 years, set `dtick` to *M48*
        /// </summary>
        [JsonPropertyName(@"dtick")]
        public object DTick { get; set;} 

        /// <summary>
        ///     Sets the values at which ticks on this axis appear. Only has an effect if
        ///     `tickmode` is set to *array*. Used with `ticktext`.
        /// </summary>
        [JsonPropertyName(@"tickvals")]
        public IList<object> TickVals { get; set;} 

        /// <summary>
        ///     Sets the text displayed at the ticks position via `tickvals`. Only has an
        ///     effect if `tickmode` is set to *array*. Used with `tickvals`.
        /// </summary>
        [JsonPropertyName(@"ticktext")]
        public IList<object> TickText { get; set;} 

        /// <summary>
        ///     Determines whether ticks are drawn or not. If **, this axis' ticks are not
        ///     drawn. If *outside* (*inside*), this axis' are drawn outside (inside) the
        ///     axis lines.
        /// </summary>
        [JsonPropertyName(@"ticks")]
        public TicksEnum? Ticks { get; set;} 

        /// <summary>
        ///     Determines if the axis lines or/and ticks are mirrored to the opposite side
        ///     of the plotting area. If *true*, the axis lines are mirrored. If *ticks*,
        ///     the axis lines and ticks are mirrored. If *false*, mirroring is disable.
        ///     If *all*, axis lines are mirrored on all shared-axes subplots. If *allticks*,
        ///     axis lines and ticks are mirrored on all shared-axes subplots.
        /// </summary>
        [JsonPropertyName(@"mirror")]
        public MirrorEnum? Mirror { get; set;} 

        /// <summary>
        ///     Sets the tick length (in px).
        /// </summary>
        [JsonPropertyName(@"ticklen")]
        public float? TickleN { get; set;} 

        /// <summary>
        ///     Sets the tick width (in px).
        /// </summary>
        [JsonPropertyName(@"tickwidth")]
        public float? TickWidth { get; set;} 

        /// <summary>
        ///     Sets the tick color.
        /// </summary>
        [JsonPropertyName(@"tickcolor")]
        public object TickColor { get; set;} 

        /// <summary>
        ///     Determines whether or not the tick labels are drawn.
        /// </summary>
        [JsonPropertyName(@"showticklabels")]
        public bool? ShowTickLabels { get; set;} 

        /// <summary>
        ///     Sets the tick font.
        /// </summary>
        [JsonPropertyName(@"tickfont")]
        public TickFont TickFont { get; set;} 

        /// <summary>
        ///     Sets the angle of the tick labels with respect to the horizontal. For example,
        ///     a `tickangle` of -90 draws the tick labels vertically.
        /// </summary>
        [JsonPropertyName(@"tickangle")]
        public float? TickAngle { get; set;} 

        /// <summary>
        ///     Sets a tick label prefix.
        /// </summary>
        [JsonPropertyName(@"tickprefix")]
        public string TickPrefix { get; set;} 

        /// <summary>
        ///     If *all*, all tick labels are displayed with a prefix. If *first*, only
        ///     the first tick is displayed with a prefix. If *last*, only the last tick
        ///     is displayed with a suffix. If *none*, tick prefixes are hidden.
        /// </summary>
        [JsonPropertyName(@"showtickprefix")]
        public ShowTickPrefixEnum? ShowTickPrefix { get; set;} 

        /// <summary>
        ///     Sets a tick label suffix.
        /// </summary>
        [JsonPropertyName(@"ticksuffix")]
        public string TickSuffix { get; set;} 

        /// <summary>
        ///     Same as `showtickprefix` but for tick suffixes.
        /// </summary>
        [JsonPropertyName(@"showticksuffix")]
        public ShowTickSuffixEnum? ShowTickSuffix { get; set;} 

        /// <summary>
        ///     If *all*, all exponents are shown besides their significands. If *first*,
        ///     only the exponent of the first tick is shown. If *last*, only the exponent
        ///     of the last tick is shown. If *none*, no exponents appear.
        /// </summary>
        [JsonPropertyName(@"showexponent")]
        public ShowExponentEnum? ShowExponent { get; set;} 

        /// <summary>
        ///     Determines a formatting rule for the tick exponents. For example, consider
        ///     the number 1,000,000,000. If *none*, it appears as 1,000,000,000. If *e*,
        ///     1e+9. If *E*, 1E+9. If *power*, 1x10^9 (with 9 in a super script). If *SI*,
        ///     1G. If *B*, 1B.
        /// </summary>
        [JsonPropertyName(@"exponentformat")]
        public ExponentFormatEnum? ExponentFormat { get; set;} 

        /// <summary>
        ///     If "true", even 4-digit integers are separated
        /// </summary>
        [JsonPropertyName(@"separatethousands")]
        public bool? SeparateThousands { get; set;} 

        /// <summary>
        ///     Sets the tick label formatting rule using d3 formatting mini-languages which
        ///     are very similar to those in Python. For numbers, see: https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
        ///     And for dates see: https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format
        ///     We add one item to d3's date formatter: *%{n}f* for fractional seconds with
        ///     n digits. For example, *2016-10-13 09:15:23.456* with tickformat *%H~%M~%S.%2f*
        ///     would display *09~15~23.46*
        /// </summary>
        [JsonPropertyName(@"tickformat")]
        public string TickFormat { get; set;} 

        /// <summary>
        ///     Gets or sets the TickFormatStops.
        /// </summary>
        [JsonPropertyName(@"tickformatstops")]
        public IList<TickFormatStop> TickFormatStops { get; set;} 

        /// <summary>
        ///     Sets the hover text formatting rule using d3 formatting mini-languages which
        ///     are very similar to those in Python. For numbers, see: https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
        ///     And for dates see: https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format
        ///     We add one item to d3's date formatter: *%{n}f* for fractional seconds with
        ///     n digits. For example, *2016-10-13 09:15:23.456* with tickformat *%H~%M~%S.%2f*
        ///     would display *09~15~23.46*
        /// </summary>
        [JsonPropertyName(@"hoverformat")]
        public string HoverFormat { get; set;} 

        /// <summary>
        ///     Determines whether or not a line bounding this axis is drawn.
        /// </summary>
        [JsonPropertyName(@"showline")]
        public bool? ShowLine { get; set;} 

        /// <summary>
        ///     Sets the axis line color.
        /// </summary>
        [JsonPropertyName(@"linecolor")]
        public object LineColor { get; set;} 

        /// <summary>
        ///     Sets the width (in px) of the axis line.
        /// </summary>
        [JsonPropertyName(@"linewidth")]
        public float? LineWidth { get; set;} 

        /// <summary>
        ///     Determines whether or not grid lines are drawn. If *true*, the grid lines
        ///     are drawn at every tick mark.
        /// </summary>
        [JsonPropertyName(@"showgrid")]
        public bool? ShowGrid { get; set;} 

        /// <summary>
        ///     Sets the color of the grid lines.
        /// </summary>
        [JsonPropertyName(@"gridcolor")]
        public object GridColor { get; set;} 

        /// <summary>
        ///     Sets the width (in px) of the grid lines.
        /// </summary>
        [JsonPropertyName(@"gridwidth")]
        public float? GridWidth { get; set;} 

        /// <summary>
        ///     Determines whether or not a line is drawn at along the 0 value of this axis.
        ///     If *true*, the zero line is drawn on top of the grid lines.
        /// </summary>
        [JsonPropertyName(@"zeroline")]
        public bool? ZeroLine { get; set;} 

        /// <summary>
        ///     Sets the line color of the zero line.
        /// </summary>
        [JsonPropertyName(@"zerolinecolor")]
        public object ZeroLineColor { get; set;} 

        /// <summary>
        ///     Sets the width (in px) of the zero line.
        /// </summary>
        [JsonPropertyName(@"zerolinewidth")]
        public float? ZeroLineWidth { get; set;} 

        /// <summary>
        ///     Sets the calendar system to use for `range` and `tick0` if this is a date
        ///     axis. This does not set the calendar for interpreting data on this axis,
        ///     that's specified in the trace or via the global `layout.calendar`
        /// </summary>
        [JsonPropertyName(@"calendar")]
        public CalendarEnum? Calendar { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  categoryarray .
        /// </summary>
        [JsonPropertyName(@"categoryarraysrc")]
        public string CategoryArraySrc { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  tickvals .
        /// </summary>
        [JsonPropertyName(@"tickvalssrc")]
        public string TickValsSrc { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  ticktext .
        /// </summary>
        [JsonPropertyName(@"ticktextsrc")]
        public string TickTextSrc { get; set;} 

    }
}
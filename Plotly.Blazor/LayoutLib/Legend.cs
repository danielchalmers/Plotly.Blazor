/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json.Serialization;

namespace Plotly.Blazor.LayoutLib
{
    /// <summary>
    ///     The Legend class.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    [Serializable]
    public class Legend : IEquatable<Legend>
    {
        /// <summary>
        ///     Sets the legend background color. Defaults to <c>layout.paper_bgcolor</c>.
        /// </summary>
        [JsonPropertyName(@"bgcolor")]
        public object BgColor { get; set;} 

        /// <summary>
        ///     Sets the color of the border enclosing the legend.
        /// </summary>
        [JsonPropertyName(@"bordercolor")]
        public object BorderColor { get; set;} 

        /// <summary>
        ///     Sets the width (in px) of the border enclosing the legend.
        /// </summary>
        [JsonPropertyName(@"borderwidth")]
        public decimal? BorderWidth { get; set;} 

        /// <summary>
        ///     Sets the width (in px or fraction) of the legend. Use 0 to size the entry
        ///     based on the text width, when <c>entrywidthmode</c> is set to <c>pixels</c>.
        /// </summary>
        [JsonPropertyName(@"entrywidth")]
        public decimal? EntryWidth { get; set;} 

        /// <summary>
        ///     Determines what entrywidth means.
        /// </summary>
        [JsonPropertyName(@"entrywidthmode")]
        public Plotly.Blazor.LayoutLib.LegendLib.EntryWidthModeEnum? EntryWidthMode { get; set;} 

        /// <summary>
        ///     Sets the font used to text the legend items.
        /// </summary>
        [JsonPropertyName(@"font")]
        public Plotly.Blazor.LayoutLib.LegendLib.Font Font { get; set;} 

        /// <summary>
        ///     Determines the behavior on legend group item click. <c>toggleitem</c> toggles
        ///     the visibility of the individual item clicked on the graph. <c>togglegroup</c>
        ///     toggles the visibility of all items in the same legendgroup as the item
        ///     clicked on the graph.
        /// </summary>
        [JsonPropertyName(@"groupclick")]
        public Plotly.Blazor.LayoutLib.LegendLib.GroupClickEnum? GroupClick { get; set;} 

        /// <summary>
        ///     Sets the font for group titles in legend. Defaults to <c>legend.font</c>
        ///     with its size increased about 10%.
        /// </summary>
        [JsonPropertyName(@"grouptitlefont")]
        public Plotly.Blazor.LayoutLib.LegendLib.GroupTitleFont GroupTitleFont { get; set;} 

        /// <summary>
        ///     Determines the behavior on legend item click. <c>toggle</c> toggles the
        ///     visibility of the item clicked on the graph. <c>toggleothers</c> makes the
        ///     clicked item the sole visible item on the graph. <c>false</c> disables legend
        ///     item click interactions.
        /// </summary>
        [JsonPropertyName(@"itemclick")]
        public Plotly.Blazor.LayoutLib.LegendLib.ItemClickEnum? ItemClick { get; set;} 

        /// <summary>
        ///     Determines the behavior on legend item double-click. <c>toggle</c> toggles
        ///     the visibility of the item clicked on the graph. <c>toggleothers</c> makes
        ///     the clicked item the sole visible item on the graph. <c>false</c> disables
        ///     legend item double-click interactions.
        /// </summary>
        [JsonPropertyName(@"itemdoubleclick")]
        public Plotly.Blazor.LayoutLib.LegendLib.ItemDoubleClickEnum? ItemDoubleClick { get; set;} 

        /// <summary>
        ///     Determines if the legend items symbols scale with their corresponding <c>trace</c>
        ///     attributes or remain <c>constant</c> independent of the symbol size on the
        ///     graph.
        /// </summary>
        [JsonPropertyName(@"itemsizing")]
        public Plotly.Blazor.LayoutLib.LegendLib.ItemSizingEnum? ItemSizing { get; set;} 

        /// <summary>
        ///     Sets the width (in px) of the legend item symbols (the part other than the
        ///     title.text).
        /// </summary>
        [JsonPropertyName(@"itemwidth")]
        public decimal? ItemWidth { get; set;} 

        /// <summary>
        ///     Sets the orientation of the legend.
        /// </summary>
        [JsonPropertyName(@"orientation")]
        public Plotly.Blazor.LayoutLib.LegendLib.OrientationEnum? Orientation { get; set;} 

        /// <summary>
        ///     Gets or sets the Title.
        /// </summary>
        [JsonPropertyName(@"title")]
        public Plotly.Blazor.LayoutLib.LegendLib.Title Title { get; set;} 

        /// <summary>
        ///     Sets the amount of vertical space (in px) between legend groups.
        /// </summary>
        [JsonPropertyName(@"tracegroupgap")]
        public decimal? TraceGroupGap { get; set;} 

        /// <summary>
        ///     Determines the order at which the legend items are displayed. If <c>normal</c>,
        ///     the items are displayed top-to-bottom in the same order as the input data.
        ///     If <c>reversed</c>, the items are displayed in the opposite order as <c>normal</c>.
        ///     If <c>grouped</c>, the items are displayed in groups (when a trace <c>legendgroup</c>
        ///     is provided). if <c>grouped+reversed</c>, the items are displayed in the
        ///     opposite order as <c>grouped</c>.
        /// </summary>
        [JsonPropertyName(@"traceorder")]
        public Plotly.Blazor.LayoutLib.LegendLib.TraceOrderFlag? TraceOrder { get; set;} 

        /// <summary>
        ///     Controls persistence of legend-driven changes in trace and pie label visibility.
        ///     Defaults to <c>layout.uirevision</c>.
        /// </summary>
        [JsonPropertyName(@"uirevision")]
        public object UiRevision { get; set;} 

        /// <summary>
        ///     Sets the vertical alignment of the symbols with respect to their associated
        ///     text.
        /// </summary>
        [JsonPropertyName(@"valign")]
        public Plotly.Blazor.LayoutLib.LegendLib.VAlignEnum? VAlign { get; set;} 

        /// <summary>
        ///     Sets the x position (in normalized coordinates) of the legend. Defaults
        ///     to <c>1.02</c> for vertical legends and defaults to <c>0</c> for horizontal
        ///     legends.
        /// </summary>
        [JsonPropertyName(@"x")]
        public decimal? X { get; set;} 

        /// <summary>
        ///     Sets the legend&#39;s horizontal position anchor. This anchor binds the
        ///     <c>x</c> position to the <c>left</c>, <c>center</c> or <c>right</c> of the
        ///     legend. Value <c>auto</c> anchors legends to the right for <c>x</c> values
        ///     greater than or equal to 2/3, anchors legends to the left for <c>x</c> values
        ///     less than or equal to 1/3 and anchors legends with respect to their center
        ///     otherwise.
        /// </summary>
        [JsonPropertyName(@"xanchor")]
        public Plotly.Blazor.LayoutLib.LegendLib.XAnchorEnum? XAnchor { get; set;} 

        /// <summary>
        ///     Sets the y position (in normalized coordinates) of the legend. Defaults
        ///     to <c>1</c> for vertical legends, defaults to <c>-0.1</c> for horizontal
        ///     legends on graphs w/o range sliders and defaults to <c>1.1</c> for horizontal
        ///     legends on graph with one or multiple range sliders.
        /// </summary>
        [JsonPropertyName(@"y")]
        public decimal? Y { get; set;} 

        /// <summary>
        ///     Sets the legend&#39;s vertical position anchor This anchor binds the <c>y</c>
        ///     position to the <c>top</c>, <c>middle</c> or <c>bottom</c> of the legend.
        ///     Value <c>auto</c> anchors legends at their bottom for <c>y</c> values less
        ///     than or equal to 1/3, anchors legends to at their top for <c>y</c> values
        ///     greater than or equal to 2/3 and anchors legends with respect to their middle
        ///     otherwise.
        /// </summary>
        [JsonPropertyName(@"yanchor")]
        public Plotly.Blazor.LayoutLib.LegendLib.YAnchorEnum? YAnchor { get; set;} 

        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            if (!(obj is Legend other)) return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        /// <inheritdoc />
        public bool Equals([AllowNull] Legend other)
        {
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    BgColor == other.BgColor ||
                    BgColor != null &&
                    BgColor.Equals(other.BgColor)
                ) && 
                (
                    BorderColor == other.BorderColor ||
                    BorderColor != null &&
                    BorderColor.Equals(other.BorderColor)
                ) && 
                (
                    BorderWidth == other.BorderWidth ||
                    BorderWidth != null &&
                    BorderWidth.Equals(other.BorderWidth)
                ) && 
                (
                    EntryWidth == other.EntryWidth ||
                    EntryWidth != null &&
                    EntryWidth.Equals(other.EntryWidth)
                ) && 
                (
                    EntryWidthMode == other.EntryWidthMode ||
                    EntryWidthMode != null &&
                    EntryWidthMode.Equals(other.EntryWidthMode)
                ) && 
                (
                    Font == other.Font ||
                    Font != null &&
                    Font.Equals(other.Font)
                ) && 
                (
                    GroupClick == other.GroupClick ||
                    GroupClick != null &&
                    GroupClick.Equals(other.GroupClick)
                ) && 
                (
                    GroupTitleFont == other.GroupTitleFont ||
                    GroupTitleFont != null &&
                    GroupTitleFont.Equals(other.GroupTitleFont)
                ) && 
                (
                    ItemClick == other.ItemClick ||
                    ItemClick != null &&
                    ItemClick.Equals(other.ItemClick)
                ) && 
                (
                    ItemDoubleClick == other.ItemDoubleClick ||
                    ItemDoubleClick != null &&
                    ItemDoubleClick.Equals(other.ItemDoubleClick)
                ) && 
                (
                    ItemSizing == other.ItemSizing ||
                    ItemSizing != null &&
                    ItemSizing.Equals(other.ItemSizing)
                ) && 
                (
                    ItemWidth == other.ItemWidth ||
                    ItemWidth != null &&
                    ItemWidth.Equals(other.ItemWidth)
                ) && 
                (
                    Orientation == other.Orientation ||
                    Orientation != null &&
                    Orientation.Equals(other.Orientation)
                ) && 
                (
                    Title == other.Title ||
                    Title != null &&
                    Title.Equals(other.Title)
                ) && 
                (
                    TraceGroupGap == other.TraceGroupGap ||
                    TraceGroupGap != null &&
                    TraceGroupGap.Equals(other.TraceGroupGap)
                ) && 
                (
                    TraceOrder == other.TraceOrder ||
                    TraceOrder != null &&
                    TraceOrder.Equals(other.TraceOrder)
                ) && 
                (
                    UiRevision == other.UiRevision ||
                    UiRevision != null &&
                    UiRevision.Equals(other.UiRevision)
                ) && 
                (
                    VAlign == other.VAlign ||
                    VAlign != null &&
                    VAlign.Equals(other.VAlign)
                ) && 
                (
                    X == other.X ||
                    X != null &&
                    X.Equals(other.X)
                ) && 
                (
                    XAnchor == other.XAnchor ||
                    XAnchor != null &&
                    XAnchor.Equals(other.XAnchor)
                ) && 
                (
                    Y == other.Y ||
                    Y != null &&
                    Y.Equals(other.Y)
                ) && 
                (
                    YAnchor == other.YAnchor ||
                    YAnchor != null &&
                    YAnchor.Equals(other.YAnchor)
                );
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (BgColor != null) hashCode = hashCode * 59 + BgColor.GetHashCode();
                if (BorderColor != null) hashCode = hashCode * 59 + BorderColor.GetHashCode();
                if (BorderWidth != null) hashCode = hashCode * 59 + BorderWidth.GetHashCode();
                if (EntryWidth != null) hashCode = hashCode * 59 + EntryWidth.GetHashCode();
                if (EntryWidthMode != null) hashCode = hashCode * 59 + EntryWidthMode.GetHashCode();
                if (Font != null) hashCode = hashCode * 59 + Font.GetHashCode();
                if (GroupClick != null) hashCode = hashCode * 59 + GroupClick.GetHashCode();
                if (GroupTitleFont != null) hashCode = hashCode * 59 + GroupTitleFont.GetHashCode();
                if (ItemClick != null) hashCode = hashCode * 59 + ItemClick.GetHashCode();
                if (ItemDoubleClick != null) hashCode = hashCode * 59 + ItemDoubleClick.GetHashCode();
                if (ItemSizing != null) hashCode = hashCode * 59 + ItemSizing.GetHashCode();
                if (ItemWidth != null) hashCode = hashCode * 59 + ItemWidth.GetHashCode();
                if (Orientation != null) hashCode = hashCode * 59 + Orientation.GetHashCode();
                if (Title != null) hashCode = hashCode * 59 + Title.GetHashCode();
                if (TraceGroupGap != null) hashCode = hashCode * 59 + TraceGroupGap.GetHashCode();
                if (TraceOrder != null) hashCode = hashCode * 59 + TraceOrder.GetHashCode();
                if (UiRevision != null) hashCode = hashCode * 59 + UiRevision.GetHashCode();
                if (VAlign != null) hashCode = hashCode * 59 + VAlign.GetHashCode();
                if (X != null) hashCode = hashCode * 59 + X.GetHashCode();
                if (XAnchor != null) hashCode = hashCode * 59 + XAnchor.GetHashCode();
                if (Y != null) hashCode = hashCode * 59 + Y.GetHashCode();
                if (YAnchor != null) hashCode = hashCode * 59 + YAnchor.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left Legend and the right Legend.
        /// </summary>
        /// <param name="left">Left Legend.</param>
        /// <param name="right">Right Legend.</param>
        /// <returns>Boolean</returns>
        public static bool operator == (Legend left, Legend right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left Legend and the right Legend.
        /// </summary>
        /// <param name="left">Left Legend.</param>
        /// <param name="right">Right Legend.</param>
        /// <returns>Boolean</returns>
        public static bool operator != (Legend left, Legend right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>Legend</returns>
        public Legend DeepClone()
        {
            return this.Copy();
        }
    }
}
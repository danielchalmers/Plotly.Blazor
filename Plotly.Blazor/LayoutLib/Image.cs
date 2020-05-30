/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Collections.Generic;
using Plotly.Blazor.LayoutLib.ImageLib;

namespace Plotly.Blazor.LayoutLib
{
    /// <summary>
    ///     The Image class.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    public class Image 
    {
        /// <summary>
        ///     Determines whether or not this image is visible.
        /// </summary>
        [JsonPropertyName(@"visible")]
        public bool? Visible { get; set;} 

        /// <summary>
        ///     Specifies the URL of the image to be used. The URL must be accessible from
        ///     the domain where the plot code is run, and can be either relative or absolute.
        /// </summary>
        [JsonPropertyName(@"source")]
        public string Source { get; set;} 

        /// <summary>
        ///     Specifies whether images are drawn below or above traces. When `xref` and
        ///     `yref` are both set to `paper`, image is drawn below the entire plot area.
        /// </summary>
        [JsonPropertyName(@"layer")]
        public LayerEnum? Layer { get; set;} 

        /// <summary>
        ///     Sets the image container size horizontally. The image will be sized based
        ///     on the `position` value. When `xref` is set to `paper`, units are sized
        ///     relative to the plot width.
        /// </summary>
        [JsonPropertyName(@"sizex")]
        public float? SizeX { get; set;} 

        /// <summary>
        ///     Sets the image container size vertically. The image will be sized based
        ///     on the `position` value. When `yref` is set to `paper`, units are sized
        ///     relative to the plot height.
        /// </summary>
        [JsonPropertyName(@"sizey")]
        public float? SizeY { get; set;} 

        /// <summary>
        ///     Specifies which dimension of the image to constrain.
        /// </summary>
        [JsonPropertyName(@"sizing")]
        public SizingEnum? Sizing { get; set;} 

        /// <summary>
        ///     Sets the opacity of the image.
        /// </summary>
        [JsonPropertyName(@"opacity")]
        public float? Opacity { get; set;} 

        /// <summary>
        ///     Sets the image's x position. When `xref` is set to `paper`, units are sized
        ///     relative to the plot height. See `xref` for more info
        /// </summary>
        [JsonPropertyName(@"x")]
        public object X { get; set;} 

        /// <summary>
        ///     Sets the image's y position. When `yref` is set to `paper`, units are sized
        ///     relative to the plot height. See `yref` for more info
        /// </summary>
        [JsonPropertyName(@"y")]
        public object Y { get; set;} 

        /// <summary>
        ///     Sets the anchor for the x position
        /// </summary>
        [JsonPropertyName(@"xanchor")]
        public XAnchorEnum? XAnchor { get; set;} 

        /// <summary>
        ///     Sets the anchor for the y position.
        /// </summary>
        [JsonPropertyName(@"yanchor")]
        public YAnchorEnum? YAnchor { get; set;} 

        /// <summary>
        ///     Sets the images's x coordinate axis. If set to a x axis id (e.g. *x* or
        ///     *x2*), the `x` position refers to an x data coordinate If set to *paper*,
        ///     the `x` position refers to the distance from the left of plot in normalized
        ///     coordinates where *0* (*1*) corresponds to the left (right).
        /// </summary>
        [JsonPropertyName(@"xref")]
        public string Xref { get; set;} 

        /// <summary>
        ///     Sets the images's y coordinate axis. If set to a y axis id (e.g. *y* or
        ///     *y2*), the `y` position refers to a y data coordinate. If set to *paper*,
        ///     the `y` position refers to the distance from the bottom of the plot in normalized
        ///     coordinates where *0* (*1*) corresponds to the bottom (top).
        /// </summary>
        [JsonPropertyName(@"yref")]
        public string YRef { get; set;} 

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
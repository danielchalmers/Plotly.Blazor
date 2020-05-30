/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Runtime.Serialization;

namespace Plotly.Blazor.LayoutLib.MapBoxLib.LayerLib.SymbolLib
{
    /// <summary>
    ///     Sets the symbol and/or text placement (mapbox.layer.layout.symbol-placement).
    ///     If `placement` is *point*, the label is placed where the geometry is located
    ///     If `placement` is *line*, the label is placed along the line of the geometry
    ///     If `placement` is *line-center*, the label is placed on the center of the
    ///     geometry
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    [JsonConverter(typeof(EnumConverter))]
    public enum PlacementEnum
    {
        [EnumMember(Value=@"point")]
        Point = 0,
        [EnumMember(Value=@"line")]
        Line,
        [EnumMember(Value=@"line-center")]
        LineCenter
    }
}
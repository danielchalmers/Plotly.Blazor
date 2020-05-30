/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Runtime.Serialization;

namespace Plotly.Blazor.Traces.ScatterLib
{
    /// <summary>
    ///     Sets the area to fill with a solid color. Defaults to *none* unless this
    ///     trace is stacked, then it gets *tonexty* (*tonextx*) if `orientation` is
    ///     *v* (*h*) Use with `fillcolor` if not *none*. *tozerox* and *tozeroy* fill
    ///     to x=0 and y=0 respectively. *tonextx* and *tonexty* fill between the endpoints
    ///     of this trace and the endpoints of the trace before it, connecting those
    ///     endpoints with straight lines (to make a stacked area graph); if there is
    ///     no trace before it, they behave like *tozerox* and *tozeroy*. *toself* connects
    ///     the endpoints of the trace (or each segment of the trace if it has gaps)
    ///     into a closed shape. *tonext* fills the space between two traces if one
    ///     completely encloses the other (eg consecutive contour lines), and behaves
    ///     like *toself* if there is no trace before it. *tonext* should not be used
    ///     if one trace does not enclose the other. Traces in a `stackgroup` will only
    ///     fill to (or be filled to) other traces in the same group. With multiple
    ///     `stackgroup`s or some traces stacked and some not, if fill-linked traces
    ///     are not already consecutive, the later ones will be pushed down in the drawing
    ///     order.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    [JsonConverter(typeof(EnumConverter))]
    public enum FillEnum
    {
        [EnumMember(Value=@"none")]
        None,
        [EnumMember(Value=@"tozeroy")]
        ToZeroY,
        [EnumMember(Value=@"tozerox")]
        ToZeroX,
        [EnumMember(Value=@"tonexty")]
        ToNextY,
        [EnumMember(Value=@"tonextx")]
        ToNextX,
        [EnumMember(Value=@"toself")]
        ToSelf,
        [EnumMember(Value=@"tonext")]
        ToNext
    }
}
/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Runtime.Serialization;

namespace Plotly.Blazor.Traces.ScatterPolarGlLib.MarkerLib
{
    /// <summary>
    ///     Has an effect only if `marker.size` is set to a numerical array. Sets the
    ///     rule for which the data in `size` is converted to pixels.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    [JsonConverter(typeof(EnumConverter))]
    public enum SizeModeEnum
    {
        [EnumMember(Value=@"diameter")]
        Diameter = 0,
        [EnumMember(Value=@"area")]
        Area
    }
}
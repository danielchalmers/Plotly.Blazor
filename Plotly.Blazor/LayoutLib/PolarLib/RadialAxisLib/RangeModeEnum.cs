/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Runtime.Serialization;

namespace Plotly.Blazor.LayoutLib.PolarLib.RadialAxisLib
{
    /// <summary>
    ///     If *tozero*`, the range extends to 0, regardless of the input data If *nonnegative*,
    ///     the range is non-negative, regardless of the input data. If *normal*, the
    ///     range is computed in relation to the extrema of the input data (same behavior
    ///     as for cartesian axes).
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    [JsonConverter(typeof(EnumConverter))]
    public enum RangeModeEnum
    {
        [EnumMember(Value=@"tozero")]
        ToZero = 0,
        [EnumMember(Value=@"nonnegative")]
        NonNegative,
        [EnumMember(Value=@"normal")]
        Normal
    }
}
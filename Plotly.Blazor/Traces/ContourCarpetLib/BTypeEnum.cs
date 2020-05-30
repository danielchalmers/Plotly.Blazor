/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Runtime.Serialization;

namespace Plotly.Blazor.Traces.ContourCarpetLib
{
    /// <summary>
    ///     If *array*, the heatmap&#39;s y coordinates are given by *y* (the default
    ///     behavior when `y` is provided) If *scaled*, the heatmap&#39;s y coordinates
    ///     are given by *y0* and *dy* (the default behavior when `y` is not provided)
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    [JsonConverter(typeof(EnumConverter))]
    public enum BTypeEnum
    {
        [EnumMember(Value=@"array")]
        Array,
        [EnumMember(Value=@"scaled")]
        Scaled
    }
}
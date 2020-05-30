/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Runtime.Serialization;

namespace Plotly.Blazor.Traces.ContourLib
{
    /// <summary>
    ///     If *array*, the heatmap&#39;s x coordinates are given by *x* (the default
    ///     behavior when `x` is provided). If *scaled*, the heatmap&#39;s x coordinates
    ///     are given by *x0* and *dx* (the default behavior when `x` is not provided).
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    [JsonConverter(typeof(EnumConverter))]
    public enum XTypeEnum
    {
        [EnumMember(Value=@"array")]
        Array,
        [EnumMember(Value=@"scaled")]
        Scaled
    }
}
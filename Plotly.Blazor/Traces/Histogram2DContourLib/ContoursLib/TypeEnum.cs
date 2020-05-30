/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Runtime.Serialization;

namespace Plotly.Blazor.Traces.Histogram2DContourLib.ContoursLib
{
    /// <summary>
    ///     If `levels`, the data is represented as a contour plot with multiple levels
    ///     displayed. If `constraint`, the data is represented as constraints with
    ///     the invalid region shaded as specified by the `operation` and `value` parameters.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    [JsonConverter(typeof(EnumConverter))]
    public enum TypeEnum
    {
        [EnumMember(Value=@"levels")]
        Levels = 0,
        [EnumMember(Value=@"constraint")]
        Constraint
    }
}
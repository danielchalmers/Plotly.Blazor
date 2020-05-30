/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Runtime.Serialization;

namespace Plotly.Blazor.Traces.Histogram2DContourLib
{
    /// <summary>
    ///     Specifies the type of normalization used for this histogram trace. If **,
    ///     the span of each bar corresponds to the number of occurrences (i.e. the
    ///     number of data points lying inside the bins). If *percent* / *probability*,
    ///     the span of each bar corresponds to the percentage / fraction of occurrences
    ///     with respect to the total number of sample points (here, the sum of all
    ///     bin HEIGHTS equals 100% / 1). If *density*, the span of each bar corresponds
    ///     to the number of occurrences in a bin divided by the size of the bin interval
    ///     (here, the sum of all bin AREAS equals the total number of sample points).
    ///     If *probability density*, the area of each bar corresponds to the probability
    ///     that an event will fall into the corresponding bin (here, the sum of all
    ///     bin AREAS equals 1).
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    [JsonConverter(typeof(EnumConverter))]
    public enum HistNormEnum
    {
        [EnumMember(Value=@"")]
        Empty = 0,
        [EnumMember(Value=@"percent")]
        Percent,
        [EnumMember(Value=@"probability")]
        Probability,
        [EnumMember(Value=@"density")]
        Density,
        [EnumMember(Value=@"probability density")]
        ProbabilityDensity
    }
}
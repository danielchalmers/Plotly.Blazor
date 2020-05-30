/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Collections.Generic;
using Plotly.Blazor.Transforms.AggregateLib;

namespace Plotly.Blazor.Transforms
{
    /// <summary>
    ///     The Aggregate class.
    ///     Implements the <see cref="ITransform" />
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    public class Aggregate : ITransform
    {
        /// <inheritdoc/>
        [JsonPropertyName(@"type")]
        public TransformTypeEnum Type { get; } = TransformTypeEnum.Aggregate;

        /// <summary>
        ///     Determines whether this aggregate transform is enabled or disabled.
        /// </summary>
        [JsonPropertyName(@"enabled")]
        public bool? Enabled { get; set;} 

        /// <summary>
        ///     Sets the grouping target to which the aggregation is applied. Data points
        ///     with matching group values will be coalesced into one point, using the supplied
        ///     aggregation functions to reduce data in other data arrays. If a string,
        ///     `groups` is assumed to be a reference to a data array in the parent trace
        ///     object. To aggregate by nested variables, use *.* to access them. For example,
        ///     set `groups` to *marker.color* to aggregate about the marker color array.
        ///     If an array, `groups` is itself the data array by which we aggregate.
        /// </summary>
        [JsonPropertyName(@"groups")]
        public string Groups { get; set;} 

        /// <summary>
        ///     Gets or sets the Aggregations.
        /// </summary>
        [JsonPropertyName(@"aggregations")]
        public IList<Aggregation> Aggregations { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  groups .
        /// </summary>
        [JsonPropertyName(@"groupssrc")]
        public string GroupsSrc { get; set;} 

    }
}
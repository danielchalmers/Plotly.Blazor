/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Runtime.Serialization;

namespace Plotly.Blazor.LayoutLib.XAxisLib
{
    /// <summary>
    ///     Determines where ticks and grid lines are drawn with respect to their corresponding
    ///     tick labels. Only has an effect for axes of `type` *category* or *multicategory*.
    ///     When set to *boundaries*, ticks and grid lines are drawn half a category
    ///     to the left/bottom of labels.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    [JsonConverter(typeof(EnumConverter))]
    public enum TickSonEnum
    {
        [EnumMember(Value=@"labels")]
        Labels = 0,
        [EnumMember(Value=@"boundaries")]
        Boundaries
    }
}
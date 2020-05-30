/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Runtime.Serialization;

namespace Plotly.Blazor.LayoutLib.LegendLib
{
    /// <summary>
    ///     Determines the behavior on legend item click. *toggle* toggles the visibility
    ///     of the item clicked on the graph. *toggleothers* makes the clicked item
    ///     the sole visible item on the graph. *false* disable legend item click interactions.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    [JsonConverter(typeof(EnumConverter))]
    public enum ItemClickEnum
    {
        [EnumMember(Value=@"toggle")]
        Toggle = 0,
        [EnumMember(Value=@"toggleothers")]
        ToggleOthers,
        [EnumMember(Value=@"False")]
        False
    }
}
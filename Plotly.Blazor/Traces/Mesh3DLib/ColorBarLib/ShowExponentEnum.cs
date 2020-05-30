/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Runtime.Serialization;

namespace Plotly.Blazor.Traces.Mesh3DLib.ColorBarLib
{
    /// <summary>
    ///     If *all*, all exponents are shown besides their significands. If *first*,
    ///     only the exponent of the first tick is shown. If *last*, only the exponent
    ///     of the last tick is shown. If *none*, no exponents appear.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    [JsonConverter(typeof(EnumConverter))]
    public enum ShowExponentEnum
    {
        [EnumMember(Value=@"all")]
        All = 0,
        [EnumMember(Value=@"first")]
        First,
        [EnumMember(Value=@"last")]
        Last,
        [EnumMember(Value=@"none")]
        None
    }
}
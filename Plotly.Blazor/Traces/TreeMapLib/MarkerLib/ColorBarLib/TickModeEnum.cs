/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Runtime.Serialization;

namespace Plotly.Blazor.Traces.TreeMapLib.MarkerLib.ColorBarLib
{
    /// <summary>
    ///     Sets the tick mode for this axis. If *auto*, the number of ticks is set
    ///     via `nticks`. If *linear*, the placement of the ticks is determined by a
    ///     starting position `tick0` and a tick step `dtick` (*linear* is the default
    ///     value if `tick0` and `dtick` are provided). If *array*, the placement of
    ///     the ticks is set via `tickvals` and the tick text is `ticktext`. (*array*
    ///     is the default value if `tickvals` is provided).
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    [JsonConverter(typeof(EnumConverter))]
    public enum TickModeEnum
    {
        [EnumMember(Value=@"auto")]
        Auto,
        [EnumMember(Value=@"linear")]
        Linear,
        [EnumMember(Value=@"array")]
        Array
    }
}
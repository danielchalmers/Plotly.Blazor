/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Collections.Generic;
using Plotly.Blazor.LayoutLib.UpdateMenuLib.ButtonLib;

namespace Plotly.Blazor.LayoutLib.UpdateMenuLib
{
    /// <summary>
    ///     The Button class.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    public class Button 
    {
        /// <summary>
        ///     Determines whether or not this button is visible.
        /// </summary>
        [JsonPropertyName(@"visible")]
        public bool? Visible { get; set;} 

        /// <summary>
        ///     Sets the Plotly method to be called on click. If the `skip` method is used,
        ///     the API updatemenu will function as normal but will perform no API calls
        ///     and will not bind automatically to state updates. This may be used to create
        ///     a component interface and attach to updatemenu events manually via JavaScript.
        /// </summary>
        [JsonPropertyName(@"method")]
        public MethodEnum? Method { get; set;} 

        /// <summary>
        ///     Sets the arguments values to be passed to the Plotly method set in `method`
        ///     on click.
        /// </summary>
        [JsonPropertyName(@"args")]
        public IList<object> Args { get; set;} 

        /// <summary>
        ///     Sets a 2nd set of `args`, these arguments values are passed to the Plotly
        ///     method set in `method` when clicking this button while in the active state.
        ///     Use this to create toggle buttons.
        /// </summary>
        [JsonPropertyName(@"args2")]
        public IList<object> Args2 { get; set;} 

        /// <summary>
        ///     Sets the text label to appear on the button.
        /// </summary>
        [JsonPropertyName(@"label")]
        public string Label { get; set;} 

        /// <summary>
        ///     When true, the API method is executed. When false, all other behaviors are
        ///     the same and command execution is skipped. This may be useful when hooking
        ///     into, for example, the `plotly_buttonclicked` method and executing the API
        ///     command manually without losing the benefit of the updatemenu automatically
        ///     binding to the state of the plot through the specification of `method` and
        ///     `args`.
        /// </summary>
        [JsonPropertyName(@"execute")]
        public bool? Execute { get; set;} 

        /// <summary>
        ///     When used in a template, named items are created in the output figure in
        ///     addition to any items the figure already has in this array. You can modify
        ///     these items in the output figure by making your own item with `templateitemname`
        ///     matching this `name` alongside your modifications (including `visible: false`
        ///     or `enabled: false` to hide it). Has no effect outside of a template.
        /// </summary>
        [JsonPropertyName(@"name")]
        public string Name { get; set;} 

        /// <summary>
        ///     Used to refer to a named item in this array in the template. Named items
        ///     from the template will be created even without a matching item in the input
        ///     figure, but you can modify one by making an item with `templateitemname`
        ///     matching its `name`, alongside your modifications (including `visible: false`
        ///     or `enabled: false` to hide it). If there is no template or no matching
        ///     item, this item will be hidden unless you explicitly show it with `visible:
        ///     true`.
        /// </summary>
        [JsonPropertyName(@"templateitemname")]
        public string TemplateItemName { get; set;} 

    }
}
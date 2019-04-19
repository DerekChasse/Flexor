// <copyright file="FlexorJSInterop.cs" company="Derek Chasse">
// Copyright (c) Derek Chasse. All rights reserved.
// </copyright>

using System.Threading.Tasks;
using Microsoft.JSInterop;

namespace Flexor
{
    /// <summary>
    /// Javascript interop interface.
    /// </summary>
    public interface IFlexorJSInterop
    {
        /// <summary>
        /// Adds new CSS classes dynamically to the page.
        /// </summary>
        /// <param name="className">The name of the CSS class to add.</param>
        /// <param name="classCSS">The CSS class to add to the page.</param>
        Task AddDynamicStyle(string className, string classCSS);

        /// <summary>
        /// Decorates a div's child element with CSS classes.
        /// </summary>
        /// <param name="parentDivId">The identifier of the parent div.</param>
        /// <param name="classes">The CSS classes to apply the the child element.</param>
        Task DecorateChild(string parentDivId, string classes);

        /// <summary>
        /// Unwraps a div, removing it from the DOM and promoting its child in its place.
        /// </summary>
        /// <param name="divId">The id of the div element.</param>
        Task UnwrapDiv(string divId);
    }

    /// <summary>
    /// Javascript interop implementation.
    /// </summary>
    public class FlexorJSInterop : IFlexorJSInterop
    {
        private readonly IJSRuntime runtime;

        /// <summary>
        /// Initializes a new instance of the <see cref="FlexorJSInterop"/> class.
        /// </summary>
        /// <param name="runtime">The registered javascript runtime.</param>
        public FlexorJSInterop(IJSRuntime runtime)
        {
            this.runtime = runtime;
        }

        /// <inheritdoc/>
        public Task AddDynamicStyle(string className, string classCSS)
        {
            return this.runtime.InvokeAsync<object>("flexor.addDynamicStyle", className, classCSS);
        }

        /// <inheritdoc/>
        public Task DecorateChild(string parentDivId, string classes)
        {
            return this.runtime.InvokeAsync<object>("flexor.decorateChild", parentDivId, classes);
        }

        /// <inheritdoc/>
        public Task UnwrapDiv(string divId)
        {
            return this.runtime.InvokeAsync<object>("flexor.unwrapDiv", divId);
        }
    }
}

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
    }
}

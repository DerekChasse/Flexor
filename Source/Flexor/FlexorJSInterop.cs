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
        /// <param name="rawCSS">The CSS classes to add to the page.</param>
        Task AddDynamicStyle(string rawCSS);
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
        public Task AddDynamicStyle(string rawCSS)
        {
            return this.runtime.InvokeAsync<object>("flexor.addDynamicStyle", rawCSS);
        }
    }
}

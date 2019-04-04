// <copyright file="Resizability.cs" company="Derek Chasse">
// Copyright (c) Derek Chasse. All rights reserved.
// </copyright>

namespace Flexor
{
    /// <summary>
    /// Defines how flex items react to the resizing of a flex-container.
    /// </summary>
    public static class Resizability
    {
        /// <summary>
        /// Flex item is allowed to grow as there is space available.
        /// Item resizing ability is applied consistently across all CSS media query breakpoints.
        /// </summary>
        public static IFluentResizability Grow => new FluentResizability(ResizabilityValue.Grow);

        /// <summary>
        /// Flex item is allowed to resize automatically as there is space available.
        /// Item resizing ability is applied consistently across all CSS media query breakpoints.
        /// </summary>
        public static IFluentResizability Auto => new FluentResizability(ResizabilityValue.Auto);

        /// <summary>
        /// Flex item is not allowed to grow but can shrink if necessary.
        /// Item resizing ability is applied consistently across all CSS media query breakpoints.
        /// </summary>
        public static IFluentResizability NoGrow => new FluentResizability(ResizabilityValue.NoGrow);

        /// <summary>
        /// Flex item is not allowed to shrink but can grow if necessary.
        /// Item resizing ability is applied consistently across all CSS media query breakpoints.
        /// </summary>
        public static IFluentResizability NoShrink => new FluentResizability(ResizabilityValue.NoShrink);

        /// <summary>
        /// Flex item is not allowed to grow or shrink and will retain its initial size.
        /// Item resizing ability is applied consistently across all CSS media query breakpoints.
        /// </summary>
        public static IFluentResizability Initial => new FluentResizability(ResizabilityValue.None);

        /// <summary>
        /// Flex item is sized by default according to the supplied resizability value.
        /// Rendering is configurable based on CSS media query breakpoints.
        /// </summary>
        /// <param name="value">The default resizability value.</param>
        /// <returns>The resizability configuration.</returns>
        public static IFluentResizabilityWithValueOnBreakpoint Is(ResizabilityValue value) => new FluentResizability(value);
    }
}

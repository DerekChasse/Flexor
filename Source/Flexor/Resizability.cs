// <copyright file="Resizability.cs" company="Derek Chasse">
// Copyright (c) Derek Chasse. All rights reserved.
// </copyright>

namespace Flexor
{
    /// <summary>
    /// Defines how flex-items react to the resizing of a flex-line.
    /// </summary>
    public static class Resizability
    {
        /// <summary>
        /// Flex-item resizability is unset.
        /// Item resizing ability is applied consistently across all CSS media query breakpoints.
        /// </summary>
        public static IResizability Default => new FluentResizability(ResizabilityOption.Default);

        /// <summary>
        /// Flex-item is allowed to grow as there is space available.
        /// Item resizing ability is applied consistently across all CSS media query breakpoints.
        /// </summary>
        public static IResizability Grow => new FluentResizability(ResizabilityOption.Grow);

        /// <summary>
        /// Flex-item is allowed to resize automatically as there is space available.
        /// Item resizing ability is applied consistently across all CSS media query breakpoints.
        /// </summary>
        public static IResizability Auto => new FluentResizability(ResizabilityOption.Auto);

        /// <summary>
        /// Flex-item is not allowed to grow but can shrink if necessary.
        /// Item resizing ability is applied consistently across all CSS media query breakpoints.
        /// </summary>
        public static IResizability NoGrow => new FluentResizability(ResizabilityOption.NoGrow);

        /// <summary>
        /// Flex-item is not allowed to shrink but can grow if necessary.
        /// Item resizing ability is applied consistently across all CSS media query breakpoints.
        /// </summary>
        public static IResizability NoShrink => new FluentResizability(ResizabilityOption.NoShrink);

        /// <summary>
        /// Flex-item is not allowed to grow or shrink and will retain its initial size.
        /// Item resizing ability is applied consistently across all CSS media query breakpoints.
        /// </summary>
        public static IResizability Initial => new FluentResizability(ResizabilityOption.Initial);

        /// <summary>
        /// Flex-item will not resize.
        /// Item resizing ability is applied consistently across all CSS media query breakpoints.
        /// </summary>
        public static IResizability None => new FluentResizability(ResizabilityOption.None);

        /// <summary>
        /// Flex-item will fill all available vertical and horizontal space within its flex-line.
        /// Item resizing ability is applied consistently across all CSS media query breakpoints.
        /// </summary>
        public static IResizability Fill => new FluentResizability(ResizabilityOption.Fill);

        /// <summary>
        /// Flex-item will be rendered and configured with the supplied resizability value.
        /// Rendering is configurable based on CSS media query breakpoints.
        /// </summary>
        /// <param name="value">The default resizability value.</param>
        /// <returns>The resizability configuration.</returns>
        public static IFluentResizabilityWithValueOnBreakpoint Is(ResizabilityOption value) => new FluentResizability().Is(value);
    }
}

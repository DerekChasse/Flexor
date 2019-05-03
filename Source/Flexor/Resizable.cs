// <copyright file="Resizable.cs" company="Derek Chasse">
// Copyright (c) Derek Chasse. All rights reserved.
// </copyright>

namespace Flexor
{
    /// <summary>
    /// Defines how flex-items react to the resizing of a flex-line.
    /// </summary>
    public static class Resizable
    {
        /// <summary>
        /// Flex-item ability to resize is unset.
        /// Item resizing ability is applied consistently across all CSS media query breakpoints.
        /// </summary>
        public static IResizable Default => new FluentResizable(ResizableOption.Default);

        /// <summary>
        /// Flex-item is allowed to grow as there is space available.
        /// Item resizing ability is applied consistently across all CSS media query breakpoints.
        /// </summary>
        public static IResizable Grow => new FluentResizable(ResizableOption.Grow);

        /// <summary>
        /// Flex-item is allowed to resize automatically as there is space available.
        /// Item resizing ability is applied consistently across all CSS media query breakpoints.
        /// </summary>
        public static IResizable Auto => new FluentResizable(ResizableOption.Auto);

        /// <summary>
        /// Flex-item is not allowed to grow but can shrink if necessary.
        /// Item resizing ability is applied consistently across all CSS media query breakpoints.
        /// </summary>
        public static IResizable NoGrow => new FluentResizable(ResizableOption.NoGrow);

        /// <summary>
        /// Flex-item is not allowed to shrink but can grow if necessary.
        /// Item resizing ability is applied consistently across all CSS media query breakpoints.
        /// </summary>
        public static IResizable NoShrink => new FluentResizable(ResizableOption.NoShrink);

        /// <summary>
        /// Flex-item is not allowed to grow or shrink and will retain its initial size.
        /// Item resizing ability is applied consistently across all CSS media query breakpoints.
        /// </summary>
        public static IResizable Initial => new FluentResizable(ResizableOption.Initial);

        /// <summary>
        /// Flex-item will not resize.
        /// Item resizing ability is applied consistently across all CSS media query breakpoints.
        /// </summary>
        public static IResizable None => new FluentResizable(ResizableOption.None);

        /// <summary>
        /// Flex-item will fill all available vertical and horizontal space within its flex-line.
        /// Item resizing ability is applied consistently across all CSS media query breakpoints.
        /// </summary>
        public static IResizable Fill => new FluentResizable(ResizableOption.Fill);

        /// <summary>
        /// Flex-item will be rendered and configured with the supplied resizable value.
        /// Rendering is configurable based on CSS media query breakpoints.
        /// </summary>
        /// <returns>The resizable configuration.</returns>
        public static IFluentResizable Is => new FluentResizable();
    }
}

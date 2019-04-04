// <copyright file="SelfAlignment.cs" company="Derek Chasse">
// Copyright (c) Derek Chasse. All rights reserved.
// </copyright>

namespace Flexor
{
    /// <summary>
    /// Defines how an individual flex-item is laid out along the flex-container's cross axis.
    /// </summary>
    public static class SelfAlignment
    {
        /// <summary>
        /// The individual item is aligned along the start of the flex-container's cross axis.
        /// The individual item is rendered this way consistently across all CSS media query breakpoints.
        /// </summary>
        public static IFluentAlignItems Start => new FluentAlignItems(ItemAlignmentValue.Start);

        /// <summary>
        /// The individual item is aligned along the center of the flex-container's cross axis.
        /// The individual item is rendered this way consistently across all CSS media query breakpoints.
        /// </summary>
        public static IFluentAlignItems Center => new FluentAlignItems(ItemAlignmentValue.Center);

        /// <summary>
        /// The individual item is aligned along the end of the flex-container's cross axis.
        /// The individual item is rendered this way consistently across all CSS media query breakpoints.
        /// </summary>
        public static IFluentAlignItems End => new FluentAlignItems(ItemAlignmentValue.End);

        /// <summary>
        /// The individual item is stretched along the entirety of the flex-container's cross axis.
        /// The individual item is rendered this way consistently across all CSS media query breakpoints.
        /// </summary>
        public static IFluentAlignItems Stretch => new FluentAlignItems(ItemAlignmentValue.Stretch);

        /// <summary>
        /// The individual item is aligned as their baseline is aligned.
        /// The individual item is rendered this way consistently across all CSS media query breakpoints.
        /// </summary>
        public static IFluentAlignItems Baseline => new FluentAlignItems(ItemAlignmentValue.Baseline);

        /// <summary>
        /// The individual item is rendered by default according to the supplied item alignment.
        /// Rendering is configurable based on CSS media query breakpoints.
        /// </summary>
        /// <param name="value">The default item alignment.</param>
        /// <returns>The item alignment configuration.</returns>
        public static IFluentAlignItemsWithValueOnBreakpoint Is(ItemAlignmentValue value) => new FluentAlignItems(value);
    }
}

// <copyright file="ItemAlignment.cs" company="Derek Chasse">
// Copyright (c) Derek Chasse. All rights reserved.
// </copyright>

namespace Flexor
{
    /// <summary>
    /// Defines how flex-items are laid out along the flex-container's cross axis.
    /// </summary>
    public static class ItemAlignment
    {
        /// <summary>
        /// Items are aligned along the start of the flex-container's cross axis.
        /// Items are rendered this way consistently across all CSS media query breakpoints.
        /// </summary>
        public static IFluentAlignItems Start => new FluentAlignItems(ItemAlignmentValue.Start);

        /// <summary>
        /// Items are aligned along the center of the flex-container's cross axis.
        /// Items are rendered this way consistently across all CSS media query breakpoints.
        /// </summary>
        public static IFluentAlignItems Center => new FluentAlignItems(ItemAlignmentValue.Center);

        /// <summary>
        /// Items are aligned along the end of the flex-container's cross axis.
        /// Items are rendered this way consistently across all CSS media query breakpoints.
        /// </summary>
        public static IFluentAlignItems End => new FluentAlignItems(ItemAlignmentValue.End);

        /// <summary>
        /// Items are stretched along the entirety of the flex-container's cross axis.
        /// Items are rendered this way consistently across all CSS media query breakpoints.
        /// </summary>
        public static IFluentAlignItems Stretch => new FluentAlignItems(ItemAlignmentValue.Stretch);

        /// <summary>
        /// Items are aligned as their baseline is aligned.
        /// Items are rendered this way consistently across all CSS media query breakpoints.
        /// </summary>
        public static IFluentAlignItems Baseline => new FluentAlignItems(ItemAlignmentValue.Baseline);

        /// <summary>
        /// Flex items are rendered by default according to the supplied item alignment.
        /// Rendering is configurable based on CSS media query breakpoints.
        /// </summary>
        /// <param name="value">The default item alignment.</param>
        /// <returns>The item alignment configuration.</returns>
        public static IFluentAlignItemsWithValueOnBreakpoint Is(ItemAlignmentValue value) => new FluentAlignItems(value);
    }
}

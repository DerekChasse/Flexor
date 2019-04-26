// <copyright file="AlignItems.cs" company="Derek Chasse">
// Copyright (c) Derek Chasse. All rights reserved.
// </copyright>

namespace Flexor
{
    /// <summary>
    /// Defines how flex-items are laid out along the flex-line's cross axis.
    /// </summary>
    public static class AlignItems
    {
        /// <summary>
        /// Items are aligned along the start of the flex-line's cross axis.
        /// Items are rendered this way consistently across all CSS media query breakpoints.
        /// </summary>
        public static IFluentAlignItems Start => new FluentAlignItems(AlignItemsOption.Start);

        /// <summary>
        /// Items are aligned along the center of the flex-line's cross axis.
        /// Items are rendered this way consistently across all CSS media query breakpoints.
        /// </summary>
        public static IFluentAlignItems Center => new FluentAlignItems(AlignItemsOption.Center);

        /// <summary>
        /// Items are aligned along the end of the flex-line's cross axis.
        /// Items are rendered this way consistently across all CSS media query breakpoints.
        /// </summary>
        public static IFluentAlignItems End => new FluentAlignItems(AlignItemsOption.End);

        /// <summary>
        /// Items are stretched along the entirety of the flex-line's cross axis.
        /// Items are rendered this way consistently across all CSS media query breakpoints.
        /// </summary>
        public static IFluentAlignItems Stretch => new FluentAlignItems(AlignItemsOption.Stretch);

        /// <summary>
        /// Items are aligned as their baseline is aligned.
        /// Items are rendered this way consistently across all CSS media query breakpoints.
        /// </summary>
        public static IFluentAlignItems Baseline => new FluentAlignItems(AlignItemsOption.Baseline);

        /// <summary>
        /// Flex-items are rendered using default item alignments.
        /// Rendering is configurable based on CSS media query breakpoints.
        /// </summary>
        /// <returns>The item alignment configuration.</returns>
        public static IFluentAlignItems Is => new FluentAlignItems();
    }
}

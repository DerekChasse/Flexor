// <copyright file="AlignItems.cs" company="Derek Chasse">
// Copyright (c) Derek Chasse. All rights reserved.
// </copyright>

namespace Flexor
{
    /// <summary>
    /// Defines how flex-items are laid out along the flex-container's cross axis.
    /// </summary>
    public static class AlignItems
    {
        /// <summary>
        /// The default alignment of <see cref="ItemAlignment.Stretch"/> for items within a flex-container across all CSS media query breakpoints.
        /// </summary>
        public static IFluentAlignItemsOnBreakpoint Is => new FluentAlignItems();

        /// <summary>
        /// Items are aligned along the start of the flex-container's cross axis.
        /// </summary>
        public static IFluentAlignItemsOnBreakpoint Start => new FluentAlignItems(ItemAlignment.Start);

        /// <summary>
        /// Items are aligned along the center of the flex-container's cross axis.
        /// </summary>
        public static IFluentAlignItemsOnBreakpoint Center => new FluentAlignItems(ItemAlignment.Center);

        /// <summary>
        /// Items are aligned along the end of the flex-container's cross axis.
        /// </summary>
        public static IFluentAlignItemsOnBreakpoint End => new FluentAlignItems(ItemAlignment.End);

        /// <summary>
        /// Items are stretched along the entirety of the flex-container's cross axis.
        /// </summary>
        public static IFluentAlignItemsOnBreakpoint Stretch => new FluentAlignItems(ItemAlignment.Stretch);

        /// <summary>
        /// Items are aligned as their baseline is aligned.
        /// </summary>
        public static IFluentAlignItemsOnBreakpoint Baseline => new FluentAlignItems(ItemAlignment.Baseline);
    }
}

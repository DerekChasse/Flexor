// <copyright file="AlignSelf.cs" company="Derek Chasse">
// Copyright (c) Derek Chasse. All rights reserved.
// </copyright>

namespace Flexor
{
    /// <summary>
    /// Defines how an individual flex-item is laid out along the flex-container's cross axis.
    /// </summary>
    public static class AlignSelf
    {
        /// <summary>
        /// The default alignment of <see cref="ItemAxisAlignment.Stretch"/> for the item within a flex-container across all CSS media query breakpoints.
        /// </summary>
        public static IFluentAlignItemsOnBreakpoint Is => new FluentAlignItems();

        /// <summary>
        /// Item is aligned along the start of the flex-container's cross axis.
        /// </summary>
        public static IFluentAlignItemsOnBreakpoint Start => new FluentAlignItems(ItemAxisAlignment.Start);

        /// <summary>
        /// Item is aligned along the center of the flex-container's cross axis.
        /// </summary>
        public static IFluentAlignItemsOnBreakpoint Center => new FluentAlignItems(ItemAxisAlignment.Center);

        /// <summary>
        /// Item is aligned along the end of the flex-container's cross axis.
        /// </summary>
        public static IFluentAlignItemsOnBreakpoint End => new FluentAlignItems(ItemAxisAlignment.End);

        /// <summary>
        /// Item is stretched along the entirety of the flex-container's cross axis.
        /// </summary>
        public static IFluentAlignItemsOnBreakpoint Stretch => new FluentAlignItems(ItemAxisAlignment.Stretch);

        /// <summary>
        /// Item is aligned as their baseline is aligned.
        /// </summary>
        public static IFluentAlignItemsOnBreakpoint Baseline => new FluentAlignItems(ItemAxisAlignment.Baseline);
    }
}

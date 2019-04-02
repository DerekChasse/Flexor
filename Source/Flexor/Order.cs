// <copyright file="Order.cs" company="Derek Chasse">
// Copyright (c) Derek Chasse. All rights reserved.
// </copyright>

namespace Flexor
{
    /// <summary>
    /// Defines the order in which a flex-item is displayed.
    /// </summary>
    public static class Order
    {
        /// <summary>
        /// The default order of an item within a flex-container across all CSS media query breakpoints.
        /// </summary>
        public static IFluentOrderOnBreakpointWithValue Is => new FluentOrder();

        /// <summary>
        /// A specified order of an item within a flex-container across all CSS media query breakpoints.
        /// </summary>
        /// <param name="value">The order of the item.</param>
        /// <returns>The customized order definition.</returns>
        public static IFluentOrder ForAll(int? value) => new FluentOrder().OnMobileAndLarger(value);
    }
}

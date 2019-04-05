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
        /// The default order configuration of an item within a flex-container across all CSS media query breakpoints.
        /// The default order is unspecified, and will honor the definition as defined within the flex-container.
        /// </summary>
        public static IFluentOrder Default => new FluentOrder();

        /// <summary>
        /// The default order configuration of an item within a flex-container across all CSS media query breakpoints.
        /// </summary>
        /// <param name="value">The order of the item.</param>
        /// <returns>The order configuration.</returns>
        public static IFluentOrderWithValueOnBreakpoint Is(int value) => new FluentOrder(value);
    }
}

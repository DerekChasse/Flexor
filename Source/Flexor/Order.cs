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
        public static IOrder Default => new FluentOrder();

        /// <summary>
        /// Items by default will be index 0 within a flex-container across all CSS media query breakpoints.
        /// </summary>
        /// <returns>The order configuration.</returns>
        public static IFluentOrderWithValueOnBreakpoint Is0 => new FluentOrder(0);

        /// <summary>
        /// Items by default will be index 1 within a flex-container across all CSS media query breakpoints.
        /// </summary>
        /// <returns>The order configuration.</returns>
        public static IFluentOrderWithValueOnBreakpoint Is1 => new FluentOrder(1);

        /// <summary>
        /// Items by default will be index 2 within a flex-container across all CSS media query breakpoints.
        /// </summary>
        /// <returns>The order configuration.</returns>
        public static IFluentOrderWithValueOnBreakpoint Is2 => new FluentOrder(2);

        /// <summary>
        /// Items by default will be index 3 within a flex-container across all CSS media query breakpoints.
        /// </summary>
        /// <returns>The order configuration.</returns>
        public static IFluentOrderWithValueOnBreakpoint Is3 => new FluentOrder(3);

        /// <summary>
        /// Items by default will be index 4 within a flex-container across all CSS media query breakpoints.
        /// </summary>
        /// <returns>The order configuration.</returns>
        public static IFluentOrderWithValueOnBreakpoint Is4 => new FluentOrder(4);

        /// <summary>
        /// Items by default will be index 5 within a flex-container across all CSS media query breakpoints.
        /// </summary>
        /// <returns>The order configuration.</returns>
        public static IFluentOrderWithValueOnBreakpoint Is5 => new FluentOrder(5);

        /// <summary>
        /// Items by default will be index 6 within a flex-container across all CSS media query breakpoints.
        /// </summary>
        /// <returns>The order configuration.</returns>
        public static IFluentOrderWithValueOnBreakpoint Is6 => new FluentOrder(6);

        /// <summary>
        /// Items by default will be index 7 within a flex-container across all CSS media query breakpoints.
        /// </summary>
        /// <returns>The order configuration.</returns>
        public static IFluentOrderWithValueOnBreakpoint Is7 => new FluentOrder(7);

        /// <summary>
        /// Items by default will be index 8 within a flex-container across all CSS media query breakpoints.
        /// </summary>
        /// <returns>The order configuration.</returns>
        public static IFluentOrderWithValueOnBreakpoint Is8 => new FluentOrder(8);

        /// <summary>
        /// Items by default will be index 9 within a flex-container across all CSS media query breakpoints.
        /// </summary>
        /// <returns>The order configuration.</returns>
        public static IFluentOrderWithValueOnBreakpoint Is9 => new FluentOrder(9);

        /// <summary>
        /// Items by default will be index 10 within a flex-container across all CSS media query breakpoints.
        /// </summary>
        /// <returns>The order configuration.</returns>
        public static IFluentOrderWithValueOnBreakpoint Is10 => new FluentOrder(10);

        /// <summary>
        /// Items by default will be index 11 within a flex-container across all CSS media query breakpoints.
        /// </summary>
        /// <returns>The order configuration.</returns>
        public static IFluentOrderWithValueOnBreakpoint Is11 => new FluentOrder(11);

        /// <summary>
        /// Items by default will be index 12 within a flex-container across all CSS media query breakpoints.
        /// </summary>
        /// <returns>The order configuration.</returns>
        public static IFluentOrderWithValueOnBreakpoint Is12 => new FluentOrder(12);

        /// <summary>
        /// Items by default will be first within a flex-container across all CSS media query breakpoints.
        /// </summary>
        /// <returns>The order configuration.</returns>
        public static IFluentOrderWithValueOnBreakpoint IsFirst => new FluentOrder(int.MinValue);

        /// <summary>
        /// Items by default will be last within a flex-container across all CSS media query breakpoints.
        /// </summary>
        /// <returns>The order configuration.</returns>
        public static IFluentOrderWithValueOnBreakpoint IsLast => new FluentOrder(int.MaxValue);
    }
}

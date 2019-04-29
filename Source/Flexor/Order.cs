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
        /// The default order configuration of an item within a flex-line across all CSS media query breakpoints.
        /// The default order is unspecified, and will honor the definition as defined within the flex-line.
        /// </summary>
        public static IOrder Default => new FluentOrder();

        /// <summary>
        /// Items by will be index 0 within a flex-line across all CSS media query breakpoints.
        /// </summary>
        /// <returns>The order configuration.</returns>
        public static IOrder Is0 => new FluentOrder(0);

        /// <summary>
        /// Items by will be index 1 within a flex-line across all CSS media query breakpoints.
        /// </summary>
        /// <returns>The order configuration.</returns>
        public static IOrder Is1 => new FluentOrder(1);

        /// <summary>
        /// Items by will be index 2 within a flex-line across all CSS media query breakpoints.
        /// </summary>
        /// <returns>The order configuration.</returns>
        public static IOrder Is2 => new FluentOrder(2);

        /// <summary>
        /// Items by will be index 3 within a flex-line across all CSS media query breakpoints.
        /// </summary>
        /// <returns>The order configuration.</returns>
        public static IOrder Is3 => new FluentOrder(3);

        /// <summary>
        /// Items by will be index 4 within a flex-line across all CSS media query breakpoints.
        /// </summary>
        /// <returns>The order configuration.</returns>
        public static IOrder Is4 => new FluentOrder(4);

        /// <summary>
        /// Items by will be index 5 within a flex-line across all CSS media query breakpoints.
        /// </summary>
        /// <returns>The order configuration.</returns>
        public static IOrder Is5 => new FluentOrder(5);

        /// <summary>
        /// Items by will be index 6 within a flex-line across all CSS media query breakpoints.
        /// </summary>
        /// <returns>The order configuration.</returns>
        public static IOrder Is6 => new FluentOrder(6);

        /// <summary>
        /// Items by will be index 7 within a flex-line across all CSS media query breakpoints.
        /// </summary>
        /// <returns>The order configuration.</returns>
        public static IOrder Is7 => new FluentOrder(7);

        /// <summary>
        /// Items by will be index 8 within a flex-line across all CSS media query breakpoints.
        /// </summary>
        /// <returns>The order configuration.</returns>
        public static IOrder Is8 => new FluentOrder(8);

        /// <summary>
        /// Items by will be index 9 within a flex-line across all CSS media query breakpoints.
        /// </summary>
        /// <returns>The order configuration.</returns>
        public static IOrder Is9 => new FluentOrder(9);

        /// <summary>
        /// Items by will be index 10 within a flex-line across all CSS media query breakpoints.
        /// </summary>
        /// <returns>The order configuration.</returns>
        public static IOrder Is10 => new FluentOrder(10);

        /// <summary>
        /// Items by will be index 11 within a flex-line across all CSS media query breakpoints.
        /// </summary>
        /// <returns>The order configuration.</returns>
        public static IOrder Is11 => new FluentOrder(11);

        /// <summary>
        /// Items by will be index 12 within a flex-line across all CSS media query breakpoints.
        /// </summary>
        /// <returns>The order configuration.</returns>
        public static IOrder Is12 => new FluentOrder(12);

        /// <summary>
        /// Items by will be first within a flex-line across all CSS media query breakpoints.
        /// </summary>
        /// <returns>The order configuration.</returns>
        public static IOrder IsFirst => new FluentOrder(OrderOption.First);

        /// <summary>
        /// Items by will be last within a flex-line across all CSS media query breakpoints.
        /// </summary>
        /// <returns>The order configuration.</returns>
        public static IOrder IsLast => new FluentOrder(OrderOption.Last);

        /// <summary>
        /// The default order configuration of an item within a flex-line.
        /// The default order is unspecified, and will honor the definition as defined within the flex-line.
        /// </summary>
        public static IFluentOrder Is => new FluentOrder();
    }
}

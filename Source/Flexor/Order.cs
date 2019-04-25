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
        /// Items by default will be index 0 within a flex-line across all CSS media query breakpoints.
        /// </summary>
        /// <returns>The order configuration.</returns>
        public static IOrder Is0OnAll => new FluentOrder(0);

        /// <summary>
        /// Items by default will be index 1 within a flex-line across all CSS media query breakpoints.
        /// </summary>
        /// <returns>The order configuration.</returns>
        public static IOrder Is1OnAll => new FluentOrder(1);

        /// <summary>
        /// Items by default will be index 2 within a flex-line across all CSS media query breakpoints.
        /// </summary>
        /// <returns>The order configuration.</returns>
        public static IOrder Is2OnAll => new FluentOrder(2);

        /// <summary>
        /// Items by default will be index 3 within a flex-line across all CSS media query breakpoints.
        /// </summary>
        /// <returns>The order configuration.</returns>
        public static IOrder Is3OnAll => new FluentOrder(3);

        /// <summary>
        /// Items by default will be index 4 within a flex-line across all CSS media query breakpoints.
        /// </summary>
        /// <returns>The order configuration.</returns>
        public static IOrder Is4OnAll => new FluentOrder(4);

        /// <summary>
        /// Items by default will be index 5 within a flex-line across all CSS media query breakpoints.
        /// </summary>
        /// <returns>The order configuration.</returns>
        public static IOrder Is5OnAll => new FluentOrder(5);

        /// <summary>
        /// Items by default will be index 6 within a flex-line across all CSS media query breakpoints.
        /// </summary>
        /// <returns>The order configuration.</returns>
        public static IOrder Is6OnAll => new FluentOrder(6);

        /// <summary>
        /// Items by default will be index 7 within a flex-line across all CSS media query breakpoints.
        /// </summary>
        /// <returns>The order configuration.</returns>
        public static IOrder Is7OnAll => new FluentOrder(7);

        /// <summary>
        /// Items by default will be index 8 within a flex-line across all CSS media query breakpoints.
        /// </summary>
        /// <returns>The order configuration.</returns>
        public static IOrder Is8OnAll => new FluentOrder(8);

        /// <summary>
        /// Items by default will be index 9 within a flex-line across all CSS media query breakpoints.
        /// </summary>
        /// <returns>The order configuration.</returns>
        public static IOrder Is9OnAll => new FluentOrder(9);

        /// <summary>
        /// Items by default will be index 10 within a flex-line across all CSS media query breakpoints.
        /// </summary>
        /// <returns>The order configuration.</returns>
        public static IOrder Is10OnAll => new FluentOrder(10);

        /// <summary>
        /// Items by default will be index 11 within a flex-line across all CSS media query breakpoints.
        /// </summary>
        /// <returns>The order configuration.</returns>
        public static IOrder Is11OnAll => new FluentOrder(11);

        /// <summary>
        /// Items by default will be index 12 within a flex-line across all CSS media query breakpoints.
        /// </summary>
        /// <returns>The order configuration.</returns>
        public static IOrder Is12OnAll => new FluentOrder(12);

        /// <summary>
        /// Items by default will be first within a flex-line across all CSS media query breakpoints.
        /// </summary>
        /// <returns>The order configuration.</returns>
        public static IOrder IsFirstOnAll => new FluentOrder(int.MinValue);

        /// <summary>
        /// Items by default will be last within a flex-line across all CSS media query breakpoints.
        /// </summary>
        /// <returns>The order configuration.</returns>
        public static IOrder IsLastOnAll => new FluentOrder(int.MaxValue);

        /// <summary>
        /// Items by will be index 0 within a flex-line across specified CSS media query breakpoints.
        /// </summary>
        /// <returns>The order configuration.</returns>
        public static IFluentOrderWithValueOnBreakpoint Is0 => new FluentOrder().Is0;

        /// <summary>
        /// Items by will be index 1 within a flex-line across specified CSS media query breakpoints.
        /// </summary>
        /// <returns>The order configuration.</returns>
        public static IFluentOrderWithValueOnBreakpoint Is1 => new FluentOrder().Is1;

        /// <summary>
        /// Items by will be index 2 within a flex-line across specified CSS media query breakpoints.
        /// </summary>
        /// <returns>The order configuration.</returns>
        public static IFluentOrderWithValueOnBreakpoint Is2 => new FluentOrder().Is2;

        /// <summary>
        /// Items by will be index 3 within a flex-line across specified CSS media query breakpoints.
        /// </summary>
        /// <returns>The order configuration.</returns>
        public static IFluentOrderWithValueOnBreakpoint Is3 => new FluentOrder().Is3;

        /// <summary>
        /// Items by will be index 4 within a flex-line across specified CSS media query breakpoints.
        /// </summary>
        /// <returns>The order configuration.</returns>
        public static IFluentOrderWithValueOnBreakpoint Is4 => new FluentOrder().Is4;

        /// <summary>
        /// Items by will be index 5 within a flex-line across specified CSS media query breakpoints.
        /// </summary>
        /// <returns>The order configuration.</returns>
        public static IFluentOrderWithValueOnBreakpoint Is5 => new FluentOrder().Is5;

        /// <summary>
        /// Items by will be index 6 within a flex-line across specified CSS media query breakpoints.
        /// </summary>
        /// <returns>The order configuration.</returns>
        public static IFluentOrderWithValueOnBreakpoint Is6 => new FluentOrder().Is6;

        /// <summary>
        /// Items by will be index 7 within a flex-line across specified CSS media query breakpoints.
        /// </summary>
        /// <returns>The order configuration.</returns>
        public static IFluentOrderWithValueOnBreakpoint Is7 => new FluentOrder().Is7;

        /// <summary>
        /// Items by will be index 8 within a flex-line across specified CSS media query breakpoints.
        /// </summary>
        /// <returns>The order configuration.</returns>
        public static IFluentOrderWithValueOnBreakpoint Is8 => new FluentOrder().Is8;

        /// <summary>
        /// Items by will be index 9 within a flex-line across specified CSS media query breakpoints.
        /// </summary>
        /// <returns>The order configuration.</returns>
        public static IFluentOrderWithValueOnBreakpoint Is9 => new FluentOrder().Is9;

        /// <summary>
        /// Items by will be index 10 within a flex-line across specified CSS media query breakpoints.
        /// </summary>
        /// <returns>The order configuration.</returns>
        public static IFluentOrderWithValueOnBreakpoint Is10 => new FluentOrder().Is10;

        /// <summary>
        /// Items by will be index 11 within a flex-line across specified CSS media query breakpoints.
        /// </summary>
        /// <returns>The order configuration.</returns>
        public static IFluentOrderWithValueOnBreakpoint Is11 => new FluentOrder().Is11;

        /// <summary>
        /// Items by will be index 12 within a flex-line across specified CSS media query breakpoints.
        /// </summary>
        /// <returns>The order configuration.</returns>
        public static IFluentOrderWithValueOnBreakpoint Is12 => new FluentOrder().Is12;

        /// <summary>
        /// Items by will be first within a flex-line across specified CSS media query breakpoints.
        /// </summary>
        /// <returns>The order configuration.</returns>
        public static IFluentOrderWithValueOnBreakpoint IsFirst => new FluentOrder().IsFirst;

        /// <summary>
        /// Items by will be last within a flex-line across specified CSS media query breakpoints.
        /// </summary>
        /// <returns>The order configuration.</returns>
        public static IFluentOrderWithValueOnBreakpoint IsLast => new FluentOrder().IsLast;
    }
}

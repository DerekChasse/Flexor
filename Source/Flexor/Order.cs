// <copyright file="Order.cs" company="Derek Chasse">
// Copyright (c) Derek Chasse. All rights reserved.
// </copyright>

namespace Flexor
{
    public static class Order
    {
        public static IFluentOrderOnBreakpointWithValue Is => new FluentOrder();

        public static IFluentOrder ForAll(int? value) => new FluentOrder().OnMobileAndLarger(value);
    }
}

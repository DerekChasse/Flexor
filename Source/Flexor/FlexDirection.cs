// <copyright file="FlexDirection.cs" company="Derek Chasse">
// Copyright (c) Derek Chasse. All rights reserved.
// </copyright>

namespace Flexor
{
    public static class FlexDirection
    {
        public static IFluentFlexDirectionOnBreakpointWithValue Row => new FluentFlexDirection(Direction.Row);

        public static IFluentFlexDirectionOnBreakpointWithValue Column => new FluentFlexDirection(Direction.Column);

        public static IFluentFlexDirectionOnBreakpointWithValue RowReverse => new FluentFlexDirection(Direction.RowReverse);

        public static IFluentFlexDirectionOnBreakpointWithValue ColumnReverse => new FluentFlexDirection(Direction.ColumnReverse);
    }
}

// <copyright file="FlexDirection.cs" company="Derek Chasse">
// Copyright (c) Derek Chasse. All rights reserved.
// </copyright>

namespace Flexor
{
    /// <summary>
    /// Defines the direction flex items are placed within a flex-container.
    /// </summary>
    public static class FlexDirection
    {
        /// <summary>
        /// Flex items are rendered horizontally in the order they are defined within a container.
        /// </summary>
        public static IFluentFlexDirectionOnBreakpointWithValue Row => new FluentFlexDirection(DirectionValue.Row);

        /// <summary>
        /// Flex items are rendered vertically in the order they are defined within a container.
        /// </summary>
        public static IFluentFlexDirectionOnBreakpointWithValue Column => new FluentFlexDirection(DirectionValue.Column);

        /// <summary>
        /// Flex items are rendered horizontally in the reverse order they are defined within a container.
        /// </summary>
        public static IFluentFlexDirectionOnBreakpointWithValue RowReverse => new FluentFlexDirection(DirectionValue.RowReverse);

        /// <summary>
        /// Flex items are rendered vertically in the reverse order they are defined within a container.
        /// </summary>
        public static IFluentFlexDirectionOnBreakpointWithValue ColumnReverse => new FluentFlexDirection(DirectionValue.ColumnReverse);
    }
}

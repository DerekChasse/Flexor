// <copyright file="Direction.cs" company="Derek Chasse">
// Copyright (c) Derek Chasse. All rights reserved.
// </copyright>

namespace Flexor
{
    /// <summary>
    /// Defines the direction flex-items are placed within a flex-line.
    /// </summary>
    public static class Direction
    {
        /// <summary>
        /// Flex-items are rendered horizontally in the order they are defined within a flex-line.
        /// Items are rendered this way consistently across all CSS media query breakpoints.
        /// </summary>
        public static IDirection Row => new FluentFlexDirection().Is(DirectionOption.Row).OnAll();

        /// <summary>
        /// Flex-items are rendered vertically in the order they are defined within a flex-line.
        /// Items are rendered this way consistently across all CSS media query breakpoints.
        /// </summary>
        public static IDirection Column => new FluentFlexDirection().Is(DirectionOption.Column).OnAll();

        /// <summary>
        /// Flex-items are rendered horizontally in the reverse order they are defined within a flex-line.
        /// Items are rendered this way consistently across all CSS media query breakpoints.
        /// </summary>
        public static IDirection RowReverse => new FluentFlexDirection().Is(DirectionOption.RowReverse).OnAll();

        /// <summary>
        /// Flex-items are rendered vertically in the reverse order they are defined within a flex-line.
        /// Items are rendered this way consistently across all CSS media query breakpoints.
        /// </summary>
        public static IDirection ColumnReverse => new FluentFlexDirection().Is(DirectionOption.ColumnReverse).OnAll();

        /// <summary>
        /// Flex-items will be rendered and configured with the supplied direction.
        /// Rendering is configurable based on CSS media query breakpoints.
        /// </summary>
        /// <param name="direction">The default direction.</param>
        /// <returns>The flex direction configuration.</returns>
        public static IFluentFlexDirectionWithValueOnBreakpoint Is(DirectionOption direction) => new FluentFlexDirection().Is(direction);
    }
}

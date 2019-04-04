// <copyright file="Visible.cs" company="Derek Chasse">
// Copyright (c) Derek Chasse. All rights reserved.
// </copyright>

namespace Flexor
{
    /// <summary>
    /// Defines the visibility of a flex-item.
    /// </summary>
    public static class Visible
    {
        /// <summary>
        /// The item should always be visible.
        /// </summary>
        public static IFluentVisible Always => new FluentVisible(true);

        /// <summary>
        /// The item is only visible on certain CSS media queries.
        /// </summary>
        public static IFluentVisibleWithValueOnBreakpoint Only => new FluentVisible(false);

        /// <summary>
        /// The item is visible when a certain condition is met.
        /// </summary>
        /// <param name="condition">The condition which should trigger visibility.</param>
        /// <returns>The visibility configuration.</returns>
        public static IFluentVisibleWithValueOnBreakpoint When(bool condition) => new FluentVisible(condition);
    }
}

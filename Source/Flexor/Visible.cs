// <copyright file="Visible.cs" company="Derek Chasse">
// Copyright (c) Derek Chasse. All rights reserved.
// </copyright>

namespace Flexor
{
    /// <summary>
    /// Defines when a component should be visible.
    /// </summary>
    public static class Visible
    {
        /// <summary>
        /// Gets a configuration which states that a component should always be visible.
        /// </summary>
        public static IFluentVisible Always => new FluentVisible(true);

        /// <summary>
        /// Gets a configuration which states that a component should be conditionally visible based on media queries.
        /// </summary>
        public static IFluentVisibleOnBreakpointWithValue Only => new FluentVisible(false);

        /// <summary>
        /// Gets a configuration which states that a component should be conditionally visible.
        /// </summary>
        /// <param name="condition">The condition which should trigger visibility.</param>
        /// <returns>Configuration of when a component is visible.</returns>
        public static IFluentVisibleOnBreakpointWithValue When(bool condition) => new FluentVisible(condition);
    }
}

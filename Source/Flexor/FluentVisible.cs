// <copyright file="FluentVisible.cs" company="Derek Chasse">
// Copyright (c) Derek Chasse. All rights reserved.
// </copyright>

using System.Collections.Generic;

namespace Flexor
{
    /// <summary>
    /// Fluent interface which describes when a component should be visible.
    /// </summary>
    public interface IFluentVisible
    {
    }

    /// <summary>
    /// Fluent interface which describes when a component should be visible.
    /// </summary>
    public interface IFluentVisibleOnBreakpoint : IFluentVisible
    {
        IFluentVisibleOnBreakpointWithValue OnMobile(bool value = true);

        IFluentVisibleOnBreakpointWithValue OnTablet(bool value = true);

        IFluentVisibleOnBreakpointWithValue OnDesktop(bool value = true);

        IFluentVisibleOnBreakpointWithValue OnWidescreen(bool value = true);

        IFluentVisibleOnBreakpointWithValue OnFullHD(bool value = true);
    }

    /// <summary>
    /// Fluent interface which describes when a component should be visible.
    /// </summary>
    public interface IFluentVisibleOnBreakpointWithValue : IFluentVisible, IFluentVisibleOnBreakpoint
    {
    }

    public class FluentVisible : IFluentVisible, IFluentVisibleOnBreakpoint, IFluentVisibleOnBreakpointWithValue
    {
        private Dictionary<Breakpoint, bool> breakpointDictionary;

        /// <summary>
        /// Initializes a new instance of the <see cref="FluentVisible"/> class.
        /// </summary>
        public FluentVisible()
            : this(true)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FluentVisible"/> class.
        /// </summary>
        /// <param name="initialValue">The initial visiblity across all media query breakpoints.</param>
        public FluentVisible(bool initialValue)
        {
            this.InitializeBreakpointDictionary(initialValue);
        }

        /// <inheritdoc/>
        public IFluentVisibleOnBreakpointWithValue OnDesktop(bool value = true)
        {
            this.breakpointDictionary[Breakpoint.Desktop] = value;
            return this;
        }

        /// <inheritdoc/>
        public IFluentVisibleOnBreakpointWithValue OnFullHD(bool value = true)
        {
            this.breakpointDictionary[Breakpoint.FullHD] = value;
            return this;
        }

        /// <inheritdoc/>
        public IFluentVisibleOnBreakpointWithValue OnMobile(bool value = true)
        {
            this.breakpointDictionary[Breakpoint.Mobile] = value;
            return this;
        }

        /// <inheritdoc/>
        public IFluentVisibleOnBreakpointWithValue OnTablet(bool value = true)
        {
            this.breakpointDictionary[Breakpoint.Tablet] = value;
            return this;
        }

        /// <inheritdoc/>
        public IFluentVisibleOnBreakpointWithValue OnWidescreen(bool value = true)
        {
            this.breakpointDictionary[Breakpoint.Widescreen] = value;
            return this;
        }

        private void InitializeBreakpointDictionary(bool initialValue)
        {
            this.breakpointDictionary = new Dictionary<Breakpoint, bool>()
            {
                { Breakpoint.None, initialValue },
                { Breakpoint.Mobile, initialValue },
                { Breakpoint.Tablet, initialValue },
                { Breakpoint.Desktop, initialValue },
                { Breakpoint.Widescreen, initialValue },
                { Breakpoint.FullHD, initialValue },
            };
        }
    }

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
        /// <param name="condition">The condition which should trigger visiblity.</param>
        /// <returns>Configuration of when a component is visible.</returns>
        public static IFluentVisible When(bool condition) => new FluentVisible(condition);
    }
}

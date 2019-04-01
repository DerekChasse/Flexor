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
    public interface IFluentVisibleOnBreakpoint : IFluentVisible, IFluentReactive<IFluentVisibleOnBreakpointWithValue>
    {
    }

    /// <summary>
    /// Fluent interface which describes when a component should be visible.
    /// </summary>
    public interface IFluentVisibleOnBreakpointWithValue : IFluentVisibleOnBreakpoint
    {
    }

    public class FluentVisible : IFluentVisibleOnBreakpointWithValue
    {
        private readonly Dictionary<Breakpoint, bool> breakpointDictionary = new Dictionary<Breakpoint, bool>();

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
        /// <param name="initialValue">The initial visibility across all media query breakpoints.</param>
        public FluentVisible(bool initialValue)
        {
            this.SetBreakpointValues(initialValue, Breakpoint.Mobile, Breakpoint.Tablet, Breakpoint.Desktop, Breakpoint.Widescreen, Breakpoint.FullHD);
        }

        /// <inheritdoc/>
        public IFluentVisibleOnBreakpointWithValue OnDesktop()
        {
            this.breakpointDictionary[Breakpoint.Desktop] = true;
            return this;
        }

        /// <inheritdoc/>
        public IFluentVisibleOnBreakpointWithValue OnDesktopAndLarger()
        {
            this.SetBreakpointValues(true, Breakpoint.Desktop, Breakpoint.Widescreen, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentVisibleOnBreakpointWithValue OnDesktopAndSmaller()
        {
            this.SetBreakpointValues(true, Breakpoint.Mobile, Breakpoint.Tablet, Breakpoint.Desktop);
            return this;
        }

        /// <inheritdoc/>
        public IFluentVisibleOnBreakpointWithValue OnFullHD()
        {
            this.breakpointDictionary[Breakpoint.FullHD] = true;
            return this;
        }

        /// <inheritdoc/>
        public IFluentVisibleOnBreakpointWithValue OnFullHDAndSmaller()
        {
            this.SetBreakpointValues(true, Breakpoint.Mobile, Breakpoint.Tablet, Breakpoint.Desktop, Breakpoint.Widescreen, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentVisibleOnBreakpointWithValue OnMobile()
        {
            this.breakpointDictionary[Breakpoint.Mobile] = true;
            return this;
        }

        /// <inheritdoc/>
        public IFluentVisibleOnBreakpointWithValue OnMobileAndLarger()
        {
            this.SetBreakpointValues(true, Breakpoint.Mobile, Breakpoint.Tablet, Breakpoint.Desktop, Breakpoint.Widescreen, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentVisibleOnBreakpointWithValue OnTablet()
        {
            this.breakpointDictionary[Breakpoint.Tablet] = true;
            return this;
        }

        /// <inheritdoc/>
        public IFluentVisibleOnBreakpointWithValue OnTabletAndLarger()
        {
            this.SetBreakpointValues(true, Breakpoint.Tablet, Breakpoint.Desktop, Breakpoint.Widescreen, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentVisibleOnBreakpointWithValue OnTabletAndSmaller()
        {
            this.SetBreakpointValues(true, Breakpoint.Mobile, Breakpoint.Tablet);
            return this;
        }

        /// <inheritdoc/>
        public IFluentVisibleOnBreakpointWithValue OnWidescreen()
        {
            this.breakpointDictionary[Breakpoint.Widescreen] = true;
            return this;
        }

        /// <inheritdoc/>
        public IFluentVisibleOnBreakpointWithValue OnWidescreenAndLarger()
        {
            this.SetBreakpointValues(true, Breakpoint.Widescreen, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentVisibleOnBreakpointWithValue OnWidescreenAndSmaller()
        {
            this.SetBreakpointValues(true, Breakpoint.Mobile, Breakpoint.Tablet, Breakpoint.Desktop, Breakpoint.Widescreen);
            return this;
        }

        private void SetBreakpointValues(bool value, params Breakpoint[] breakpoints)
        {
            foreach (var breakpoint in breakpoints)
            {
                this.breakpointDictionary[breakpoint] = value;
            }
        }
    }
}

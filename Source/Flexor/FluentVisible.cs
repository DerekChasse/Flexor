// <copyright file="FluentVisible.cs" company="Derek Chasse">
// Copyright (c) Derek Chasse. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Linq;

namespace Flexor
{
#pragma warning disable SA1600 // Elements should be documented
    public interface IFluentVisible
    {
    }

    public interface IFluentVisibleWithValue : IFluentVisible
    {
        /// <summary>
        /// Chains visibility breakpoint conditional.
        /// </summary>
        IFluentVisibleWithValueOnBreakpoint And { get; }
    }

    public interface IFluentVisibleWithValueOnBreakpoint : IFluentVisible, IFluentReactive<IFluentVisibleWithValue>
    {
    }
#pragma warning restore SA1600 // Elements should be documented

    /// <summary>
    /// Definition of when a flex-item should be visible.
    /// </summary>
    public class FluentVisible : IFluentVisibleWithValueOnBreakpoint, IFluentVisibleWithValue
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
            foreach (var breakpoint in Enum.GetValues(typeof(Breakpoint)).Cast<Breakpoint>())
            {
                this.breakpointDictionary.Add(breakpoint, initialValue);
            }
        }

        /// <inheritdoc/>
        public IFluentVisibleWithValueOnBreakpoint And
        {
            get
            {
                return this;
            }
        }

        /// <inheritdoc/>
        public IFluentVisibleWithValue OnDesktop()
        {
            this.breakpointDictionary[Breakpoint.Desktop] = true;
            return this;
        }

        /// <inheritdoc/>
        public IFluentVisibleWithValue OnDesktopAndLarger()
        {
            this.SetBreakpointValues(true, Breakpoint.Desktop, Breakpoint.Widescreen, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentVisibleWithValue OnDesktopAndSmaller()
        {
            this.SetBreakpointValues(true, Breakpoint.Mobile, Breakpoint.Tablet, Breakpoint.Desktop);
            return this;
        }

        /// <inheritdoc/>
        public IFluentVisibleWithValue OnFullHD()
        {
            this.breakpointDictionary[Breakpoint.FullHD] = true;
            return this;
        }

        /// <inheritdoc/>
        public IFluentVisibleWithValue OnFullHDAndSmaller()
        {
            this.SetBreakpointValues(true, Breakpoint.Mobile, Breakpoint.Tablet, Breakpoint.Desktop, Breakpoint.Widescreen, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentVisibleWithValue OnMobile()
        {
            this.breakpointDictionary[Breakpoint.Mobile] = true;
            return this;
        }

        /// <inheritdoc/>
        public IFluentVisibleWithValue OnMobileAndLarger()
        {
            this.SetBreakpointValues(true, Breakpoint.Mobile, Breakpoint.Tablet, Breakpoint.Desktop, Breakpoint.Widescreen, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentVisibleWithValue OnTablet()
        {
            this.breakpointDictionary[Breakpoint.Tablet] = true;
            return this;
        }

        /// <inheritdoc/>
        public IFluentVisibleWithValue OnTabletAndLarger()
        {
            this.SetBreakpointValues(true, Breakpoint.Tablet, Breakpoint.Desktop, Breakpoint.Widescreen, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentVisibleWithValue OnTabletAndSmaller()
        {
            this.SetBreakpointValues(true, Breakpoint.Mobile, Breakpoint.Tablet);
            return this;
        }

        /// <inheritdoc/>
        public IFluentVisibleWithValue OnWidescreen()
        {
            this.breakpointDictionary[Breakpoint.Widescreen] = true;
            return this;
        }

        /// <inheritdoc/>
        public IFluentVisibleWithValue OnWidescreenAndLarger()
        {
            this.SetBreakpointValues(true, Breakpoint.Widescreen, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentVisibleWithValue OnWidescreenAndSmaller()
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

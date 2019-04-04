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
        private readonly Dictionary<BreakpointValue, bool> breakpointDictionary = new Dictionary<BreakpointValue, bool>();

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
            foreach (var breakpoint in Enum.GetValues(typeof(BreakpointValue)).Cast<BreakpointValue>())
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
            this.breakpointDictionary[BreakpointValue.Desktop] = true;
            return this;
        }

        /// <inheritdoc/>
        public IFluentVisibleWithValue OnDesktopAndLarger()
        {
            this.SetBreakpointValues(true, BreakpointValue.Desktop, BreakpointValue.Widescreen, BreakpointValue.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentVisibleWithValue OnDesktopAndSmaller()
        {
            this.SetBreakpointValues(true, BreakpointValue.Mobile, BreakpointValue.Tablet, BreakpointValue.Desktop);
            return this;
        }

        /// <inheritdoc/>
        public IFluentVisibleWithValue OnFullHD()
        {
            this.breakpointDictionary[BreakpointValue.FullHD] = true;
            return this;
        }

        /// <inheritdoc/>
        public IFluentVisibleWithValue OnFullHDAndSmaller()
        {
            this.SetBreakpointValues(true, BreakpointValue.Mobile, BreakpointValue.Tablet, BreakpointValue.Desktop, BreakpointValue.Widescreen, BreakpointValue.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentVisibleWithValue OnMobile()
        {
            this.breakpointDictionary[BreakpointValue.Mobile] = true;
            return this;
        }

        /// <inheritdoc/>
        public IFluentVisibleWithValue OnMobileAndLarger()
        {
            this.SetBreakpointValues(true, BreakpointValue.Mobile, BreakpointValue.Tablet, BreakpointValue.Desktop, BreakpointValue.Widescreen, BreakpointValue.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentVisibleWithValue OnTablet()
        {
            this.breakpointDictionary[BreakpointValue.Tablet] = true;
            return this;
        }

        /// <inheritdoc/>
        public IFluentVisibleWithValue OnTabletAndLarger()
        {
            this.SetBreakpointValues(true, BreakpointValue.Tablet, BreakpointValue.Desktop, BreakpointValue.Widescreen, BreakpointValue.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentVisibleWithValue OnTabletAndSmaller()
        {
            this.SetBreakpointValues(true, BreakpointValue.Mobile, BreakpointValue.Tablet);
            return this;
        }

        /// <inheritdoc/>
        public IFluentVisibleWithValue OnWidescreen()
        {
            this.breakpointDictionary[BreakpointValue.Widescreen] = true;
            return this;
        }

        /// <inheritdoc/>
        public IFluentVisibleWithValue OnWidescreenAndLarger()
        {
            this.SetBreakpointValues(true, BreakpointValue.Widescreen, BreakpointValue.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentVisibleWithValue OnWidescreenAndSmaller()
        {
            this.SetBreakpointValues(true, BreakpointValue.Mobile, BreakpointValue.Tablet, BreakpointValue.Desktop, BreakpointValue.Widescreen);
            return this;
        }

        private void SetBreakpointValues(bool value, params BreakpointValue[] breakpoints)
        {
            foreach (var breakpoint in breakpoints)
            {
                this.breakpointDictionary[breakpoint] = value;
            }
        }
    }
}

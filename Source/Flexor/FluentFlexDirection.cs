// <copyright file="FluentFlexDirection.cs" company="Derek Chasse">
// Copyright (c) Derek Chasse. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Linq;

namespace Flexor
{
#pragma warning disable SA1600 // Elements should be documented
    public interface IFluentFlexDirection
    {
    }

    public interface IFluentFlexDirectionOnBreakpoint : IFluentFlexDirection, IFluentReactive<IFluentFlexDirectionOnBreakpointWithValue, Direction>
    {
    }

    public interface IFluentFlexDirectionOnBreakpointWithValue : IFluentFlexDirectionOnBreakpoint
    {
    }
#pragma warning restore SA1600 // Elements should be documented

    /// <summary>
    /// Define the direction items are added to a flex-container.
    /// </summary>
    public class FluentFlexDirection : IFluentFlexDirectionOnBreakpointWithValue
    {
        private readonly Dictionary<Breakpoint, Direction> breakpointDictionary = new Dictionary<Breakpoint, Direction>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FluentFlexDirection"/> class.
        /// </summary>
        public FluentFlexDirection()
            : this(Direction.Row)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FluentFlexDirection"/> class.
        /// </summary>
        /// <param name="initialValue">The initial value across all CSS media queries.</param>
        public FluentFlexDirection(Direction initialValue)
        {
            foreach (var breakpoint in Enum.GetValues(typeof(Breakpoint)).Cast<Breakpoint>())
            {
                this.breakpointDictionary.Add(breakpoint, initialValue);
            }
        }

        /// <inheritdoc/>
        public IFluentFlexDirectionOnBreakpointWithValue OnDesktop(Direction value)
        {
            this.breakpointDictionary[Breakpoint.Desktop] = value;
            return this;
        }

        /// <inheritdoc/>
        public IFluentFlexDirectionOnBreakpointWithValue OnDesktopAndLarger(Direction value)
        {
            this.SetBreakpointValues(value, Breakpoint.Desktop, Breakpoint.Widescreen, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentFlexDirectionOnBreakpointWithValue OnDesktopAndSmaller(Direction value)
        {
            this.SetBreakpointValues(value, Breakpoint.Mobile, Breakpoint.Tablet, Breakpoint.Desktop);
            return this;
        }

        /// <inheritdoc/>
        public IFluentFlexDirectionOnBreakpointWithValue OnFullHD(Direction value)
        {
            this.breakpointDictionary[Breakpoint.FullHD] = value;
            return this;
        }

        /// <inheritdoc/>
        public IFluentFlexDirectionOnBreakpointWithValue OnFullHDAndSmaller(Direction value)
        {
            this.SetBreakpointValues(value, Breakpoint.Mobile, Breakpoint.Tablet, Breakpoint.Desktop, Breakpoint.Widescreen, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentFlexDirectionOnBreakpointWithValue OnMobile(Direction value)
        {
            this.breakpointDictionary[Breakpoint.Mobile] = value;
            return this;
        }

        /// <inheritdoc/>
        public IFluentFlexDirectionOnBreakpointWithValue OnMobileAndLarger(Direction value)
        {
            this.SetBreakpointValues(value, Breakpoint.Mobile, Breakpoint.Tablet, Breakpoint.Desktop, Breakpoint.Widescreen, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentFlexDirectionOnBreakpointWithValue OnTablet(Direction value)
        {
            this.breakpointDictionary[Breakpoint.Tablet] = value;
            return this;
        }

        /// <inheritdoc/>
        public IFluentFlexDirectionOnBreakpointWithValue OnTabletAndLarger(Direction value)
        {
            this.SetBreakpointValues(value, Breakpoint.Tablet, Breakpoint.Desktop, Breakpoint.Widescreen, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentFlexDirectionOnBreakpointWithValue OnTabletAndSmaller(Direction value)
        {
            this.SetBreakpointValues(value, Breakpoint.Mobile, Breakpoint.Tablet);
            return this;
        }

        /// <inheritdoc/>
        public IFluentFlexDirectionOnBreakpointWithValue OnWidescreen(Direction value)
        {
            this.breakpointDictionary[Breakpoint.Widescreen] = value;
            return this;
        }

        /// <inheritdoc/>
        public IFluentFlexDirectionOnBreakpointWithValue OnWidescreenAndLarger(Direction value)
        {
            this.SetBreakpointValues(value, Breakpoint.Widescreen, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentFlexDirectionOnBreakpointWithValue OnWidescreenAndSmaller(Direction value)
        {
            this.SetBreakpointValues(value, Breakpoint.Mobile, Breakpoint.Tablet, Breakpoint.Desktop, Breakpoint.Widescreen);
            return this;
        }

        private void SetBreakpointValues(Direction value, params Breakpoint[] breakpoints)
        {
            foreach (var breakpoint in breakpoints)
            {
                this.breakpointDictionary[breakpoint] = value;
            }
        }
    }
}

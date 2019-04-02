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

    public interface IFluentFlexDirectionOnBreakpoint : IFluentFlexDirection, IFluentReactive<IFluentFlexDirectionOnBreakpointWithValue, DirectionValue>
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
        private readonly Dictionary<BreakpointValue, DirectionValue> breakpointDictionary = new Dictionary<BreakpointValue, DirectionValue>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FluentFlexDirection"/> class.
        /// </summary>
        public FluentFlexDirection()
            : this(DirectionValue.Row)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FluentFlexDirection"/> class.
        /// </summary>
        /// <param name="initialValue">The initial value across all CSS media queries.</param>
        public FluentFlexDirection(DirectionValue initialValue)
        {
            foreach (var breakpoint in Enum.GetValues(typeof(BreakpointValue)).Cast<BreakpointValue>())
            {
                this.breakpointDictionary.Add(breakpoint, initialValue);
            }
        }

        /// <inheritdoc/>
        public IFluentFlexDirectionOnBreakpointWithValue OnDesktop(DirectionValue value)
        {
            this.breakpointDictionary[BreakpointValue.Desktop] = value;
            return this;
        }

        /// <inheritdoc/>
        public IFluentFlexDirectionOnBreakpointWithValue OnDesktopAndLarger(DirectionValue value)
        {
            this.SetBreakpointValues(value, BreakpointValue.Desktop, BreakpointValue.Widescreen, BreakpointValue.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentFlexDirectionOnBreakpointWithValue OnDesktopAndSmaller(DirectionValue value)
        {
            this.SetBreakpointValues(value, BreakpointValue.Mobile, BreakpointValue.Tablet, BreakpointValue.Desktop);
            return this;
        }

        /// <inheritdoc/>
        public IFluentFlexDirectionOnBreakpointWithValue OnFullHD(DirectionValue value)
        {
            this.breakpointDictionary[BreakpointValue.FullHD] = value;
            return this;
        }

        /// <inheritdoc/>
        public IFluentFlexDirectionOnBreakpointWithValue OnFullHDAndSmaller(DirectionValue value)
        {
            this.SetBreakpointValues(value, BreakpointValue.Mobile, BreakpointValue.Tablet, BreakpointValue.Desktop, BreakpointValue.Widescreen, BreakpointValue.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentFlexDirectionOnBreakpointWithValue OnMobile(DirectionValue value)
        {
            this.breakpointDictionary[BreakpointValue.Mobile] = value;
            return this;
        }

        /// <inheritdoc/>
        public IFluentFlexDirectionOnBreakpointWithValue OnMobileAndLarger(DirectionValue value)
        {
            this.SetBreakpointValues(value, BreakpointValue.Mobile, BreakpointValue.Tablet, BreakpointValue.Desktop, BreakpointValue.Widescreen, BreakpointValue.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentFlexDirectionOnBreakpointWithValue OnTablet(DirectionValue value)
        {
            this.breakpointDictionary[BreakpointValue.Tablet] = value;
            return this;
        }

        /// <inheritdoc/>
        public IFluentFlexDirectionOnBreakpointWithValue OnTabletAndLarger(DirectionValue value)
        {
            this.SetBreakpointValues(value, BreakpointValue.Tablet, BreakpointValue.Desktop, BreakpointValue.Widescreen, BreakpointValue.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentFlexDirectionOnBreakpointWithValue OnTabletAndSmaller(DirectionValue value)
        {
            this.SetBreakpointValues(value, BreakpointValue.Mobile, BreakpointValue.Tablet);
            return this;
        }

        /// <inheritdoc/>
        public IFluentFlexDirectionOnBreakpointWithValue OnWidescreen(DirectionValue value)
        {
            this.breakpointDictionary[BreakpointValue.Widescreen] = value;
            return this;
        }

        /// <inheritdoc/>
        public IFluentFlexDirectionOnBreakpointWithValue OnWidescreenAndLarger(DirectionValue value)
        {
            this.SetBreakpointValues(value, BreakpointValue.Widescreen, BreakpointValue.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentFlexDirectionOnBreakpointWithValue OnWidescreenAndSmaller(DirectionValue value)
        {
            this.SetBreakpointValues(value, BreakpointValue.Mobile, BreakpointValue.Tablet, BreakpointValue.Desktop, BreakpointValue.Widescreen);
            return this;
        }

        private void SetBreakpointValues(DirectionValue value, params BreakpointValue[] breakpoints)
        {
            foreach (var breakpoint in breakpoints)
            {
                this.breakpointDictionary[breakpoint] = value;
            }
        }
    }
}

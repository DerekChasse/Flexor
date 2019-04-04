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

    public interface IFluentFlexDirectionWithValue : IFluentFlexDirection
    {
        IFluentFlexDirectionWithValueOnBreakpoint Is(DirectionValue direction);
    }

    public interface IFluentFlexDirectionWithValueOnBreakpoint : IFluentReactive<IFluentFlexDirectionWithValue>, IFluentFlexDirection
    {
    }
#pragma warning restore SA1600 // Elements should be documented

    /// <summary>
    /// Define the direction items are added to a flex-container.
    /// </summary>
    public class FluentFlexDirection : IFluentFlexDirectionWithValue, IFluentFlexDirectionWithValueOnBreakpoint
    {
        private readonly Dictionary<BreakpointValue, DirectionValue> breakpointDictionary = new Dictionary<BreakpointValue, DirectionValue>();
        private DirectionValue valueToApply;

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
        public IFluentFlexDirectionWithValueOnBreakpoint Is(DirectionValue direction)
        {
            this.valueToApply = direction;
            return this;
        }

        /// <inheritdoc/>
        public IFluentFlexDirectionWithValue OnDesktop()
        {
            this.breakpointDictionary[BreakpointValue.Desktop] = this.valueToApply;
            return this;
        }

        /// <inheritdoc/>
        public IFluentFlexDirectionWithValue OnDesktopAndLarger()
        {
            this.SetBreakpointValues(this.valueToApply, BreakpointValue.Desktop, BreakpointValue.Widescreen, BreakpointValue.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentFlexDirectionWithValue OnDesktopAndSmaller()
        {
            this.SetBreakpointValues(this.valueToApply, BreakpointValue.Mobile, BreakpointValue.Tablet, BreakpointValue.Desktop);
            return this;
        }

        /// <inheritdoc/>
        public IFluentFlexDirectionWithValue OnFullHD()
        {
            this.breakpointDictionary[BreakpointValue.FullHD] = this.valueToApply;
            return this;
        }

        /// <inheritdoc/>
        public IFluentFlexDirectionWithValue OnFullHDAndSmaller()
        {
            this.SetBreakpointValues(this.valueToApply, BreakpointValue.Mobile, BreakpointValue.Tablet, BreakpointValue.Desktop, BreakpointValue.Widescreen, BreakpointValue.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentFlexDirectionWithValue OnMobile()
        {
            this.breakpointDictionary[BreakpointValue.Mobile] = this.valueToApply;
            return this;
        }

        /// <inheritdoc/>
        public IFluentFlexDirectionWithValue OnMobileAndLarger()
        {
            this.SetBreakpointValues(this.valueToApply, BreakpointValue.Mobile, BreakpointValue.Tablet, BreakpointValue.Desktop, BreakpointValue.Widescreen, BreakpointValue.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentFlexDirectionWithValue OnTablet()
        {
            this.breakpointDictionary[BreakpointValue.Tablet] = this.valueToApply;
            return this;
        }

        /// <inheritdoc/>
        public IFluentFlexDirectionWithValue OnTabletAndLarger()
        {
            this.SetBreakpointValues(this.valueToApply, BreakpointValue.Tablet, BreakpointValue.Desktop, BreakpointValue.Widescreen, BreakpointValue.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentFlexDirectionWithValue OnTabletAndSmaller()
        {
            this.SetBreakpointValues(this.valueToApply, BreakpointValue.Mobile, BreakpointValue.Tablet);
            return this;
        }

        /// <inheritdoc/>
        public IFluentFlexDirectionWithValue OnWidescreen()
        {
            this.breakpointDictionary[BreakpointValue.Widescreen] = this.valueToApply;
            return this;
        }

        /// <inheritdoc/>
        public IFluentFlexDirectionWithValue OnWidescreenAndLarger()
        {
            this.SetBreakpointValues(this.valueToApply, BreakpointValue.Widescreen, BreakpointValue.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentFlexDirectionWithValue OnWidescreenAndSmaller()
        {
            this.SetBreakpointValues(this.valueToApply, BreakpointValue.Mobile, BreakpointValue.Tablet, BreakpointValue.Desktop, BreakpointValue.Widescreen);
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

// <copyright file="FluentWrap.cs" company="Derek Chasse">
// Copyright (c) Derek Chasse. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Linq;

namespace Flexor
{
#pragma warning disable SA1600 // Elements should be documented
    public interface IFluentWrap
    {
    }

    public interface IFluentWrapWithValue : IFluentWrap
    {
        IFluentWrapWithValueOnBreakpoint Is(WrapValue direction);
    }

    public interface IFluentWrapWithValueOnBreakpoint : IFluentReactive<IFluentWrapWithValue>, IFluentWrap
    {
    }
#pragma warning restore SA1600 // Elements should be documented

    /// <summary>
    /// Define the ability of a flex-container to wrap.
    /// </summary>
    public class FluentWrap : IFluentWrapWithValue, IFluentWrapWithValueOnBreakpoint
    {
        private readonly Dictionary<BreakpointValue, WrapValue> breakpointDictionary = new Dictionary<BreakpointValue, WrapValue>();
        private WrapValue valueToApply;

        /// <summary>
        /// Initializes a new instance of the <see cref="FluentWrap"/> class.
        /// </summary>
        public FluentWrap()
            : this(WrapValue.NoWrap)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FluentWrap"/> class.
        /// </summary>
        /// <param name="initialValue">The initial value across all CSS media queries.</param>
        public FluentWrap(WrapValue initialValue)
        {
            foreach (var breakpoint in Enum.GetValues(typeof(BreakpointValue)).Cast<BreakpointValue>())
            {
                this.breakpointDictionary.Add(breakpoint, initialValue);
            }
        }

        /// <inheritdoc/>
        public IFluentWrapWithValueOnBreakpoint Is(WrapValue direction)
        {
            this.valueToApply = direction;
            return this;
        }

        /// <inheritdoc/>
        public IFluentWrapWithValue OnDesktop()
        {
            this.breakpointDictionary[BreakpointValue.Desktop] = this.valueToApply;
            return this;
        }

        /// <inheritdoc/>
        public IFluentWrapWithValue OnDesktopAndLarger()
        {
            this.SetBreakpointValues(this.valueToApply, BreakpointValue.Desktop, BreakpointValue.Widescreen, BreakpointValue.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentWrapWithValue OnDesktopAndSmaller()
        {
            this.SetBreakpointValues(this.valueToApply, BreakpointValue.Mobile, BreakpointValue.Tablet, BreakpointValue.Desktop);
            return this;
        }

        /// <inheritdoc/>
        public IFluentWrapWithValue OnFullHD()
        {
            this.breakpointDictionary[BreakpointValue.FullHD] = this.valueToApply;
            return this;
        }

        /// <inheritdoc/>
        public IFluentWrapWithValue OnFullHDAndSmaller()
        {
            this.SetBreakpointValues(this.valueToApply, BreakpointValue.Mobile, BreakpointValue.Tablet, BreakpointValue.Desktop, BreakpointValue.Widescreen, BreakpointValue.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentWrapWithValue OnMobile()
        {
            this.breakpointDictionary[BreakpointValue.Mobile] = this.valueToApply;
            return this;
        }

        /// <inheritdoc/>
        public IFluentWrapWithValue OnMobileAndLarger()
        {
            this.SetBreakpointValues(this.valueToApply, BreakpointValue.Mobile, BreakpointValue.Tablet, BreakpointValue.Desktop, BreakpointValue.Widescreen, BreakpointValue.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentWrapWithValue OnTablet()
        {
            this.breakpointDictionary[BreakpointValue.Tablet] = this.valueToApply;
            return this;
        }

        /// <inheritdoc/>
        public IFluentWrapWithValue OnTabletAndLarger()
        {
            this.SetBreakpointValues(this.valueToApply, BreakpointValue.Tablet, BreakpointValue.Desktop, BreakpointValue.Widescreen, BreakpointValue.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentWrapWithValue OnTabletAndSmaller()
        {
            this.SetBreakpointValues(this.valueToApply, BreakpointValue.Mobile, BreakpointValue.Tablet);
            return this;
        }

        /// <inheritdoc/>
        public IFluentWrapWithValue OnWidescreen()
        {
            this.breakpointDictionary[BreakpointValue.Widescreen] = this.valueToApply;
            return this;
        }

        /// <inheritdoc/>
        public IFluentWrapWithValue OnWidescreenAndLarger()
        {
            this.SetBreakpointValues(this.valueToApply, BreakpointValue.Widescreen, BreakpointValue.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentWrapWithValue OnWidescreenAndSmaller()
        {
            this.SetBreakpointValues(this.valueToApply, BreakpointValue.Mobile, BreakpointValue.Tablet, BreakpointValue.Desktop, BreakpointValue.Widescreen);
            return this;
        }

        private void SetBreakpointValues(WrapValue value, params BreakpointValue[] breakpoints)
        {
            foreach (var breakpoint in breakpoints)
            {
                this.breakpointDictionary[breakpoint] = value;
            }
        }
    }
}

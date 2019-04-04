// <copyright file="FluentResizability.cs" company="Derek Chasse">
// Copyright (c) Derek Chasse. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Linq;

namespace Flexor
{
#pragma warning disable SA1600 // Elements should be documented
    public interface IFluentResizability
    {
    }

    public interface IFluentResizabilityWithValue : IFluentResizability
    {
        IFluentResizabilityWithValueOnBreakpoint IsAutomatic();

        IFluentResizabilityWithValueOnBreakpoint IsInitial();

        IFluentResizabilityWithValueOnBreakpoint CanGrow();

        IFluentResizabilityWithValueOnBreakpoint CanNotGrow();

        IFluentResizabilityWithValueOnBreakpoint CanNotShrink();
    }

    public interface IFluentResizabilityWithValueOnBreakpoint : IFluentResizability, IFluentReactive<IFluentResizabilityWithValue>
    {
    }
#pragma warning restore SA1600 // Elements should be documented

    /// <summary>
    /// Define the ability to resize an item is displayed in a flex-container.
    /// </summary>
    public class FluentResizability : IFluentResizabilityWithValueOnBreakpoint, IFluentResizabilityWithValue
    {
        private readonly Dictionary<BreakpointValue, ResizabilityValue> breakpointDictionary = new Dictionary<BreakpointValue, ResizabilityValue>();
        private ResizabilityValue valueToApply;

        /// <summary>
        /// Initializes a new instance of the <see cref="FluentResizability"/> class.
        /// </summary>
        public FluentResizability()
            : this(ResizabilityValue.Auto)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FluentResizability"/> class.
        /// </summary>
        /// <param name="initialValue">The initial <see cref="ResizabilityValue"/> across all media query breakpoints.</param>
        public FluentResizability(ResizabilityValue initialValue)
        {
            foreach (var breakpoint in Enum.GetValues(typeof(BreakpointValue)).Cast<BreakpointValue>())
            {
                this.breakpointDictionary.Add(breakpoint, initialValue);
            }
        }

        /// <inheritdoc/>
        public IFluentResizabilityWithValueOnBreakpoint CanGrow()
        {
            this.valueToApply = ResizabilityValue.Grow;
            return this;
        }

        /// <inheritdoc/>
        public IFluentResizabilityWithValueOnBreakpoint CanNotGrow()
        {
            this.valueToApply = ResizabilityValue.NoGrow;
            return this;
        }

        /// <inheritdoc/>
        public IFluentResizabilityWithValueOnBreakpoint CanNotShrink()
        {
            this.valueToApply = ResizabilityValue.NoShrink;
            return this;
        }

        /// <inheritdoc/>
        public IFluentResizabilityWithValueOnBreakpoint IsAutomatic()
        {
            this.valueToApply = ResizabilityValue.Auto;
            return this;
        }

        /// <inheritdoc/>
        public IFluentResizabilityWithValueOnBreakpoint IsInitial()
        {
            this.valueToApply = ResizabilityValue.None;
            return this;
        }

        /// <inheritdoc/>
        public IFluentResizabilityWithValue OnDesktop()
        {
            this.breakpointDictionary[BreakpointValue.Desktop] = this.valueToApply;
            return this;
        }

        /// <inheritdoc/>
        public IFluentResizabilityWithValue OnDesktopAndLarger()
        {
            this.SetBreakpointValues(this.valueToApply, BreakpointValue.Desktop, BreakpointValue.Widescreen, BreakpointValue.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentResizabilityWithValue OnDesktopAndSmaller()
        {
            this.SetBreakpointValues(this.valueToApply, BreakpointValue.Mobile, BreakpointValue.Tablet, BreakpointValue.Desktop);
            return this;
        }

        /// <inheritdoc/>
        public IFluentResizabilityWithValue OnFullHD()
        {
            this.breakpointDictionary[BreakpointValue.FullHD] = this.valueToApply;
            return this;
        }

        /// <inheritdoc/>
        public IFluentResizabilityWithValue OnFullHDAndSmaller()
        {
            this.SetBreakpointValues(this.valueToApply, BreakpointValue.Mobile, BreakpointValue.Tablet, BreakpointValue.Desktop, BreakpointValue.Widescreen, BreakpointValue.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentResizabilityWithValue OnMobile()
        {
            this.breakpointDictionary[BreakpointValue.Mobile] = this.valueToApply;
            return this;
        }

        /// <inheritdoc/>
        public IFluentResizabilityWithValue OnMobileAndLarger()
        {
            this.SetBreakpointValues(this.valueToApply, BreakpointValue.Mobile, BreakpointValue.Tablet, BreakpointValue.Desktop, BreakpointValue.Widescreen, BreakpointValue.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentResizabilityWithValue OnTablet()
        {
            this.breakpointDictionary[BreakpointValue.Tablet] = this.valueToApply;
            return this;
        }

        /// <inheritdoc/>
        public IFluentResizabilityWithValue OnTabletAndLarger()
        {
            this.SetBreakpointValues(this.valueToApply, BreakpointValue.Tablet, BreakpointValue.Desktop, BreakpointValue.Widescreen, BreakpointValue.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentResizabilityWithValue OnTabletAndSmaller()
        {
            this.SetBreakpointValues(this.valueToApply, BreakpointValue.Mobile, BreakpointValue.Tablet);
            return this;
        }

        /// <inheritdoc/>
        public IFluentResizabilityWithValue OnWidescreen()
        {
            this.breakpointDictionary[BreakpointValue.Widescreen] = this.valueToApply;
            return this;
        }

        /// <inheritdoc/>
        public IFluentResizabilityWithValue OnWidescreenAndLarger()
        {
            this.SetBreakpointValues(this.valueToApply, BreakpointValue.Widescreen, BreakpointValue.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentResizabilityWithValue OnWidescreenAndSmaller()
        {
            this.SetBreakpointValues(this.valueToApply, BreakpointValue.Mobile, BreakpointValue.Tablet, BreakpointValue.Desktop, BreakpointValue.Widescreen);
            return this;
        }

        private void SetBreakpointValues(ResizabilityValue value, params BreakpointValue[] breakpoints)
        {
            foreach (var breakpoint in breakpoints)
            {
                this.breakpointDictionary[breakpoint] = value;
            }
        }
    }
}

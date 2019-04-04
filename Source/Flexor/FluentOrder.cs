// <copyright file="FluentOrder.cs" company="Derek Chasse">
// Copyright (c) Derek Chasse. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Linq;

namespace Flexor
{
#pragma warning disable SA1600 // Elements should be documented
    public interface IFluentOrder
    {
    }

    public interface IFluentOrderWithValue : IFluentOrder
    {
        IFluentOrderWithValueOnBreakpoint Is(int value);
    }

    public interface IFluentOrderWithValueOnBreakpoint : IFluentReactive<IFluentOrderWithValue>, IFluentOrder
    {
    }
#pragma warning restore SA1600 // Elements should be documented

    /// <summary>
    /// Define the order in which an item is displayed in a flex-container.
    /// </summary>
    public class FluentOrder : IFluentOrderWithValueOnBreakpoint, IFluentOrderWithValue
    {
        private readonly Dictionary<BreakpointValue, int?> breakpointDictionary = new Dictionary<BreakpointValue, int?>();
        private int valueToApply;

        /// <summary>
        /// Initializes a new instance of the <see cref="FluentOrder"/> class.
        /// </summary>
        public FluentOrder()
            : this(default)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FluentOrder"/> class.
        /// </summary>
        /// <param name="value">The default item order.</param>
        public FluentOrder(int? value)
        {
            foreach (var item in Enum.GetValues(typeof(BreakpointValue)).Cast<BreakpointValue>())
            {
                this.breakpointDictionary.Add(item, value);
            }
        }

        /// <inheritdoc/>
        public IFluentOrderWithValueOnBreakpoint Is(int value)
        {
            this.valueToApply = value;
            return this;
        }

        /// <inheritdoc/>
        public IFluentOrderWithValue OnDesktop()
        {
            this.breakpointDictionary[BreakpointValue.Desktop] = this.valueToApply;
            return this;
        }

        /// <inheritdoc/>
        public IFluentOrderWithValue OnDesktopAndLarger()
        {
            this.SetBreakpointValues(this.valueToApply, BreakpointValue.Desktop, BreakpointValue.Widescreen, BreakpointValue.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentOrderWithValue OnDesktopAndSmaller()
        {
            this.SetBreakpointValues(this.valueToApply, BreakpointValue.Mobile, BreakpointValue.Tablet, BreakpointValue.Desktop);
            return this;
        }

        /// <inheritdoc/>
        public IFluentOrderWithValue OnFullHD()
        {
            this.breakpointDictionary[BreakpointValue.FullHD] = this.valueToApply;
            return this;
        }

        /// <inheritdoc/>
        public IFluentOrderWithValue OnFullHDAndSmaller()
        {
            this.SetBreakpointValues(this.valueToApply, BreakpointValue.Mobile, BreakpointValue.Tablet, BreakpointValue.Desktop, BreakpointValue.Widescreen, BreakpointValue.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentOrderWithValue OnMobile()
        {
            this.breakpointDictionary[BreakpointValue.Mobile] = this.valueToApply;
            return this;
        }

        /// <inheritdoc/>
        public IFluentOrderWithValue OnMobileAndLarger()
        {
            this.SetBreakpointValues(this.valueToApply, BreakpointValue.Mobile, BreakpointValue.Tablet, BreakpointValue.Desktop, BreakpointValue.Widescreen, BreakpointValue.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentOrderWithValue OnTablet()
        {
            this.breakpointDictionary[BreakpointValue.Tablet] = this.valueToApply;
            return this;
        }

        /// <inheritdoc/>
        public IFluentOrderWithValue OnTabletAndLarger()
        {
            this.SetBreakpointValues(this.valueToApply, BreakpointValue.Tablet, BreakpointValue.Desktop, BreakpointValue.Widescreen, BreakpointValue.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentOrderWithValue OnTabletAndSmaller()
        {
            this.SetBreakpointValues(this.valueToApply, BreakpointValue.Mobile, BreakpointValue.Tablet);
            return this;
        }

        /// <inheritdoc/>
        public IFluentOrderWithValue OnWidescreen()
        {
            this.breakpointDictionary[BreakpointValue.Widescreen] = this.valueToApply;
            return this;
        }

        /// <inheritdoc/>
        public IFluentOrderWithValue OnWidescreenAndLarger()
        {
            this.SetBreakpointValues(this.valueToApply, BreakpointValue.Widescreen, BreakpointValue.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentOrderWithValue OnWidescreenAndSmaller()
        {
            this.SetBreakpointValues(this.valueToApply, BreakpointValue.Mobile, BreakpointValue.Tablet, BreakpointValue.Desktop, BreakpointValue.Widescreen);
            return this;
        }

        private void SetBreakpointValues(int? value, params BreakpointValue[] breakpoints)
        {
            foreach (var breakpoint in breakpoints)
            {
                this.breakpointDictionary[breakpoint] = value;
            }
        }
    }
}

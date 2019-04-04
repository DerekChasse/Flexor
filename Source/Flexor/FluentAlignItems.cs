// <copyright file="FluentAlignItems.cs" company="Derek Chasse">
// Copyright (c) Derek Chasse. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Linq;

namespace Flexor
{
#pragma warning disable SA1600 // Elements should be documented
    public interface IFluentAlignItems
    {
    }

    public interface IFluentAlignItemsWithValue : IFluentAlignItems
    {
        IFluentAlignItemsWithValueOnBreakpoint Is(ItemAlignmentValue value);
    }

    public interface IFluentAlignItemsWithValueOnBreakpoint : IFluentReactive<IFluentAlignItemsWithValue>, IFluentAlignItems
    {
    }
#pragma warning restore SA1600 // Elements should be documented

    /// <summary>
    /// Define how items are aligned along a flex-container's cross axis.
    /// </summary>
    public class FluentAlignItems : IFluentAlignItemsWithValueOnBreakpoint, IFluentAlignItemsWithValue
    {
        private readonly Dictionary<BreakpointValue, ItemAlignmentValue> breakpointDictionary = new Dictionary<BreakpointValue, ItemAlignmentValue>();
        private ItemAlignmentValue valueToApply;

        /// <summary>
        /// Initializes a new instance of the <see cref="FluentAlignItems"/> class.
        /// </summary>
        public FluentAlignItems()
            : this(ItemAlignmentValue.Stretch)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FluentAlignItems"/> class.
        /// </summary>
        /// <param name="initialValue">The initial value across all CSS media queries.</param>
        public FluentAlignItems(ItemAlignmentValue initialValue)
        {
            foreach (var breakpoint in Enum.GetValues(typeof(BreakpointValue)).Cast<BreakpointValue>())
            {
                this.breakpointDictionary.Add(breakpoint, initialValue);
            }
        }

        /// <inheritdoc/>
        public IFluentAlignItemsWithValueOnBreakpoint Is(ItemAlignmentValue value)
        {
            this.valueToApply = value;
            return this;
        }

        /// <inheritdoc/>
        public IFluentAlignItemsWithValue OnDesktop()
        {
            this.SetBreakpointValues(this.valueToApply, BreakpointValue.Desktop);
            return this;
        }

        /// <inheritdoc/>
        public IFluentAlignItemsWithValue OnDesktopAndLarger()
        {
            this.SetBreakpointValues(this.valueToApply, BreakpointValue.Desktop, BreakpointValue.Widescreen, BreakpointValue.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentAlignItemsWithValue OnDesktopAndSmaller()
        {
            this.SetBreakpointValues(this.valueToApply, BreakpointValue.Mobile, BreakpointValue.Tablet, BreakpointValue.Desktop);
            return this;
        }

        /// <inheritdoc/>
        public IFluentAlignItemsWithValue OnFullHD()
        {
            this.SetBreakpointValues(this.valueToApply, BreakpointValue.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentAlignItemsWithValue OnFullHDAndSmaller()
        {
            this.SetBreakpointValues(this.valueToApply, BreakpointValue.Mobile, BreakpointValue.Tablet, BreakpointValue.Desktop, BreakpointValue.Widescreen, BreakpointValue.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentAlignItemsWithValue OnMobile()
        {
            this.SetBreakpointValues(this.valueToApply, BreakpointValue.Mobile);
            return this;
        }

        /// <inheritdoc/>
        public IFluentAlignItemsWithValue OnMobileAndLarger()
        {
            this.SetBreakpointValues(this.valueToApply, BreakpointValue.Mobile, BreakpointValue.Tablet, BreakpointValue.Desktop, BreakpointValue.Widescreen, BreakpointValue.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentAlignItemsWithValue OnTablet()
        {
            this.SetBreakpointValues(this.valueToApply, BreakpointValue.Tablet);
            return this;
        }

        /// <inheritdoc/>
        public IFluentAlignItemsWithValue OnTabletAndLarger()
        {
            this.SetBreakpointValues(this.valueToApply, BreakpointValue.Tablet, BreakpointValue.Desktop, BreakpointValue.Widescreen, BreakpointValue.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentAlignItemsWithValue OnTabletAndSmaller()
        {
            this.SetBreakpointValues(this.valueToApply, BreakpointValue.Mobile, BreakpointValue.Tablet);
            return this;
        }

        /// <inheritdoc/>
        public IFluentAlignItemsWithValue OnWidescreen()
        {
            this.SetBreakpointValues(this.valueToApply, BreakpointValue.Widescreen);
            return this;
        }

        /// <inheritdoc/>
        public IFluentAlignItemsWithValue OnWidescreenAndLarger()
        {
            this.SetBreakpointValues(this.valueToApply, BreakpointValue.Widescreen, BreakpointValue.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentAlignItemsWithValue OnWidescreenAndSmaller()
        {
            this.SetBreakpointValues(this.valueToApply, BreakpointValue.Mobile, BreakpointValue.Tablet, BreakpointValue.Desktop, BreakpointValue.Widescreen);
            return this;
        }

        private void SetBreakpointValues(ItemAlignmentValue value, params BreakpointValue[] breakpoints)
        {
            foreach (var breakpoint in breakpoints)
            {
                this.breakpointDictionary[breakpoint] = value;
            }
        }
    }
}

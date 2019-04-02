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

    public interface IFluentAlignItemsOnBreakpoint : IFluentAlignItems, IFluentReactive<IFluentAlignItemsOnBreakpointWithValue, ItemAlignmentValue>
    {
    }

    public interface IFluentAlignItemsOnBreakpointWithValue : IFluentAlignItemsOnBreakpoint
    {
    }
#pragma warning restore SA1600 // Elements should be documented

    /// <summary>
    /// Define how items are aligned along a flex-container's cross axis.
    /// </summary>
    public class FluentAlignItems : IFluentAlignItemsOnBreakpointWithValue
    {
        private readonly Dictionary<BreakpointValue, ItemAlignmentValue> breakpointDictionary = new Dictionary<BreakpointValue, ItemAlignmentValue>();

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
        public IFluentAlignItemsOnBreakpointWithValue OnDesktop(ItemAlignmentValue value)
        {
            this.SetBreakpointValues(value, BreakpointValue.Desktop);
            return this;
        }

        /// <inheritdoc/>
        public IFluentAlignItemsOnBreakpointWithValue OnDesktopAndLarger(ItemAlignmentValue value)
        {
            this.SetBreakpointValues(value, BreakpointValue.Desktop, BreakpointValue.Widescreen, BreakpointValue.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentAlignItemsOnBreakpointWithValue OnDesktopAndSmaller(ItemAlignmentValue value)
        {
            this.SetBreakpointValues(value, BreakpointValue.Mobile, BreakpointValue.Tablet, BreakpointValue.Desktop);
            return this;
        }

        /// <inheritdoc/>
        public IFluentAlignItemsOnBreakpointWithValue OnFullHD(ItemAlignmentValue value)
        {
            this.SetBreakpointValues(value, BreakpointValue.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentAlignItemsOnBreakpointWithValue OnFullHDAndSmaller(ItemAlignmentValue value)
        {
            this.SetBreakpointValues(value, BreakpointValue.Mobile, BreakpointValue.Tablet, BreakpointValue.Desktop, BreakpointValue.Widescreen, BreakpointValue.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentAlignItemsOnBreakpointWithValue OnMobile(ItemAlignmentValue value)
        {
            this.SetBreakpointValues(value, BreakpointValue.Mobile);
            return this;
        }

        /// <inheritdoc/>
        public IFluentAlignItemsOnBreakpointWithValue OnMobileAndLarger(ItemAlignmentValue value)
        {
            this.SetBreakpointValues(value, BreakpointValue.Mobile, BreakpointValue.Tablet, BreakpointValue.Desktop, BreakpointValue.Widescreen, BreakpointValue.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentAlignItemsOnBreakpointWithValue OnTablet(ItemAlignmentValue value)
        {
            this.SetBreakpointValues(value, BreakpointValue.Tablet);
            return this;
        }

        /// <inheritdoc/>
        public IFluentAlignItemsOnBreakpointWithValue OnTabletAndLarger(ItemAlignmentValue value)
        {
            this.SetBreakpointValues(value, BreakpointValue.Tablet, BreakpointValue.Desktop, BreakpointValue.Widescreen, BreakpointValue.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentAlignItemsOnBreakpointWithValue OnTabletAndSmaller(ItemAlignmentValue value)
        {
            this.SetBreakpointValues(value, BreakpointValue.Mobile, BreakpointValue.Tablet);
            return this;
        }

        /// <inheritdoc/>
        public IFluentAlignItemsOnBreakpointWithValue OnWidescreen(ItemAlignmentValue value)
        {
            this.SetBreakpointValues(value, BreakpointValue.Widescreen);
            return this;
        }

        /// <inheritdoc/>
        public IFluentAlignItemsOnBreakpointWithValue OnWidescreenAndLarger(ItemAlignmentValue value)
        {
            this.SetBreakpointValues(value, BreakpointValue.Widescreen, BreakpointValue.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentAlignItemsOnBreakpointWithValue OnWidescreenAndSmaller(ItemAlignmentValue value)
        {
            this.SetBreakpointValues(value, BreakpointValue.Mobile, BreakpointValue.Tablet, BreakpointValue.Desktop, BreakpointValue.Widescreen);
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

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

    public interface IFluentAlignItemsOnBreakpoint : IFluentAlignItems, IFluentReactive<IFluentAlignItemsOnBreakpointWithValue, ItemAlignment>
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
        private readonly Dictionary<Breakpoint, ItemAlignment> breakpointDictionary = new Dictionary<Breakpoint, ItemAlignment>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FluentAlignItems"/> class.
        /// </summary>
        public FluentAlignItems()
            : this(ItemAlignment.Stretch)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FluentAlignItems"/> class.
        /// </summary>
        /// <param name="initialValue">The initial value across all CSS media queries.</param>
        public FluentAlignItems(ItemAlignment initialValue)
        {
            foreach (var breakpoint in Enum.GetValues(typeof(Breakpoint)).Cast<Breakpoint>())
            {
                this.breakpointDictionary.Add(breakpoint, initialValue);
            }
        }

        /// <inheritdoc/>
        public IFluentAlignItemsOnBreakpointWithValue OnDesktop(ItemAlignment value)
        {
            this.SetBreakpointValues(value, Breakpoint.Desktop);
            return this;
        }

        /// <inheritdoc/>
        public IFluentAlignItemsOnBreakpointWithValue OnDesktopAndLarger(ItemAlignment value)
        {
            this.SetBreakpointValues(value, Breakpoint.Desktop, Breakpoint.Widescreen, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentAlignItemsOnBreakpointWithValue OnDesktopAndSmaller(ItemAlignment value)
        {
            this.SetBreakpointValues(value, Breakpoint.Mobile, Breakpoint.Tablet, Breakpoint.Desktop);
            return this;
        }

        /// <inheritdoc/>
        public IFluentAlignItemsOnBreakpointWithValue OnFullHD(ItemAlignment value)
        {
            this.SetBreakpointValues(value, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentAlignItemsOnBreakpointWithValue OnFullHDAndSmaller(ItemAlignment value)
        {
            this.SetBreakpointValues(value, Breakpoint.Mobile, Breakpoint.Tablet, Breakpoint.Desktop, Breakpoint.Widescreen, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentAlignItemsOnBreakpointWithValue OnMobile(ItemAlignment value)
        {
            this.SetBreakpointValues(value, Breakpoint.Mobile);
            return this;
        }

        /// <inheritdoc/>
        public IFluentAlignItemsOnBreakpointWithValue OnMobileAndLarger(ItemAlignment value)
        {
            this.SetBreakpointValues(value, Breakpoint.Mobile, Breakpoint.Tablet, Breakpoint.Desktop, Breakpoint.Widescreen, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentAlignItemsOnBreakpointWithValue OnTablet(ItemAlignment value)
        {
            this.SetBreakpointValues(value, Breakpoint.Tablet);
            return this;
        }

        /// <inheritdoc/>
        public IFluentAlignItemsOnBreakpointWithValue OnTabletAndLarger(ItemAlignment value)
        {
            this.SetBreakpointValues(value, Breakpoint.Tablet, Breakpoint.Desktop, Breakpoint.Widescreen, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentAlignItemsOnBreakpointWithValue OnTabletAndSmaller(ItemAlignment value)
        {
            this.SetBreakpointValues(value, Breakpoint.Mobile, Breakpoint.Tablet);
            return this;
        }

        /// <inheritdoc/>
        public IFluentAlignItemsOnBreakpointWithValue OnWidescreen(ItemAlignment value)
        {
            this.SetBreakpointValues(value, Breakpoint.Widescreen);
            return this;
        }

        /// <inheritdoc/>
        public IFluentAlignItemsOnBreakpointWithValue OnWidescreenAndLarger(ItemAlignment value)
        {
            this.SetBreakpointValues(value, Breakpoint.Widescreen, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentAlignItemsOnBreakpointWithValue OnWidescreenAndSmaller(ItemAlignment value)
        {
            this.SetBreakpointValues(value, Breakpoint.Mobile, Breakpoint.Tablet, Breakpoint.Desktop, Breakpoint.Widescreen);
            return this;
        }

        private void SetBreakpointValues(ItemAlignment value, params Breakpoint[] breakpoints)
        {
            foreach (var breakpoint in breakpoints)
            {
                this.breakpointDictionary[breakpoint] = value;
            }
        }
    }
}

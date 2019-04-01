// <copyright file="FluentAlignItems.cs" company="Derek Chasse">
// Copyright (c) Derek Chasse. All rights reserved.
// </copyright>

using System.Collections.Generic;

namespace Flexor
{
    public interface IFluentAlignItems
    {
    }

    public interface IFluentAlignItemsOnBreakpoint : IFluentAlignItems, IFluentReactive<IFluentAlignItemsOnBreakpointWithValue, ItemAxisAlignment>
    {
    }

    public interface IFluentAlignItemsOnBreakpointWithValue : IFluentAlignItemsOnBreakpoint
    {
    }

    public class FluentAlignItems : IFluentAlignItemsOnBreakpointWithValue
    {
        private readonly Dictionary<Breakpoint, ItemAxisAlignment> breakpointDictionary = new Dictionary<Breakpoint, ItemAxisAlignment>();

        public FluentAlignItems()
            : this(ItemAxisAlignment.Stretch)
        {
        }

        public FluentAlignItems(ItemAxisAlignment initialValue)
        {
            this.SetBreakpointValues(initialValue, Breakpoint.Mobile, Breakpoint.Tablet, Breakpoint.Desktop, Breakpoint.Widescreen, Breakpoint.FullHD);
        }

        /// <inheritdoc/>
        public IFluentAlignItemsOnBreakpointWithValue OnDesktop(ItemAxisAlignment value)
        {
            this.SetBreakpointValues(value, Breakpoint.Desktop);
            return this;
        }

        /// <inheritdoc/>
        public IFluentAlignItemsOnBreakpointWithValue OnDesktopAndLarger(ItemAxisAlignment value)
        {
            this.SetBreakpointValues(value, Breakpoint.Desktop, Breakpoint.Widescreen, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentAlignItemsOnBreakpointWithValue OnDesktopAndSmaller(ItemAxisAlignment value)
        {
            this.SetBreakpointValues(value, Breakpoint.Mobile, Breakpoint.Tablet, Breakpoint.Desktop);
            return this;
        }

        /// <inheritdoc/>
        public IFluentAlignItemsOnBreakpointWithValue OnFullHD(ItemAxisAlignment value)
        {
            this.SetBreakpointValues(value, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentAlignItemsOnBreakpointWithValue OnFullHDAndSmaller(ItemAxisAlignment value)
        {
            this.SetBreakpointValues(value, Breakpoint.Mobile, Breakpoint.Tablet, Breakpoint.Desktop, Breakpoint.Widescreen, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentAlignItemsOnBreakpointWithValue OnMobile(ItemAxisAlignment value)
        {
            this.SetBreakpointValues(value, Breakpoint.Mobile);
            return this;
        }

        /// <inheritdoc/>
        public IFluentAlignItemsOnBreakpointWithValue OnMobileAndLarger(ItemAxisAlignment value)
        {
            this.SetBreakpointValues(value, Breakpoint.Mobile, Breakpoint.Tablet, Breakpoint.Desktop, Breakpoint.Widescreen, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentAlignItemsOnBreakpointWithValue OnTablet(ItemAxisAlignment value)
        {
            this.SetBreakpointValues(value, Breakpoint.Tablet);
            return this;
        }

        /// <inheritdoc/>
        public IFluentAlignItemsOnBreakpointWithValue OnTabletAndLarger(ItemAxisAlignment value)
        {
            this.SetBreakpointValues(value, Breakpoint.Tablet, Breakpoint.Desktop, Breakpoint.Widescreen, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentAlignItemsOnBreakpointWithValue OnTabletAndSmaller(ItemAxisAlignment value)
        {
            this.SetBreakpointValues(value, Breakpoint.Mobile, Breakpoint.Tablet);
            return this;
        }

        /// <inheritdoc/>
        public IFluentAlignItemsOnBreakpointWithValue OnWidescreen(ItemAxisAlignment value)
        {
            this.SetBreakpointValues(value, Breakpoint.Widescreen);
            return this;
        }

        /// <inheritdoc/>
        public IFluentAlignItemsOnBreakpointWithValue OnWidescreenAndLarger(ItemAxisAlignment value)
        {
            this.SetBreakpointValues(value, Breakpoint.Widescreen, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentAlignItemsOnBreakpointWithValue OnWidescreenAndSmaller(ItemAxisAlignment value)
        {
            this.SetBreakpointValues(value, Breakpoint.Mobile, Breakpoint.Tablet, Breakpoint.Desktop, Breakpoint.Widescreen);
            return this;
        }

        private void SetBreakpointValues(ItemAxisAlignment value, params Breakpoint[] breakpoints)
        {
            foreach (var breakpoint in breakpoints)
            {
                this.breakpointDictionary[breakpoint] = value;
            }
        }
    }
}

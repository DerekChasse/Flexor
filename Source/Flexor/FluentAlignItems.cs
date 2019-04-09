// <copyright file="FluentAlignItems.cs" company="Derek Chasse">
// Copyright (c) Derek Chasse. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Flexor
{
#pragma warning disable SA1600 // Elements should be documented
    public interface IFluentAlignItems : ICssBacked
    {
    }

    public interface IFluentAlignItemsWithValue : IFluentAlignItems
    {
        IFluentAlignItemsWithValueOnBreakpoint Is(ItemAlignmentOption value);
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
        private readonly Dictionary<Breakpoint, ItemAlignmentOption> breakpointDictionary = new Dictionary<Breakpoint, ItemAlignmentOption>();
        private ItemAlignmentOption valueToApply;

        /// <summary>
        /// Initializes a new instance of the <see cref="FluentAlignItems"/> class.
        /// </summary>
        public FluentAlignItems()
            : this(ItemAlignmentOption.Stretch)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FluentAlignItems"/> class.
        /// </summary>
        /// <param name="initialValue">The initial value across all CSS media queries.</param>
        public FluentAlignItems(ItemAlignmentOption initialValue)
        {
            this.breakpointDictionary.Add(Breakpoint.Mobile, initialValue);
            this.breakpointDictionary.Add(Breakpoint.Tablet, initialValue);
            this.breakpointDictionary.Add(Breakpoint.Desktop, initialValue);
            this.breakpointDictionary.Add(Breakpoint.Widescreen, initialValue);
            this.breakpointDictionary.Add(Breakpoint.FullHD, initialValue);
        }

        /// <inheritdoc/>
        public string Class => this.BuildClass();

        /// <inheritdoc/>
        public string Style => string.Empty;

        /// <inheritdoc/>
        public IFluentAlignItemsWithValueOnBreakpoint Is(ItemAlignmentOption value)
        {
            this.valueToApply = value;
            return this;
        }

        /// <inheritdoc/>
        public IFluentAlignItemsWithValue OnDesktop()
        {
            this.SetBreakpointValues(this.valueToApply, Breakpoint.Desktop);
            return this;
        }

        /// <inheritdoc/>
        public IFluentAlignItemsWithValue OnDesktopAndLarger()
        {
            this.SetBreakpointValues(this.valueToApply, Breakpoint.Desktop, Breakpoint.Widescreen, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentAlignItemsWithValue OnDesktopAndSmaller()
        {
            this.SetBreakpointValues(this.valueToApply, Breakpoint.Mobile, Breakpoint.Tablet, Breakpoint.Desktop);
            return this;
        }

        /// <inheritdoc/>
        public IFluentAlignItemsWithValue OnFullHD()
        {
            this.SetBreakpointValues(this.valueToApply, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentAlignItemsWithValue OnFullHDAndSmaller()
        {
            this.SetBreakpointValues(this.valueToApply, Breakpoint.Mobile, Breakpoint.Tablet, Breakpoint.Desktop, Breakpoint.Widescreen, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentAlignItemsWithValue OnMobile()
        {
            this.SetBreakpointValues(this.valueToApply, Breakpoint.Mobile);
            return this;
        }

        /// <inheritdoc/>
        public IFluentAlignItemsWithValue OnMobileAndLarger()
        {
            this.SetBreakpointValues(this.valueToApply, Breakpoint.Mobile, Breakpoint.Tablet, Breakpoint.Desktop, Breakpoint.Widescreen, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentAlignItemsWithValue OnTablet()
        {
            this.SetBreakpointValues(this.valueToApply, Breakpoint.Tablet);
            return this;
        }

        /// <inheritdoc/>
        public IFluentAlignItemsWithValue OnTabletAndLarger()
        {
            this.SetBreakpointValues(this.valueToApply, Breakpoint.Tablet, Breakpoint.Desktop, Breakpoint.Widescreen, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentAlignItemsWithValue OnTabletAndSmaller()
        {
            this.SetBreakpointValues(this.valueToApply, Breakpoint.Mobile, Breakpoint.Tablet);
            return this;
        }

        /// <inheritdoc/>
        public IFluentAlignItemsWithValue OnWidescreen()
        {
            this.SetBreakpointValues(this.valueToApply, Breakpoint.Widescreen);
            return this;
        }

        /// <inheritdoc/>
        public IFluentAlignItemsWithValue OnWidescreenAndLarger()
        {
            this.SetBreakpointValues(this.valueToApply, Breakpoint.Widescreen, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentAlignItemsWithValue OnWidescreenAndSmaller()
        {
            this.SetBreakpointValues(this.valueToApply, Breakpoint.Mobile, Breakpoint.Tablet, Breakpoint.Desktop, Breakpoint.Widescreen);
            return this;
        }

        private string BuildClass()
        {
            StringBuilder builder = new StringBuilder();

            foreach (var kvp in this.breakpointDictionary)
            {
                builder.Append($"align-items{kvp.Key}{kvp.Value} ");
            }

            return builder.ToString();
        }

        private void SetBreakpointValues(ItemAlignmentOption value, params Breakpoint[] breakpoints)
        {
            foreach (var breakpoint in breakpoints)
            {
                this.breakpointDictionary[breakpoint] = value;
            }
        }
    }
}

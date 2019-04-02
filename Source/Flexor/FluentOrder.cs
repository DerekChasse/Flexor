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

    public interface IFluentOrderOnBreakpoint : IFluentOrder, IFluentReactive<IFluentOrderOnBreakpointWithValue, int?>
    {
    }

    public interface IFluentOrderOnBreakpointWithValue : IFluentOrderOnBreakpoint
    {
    }
#pragma warning restore SA1600 // Elements should be documented

    /// <summary>
    /// Define the order in which an item is displayed in a flex-container.
    /// </summary>
    public class FluentOrder : IFluentOrderOnBreakpointWithValue
    {
        private readonly Dictionary<BreakpointValue, int?> breakpointDictionary = new Dictionary<BreakpointValue, int?>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FluentOrder"/> class.
        /// </summary>
        public FluentOrder()
        {
            foreach (var item in Enum.GetValues(typeof(BreakpointValue)).Cast<BreakpointValue>())
            {
                this.breakpointDictionary.Add(item, default(int?));
            }
        }

        /// <inheritdoc/>
        public IFluentOrderOnBreakpointWithValue OnDesktop(int? value)
        {
            this.breakpointDictionary[BreakpointValue.Desktop] = value;
            return this;
        }

        /// <inheritdoc/>
        public IFluentOrderOnBreakpointWithValue OnDesktopAndLarger(int? value)
        {
            this.SetBreakpointValues(value, BreakpointValue.Desktop, BreakpointValue.Widescreen, BreakpointValue.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentOrderOnBreakpointWithValue OnDesktopAndSmaller(int? value)
        {
            this.SetBreakpointValues(value, BreakpointValue.Mobile, BreakpointValue.Tablet, BreakpointValue.Desktop);
            return this;
        }

        /// <inheritdoc/>
        public IFluentOrderOnBreakpointWithValue OnFullHD(int? value)
        {
            this.breakpointDictionary[BreakpointValue.FullHD] = value;
            return this;
        }

        /// <inheritdoc/>
        public IFluentOrderOnBreakpointWithValue OnFullHDAndSmaller(int? value)
        {
            this.SetBreakpointValues(value, BreakpointValue.Mobile, BreakpointValue.Tablet, BreakpointValue.Desktop, BreakpointValue.Widescreen, BreakpointValue.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentOrderOnBreakpointWithValue OnMobile(int? value)
        {
            this.breakpointDictionary[BreakpointValue.Mobile] = value;
            return this;
        }

        /// <inheritdoc/>
        public IFluentOrderOnBreakpointWithValue OnMobileAndLarger(int? value)
        {
            this.SetBreakpointValues(value, BreakpointValue.Mobile, BreakpointValue.Tablet, BreakpointValue.Desktop, BreakpointValue.Widescreen, BreakpointValue.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentOrderOnBreakpointWithValue OnTablet(int? value)
        {
            this.breakpointDictionary[BreakpointValue.Tablet] = value;
            return this;
        }

        /// <inheritdoc/>
        public IFluentOrderOnBreakpointWithValue OnTabletAndLarger(int? value)
        {
            this.SetBreakpointValues(value, BreakpointValue.Tablet, BreakpointValue.Desktop, BreakpointValue.Widescreen, BreakpointValue.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentOrderOnBreakpointWithValue OnTabletAndSmaller(int? value)
        {
            this.SetBreakpointValues(value, BreakpointValue.Mobile, BreakpointValue.Tablet);
            return this;
        }

        /// <inheritdoc/>
        public IFluentOrderOnBreakpointWithValue OnWidescreen(int? value)
        {
            this.breakpointDictionary[BreakpointValue.Widescreen] = value;
            return this;
        }

        /// <inheritdoc/>
        public IFluentOrderOnBreakpointWithValue OnWidescreenAndLarger(int? value)
        {
            this.SetBreakpointValues(value, BreakpointValue.Widescreen, BreakpointValue.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentOrderOnBreakpointWithValue OnWidescreenAndSmaller(int? value)
        {
            this.SetBreakpointValues(value, BreakpointValue.Mobile, BreakpointValue.Tablet, BreakpointValue.Desktop, BreakpointValue.Widescreen);
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

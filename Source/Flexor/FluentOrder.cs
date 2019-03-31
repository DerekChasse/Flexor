// <copyright file="FluentOrder.cs" company="Derek Chasse">
// Copyright (c) Derek Chasse. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Linq;

namespace Flexor
{
    public interface IFluentOrder
    {
    }

    public interface IFluentOrderOnBreakpoint : IFluentOrder, IFluentReactive<IFluentOrderOnBreakpointWithValue, int?>
    {
    }

    public interface IFluentOrderOnBreakpointWithValue : IFluentOrderOnBreakpoint
    {
    }

    public class FluentOrder : IFluentOrderOnBreakpointWithValue, IFluentOrderOnBreakpoint, IFluentOrder
    {
        private readonly Dictionary<Breakpoint, int?> breakpointDictionary = new Dictionary<Breakpoint, int?>();

        public FluentOrder()
        {
            foreach (var item in Enum.GetValues(typeof(Breakpoint)).Cast<Breakpoint>())
            {
                this.breakpointDictionary.Add(item, default);
            }
        }

        /// <inheritdoc/>
        public IFluentOrderOnBreakpointWithValue OnDesktop(int? value)
        {
            this.breakpointDictionary[Breakpoint.Desktop] = value;
            return this;
        }

        /// <inheritdoc/>
        public IFluentOrderOnBreakpointWithValue OnDesktopAndLarger(int? value)
        {
            this.SetBreakpointValues(value, Breakpoint.Desktop, Breakpoint.Widescreen, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentOrderOnBreakpointWithValue OnDesktopAndSmaller(int? value)
        {
            this.SetBreakpointValues(value, Breakpoint.Mobile, Breakpoint.Tablet, Breakpoint.Desktop);
            return this;
        }

        /// <inheritdoc/>
        public IFluentOrderOnBreakpointWithValue OnFullHD(int? value)
        {
            this.breakpointDictionary[Breakpoint.FullHD] = value;
            return this;
        }

        /// <inheritdoc/>
        public IFluentOrderOnBreakpointWithValue OnFullHDAndSmaller(int? value)
        {
            this.SetBreakpointValues(value, Breakpoint.Mobile, Breakpoint.Tablet, Breakpoint.Desktop, Breakpoint.Widescreen, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentOrderOnBreakpointWithValue OnMobile(int? value)
        {
            this.breakpointDictionary[Breakpoint.Mobile] = value;
            return this;
        }

        /// <inheritdoc/>
        public IFluentOrderOnBreakpointWithValue OnMobileAndLarger(int? value)
        {
            this.SetBreakpointValues(value, Breakpoint.Mobile, Breakpoint.Tablet, Breakpoint.Desktop, Breakpoint.Widescreen, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentOrderOnBreakpointWithValue OnTablet(int? value)
        {
            this.breakpointDictionary[Breakpoint.Tablet] = value;
            return this;
        }

        /// <inheritdoc/>
        public IFluentOrderOnBreakpointWithValue OnTabletAndLarger(int? value)
        {
            this.SetBreakpointValues(value, Breakpoint.Tablet, Breakpoint.Desktop, Breakpoint.Widescreen, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentOrderOnBreakpointWithValue OnTabletAndSmaller(int? value)
        {
            this.SetBreakpointValues(value, Breakpoint.Mobile, Breakpoint.Tablet);
            return this;
        }

        /// <inheritdoc/>
        public IFluentOrderOnBreakpointWithValue OnWidescreen(int? value)
        {
            this.breakpointDictionary[Breakpoint.Widescreen] = value;
            return this;
        }

        /// <inheritdoc/>
        public IFluentOrderOnBreakpointWithValue OnWidescreenAndLarger(int? value)
        {
            this.SetBreakpointValues(value, Breakpoint.Widescreen, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentOrderOnBreakpointWithValue OnWidescreenAndSmaller(int? value)
        {
            this.SetBreakpointValues(value, Breakpoint.Mobile, Breakpoint.Tablet, Breakpoint.Desktop, Breakpoint.Widescreen);
            return this;
        }

        private void SetBreakpointValues(int? value, params Breakpoint[] breakpoints)
        {
            foreach (var breakpoint in breakpoints)
            {
                this.breakpointDictionary[breakpoint] = value;
            }
        }
    }

    public static class Order
    {
        public static IFluentOrderOnBreakpointWithValue Is => new FluentOrder();

        public static IFluentOrder ForAll(int? value) => new FluentOrder().OnMobileAndLarger(value);
    }
}

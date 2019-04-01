// <copyright file="FluentDirection.cs" company="Derek Chasse">
// Copyright (c) Derek Chasse. All rights reserved.
// </copyright>

using System.Collections.Generic;

namespace Flexor
{
    public interface IFluentDirection
    {
    }

    public interface IFluentDirectionOnBreakpoint : IFluentDirection, IFluentReactive<IFluentDirectionOnBreakpointWithValue, FlexDirection>
    {
    }

    public interface IFluentDirectionOnBreakpointWithValue : IFluentDirectionOnBreakpoint
    {
    }

    public static class Direction
    {
        public static IFluentDirectionOnBreakpointWithValue Row => new FluentDirection(FlexDirection.Row);

        public static IFluentDirectionOnBreakpointWithValue Column => new FluentDirection(FlexDirection.Column);

        public static IFluentDirectionOnBreakpointWithValue RowReverse => new FluentDirection(FlexDirection.RowReverse);

        public static IFluentDirectionOnBreakpointWithValue ColumnReverse => new FluentDirection(FlexDirection.ColumnReverse);
    }

    public class FluentDirection : IFluentDirectionOnBreakpointWithValue
    {
        private Dictionary<Breakpoint, FlexDirection> breakpointDictionary;

        public FluentDirection()
            : this(FlexDirection.Row)
        {
        }

        public FluentDirection(FlexDirection initialValue)
        {
            this.SetBreakpointValues(initialValue, Breakpoint.Mobile, Breakpoint.Tablet, Breakpoint.Desktop, Breakpoint.Widescreen, Breakpoint.FullHD);
        }

        /// <inheritdoc/>
        public IFluentDirectionOnBreakpointWithValue OnDesktop(FlexDirection value)
        {
            this.breakpointDictionary[Breakpoint.Desktop] = value;
            return this;
        }

        /// <inheritdoc/>
        public IFluentDirectionOnBreakpointWithValue OnDesktopAndLarger(FlexDirection value)
        {
            this.SetBreakpointValues(value, Breakpoint.Desktop, Breakpoint.Widescreen, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentDirectionOnBreakpointWithValue OnDesktopAndSmaller(FlexDirection value)
        {
            this.SetBreakpointValues(value, Breakpoint.Mobile, Breakpoint.Tablet, Breakpoint.Desktop);
            return this;
        }

        /// <inheritdoc/>
        public IFluentDirectionOnBreakpointWithValue OnFullHD(FlexDirection value)
        {
            this.breakpointDictionary[Breakpoint.FullHD] = value;
            return this;
        }

        /// <inheritdoc/>
        public IFluentDirectionOnBreakpointWithValue OnFullHDAndSmaller(FlexDirection value)
        {
            this.SetBreakpointValues(value, Breakpoint.Mobile, Breakpoint.Tablet, Breakpoint.Desktop, Breakpoint.Widescreen, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentDirectionOnBreakpointWithValue OnMobile(FlexDirection value)
        {
            this.breakpointDictionary[Breakpoint.Mobile] = value;
            return this;
        }

        /// <inheritdoc/>
        public IFluentDirectionOnBreakpointWithValue OnMobileAndLarger(FlexDirection value)
        {
            this.SetBreakpointValues(value, Breakpoint.Mobile, Breakpoint.Tablet, Breakpoint.Desktop, Breakpoint.Widescreen, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentDirectionOnBreakpointWithValue OnTablet(FlexDirection value)
        {
            this.breakpointDictionary[Breakpoint.Tablet] = value;
            return this;
        }

        /// <inheritdoc/>
        public IFluentDirectionOnBreakpointWithValue OnTabletAndLarger(FlexDirection value)
        {
            this.SetBreakpointValues(value, Breakpoint.Tablet, Breakpoint.Desktop, Breakpoint.Widescreen, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentDirectionOnBreakpointWithValue OnTabletAndSmaller(FlexDirection value)
        {
            this.SetBreakpointValues(value, Breakpoint.Mobile, Breakpoint.Tablet);
            return this;
        }

        /// <inheritdoc/>
        public IFluentDirectionOnBreakpointWithValue OnWidescreen(FlexDirection value)
        {
            this.breakpointDictionary[Breakpoint.Widescreen] = value;
            return this;
        }

        /// <inheritdoc/>
        public IFluentDirectionOnBreakpointWithValue OnWidescreenAndLarger(FlexDirection value)
        {
            this.SetBreakpointValues(value, Breakpoint.Widescreen, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentDirectionOnBreakpointWithValue OnWidescreenAndSmaller(FlexDirection value)
        {
            this.SetBreakpointValues(value, Breakpoint.Mobile, Breakpoint.Tablet, Breakpoint.Desktop, Breakpoint.Widescreen);
            return this;
        }

        private void SetBreakpointValues(FlexDirection value, params Breakpoint[] breakpoints)
        {
            foreach (var breakpoint in breakpoints)
            {
                this.breakpointDictionary[breakpoint] = value;
            }
        }
    }
}

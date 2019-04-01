// <copyright file="FluentDirection.cs" company="Derek Chasse">
// Copyright (c) Derek Chasse. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Linq;

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
            this.InitializeBreakpointDictionary(initialValue);
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
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public IFluentDirectionOnBreakpointWithValue OnDesktopAndSmaller(FlexDirection value)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
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
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public IFluentDirectionOnBreakpointWithValue OnTabletAndSmaller(FlexDirection value)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public IFluentDirectionOnBreakpointWithValue OnWidescreenAndSmaller(FlexDirection value)
        {
            throw new NotImplementedException();
        }

        private void InitializeBreakpointDictionary(FlexDirection initialValue)
        {
            this.breakpointDictionary = Enum.GetValues(typeof(Breakpoint)).Cast<Breakpoint>().ToDictionary(breakpoint => breakpoint, x => initialValue);
        }
    }
}

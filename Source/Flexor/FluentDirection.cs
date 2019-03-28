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

    public interface IFluentDirectionOnBreakpoint : IFluentDirection
    {
        IFluentDirectionOnBreakpointWithValue OnMobile(FlexDirection value);

        IFluentDirectionOnBreakpointWithValue OnTablet(FlexDirection value);

        IFluentDirectionOnBreakpointWithValue OnDesktop(FlexDirection value);

        IFluentDirectionOnBreakpointWithValue OnWidescreen(FlexDirection value);

        IFluentDirectionOnBreakpointWithValue OnFullHD(FlexDirection value);
    }

    public interface IFluentDirectionOnBreakpointWithValue : IFluentDirectionOnBreakpoint
    {
    }

    public class FluentDirection : IFluentDirectionOnBreakpointWithValue, IFluentDirectionOnBreakpoint, IFluentDirection
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

        public IFluentDirectionOnBreakpointWithValue OnDesktop(FlexDirection value)
        {
            this.breakpointDictionary[Breakpoint.Desktop] = value;
            return this;
        }

        public IFluentDirectionOnBreakpointWithValue OnFullHD(FlexDirection value)
        {
            this.breakpointDictionary[Breakpoint.FullHD] = value;
            return this;
        }

        public IFluentDirectionOnBreakpointWithValue OnMobile(FlexDirection value)
        {
            this.breakpointDictionary[Breakpoint.Mobile] = value;
            return this;
        }

        public IFluentDirectionOnBreakpointWithValue OnTablet(FlexDirection value)
        {
            this.breakpointDictionary[Breakpoint.Tablet] = value;
            return this;
        }

        public IFluentDirectionOnBreakpointWithValue OnWidescreen(FlexDirection value)
        {
            this.breakpointDictionary[Breakpoint.Widescreen] = value;
            return this;
        }

        private void InitializeBreakpointDictionary(FlexDirection initialValue)
        {
            this.breakpointDictionary = Enum.GetValues(typeof(Breakpoint)).Cast<Breakpoint>().ToDictionary(breakpoint => breakpoint, x => initialValue);
        }
    }

    public static class Direction
    {
        public static IFluentDirectionOnBreakpointWithValue Row => new FluentDirection(FlexDirection.Row);

        public static IFluentDirectionOnBreakpointWithValue Column => new FluentDirection(FlexDirection.Column);

        public static IFluentDirectionOnBreakpointWithValue RowReverse => new FluentDirection(FlexDirection.RowReverse);

        public static IFluentDirectionOnBreakpointWithValue ColumnReverse => new FluentDirection(FlexDirection.ColumnReverse);
    }

}

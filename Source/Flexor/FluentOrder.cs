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

    public interface IFluentOrderOnBreakpoint : IFluentOrder
    {
        IFluentOrderOnBreakpointWithValue OnMobile(int? value);

        IFluentOrderOnBreakpointWithValue OnTablet(int? value);

        IFluentOrderOnBreakpointWithValue OnDesktop(int? value);

        IFluentOrderOnBreakpointWithValue OnWidescreen(int? value);

        IFluentOrderOnBreakpointWithValue OnFullHD(int? value);
    }

    public interface IFluentOrderOnBreakpointWithValue : IFluentOrderOnBreakpoint
    {
    }

    public class FluentOrder : IFluentOrderOnBreakpointWithValue, IFluentOrderOnBreakpoint, IFluentOrder
    {
        private Dictionary<Breakpoint, int?> breakpointDictionary;

        public FluentOrder()
        {
            this.breakpointDictionary = Enum.GetValues(typeof(Breakpoint)).Cast<Breakpoint>().ToDictionary(breakpoint => breakpoint, x => default(int?));
        }

        public IFluentOrderOnBreakpointWithValue OnDesktop(int? value)
        {
            this.breakpointDictionary[Breakpoint.Desktop] = value;
            return this;
        }

        public IFluentOrderOnBreakpointWithValue OnFullHD(int? value)
        {
            this.breakpointDictionary[Breakpoint.FullHD] = value;
            return this;
        }

        public IFluentOrderOnBreakpointWithValue OnMobile(int? value)
        {
            this.breakpointDictionary[Breakpoint.Mobile] = value;
            return this;
        }

        public IFluentOrderOnBreakpointWithValue OnTablet(int? value)
        {
            this.breakpointDictionary[Breakpoint.Tablet] = value;
            return this;
        }

        public IFluentOrderOnBreakpointWithValue OnWidescreen(int? value)
        {
            this.breakpointDictionary[Breakpoint.Widescreen] = value;
            return this;
        }
    }

    public static class Order
    {
        public static IFluentOrderOnBreakpointWithValue OnMobile(int? value) => new FluentOrder().OnMobile(value);

        public static IFluentOrderOnBreakpointWithValue OnTablet(int? value) => new FluentOrder().OnTablet(value);

        public static IFluentOrderOnBreakpointWithValue OnDesktop(int? value) => new FluentOrder().OnDesktop(value);

        public static IFluentOrderOnBreakpointWithValue OnWidescreen(int? value) => new FluentOrder().OnWidescreen(value);

        public static IFluentOrderOnBreakpointWithValue OnFullHD(int? value) => new FluentOrder().OnFullHD(value);

    }
}

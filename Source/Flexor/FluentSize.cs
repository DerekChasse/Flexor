// <copyright file="FluentSize.cs" company="Derek Chasse">
// Copyright (c) Derek Chasse. All rights reserved.
// </copyright>

using System;

namespace Flexor
{
    public interface IFluentSize
    {
    }

    public interface IFluentSizeOnBreakpoint : IFluentSize
    {
        IFluentSizeWithModifier OnMobile { get; }

        IFluentSizeWithModifier OnTablet { get; }

        IFluentSizeWithModifier OnDesktop { get; }

        IFluentSizeWithModifier OnWidescreen { get; }

        IFluentSizeWithModifier OnFullHD { get; }
    }

    public interface IFluentSizeWithValue : IFluentSize
    {
        IFluentSizeOnBreakpoint Pixels(int value);

        IFluentSizeOnBreakpoint Percent(int value);

        IFluentSizeOnBreakpoint ViewportWidth(int value);

        IFluentSizeOnBreakpoint ViewportHeight(int value);
    }

    public interface IFluentSizeWithModifier : IFluentSize
    {
        IFluentSizeOnBreakpointWithModifier Grow { get; }

        IFluentSizeOnBreakpointWithModifier Shrink { get; }

        IFluentSizeOnBreakpointWithModifier Initial { get; }

        IFluentSizeOnBreakpointWithModifier Auto { get; }

        IFluentSizeOnBreakpointWithModifier NoGrow { get; }

        IFluentSizeOnBreakpointWithModifier NoShrink { get; }
    }

    public interface IFluentSizeOnBreakpointWithModifier : IFluentSize
    {
    }

    public interface IFluentSizeOnBreakpointWithValueAndModifier : IFluentSizeOnBreakpoint, IFluentSizeWithModifier, IFluentSizeWithValue
    {
    }

    public static class Size
    {
        public static IFluentSizeOnBreakpointWithValueAndModifier Is => new FluentSize();
    }

    public class FluentSize : IFluentSizeOnBreakpointWithValueAndModifier
    {
        public IFluentSizeWithModifier OnMobile => throw new NotImplementedException();

        public IFluentSizeWithModifier OnTablet => throw new NotImplementedException();

        public IFluentSizeWithModifier OnDesktop => throw new NotImplementedException();

        public IFluentSizeWithModifier OnWidescreen => throw new NotImplementedException();

        public IFluentSizeWithModifier OnFullHD => throw new NotImplementedException();

        public IFluentSizeOnBreakpointWithModifier Grow => throw new NotImplementedException();

        public IFluentSizeOnBreakpointWithModifier Shrink => throw new NotImplementedException();

        public IFluentSizeOnBreakpointWithModifier Initial => throw new NotImplementedException();

        public IFluentSizeOnBreakpointWithModifier Auto => throw new NotImplementedException();

        public IFluentSizeOnBreakpointWithModifier NoGrow => throw new NotImplementedException();

        public IFluentSizeOnBreakpointWithModifier NoShrink => throw new NotImplementedException();

        public IFluentSizeOnBreakpoint Percent(int value)
        {
            throw new NotImplementedException();
        }

        public IFluentSizeOnBreakpoint Pixels(int value)
        {
            throw new NotImplementedException();
        }

        public IFluentSizeOnBreakpoint ViewportHeight(int value)
        {
            throw new NotImplementedException();
        }

        public IFluentSizeOnBreakpoint ViewportWidth(int value)
        {
            throw new NotImplementedException();
        }
    }
}

// <copyright file="FluentSize.cs" company="Derek Chasse">
// Copyright (c) Derek Chasse. All rights reserved.
// </copyright>

using System;

namespace Flexor
{
    public interface IFluentSize
    {
    }

    public interface IFluentSizeOnBreakpoint : IFluentReactive<IFluentSizeWithValueAndModifier>
    {
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

    public interface IFluentSizeWithValueAndModifier : IFluentSizeWithValue, IFluentSizeWithModifier
    {

    }

    public interface IFluentSizeOnBreakpointWithModifier : IFluentSize, IFluentSizeOnBreakpoint, IFluentSizeWithModifier
    {
    }

    public interface IFluentSizeOnBreakpointWithValue : IFluentSize, IFluentSizeOnBreakpoint, IFluentSizeWithValue
    {
    }

    public interface IFluentSizeOnBreakpointWithValueAndModifier : IFluentSizeOnBreakpointWithValue,
                                                                   IFluentSizeOnBreakpointWithModifier,
                                                                   IFluentSizeWithValueAndModifier,
                                                                   IFluentSizeOnBreakpoint,
                                                                   IFluentSizeWithValue,
                                                                   IFluentSizeWithModifier,
                                                                   IFluentSize
    {

    }

    public class FluentSize : IFluentSizeOnBreakpointWithValueAndModifier
    {
        public IFluentSizeOnBreakpointWithModifier Grow => throw new NotImplementedException();

        public IFluentSizeOnBreakpointWithModifier Shrink => throw new NotImplementedException();

        public IFluentSizeOnBreakpointWithModifier Initial => throw new NotImplementedException();

        public IFluentSizeOnBreakpointWithModifier Auto => throw new NotImplementedException();

        public IFluentSizeOnBreakpointWithModifier NoGrow => throw new NotImplementedException();

        public IFluentSizeOnBreakpointWithModifier NoShrink => throw new NotImplementedException();

        public IFluentSizeWithValueAndModifier OnDesktop()
        {
            throw new NotImplementedException();
        }

        public IFluentSizeWithValueAndModifier OnDesktopAndLarger()
        {
            throw new NotImplementedException();
        }

        public IFluentSizeWithValueAndModifier OnDesktopAndSmaller()
        {
            throw new NotImplementedException();
        }

        public IFluentSizeWithValueAndModifier OnFullHD()
        {
            throw new NotImplementedException();
        }

        public IFluentSizeWithValueAndModifier OnFullHDAndSmaller()
        {
            throw new NotImplementedException();
        }

        public IFluentSizeWithValueAndModifier OnMobile()
        {
            throw new NotImplementedException();
        }

        public IFluentSizeWithValueAndModifier OnMobileAndLarger()
        {
            throw new NotImplementedException();
        }

        public IFluentSizeWithValueAndModifier OnTablet()
        {
            throw new NotImplementedException();
        }

        public IFluentSizeWithValueAndModifier OnTabletAndLarger()
        {
            throw new NotImplementedException();
        }

        public IFluentSizeWithValueAndModifier OnTabletAndSmaller()
        {
            throw new NotImplementedException();
        }

        public IFluentSizeWithValueAndModifier OnWidescreen()
        {
            throw new NotImplementedException();
        }

        public IFluentSizeWithValueAndModifier OnWidescreenAndLarger()
        {
            throw new NotImplementedException();
        }

        public IFluentSizeWithValueAndModifier OnWidescreenAndSmaller()
        {
            throw new NotImplementedException();
        }

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

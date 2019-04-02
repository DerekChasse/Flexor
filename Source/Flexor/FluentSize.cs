// <copyright file="FluentSize.cs" company="Derek Chasse">
// Copyright (c) Derek Chasse. All rights reserved.
// </copyright>

using System;

namespace Flexor
{
#pragma warning disable SA1600 // Elements should be documented
    public interface IFluentSize
    {
    }

    public interface IFluentSizeOnBreakpoint : IFluentReactive<IFluentSizeOnBreakpointWithValue>
    {
    }

    public interface IFluentSizeOnBreakpointWithValue : IFluentSize
    {
        IFluentSizeOnBreakpoint Pixels(int value);

        IFluentSizeOnBreakpoint Percent(int value);

        IFluentSizeOnBreakpoint Element(decimal value);

        IFluentSizeOnBreakpoint ViewportWidth(int value);

        IFluentSizeOnBreakpoint ViewportHeight(int value);
    }
#pragma warning restore SA1600 // Elements should be documented

    public class FluentSize : IFluentSizeOnBreakpointWithValue
    {
        public IFluentSizeOnBreakpoint Element(decimal value)
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

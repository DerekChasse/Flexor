// <copyright file="FluentResizability.cs" company="Derek Chasse">
// Copyright (c) Derek Chasse. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Linq;

namespace Flexor
{
#pragma warning disable SA1600 // Elements should be documented
    public interface IFluentResizability
    {
    }

    public interface IFluentResizabilityOnBreakpoint : IFluentReactive<IFluentResizabilityOnBreakpointWithValue>, IFluentResizability
    {
    }

    public interface IFluentResizabilityOnBreakpointWithValue : IFluentResizabilityOnBreakpoint
    {
        IFluentResizabilityOnBreakpoint Auto();

        IFluentResizabilityOnBreakpoint Initial();

        IFluentResizabilityOnBreakpoint Grow();

        IFluentResizabilityOnBreakpoint Shrink();

        IFluentResizabilityOnBreakpoint NoGrow();

        IFluentResizabilityOnBreakpoint NoShrink();
    }
#pragma warning restore SA1600 // Elements should be documented

    public class FluentResizability : IFluentResizabilityOnBreakpointWithValue
    {
        private readonly Dictionary<BreakpointValue, ResizabilityValue> breakpointDictionary = new Dictionary<BreakpointValue, ResizabilityValue>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FluentResizability"/> class.
        /// </summary>
        public FluentResizability()
            : this(ResizabilityValue.Auto)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FluentResizability"/> class.
        /// </summary>
        /// <param name="initialValue">The initial <see cref="ResizabilityValue"/> across all media query breakpoints.</param>
        public FluentResizability(ResizabilityValue initialValue)
        {
            foreach (var breakpoint in Enum.GetValues(typeof(BreakpointValue)).Cast<BreakpointValue>())
            {
                this.breakpointDictionary.Add(breakpoint, initialValue);
            }
        }

        public IFluentResizabilityOnBreakpoint Auto()
        {
            throw new NotImplementedException();
        }

        public IFluentResizabilityOnBreakpoint Grow()
        {
            throw new NotImplementedException();
        }

        public IFluentResizabilityOnBreakpoint Shrink()
        {
            throw new NotImplementedException();
        }

        public IFluentResizabilityOnBreakpoint Initial()
        {
            throw new NotImplementedException();
        }

        public IFluentResizabilityOnBreakpoint NoGrow()
        {
            throw new NotImplementedException();
        }

        public IFluentResizabilityOnBreakpoint NoShrink()
        {
            throw new NotImplementedException();
        }

        public IFluentResizabilityOnBreakpointWithValue OnDesktop()
        {
            throw new NotImplementedException();
        }

        public IFluentResizabilityOnBreakpointWithValue OnDesktopAndLarger()
        {
            throw new NotImplementedException();
        }

        public IFluentResizabilityOnBreakpointWithValue OnDesktopAndSmaller()
        {
            throw new NotImplementedException();
        }

        public IFluentResizabilityOnBreakpointWithValue OnFullHD()
        {
            throw new NotImplementedException();
        }

        public IFluentResizabilityOnBreakpointWithValue OnFullHDAndSmaller()
        {
            throw new NotImplementedException();
        }

        public IFluentResizabilityOnBreakpointWithValue OnMobile()
        {
            throw new NotImplementedException();
        }

        public IFluentResizabilityOnBreakpointWithValue OnMobileAndLarger()
        {
            throw new NotImplementedException();
        }

        public IFluentResizabilityOnBreakpointWithValue OnTablet()
        {
            throw new NotImplementedException();
        }

        public IFluentResizabilityOnBreakpointWithValue OnTabletAndLarger()
        {
            throw new NotImplementedException();
        }

        public IFluentResizabilityOnBreakpointWithValue OnTabletAndSmaller()
        {
            throw new NotImplementedException();
        }

        public IFluentResizabilityOnBreakpointWithValue OnWidescreen()
        {
            throw new NotImplementedException();
        }

        public IFluentResizabilityOnBreakpointWithValue OnWidescreenAndLarger()
        {
            throw new NotImplementedException();
        }

        public IFluentResizabilityOnBreakpointWithValue OnWidescreenAndSmaller()
        {
            throw new NotImplementedException();
        }
    }
}

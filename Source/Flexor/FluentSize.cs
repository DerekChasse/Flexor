// <copyright file="FluentSize.cs" company="Derek Chasse">
// Copyright (c) Derek Chasse. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Linq;

namespace Flexor
{
#pragma warning disable SA1600 // Elements should be documented
    public interface IFluentSize
    {
    }

    public interface IFluentSizeWithValue : IFluentSize
    {
        IFluentSizeWithValueOnBreakpoint IsPixels(int value);

        IFluentSizeWithValueOnBreakpoint IsPercent(int value);

        IFluentSizeWithValueOnBreakpoint IsElement(decimal value);

        IFluentSizeWithValueOnBreakpoint IsViewportWidth(int value);

        IFluentSizeWithValueOnBreakpoint IsViewportHeight(int value);
    }

    public interface ISizeSetValue
    {
        void SetSize(decimal value, SizeUnit unit);
    }

    public interface IFluentSizeWithValueOnBreakpoint : IFluentReactive<IFluentSizeWithValue>, IFluentSize
    {
    }

#pragma warning restore SA1600 // Elements should be documented

    /// <summary>
    /// Define the size of an item displayed in a flex-container.
    /// </summary>
    public class FluentSize : IFluentSizeWithValue, IFluentSizeWithValueOnBreakpoint, ISizeSetValue
    {
        private readonly Dictionary<Breakpoint, SizingUnit> breakpointDictionary = new Dictionary<Breakpoint, SizingUnit>();
        private SizingUnit valueToApply;

        /// <summary>
        /// Initializes a new instance of the <see cref="FluentSize"/> class.
        /// </summary>
        public FluentSize()
        {
            foreach (var breakpoint in Enum.GetValues(typeof(Breakpoint)).Cast<Breakpoint>())
            {
                this.breakpointDictionary.Add(breakpoint, new SizingUnit());
            }
        }

        internal FluentSize(decimal value, SizeUnit unit)
            : this()
        {
            this.SetSize(value, unit);

            this.SetBreakpointValues(this.valueToApply, Breakpoint.Mobile, Breakpoint.Tablet, Breakpoint.Desktop, Breakpoint.Widescreen, Breakpoint.FullHD);
        }

        /// <inheritdoc/>
        public IFluentSizeWithValueOnBreakpoint IsElement(decimal value)
        {
            this.SetSize(value, SizeUnit.Element);
            return this;
        }

        /// <inheritdoc/>
        public IFluentSizeWithValueOnBreakpoint IsPercent(int value)
        {
            this.SetSize(value, SizeUnit.Percent);
            return this;
        }

        /// <inheritdoc/>
        public IFluentSizeWithValueOnBreakpoint IsPixels(int value)
        {
            this.SetSize(value, SizeUnit.Pixels);
            return this;
        }

        /// <inheritdoc/>
        public IFluentSizeWithValueOnBreakpoint IsViewportHeight(int value)
        {
            this.SetSize(value, SizeUnit.ViewportHeight);
            return this;
        }

        /// <inheritdoc/>
        public IFluentSizeWithValueOnBreakpoint IsViewportWidth(int value)
        {
            this.SetSize(value, SizeUnit.ViewportWidth);
            return this;
        }

        /// <inheritdoc/>
        public IFluentSizeWithValue OnDesktop()
        {
            this.breakpointDictionary[Breakpoint.Desktop] = this.valueToApply;
            return this;
        }

        /// <inheritdoc/>
        public IFluentSizeWithValue OnDesktopAndLarger()
        {
            this.SetBreakpointValues(this.valueToApply, Breakpoint.Desktop, Breakpoint.Widescreen, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentSizeWithValue OnDesktopAndSmaller()
        {
            this.SetBreakpointValues(this.valueToApply, Breakpoint.Mobile, Breakpoint.Tablet, Breakpoint.Desktop);
            return this;
        }

        /// <inheritdoc/>
        public IFluentSizeWithValue OnFullHD()
        {
            this.breakpointDictionary[Breakpoint.FullHD] = this.valueToApply;
            return this;
        }

        /// <inheritdoc/>
        public IFluentSizeWithValue OnFullHDAndSmaller()
        {
            this.SetBreakpointValues(this.valueToApply, Breakpoint.Mobile, Breakpoint.Tablet, Breakpoint.Desktop, Breakpoint.Widescreen, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentSizeWithValue OnMobile()
        {
            this.breakpointDictionary[Breakpoint.Mobile] = this.valueToApply;
            return this;
        }

        /// <inheritdoc/>
        public IFluentSizeWithValue OnMobileAndLarger()
        {
            this.SetBreakpointValues(this.valueToApply, Breakpoint.Mobile, Breakpoint.Tablet, Breakpoint.Desktop, Breakpoint.Widescreen, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentSizeWithValue OnTablet()
        {
            this.breakpointDictionary[Breakpoint.Tablet] = this.valueToApply;
            return this;
        }

        /// <inheritdoc/>
        public IFluentSizeWithValue OnTabletAndLarger()
        {
            this.SetBreakpointValues(this.valueToApply, Breakpoint.Tablet, Breakpoint.Desktop, Breakpoint.Widescreen, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentSizeWithValue OnTabletAndSmaller()
        {
            this.SetBreakpointValues(this.valueToApply, Breakpoint.Mobile, Breakpoint.Tablet);
            return this;
        }

        /// <inheritdoc/>
        public IFluentSizeWithValue OnWidescreen()
        {
            this.breakpointDictionary[Breakpoint.Widescreen] = this.valueToApply;
            return this;
        }

        /// <inheritdoc/>
        public IFluentSizeWithValue OnWidescreenAndLarger()
        {
            this.SetBreakpointValues(this.valueToApply, Breakpoint.Widescreen, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentSizeWithValue OnWidescreenAndSmaller()
        {
            this.SetBreakpointValues(this.valueToApply, Breakpoint.Mobile, Breakpoint.Tablet, Breakpoint.Desktop, Breakpoint.Widescreen);
            return this;
        }

        /// <inheritdoc/>
        public void SetSize(decimal value, SizeUnit unit)
        {
            this.valueToApply = new SizingUnit { Value = value, Unit = unit };
        }

        private void SetBreakpointValues(SizingUnit value, params Breakpoint[] breakpoints)
        {
            foreach (var breakpoint in breakpoints)
            {
                this.breakpointDictionary[breakpoint] = value;
            }
        }

        private class SizingUnit
        {
            public decimal Value { get; set; }

            public SizeUnit Unit { get; set; }
        }
    }
}

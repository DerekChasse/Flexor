// <copyright file="FluentOrder.cs" company="Derek Chasse">
// Copyright (c) Derek Chasse. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Flexor
{
#pragma warning disable SA1600 // Elements should be documented
    public interface IFluentOrder : ICssClassBacked
    {
    }

    public interface IFluentOrderWithValue : IFluentOrder
    {
        ////TODO: Add Is0 through Is12
        ////TODO: Add IsFirst / IsLast

        IFluentOrderWithValueOnBreakpoint Is(int value);
    }

    public interface IFluentOrderWithValueOnBreakpoint : IFluentReactive<IFluentOrderWithValue>, IFluentOrder
    {
    }
#pragma warning restore SA1600 // Elements should be documented

    /// <summary>
    /// Define the order in which an item is displayed in a flex-container.
    /// </summary>
    public class FluentOrder : IFluentOrderWithValueOnBreakpoint, IFluentOrderWithValue
    {
        private readonly Dictionary<Breakpoint, int?> breakpointDictionary = new Dictionary<Breakpoint, int?>();
        private int valueToApply;

        /// <summary>
        /// Initializes a new instance of the <see cref="FluentOrder"/> class.
        /// </summary>
        public FluentOrder()
            : this(default)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FluentOrder"/> class.
        /// </summary>
        /// <param name="initialValue">The default item order.</param>
        public FluentOrder(int? initialValue)
        {
            this.breakpointDictionary.Add(Breakpoint.Mobile, initialValue);
            this.breakpointDictionary.Add(Breakpoint.Tablet, initialValue);
            this.breakpointDictionary.Add(Breakpoint.Desktop, initialValue);
            this.breakpointDictionary.Add(Breakpoint.Widescreen, initialValue);
            this.breakpointDictionary.Add(Breakpoint.FullHD, initialValue);
        }

        /// <inheritdoc/>
        public string Class => this.BuildClass();

        /// <inheritdoc/>
        public IFluentOrderWithValueOnBreakpoint Is(int value)
        {
            this.valueToApply = value;
            return this;
        }

        /// <inheritdoc/>
        public IFluentOrderWithValue OnDesktop()
        {
            this.breakpointDictionary[Breakpoint.Desktop] = this.valueToApply;
            return this;
        }

        /// <inheritdoc/>
        public IFluentOrderWithValue OnDesktopAndLarger()
        {
            this.SetBreakpointValues(this.valueToApply, Breakpoint.Desktop, Breakpoint.Widescreen, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentOrderWithValue OnDesktopAndSmaller()
        {
            this.SetBreakpointValues(this.valueToApply, Breakpoint.Mobile, Breakpoint.Tablet, Breakpoint.Desktop);
            return this;
        }

        /// <inheritdoc/>
        public IFluentOrderWithValue OnFullHD()
        {
            this.breakpointDictionary[Breakpoint.FullHD] = this.valueToApply;
            return this;
        }

        /// <inheritdoc/>
        public IFluentOrderWithValue OnFullHDAndSmaller()
        {
            this.SetBreakpointValues(this.valueToApply, Breakpoint.Mobile, Breakpoint.Tablet, Breakpoint.Desktop, Breakpoint.Widescreen, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentOrderWithValue OnMobile()
        {
            this.breakpointDictionary[Breakpoint.Mobile] = this.valueToApply;
            return this;
        }

        /// <inheritdoc/>
        public IFluentOrderWithValue OnMobileAndLarger()
        {
            this.SetBreakpointValues(this.valueToApply, Breakpoint.Mobile, Breakpoint.Tablet, Breakpoint.Desktop, Breakpoint.Widescreen, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentOrderWithValue OnTablet()
        {
            this.breakpointDictionary[Breakpoint.Tablet] = this.valueToApply;
            return this;
        }

        /// <inheritdoc/>
        public IFluentOrderWithValue OnTabletAndLarger()
        {
            this.SetBreakpointValues(this.valueToApply, Breakpoint.Tablet, Breakpoint.Desktop, Breakpoint.Widescreen, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentOrderWithValue OnTabletAndSmaller()
        {
            this.SetBreakpointValues(this.valueToApply, Breakpoint.Mobile, Breakpoint.Tablet);
            return this;
        }

        /// <inheritdoc/>
        public IFluentOrderWithValue OnWidescreen()
        {
            this.breakpointDictionary[Breakpoint.Widescreen] = this.valueToApply;
            return this;
        }

        /// <inheritdoc/>
        public IFluentOrderWithValue OnWidescreenAndLarger()
        {
            this.SetBreakpointValues(this.valueToApply, Breakpoint.Widescreen, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentOrderWithValue OnWidescreenAndSmaller()
        {
            this.SetBreakpointValues(this.valueToApply, Breakpoint.Mobile, Breakpoint.Tablet, Breakpoint.Desktop, Breakpoint.Widescreen);
            return this;
        }

        private string BuildClass()
        {
            StringBuilder builder = new StringBuilder();

            foreach (var kvp in this.breakpointDictionary)
            {
                if (kvp.Value.HasValue)
                {
                    builder.Append($"order{kvp.Key}{kvp.Value} ");
                }
            }

            return builder.ToString();
        }

        private void SetBreakpointValues(int? value, params Breakpoint[] breakpoints)
        {
            foreach (var breakpoint in breakpoints)
            {
                this.breakpointDictionary[breakpoint] = value;
            }
        }
    }
}

// <copyright file="FluentOrder.cs" company="Derek Chasse">
// Copyright (c) Derek Chasse. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Text;

namespace Flexor
{
#pragma warning disable SA1600 // Elements should be documented
    public interface IOrder : ICssBacked, IEquatable<IOrder>
    {
    }

    public interface IFluentOrderWithValue : IOrder
    {
        IFluentOrderWithValueOnBreakpoint Is0 { get; }

        IFluentOrderWithValueOnBreakpoint Is1 { get; }

        IFluentOrderWithValueOnBreakpoint Is2 { get; }

        IFluentOrderWithValueOnBreakpoint Is3 { get; }

        IFluentOrderWithValueOnBreakpoint Is4 { get; }

        IFluentOrderWithValueOnBreakpoint Is5 { get; }

        IFluentOrderWithValueOnBreakpoint Is6 { get; }

        IFluentOrderWithValueOnBreakpoint Is7 { get; }

        IFluentOrderWithValueOnBreakpoint Is8 { get; }

        IFluentOrderWithValueOnBreakpoint Is9 { get; }

        IFluentOrderWithValueOnBreakpoint Is10 { get; }

        IFluentOrderWithValueOnBreakpoint Is11 { get; }

        IFluentOrderWithValueOnBreakpoint Is12 { get; }

        IFluentOrderWithValueOnBreakpoint IsFirst { get; }

        IFluentOrderWithValueOnBreakpoint IsLast { get; }
    }

    public interface IFluentOrderWithValueOnBreakpoint : IFluentReactive<IFluentOrderWithValue>, IOrder
    {
    }
#pragma warning restore SA1600 // Elements should be documented

    /// <summary>
    /// Define the order in which an item is displayed in a flex-container.
    /// </summary>
    public class FluentOrder : IFluentOrderWithValueOnBreakpoint, IFluentOrderWithValue
    {
        private readonly Dictionary<Breakpoint, int?> breakpointDictionary = new Dictionary<Breakpoint, int?>();
        private int? valueToApply;

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
            this.valueToApply = initialValue;

            this.breakpointDictionary.Add(Breakpoint.Mobile, initialValue);
            this.breakpointDictionary.Add(Breakpoint.Tablet, initialValue);
            this.breakpointDictionary.Add(Breakpoint.Desktop, initialValue);
            this.breakpointDictionary.Add(Breakpoint.Widescreen, initialValue);
            this.breakpointDictionary.Add(Breakpoint.FullHD, initialValue);
        }

        /// <inheritdoc/>
        public string Class => this.BuildClass();

        /// <inheritdoc/>
        public IFluentOrderWithValueOnBreakpoint Is0 => this.Is(0);

        /// <inheritdoc/>
        public IFluentOrderWithValueOnBreakpoint Is1 => this.Is(1);

        /// <inheritdoc/>
        public IFluentOrderWithValueOnBreakpoint Is2 => this.Is(2);

        /// <inheritdoc/>
        public IFluentOrderWithValueOnBreakpoint Is3 => this.Is(3);

        /// <inheritdoc/>
        public IFluentOrderWithValueOnBreakpoint Is4 => this.Is(4);

        /// <inheritdoc/>
        public IFluentOrderWithValueOnBreakpoint Is5 => this.Is(5);

        /// <inheritdoc/>
        public IFluentOrderWithValueOnBreakpoint Is6 => this.Is(6);

        /// <inheritdoc/>
        public IFluentOrderWithValueOnBreakpoint Is7 => this.Is(7);

        /// <inheritdoc/>
        public IFluentOrderWithValueOnBreakpoint Is8 => this.Is(8);

        /// <inheritdoc/>
        public IFluentOrderWithValueOnBreakpoint Is9 => this.Is(9);

        /// <inheritdoc/>
        public IFluentOrderWithValueOnBreakpoint Is10 => this.Is(10);

        /// <inheritdoc/>
        public IFluentOrderWithValueOnBreakpoint Is11 => this.Is(11);

        /// <inheritdoc/>
        public IFluentOrderWithValueOnBreakpoint Is12 => this.Is(12);

        /// <inheritdoc/>
        public IFluentOrderWithValueOnBreakpoint IsFirst => this.Is(int.MinValue);

        /// <inheritdoc/>
        public IFluentOrderWithValueOnBreakpoint IsLast => this.Is(int.MaxValue);

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

        /// <inheritdoc/>
        public bool Equals(IOrder other)
        {
            return string.Equals(this.Class, other.Class);
        }

        private IFluentOrderWithValueOnBreakpoint Is(int value)
        {
            this.valueToApply = value;
            return this;
        }

        private string BuildClass()
        {
            StringBuilder builder = new StringBuilder();

            foreach (var kvp in this.breakpointDictionary)
            {
                if (kvp.Value.HasValue)
                {
                    if (kvp.Value.Value == int.MinValue)
                    {
                        builder.Append($"order{kvp.Key}-first ");
                    }
                    else if (kvp.Value.Value == int.MaxValue)
                    {
                        builder.Append($"order{kvp.Key}-last ");
                    }
                    else
                    {
                        builder.Append($"order{kvp.Key}-{kvp.Value} ");
                    }
                }
            }

            return builder.ToString().Trim();
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

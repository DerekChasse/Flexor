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

    public interface IFluentOrder : IFluentReactive<IFluentOrder, OrderOption>, IOrder
    {
    }
#pragma warning restore SA1600 // Elements should be documented

    /// <summary>
    /// Define the order in which an item is displayed in a flex-line.
    /// </summary>
    public class FluentOrder : IFluentOrder
    {
        private readonly Dictionary<Breakpoint, OrderOption> breakpointDictionary = new Dictionary<Breakpoint, OrderOption>();

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
        public FluentOrder(OrderOption initialValue)
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
        public IFluentOrder OnDesktop(OrderOption option)
        {
            this.breakpointDictionary[Breakpoint.Desktop] = option;
            return this;
        }

        /// <inheritdoc/>
        public IFluentOrder OnDesktopAndLarger(OrderOption option)
        {
            this.SetBreakpointValues(option, Breakpoint.Desktop, Breakpoint.Widescreen, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentOrder OnDesktopAndSmaller(OrderOption option)
        {
            this.SetBreakpointValues(option, Breakpoint.Mobile, Breakpoint.Tablet, Breakpoint.Desktop);
            return this;
        }

        /// <inheritdoc/>
        public IFluentOrder OnFullHD(OrderOption option)
        {
            this.breakpointDictionary[Breakpoint.FullHD] = option;
            return this;
        }

        /// <inheritdoc/>
        public IFluentOrder OnFullHDAndSmaller(OrderOption option)
        {
            this.SetBreakpointValues(option, Breakpoint.Mobile, Breakpoint.Tablet, Breakpoint.Desktop, Breakpoint.Widescreen, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentOrder OnMobile(OrderOption option)
        {
            this.breakpointDictionary[Breakpoint.Mobile] = option;
            return this;
        }

        /// <inheritdoc/>
        public IFluentOrder OnMobileAndLarger(OrderOption option)
        {
            this.SetBreakpointValues(option, Breakpoint.Mobile, Breakpoint.Tablet, Breakpoint.Desktop, Breakpoint.Widescreen, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentOrder OnTablet(OrderOption option)
        {
            this.breakpointDictionary[Breakpoint.Tablet] = option;
            return this;
        }

        /// <inheritdoc/>
        public IFluentOrder OnTabletAndLarger(OrderOption option)
        {
            this.SetBreakpointValues(option, Breakpoint.Tablet, Breakpoint.Desktop, Breakpoint.Widescreen, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentOrder OnTabletAndSmaller(OrderOption option)
        {
            this.SetBreakpointValues(option, Breakpoint.Mobile, Breakpoint.Tablet);
            return this;
        }

        /// <inheritdoc/>
        public IFluentOrder OnWidescreen(OrderOption option)
        {
            this.breakpointDictionary[Breakpoint.Widescreen] = option;
            return this;
        }

        /// <inheritdoc/>
        public IFluentOrder OnWidescreenAndLarger(OrderOption option)
        {
            this.SetBreakpointValues(option, Breakpoint.Widescreen, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentOrder OnWidescreenAndSmaller(OrderOption option)
        {
            this.SetBreakpointValues(option, Breakpoint.Mobile, Breakpoint.Tablet, Breakpoint.Desktop, Breakpoint.Widescreen);
            return this;
        }

        /// <inheritdoc/>
        public bool Equals(IOrder other)
        {
            return string.Equals(this.Class, other.Class);
        }

        private string BuildClass()
        {
            StringBuilder builder = new StringBuilder();

            foreach (var kvp in this.breakpointDictionary)
            {
                if (kvp.Value != null)
                {
                    builder.Append($"order{kvp.Key}-{kvp.Value} ");
                }
            }

            return builder.ToString().Trim();
        }

        private void SetBreakpointValues(OrderOption value, params Breakpoint[] breakpoints)
        {
            foreach (var breakpoint in breakpoints)
            {
                this.breakpointDictionary[breakpoint] = value;
            }
        }
    }
}

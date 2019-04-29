// <copyright file="FluentWrap.cs" company="Derek Chasse">
// Copyright (c) Derek Chasse. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Text;

namespace Flexor
{
#pragma warning disable SA1600 // Elements should be documented
    public interface IWrap : ICssBacked, IEquatable<IWrap>
    {
    }

    public interface IFluentWrap : IFluentReactive<IFluentWrap, WrapOption>,  IWrap
    {
    }
#pragma warning restore SA1600 // Elements should be documented

    /// <summary>
    /// Define the ability of a flex-line to wrap.
    /// </summary>
    public class FluentWrap : IFluentWrap
    {
        private readonly Dictionary<Breakpoint, WrapOption> breakpointDictionary = new Dictionary<Breakpoint, WrapOption>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FluentWrap"/> class.
        /// </summary>
        public FluentWrap()
            : this(WrapOption.NoWrap)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FluentWrap"/> class.
        /// </summary>
        /// <param name="initialValue">The initial value across all CSS media queries.</param>
        public FluentWrap(WrapOption initialValue)
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
        public IFluentWrap OnDesktop(WrapOption option)
        {
            this.breakpointDictionary[Breakpoint.Desktop] = option;
            return this;
        }

        /// <inheritdoc/>
        public IFluentWrap OnDesktopAndLarger(WrapOption option)
        {
            this.SetBreakpointValues(option, Breakpoint.Desktop, Breakpoint.Widescreen, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentWrap OnDesktopAndSmaller(WrapOption option)
        {
            this.SetBreakpointValues(option, Breakpoint.Mobile, Breakpoint.Tablet, Breakpoint.Desktop);
            return this;
        }

        /// <inheritdoc/>
        public IFluentWrap OnFullHD(WrapOption option)
        {
            this.breakpointDictionary[Breakpoint.FullHD] = option;
            return this;
        }

        /// <inheritdoc/>
        public IFluentWrap OnFullHDAndSmaller(WrapOption option)
        {
            this.SetBreakpointValues(option, Breakpoint.Mobile, Breakpoint.Tablet, Breakpoint.Desktop, Breakpoint.Widescreen, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentWrap OnMobile(WrapOption option)
        {
            this.breakpointDictionary[Breakpoint.Mobile] = option;
            return this;
        }

        /// <inheritdoc/>
        public IFluentWrap OnMobileAndLarger(WrapOption option)
        {
            this.SetBreakpointValues(option, Breakpoint.Mobile, Breakpoint.Tablet, Breakpoint.Desktop, Breakpoint.Widescreen, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentWrap OnTablet(WrapOption option)
        {
            this.breakpointDictionary[Breakpoint.Tablet] = option;
            return this;
        }

        /// <inheritdoc/>
        public IFluentWrap OnTabletAndLarger(WrapOption option)
        {
            this.SetBreakpointValues(option, Breakpoint.Tablet, Breakpoint.Desktop, Breakpoint.Widescreen, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentWrap OnTabletAndSmaller(WrapOption option)
        {
            this.SetBreakpointValues(option, Breakpoint.Mobile, Breakpoint.Tablet);
            return this;
        }

        /// <inheritdoc/>
        public IFluentWrap OnWidescreen(WrapOption option)
        {
            this.breakpointDictionary[Breakpoint.Widescreen] = option;
            return this;
        }

        /// <inheritdoc/>
        public IFluentWrap OnWidescreenAndLarger(WrapOption option)
        {
            this.SetBreakpointValues(option, Breakpoint.Widescreen, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentWrap OnWidescreenAndSmaller(WrapOption option)
        {
            this.SetBreakpointValues(option, Breakpoint.Mobile, Breakpoint.Tablet, Breakpoint.Desktop, Breakpoint.Widescreen);
            return this;
        }

        /// <inheritdoc/>
        public bool Equals(IWrap other)
        {
            return string.Equals(this.Class, other.Class);
        }

        private string BuildClass()
        {
            StringBuilder builder = new StringBuilder();

            foreach (var kvp in this.breakpointDictionary)
            {
                builder.Append($"flex{kvp.Key}-{kvp.Value} ");
            }

            return builder.ToString().Trim();
        }

        private void SetBreakpointValues(WrapOption value, params Breakpoint[] breakpoints)
        {
            foreach (var breakpoint in breakpoints)
            {
                this.breakpointDictionary[breakpoint] = value;
            }
        }
    }
}

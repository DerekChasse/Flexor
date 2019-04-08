// <copyright file="FluentWrap.cs" company="Derek Chasse">
// Copyright (c) Derek Chasse. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Flexor
{
#pragma warning disable SA1600 // Elements should be documented
    public interface IFluentWrap : ICssClassBacked
    {
    }

    public interface IFluentWrapWithValue : IFluentWrap
    {
        IFluentWrapWithValueOnBreakpoint Is(WrapOption direction);
    }

    public interface IFluentWrapWithValueOnBreakpoint : IFluentReactive<IFluentWrapWithValue>, IFluentWrap
    {
    }
#pragma warning restore SA1600 // Elements should be documented

    /// <summary>
    /// Define the ability of a flex-container to wrap.
    /// </summary>
    public class FluentWrap : IFluentWrapWithValue, IFluentWrapWithValueOnBreakpoint
    {
        private readonly Dictionary<Breakpoint, WrapOption> breakpointDictionary = new Dictionary<Breakpoint, WrapOption>();
        private WrapOption valueToApply;

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
        public IFluentWrapWithValueOnBreakpoint Is(WrapOption direction)
        {
            this.valueToApply = direction;
            return this;
        }

        /// <inheritdoc/>
        public IFluentWrapWithValue OnDesktop()
        {
            this.breakpointDictionary[Breakpoint.Desktop] = this.valueToApply;
            return this;
        }

        /// <inheritdoc/>
        public IFluentWrapWithValue OnDesktopAndLarger()
        {
            this.SetBreakpointValues(this.valueToApply, Breakpoint.Desktop, Breakpoint.Widescreen, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentWrapWithValue OnDesktopAndSmaller()
        {
            this.SetBreakpointValues(this.valueToApply, Breakpoint.Mobile, Breakpoint.Tablet, Breakpoint.Desktop);
            return this;
        }

        /// <inheritdoc/>
        public IFluentWrapWithValue OnFullHD()
        {
            this.breakpointDictionary[Breakpoint.FullHD] = this.valueToApply;
            return this;
        }

        /// <inheritdoc/>
        public IFluentWrapWithValue OnFullHDAndSmaller()
        {
            this.SetBreakpointValues(this.valueToApply, Breakpoint.Mobile, Breakpoint.Tablet, Breakpoint.Desktop, Breakpoint.Widescreen, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentWrapWithValue OnMobile()
        {
            this.breakpointDictionary[Breakpoint.Mobile] = this.valueToApply;
            return this;
        }

        /// <inheritdoc/>
        public IFluentWrapWithValue OnMobileAndLarger()
        {
            this.SetBreakpointValues(this.valueToApply, Breakpoint.Mobile, Breakpoint.Tablet, Breakpoint.Desktop, Breakpoint.Widescreen, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentWrapWithValue OnTablet()
        {
            this.breakpointDictionary[Breakpoint.Tablet] = this.valueToApply;
            return this;
        }

        /// <inheritdoc/>
        public IFluentWrapWithValue OnTabletAndLarger()
        {
            this.SetBreakpointValues(this.valueToApply, Breakpoint.Tablet, Breakpoint.Desktop, Breakpoint.Widescreen, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentWrapWithValue OnTabletAndSmaller()
        {
            this.SetBreakpointValues(this.valueToApply, Breakpoint.Mobile, Breakpoint.Tablet);
            return this;
        }

        /// <inheritdoc/>
        public IFluentWrapWithValue OnWidescreen()
        {
            this.breakpointDictionary[Breakpoint.Widescreen] = this.valueToApply;
            return this;
        }

        /// <inheritdoc/>
        public IFluentWrapWithValue OnWidescreenAndLarger()
        {
            this.SetBreakpointValues(this.valueToApply, Breakpoint.Widescreen, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentWrapWithValue OnWidescreenAndSmaller()
        {
            this.SetBreakpointValues(this.valueToApply, Breakpoint.Mobile, Breakpoint.Tablet, Breakpoint.Desktop, Breakpoint.Widescreen);
            return this;
        }

        private string BuildClass()
        {
            StringBuilder builder = new StringBuilder();

            foreach (var kvp in this.breakpointDictionary)
            {
                builder.Append($"flex{kvp.Key}{kvp.Value} ");
            }

            return builder.ToString();
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

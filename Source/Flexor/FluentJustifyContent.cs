// <copyright file="FluentJustifyContent.cs" company="Derek Chasse">
// Copyright (c) Derek Chasse. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Text;

namespace Flexor
{
#pragma warning disable SA1600 // Elements should be documented
    public interface IJustifyContent : ICssBacked, IEquatable<IJustifyContent>
    {
    }

    public interface IFluentJustifyContentWithValue : IJustifyContent
    {
        IFluentJustifyContentWithValueOnBreakpoint Is(JustifyContentOption value);
    }

    public interface IFluentJustifyContentWithValueOnBreakpoint : IJustifyContent, IFluentReactive<IFluentJustifyContentWithValue>
    {
    }
#pragma warning restore SA1600 // Elements should be documented

    /// <summary>
    /// Define item justification across a flex-line's main axis.
    /// </summary>
    public class FluentJustifyContent : IFluentJustifyContentWithValueOnBreakpoint, IFluentJustifyContentWithValue
    {
        private readonly Dictionary<Breakpoint, JustifyContentOption> breakpointDictionary = new Dictionary<Breakpoint, JustifyContentOption>();
        private JustifyContentOption valueToApply;

        /// <summary>
        /// Initializes a new instance of the <see cref="FluentJustifyContent"/> class.
        /// </summary>
        public FluentJustifyContent()
            : this(JustifyContentOption.Start)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FluentJustifyContent"/> class.
        /// </summary>
        /// <param name="initialValue">The initial value across all CSS media queries.</param>
        public FluentJustifyContent(JustifyContentOption initialValue)
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
        public IFluentJustifyContentWithValueOnBreakpoint Is(JustifyContentOption value)
        {
            this.valueToApply = value;
            return this;
        }

        /// <inheritdoc/>
        public IFluentJustifyContentWithValue OnDesktop()
        {
            this.SetBreakpointValues(this.valueToApply, Breakpoint.Desktop);
            return this;
        }

        /// <inheritdoc/>
        public IFluentJustifyContentWithValue OnDesktopAndLarger()
        {
            this.SetBreakpointValues(this.valueToApply, Breakpoint.Desktop, Breakpoint.Widescreen, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentJustifyContentWithValue OnDesktopAndSmaller()
        {
            this.SetBreakpointValues(this.valueToApply, Breakpoint.Mobile, Breakpoint.Tablet, Breakpoint.Desktop);
            return this;
        }

        /// <inheritdoc/>
        public IFluentJustifyContentWithValue OnFullHD()
        {
            this.SetBreakpointValues(this.valueToApply, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentJustifyContentWithValue OnFullHDAndSmaller()
        {
            this.SetBreakpointValues(this.valueToApply, Breakpoint.Mobile, Breakpoint.Tablet, Breakpoint.Desktop, Breakpoint.Widescreen, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentJustifyContentWithValue OnMobile()
        {
            this.SetBreakpointValues(this.valueToApply, Breakpoint.Mobile);
            return this;
        }

        /// <inheritdoc/>
        public IFluentJustifyContentWithValue OnMobileAndLarger()
        {
            this.SetBreakpointValues(this.valueToApply, Breakpoint.Mobile, Breakpoint.Tablet, Breakpoint.Desktop, Breakpoint.Widescreen, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentJustifyContentWithValue OnTablet()
        {
            this.SetBreakpointValues(this.valueToApply, Breakpoint.Tablet);
            return this;
        }

        /// <inheritdoc/>
        public IFluentJustifyContentWithValue OnTabletAndLarger()
        {
            this.SetBreakpointValues(this.valueToApply, Breakpoint.Tablet, Breakpoint.Desktop, Breakpoint.Widescreen, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentJustifyContentWithValue OnTabletAndSmaller()
        {
            this.SetBreakpointValues(this.valueToApply, Breakpoint.Mobile, Breakpoint.Tablet);
            return this;
        }

        /// <inheritdoc/>
        public IFluentJustifyContentWithValue OnWidescreen()
        {
            this.SetBreakpointValues(this.valueToApply, Breakpoint.Widescreen);
            return this;
        }

        /// <inheritdoc/>
        public IFluentJustifyContentWithValue OnWidescreenAndLarger()
        {
            this.SetBreakpointValues(this.valueToApply, Breakpoint.Widescreen, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentJustifyContentWithValue OnWidescreenAndSmaller()
        {
            this.SetBreakpointValues(this.valueToApply, Breakpoint.Mobile, Breakpoint.Tablet, Breakpoint.Desktop, Breakpoint.Widescreen);
            return this;
        }

        /// <inheritdoc/>
        public bool Equals(IJustifyContent other)
        {
            return string.Equals(this.Class, other.Class);
        }

        private void SetBreakpointValues(JustifyContentOption value, params Breakpoint[] breakpoints)
        {
            foreach (var breakpoint in breakpoints)
            {
                this.breakpointDictionary[breakpoint] = value;
            }
        }

        private string BuildClass()
        {
            StringBuilder builder = new StringBuilder();

            foreach (var kvp in this.breakpointDictionary)
            {
                builder.Append($"justify-content{kvp.Key}{kvp.Value} ");
            }

            return builder.ToString().Trim();
        }
    }
}

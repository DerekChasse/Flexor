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

    public interface IFluentJustifyContent : IFluentReactive<IFluentJustifyContent, JustifyContentOption>, IJustifyContent
    {
    }
#pragma warning restore SA1600 // Elements should be documented

    /// <summary>
    /// Define item justification across a flex-line's main axis.
    /// </summary>
    public class FluentJustifyContent : IFluentJustifyContent
    {
        private readonly Dictionary<Breakpoint, JustifyContentOption> breakpointDictionary = new Dictionary<Breakpoint, JustifyContentOption>();

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
            this.breakpointDictionary.Add(Breakpoint.Mobile, initialValue);
            this.breakpointDictionary.Add(Breakpoint.Tablet, initialValue);
            this.breakpointDictionary.Add(Breakpoint.Desktop, initialValue);
            this.breakpointDictionary.Add(Breakpoint.Widescreen, initialValue);
            this.breakpointDictionary.Add(Breakpoint.FullHD, initialValue);
        }

        /// <inheritdoc/>
        public string Class => this.BuildClass();

        /// <inheritdoc/>
        public IFluentJustifyContent OnDesktop(JustifyContentOption option)
        {
            this.SetBreakpointValues(option, Breakpoint.Desktop);
            return this;
        }

        /// <inheritdoc/>
        public IFluentJustifyContent OnDesktopAndLarger(JustifyContentOption option)
        {
            this.SetBreakpointValues(option, Breakpoint.Desktop, Breakpoint.Widescreen, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentJustifyContent OnDesktopAndSmaller(JustifyContentOption option)
        {
            this.SetBreakpointValues(option, Breakpoint.Mobile, Breakpoint.Tablet, Breakpoint.Desktop);
            return this;
        }

        /// <inheritdoc/>
        public IFluentJustifyContent OnFullHD(JustifyContentOption option)
        {
            this.SetBreakpointValues(option, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentJustifyContent OnFullHDAndSmaller(JustifyContentOption option)
        {
            this.SetBreakpointValues(option, Breakpoint.Mobile, Breakpoint.Tablet, Breakpoint.Desktop, Breakpoint.Widescreen, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentJustifyContent OnMobile(JustifyContentOption option)
        {
            this.SetBreakpointValues(option, Breakpoint.Mobile);
            return this;
        }

        /// <inheritdoc/>
        public IFluentJustifyContent OnMobileAndLarger(JustifyContentOption option)
        {
            this.SetBreakpointValues(option, Breakpoint.Mobile, Breakpoint.Tablet, Breakpoint.Desktop, Breakpoint.Widescreen, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentJustifyContent OnTablet(JustifyContentOption option)
        {
            this.SetBreakpointValues(option, Breakpoint.Tablet);
            return this;
        }

        /// <inheritdoc/>
        public IFluentJustifyContent OnTabletAndLarger(JustifyContentOption option)
        {
            this.SetBreakpointValues(option, Breakpoint.Tablet, Breakpoint.Desktop, Breakpoint.Widescreen, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentJustifyContent OnTabletAndSmaller(JustifyContentOption option)
        {
            this.SetBreakpointValues(option, Breakpoint.Mobile, Breakpoint.Tablet);
            return this;
        }

        /// <inheritdoc/>
        public IFluentJustifyContent OnWidescreen(JustifyContentOption option)
        {
            this.SetBreakpointValues(option, Breakpoint.Widescreen);
            return this;
        }

        /// <inheritdoc/>
        public IFluentJustifyContent OnWidescreenAndLarger(JustifyContentOption option)
        {
            this.SetBreakpointValues(option, Breakpoint.Widescreen, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentJustifyContent OnWidescreenAndSmaller(JustifyContentOption option)
        {
            this.SetBreakpointValues(option, Breakpoint.Mobile, Breakpoint.Tablet, Breakpoint.Desktop, Breakpoint.Widescreen);
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
                builder.Append($"justify-content{kvp.Key}-{kvp.Value} ");
            }

            return builder.ToString().Trim();
        }
    }
}

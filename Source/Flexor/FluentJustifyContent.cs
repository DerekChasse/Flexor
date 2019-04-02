// <copyright file="FluentJustifyContent.cs" company="Derek Chasse">
// Copyright (c) Derek Chasse. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Linq;

namespace Flexor
{
#pragma warning disable SA1600 // Elements should be documented
    public interface IFluentJustifyContent
    {
    }

    public interface IFluentJustifyContentOnBreakpoint : IFluentJustifyContent, IFluentReactive<IFluentJustifyContentOnBreakpointWithValue, Justification>
    {
    }

    public interface IFluentJustifyContentOnBreakpointWithValue : IFluentJustifyContentOnBreakpoint
    {
    }
#pragma warning restore SA1600 // Elements should be documented

    /// <summary>
    /// Define item justification across a flex-container's main axis.
    /// </summary>
    public class FluentJustifyContent : IFluentJustifyContentOnBreakpointWithValue
    {
        private readonly Dictionary<Breakpoint, Justification> breakpointDictionary = new Dictionary<Breakpoint, Justification>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FluentJustifyContent"/> class.
        /// </summary>
        public FluentJustifyContent()
            : this(Justification.Start)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FluentJustifyContent"/> class.
        /// </summary>
        /// <param name="initialValue">The initial value across all CSS media queries.</param>
        public FluentJustifyContent(Justification initialValue)
        {
            foreach (var breakpoint in Enum.GetValues(typeof(Breakpoint)).Cast<Breakpoint>())
            {
                this.breakpointDictionary.Add(breakpoint, initialValue);
            }
        }

        /// <inheritdoc/>
        public IFluentJustifyContentOnBreakpointWithValue OnDesktop(Justification value)
        {
            this.SetBreakpointValues(value, Breakpoint.Desktop);
            return this;
        }

        /// <inheritdoc/>
        public IFluentJustifyContentOnBreakpointWithValue OnDesktopAndLarger(Justification value)
        {
            this.SetBreakpointValues(value, Breakpoint.Desktop, Breakpoint.Widescreen, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentJustifyContentOnBreakpointWithValue OnDesktopAndSmaller(Justification value)
        {
            this.SetBreakpointValues(value, Breakpoint.Mobile, Breakpoint.Tablet, Breakpoint.Desktop);
            return this;
        }

        /// <inheritdoc/>
        public IFluentJustifyContentOnBreakpointWithValue OnFullHD(Justification value)
        {
            this.SetBreakpointValues(value, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentJustifyContentOnBreakpointWithValue OnFullHDAndSmaller(Justification value)
        {
            this.SetBreakpointValues(value, Breakpoint.Mobile, Breakpoint.Tablet, Breakpoint.Desktop, Breakpoint.Widescreen, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentJustifyContentOnBreakpointWithValue OnMobile(Justification value)
        {
            this.SetBreakpointValues(value, Breakpoint.Mobile);
            return this;
        }

        /// <inheritdoc/>
        public IFluentJustifyContentOnBreakpointWithValue OnMobileAndLarger(Justification value)
        {
            this.SetBreakpointValues(value, Breakpoint.Mobile, Breakpoint.Tablet, Breakpoint.Desktop, Breakpoint.Widescreen, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentJustifyContentOnBreakpointWithValue OnTablet(Justification value)
        {
            this.SetBreakpointValues(value, Breakpoint.Tablet);
            return this;
        }

        /// <inheritdoc/>
        public IFluentJustifyContentOnBreakpointWithValue OnTabletAndLarger(Justification value)
        {
            this.SetBreakpointValues(value, Breakpoint.Tablet, Breakpoint.Desktop, Breakpoint.Widescreen, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentJustifyContentOnBreakpointWithValue OnTabletAndSmaller(Justification value)
        {
            this.SetBreakpointValues(value, Breakpoint.Mobile, Breakpoint.Tablet);
            return this;
        }

        /// <inheritdoc/>
        public IFluentJustifyContentOnBreakpointWithValue OnWidescreen(Justification value)
        {
            this.SetBreakpointValues(value, Breakpoint.Widescreen);
            return this;
        }

        /// <inheritdoc/>
        public IFluentJustifyContentOnBreakpointWithValue OnWidescreenAndLarger(Justification value)
        {
            this.SetBreakpointValues(value, Breakpoint.Widescreen, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentJustifyContentOnBreakpointWithValue OnWidescreenAndSmaller(Justification value)
        {
            this.SetBreakpointValues(value, Breakpoint.Mobile, Breakpoint.Tablet, Breakpoint.Desktop, Breakpoint.Widescreen);
            return this;
        }

        private void SetBreakpointValues(Justification value, params Breakpoint[] breakpoints)
        {
            foreach (var breakpoint in breakpoints)
            {
                this.breakpointDictionary[breakpoint] = value;
            }
        }
    }
}

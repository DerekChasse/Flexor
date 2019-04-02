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

    public interface IFluentJustifyContentOnBreakpoint : IFluentJustifyContent, IFluentReactive<IFluentJustifyContentOnBreakpointWithValue, JustificationValue>
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
        private readonly Dictionary<BreakpointValue, JustificationValue> breakpointDictionary = new Dictionary<BreakpointValue, JustificationValue>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FluentJustifyContent"/> class.
        /// </summary>
        public FluentJustifyContent()
            : this(JustificationValue.Start)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FluentJustifyContent"/> class.
        /// </summary>
        /// <param name="initialValue">The initial value across all CSS media queries.</param>
        public FluentJustifyContent(JustificationValue initialValue)
        {
            foreach (var breakpoint in Enum.GetValues(typeof(BreakpointValue)).Cast<BreakpointValue>())
            {
                this.breakpointDictionary.Add(breakpoint, initialValue);
            }
        }

        /// <inheritdoc/>
        public IFluentJustifyContentOnBreakpointWithValue OnDesktop(JustificationValue value)
        {
            this.SetBreakpointValues(value, BreakpointValue.Desktop);
            return this;
        }

        /// <inheritdoc/>
        public IFluentJustifyContentOnBreakpointWithValue OnDesktopAndLarger(JustificationValue value)
        {
            this.SetBreakpointValues(value, BreakpointValue.Desktop, BreakpointValue.Widescreen, BreakpointValue.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentJustifyContentOnBreakpointWithValue OnDesktopAndSmaller(JustificationValue value)
        {
            this.SetBreakpointValues(value, BreakpointValue.Mobile, BreakpointValue.Tablet, BreakpointValue.Desktop);
            return this;
        }

        /// <inheritdoc/>
        public IFluentJustifyContentOnBreakpointWithValue OnFullHD(JustificationValue value)
        {
            this.SetBreakpointValues(value, BreakpointValue.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentJustifyContentOnBreakpointWithValue OnFullHDAndSmaller(JustificationValue value)
        {
            this.SetBreakpointValues(value, BreakpointValue.Mobile, BreakpointValue.Tablet, BreakpointValue.Desktop, BreakpointValue.Widescreen, BreakpointValue.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentJustifyContentOnBreakpointWithValue OnMobile(JustificationValue value)
        {
            this.SetBreakpointValues(value, BreakpointValue.Mobile);
            return this;
        }

        /// <inheritdoc/>
        public IFluentJustifyContentOnBreakpointWithValue OnMobileAndLarger(JustificationValue value)
        {
            this.SetBreakpointValues(value, BreakpointValue.Mobile, BreakpointValue.Tablet, BreakpointValue.Desktop, BreakpointValue.Widescreen, BreakpointValue.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentJustifyContentOnBreakpointWithValue OnTablet(JustificationValue value)
        {
            this.SetBreakpointValues(value, BreakpointValue.Tablet);
            return this;
        }

        /// <inheritdoc/>
        public IFluentJustifyContentOnBreakpointWithValue OnTabletAndLarger(JustificationValue value)
        {
            this.SetBreakpointValues(value, BreakpointValue.Tablet, BreakpointValue.Desktop, BreakpointValue.Widescreen, BreakpointValue.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentJustifyContentOnBreakpointWithValue OnTabletAndSmaller(JustificationValue value)
        {
            this.SetBreakpointValues(value, BreakpointValue.Mobile, BreakpointValue.Tablet);
            return this;
        }

        /// <inheritdoc/>
        public IFluentJustifyContentOnBreakpointWithValue OnWidescreen(JustificationValue value)
        {
            this.SetBreakpointValues(value, BreakpointValue.Widescreen);
            return this;
        }

        /// <inheritdoc/>
        public IFluentJustifyContentOnBreakpointWithValue OnWidescreenAndLarger(JustificationValue value)
        {
            this.SetBreakpointValues(value, BreakpointValue.Widescreen, BreakpointValue.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentJustifyContentOnBreakpointWithValue OnWidescreenAndSmaller(JustificationValue value)
        {
            this.SetBreakpointValues(value, BreakpointValue.Mobile, BreakpointValue.Tablet, BreakpointValue.Desktop, BreakpointValue.Widescreen);
            return this;
        }

        private void SetBreakpointValues(JustificationValue value, params BreakpointValue[] breakpoints)
        {
            foreach (var breakpoint in breakpoints)
            {
                this.breakpointDictionary[breakpoint] = value;
            }
        }
    }
}

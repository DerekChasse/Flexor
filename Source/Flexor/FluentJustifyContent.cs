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

    public interface IFluentJustifyContentWithValue : IFluentJustifyContent
    {
        IFluentJustifyContentWithValueOnBreakpoint Is(JustificationValue value);
    }

    public interface IFluentJustifyContentWithValueOnBreakpoint : IFluentJustifyContent, IFluentReactive<IFluentJustifyContentWithValue>
    {
    }
#pragma warning restore SA1600 // Elements should be documented

    /// <summary>
    /// Define item justification across a flex-container's main axis.
    /// </summary>
    public class FluentJustifyContent : IFluentJustifyContentWithValueOnBreakpoint, IFluentJustifyContentWithValue
    {
        private readonly Dictionary<BreakpointValue, JustificationValue> breakpointDictionary = new Dictionary<BreakpointValue, JustificationValue>();
        private JustificationValue valueToApply;

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
        public IFluentJustifyContentWithValueOnBreakpoint Is(JustificationValue value)
        {
            this.valueToApply = value;
            return this;
        }

        /// <inheritdoc/>
        public IFluentJustifyContentWithValue OnDesktop()
        {
            this.SetBreakpointValues(this.valueToApply, BreakpointValue.Desktop);
            return this;
        }

        /// <inheritdoc/>
        public IFluentJustifyContentWithValue OnDesktopAndLarger()
        {
            this.SetBreakpointValues(this.valueToApply, BreakpointValue.Desktop, BreakpointValue.Widescreen, BreakpointValue.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentJustifyContentWithValue OnDesktopAndSmaller()
        {
            this.SetBreakpointValues(this.valueToApply, BreakpointValue.Mobile, BreakpointValue.Tablet, BreakpointValue.Desktop);
            return this;
        }

        /// <inheritdoc/>
        public IFluentJustifyContentWithValue OnFullHD()
        {
            this.SetBreakpointValues(this.valueToApply, BreakpointValue.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentJustifyContentWithValue OnFullHDAndSmaller()
        {
            this.SetBreakpointValues(this.valueToApply, BreakpointValue.Mobile, BreakpointValue.Tablet, BreakpointValue.Desktop, BreakpointValue.Widescreen, BreakpointValue.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentJustifyContentWithValue OnMobile()
        {
            this.SetBreakpointValues(this.valueToApply, BreakpointValue.Mobile);
            return this;
        }

        /// <inheritdoc/>
        public IFluentJustifyContentWithValue OnMobileAndLarger()
        {
            this.SetBreakpointValues(this.valueToApply, BreakpointValue.Mobile, BreakpointValue.Tablet, BreakpointValue.Desktop, BreakpointValue.Widescreen, BreakpointValue.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentJustifyContentWithValue OnTablet()
        {
            this.SetBreakpointValues(this.valueToApply, BreakpointValue.Tablet);
            return this;
        }

        /// <inheritdoc/>
        public IFluentJustifyContentWithValue OnTabletAndLarger()
        {
            this.SetBreakpointValues(this.valueToApply, BreakpointValue.Tablet, BreakpointValue.Desktop, BreakpointValue.Widescreen, BreakpointValue.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentJustifyContentWithValue OnTabletAndSmaller()
        {
            this.SetBreakpointValues(this.valueToApply, BreakpointValue.Mobile, BreakpointValue.Tablet);
            return this;
        }

        /// <inheritdoc/>
        public IFluentJustifyContentWithValue OnWidescreen()
        {
            this.SetBreakpointValues(this.valueToApply, BreakpointValue.Widescreen);
            return this;
        }

        /// <inheritdoc/>
        public IFluentJustifyContentWithValue OnWidescreenAndLarger()
        {
            this.SetBreakpointValues(this.valueToApply, BreakpointValue.Widescreen, BreakpointValue.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentJustifyContentWithValue OnWidescreenAndSmaller()
        {
            this.SetBreakpointValues(this.valueToApply, BreakpointValue.Mobile, BreakpointValue.Tablet, BreakpointValue.Desktop, BreakpointValue.Widescreen);
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

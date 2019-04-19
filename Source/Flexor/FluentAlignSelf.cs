// <copyright file="FluentAlignSelf.cs" company="Derek Chasse">
// Copyright (c) Derek Chasse. All rights reserved.
// </copyright>

using System.Collections.Generic;
using System.Text;

namespace Flexor
{
#pragma warning disable SA1600 // Elements should be documented
    public interface IAlignSelf : ICssBacked
    {
    }

    public interface IFluentAlignSelfWithValue : IAlignSelf
    {
        IFluentAlignSelfWithValueOnBreakpoint Is(SelfAlignmentOption value);
    }

    public interface IFluentAlignSelfWithValueOnBreakpoint : IFluentReactive<IFluentAlignSelfWithValue>, IAlignSelf
    {
    }
#pragma warning restore SA1600 // Elements should be documented

    /// <summary>
    /// Define how an individual item is aligned along a flex-container's cross axis.
    /// </summary>
    public class FluentAlignSelf : IFluentAlignSelfWithValueOnBreakpoint, IFluentAlignSelfWithValue
    {
        private readonly Dictionary<Breakpoint, SelfAlignmentOption> breakpointDictionary = new Dictionary<Breakpoint, SelfAlignmentOption>();
        private SelfAlignmentOption valueToApply;

        /// <summary>
        /// Initializes a new instance of the <see cref="FluentAlignSelf"/> class.
        /// </summary>
        public FluentAlignSelf()
            : this(SelfAlignmentOption.Stretch)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FluentAlignSelf"/> class.
        /// </summary>
        /// <param name="initialValue">The initial value across all CSS media queries.</param>
        public FluentAlignSelf(SelfAlignmentOption initialValue)
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
        public IFluentAlignSelfWithValueOnBreakpoint Is(SelfAlignmentOption value)
        {
            this.valueToApply = value;
            return this;
        }

        /// <inheritdoc/>
        public IFluentAlignSelfWithValue OnDesktop()
        {
            this.SetBreakpointValues(this.valueToApply, Breakpoint.Desktop);
            return this;
        }

        /// <inheritdoc/>
        public IFluentAlignSelfWithValue OnDesktopAndLarger()
        {
            this.SetBreakpointValues(this.valueToApply, Breakpoint.Desktop, Breakpoint.Widescreen, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentAlignSelfWithValue OnDesktopAndSmaller()
        {
            this.SetBreakpointValues(this.valueToApply, Breakpoint.Mobile, Breakpoint.Tablet, Breakpoint.Desktop);
            return this;
        }

        /// <inheritdoc/>
        public IFluentAlignSelfWithValue OnFullHD()
        {
            this.SetBreakpointValues(this.valueToApply, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentAlignSelfWithValue OnFullHDAndSmaller()
        {
            this.SetBreakpointValues(this.valueToApply, Breakpoint.Mobile, Breakpoint.Tablet, Breakpoint.Desktop, Breakpoint.Widescreen, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentAlignSelfWithValue OnMobile()
        {
            this.SetBreakpointValues(this.valueToApply, Breakpoint.Mobile);
            return this;
        }

        /// <inheritdoc/>
        public IFluentAlignSelfWithValue OnMobileAndLarger()
        {
            this.SetBreakpointValues(this.valueToApply, Breakpoint.Mobile, Breakpoint.Tablet, Breakpoint.Desktop, Breakpoint.Widescreen, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentAlignSelfWithValue OnTablet()
        {
            this.SetBreakpointValues(this.valueToApply, Breakpoint.Tablet);
            return this;
        }

        /// <inheritdoc/>
        public IFluentAlignSelfWithValue OnTabletAndLarger()
        {
            this.SetBreakpointValues(this.valueToApply, Breakpoint.Tablet, Breakpoint.Desktop, Breakpoint.Widescreen, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentAlignSelfWithValue OnTabletAndSmaller()
        {
            this.SetBreakpointValues(this.valueToApply, Breakpoint.Mobile, Breakpoint.Tablet);
            return this;
        }

        /// <inheritdoc/>
        public IFluentAlignSelfWithValue OnWidescreen()
        {
            this.SetBreakpointValues(this.valueToApply, Breakpoint.Widescreen);
            return this;
        }

        /// <inheritdoc/>
        public IFluentAlignSelfWithValue OnWidescreenAndLarger()
        {
            this.SetBreakpointValues(this.valueToApply, Breakpoint.Widescreen, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentAlignSelfWithValue OnWidescreenAndSmaller()
        {
            this.SetBreakpointValues(this.valueToApply, Breakpoint.Mobile, Breakpoint.Tablet, Breakpoint.Desktop, Breakpoint.Widescreen);
            return this;
        }

        private string BuildClass()
        {
            StringBuilder builder = new StringBuilder();

            foreach (var kvp in this.breakpointDictionary)
            {
                builder.Append($"align-self{kvp.Key}{kvp.Value} ");
            }

            return builder.ToString().Trim();
        }

        private void SetBreakpointValues(SelfAlignmentOption value, params Breakpoint[] breakpoints)
        {
            foreach (var breakpoint in breakpoints)
            {
                this.breakpointDictionary[breakpoint] = value;
            }
        }
    }
}

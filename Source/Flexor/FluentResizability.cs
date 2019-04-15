// <copyright file="FluentResizability.cs" company="Derek Chasse">
// Copyright (c) Derek Chasse. All rights reserved.
// </copyright>

using System.Collections.Generic;
using System.Text;

namespace Flexor
{
#pragma warning disable SA1600 // Elements should be documented
    public interface IResizability : ICssBacked
    {
    }

    public interface IFluentResizabilityWithValue : IResizability
    {
        ////TODO: Add Fill

        IFluentResizabilityWithValueOnBreakpoint Is(ResizabilityOption value);

        IFluentResizabilityWithValueOnBreakpoint IsAutomatic();

        IFluentResizabilityWithValueOnBreakpoint IsInitial();

        IFluentResizabilityWithValueOnBreakpoint CanGrow();

        IFluentResizabilityWithValueOnBreakpoint CanNotGrow();

        IFluentResizabilityWithValueOnBreakpoint CanNotShrink();
    }

    public interface IFluentResizabilityWithValueOnBreakpoint : IResizability, IFluentReactive<IFluentResizabilityWithValue>
    {
    }
#pragma warning restore SA1600 // Elements should be documented

    /// <summary>
    /// Define the ability to resize an item is displayed in a flex-container.
    /// </summary>
    public class FluentResizability : IFluentResizabilityWithValueOnBreakpoint, IFluentResizabilityWithValue
    {
        private readonly Dictionary<Breakpoint, ResizabilityOption> breakpointDictionary = new Dictionary<Breakpoint, ResizabilityOption>();
        private ResizabilityOption valueToApply;

        /// <summary>
        /// Initializes a new instance of the <see cref="FluentResizability"/> class.
        /// </summary>
        public FluentResizability()
            : this(ResizabilityOption.Auto)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FluentResizability"/> class.
        /// </summary>
        /// <param name="initialValue">The initial <see cref="ResizabilityOption"/> across all media query breakpoints.</param>
        public FluentResizability(ResizabilityOption initialValue)
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
        public IFluentResizabilityWithValueOnBreakpoint CanGrow()
        {
            return this.Is(ResizabilityOption.Grow);
        }

        /// <inheritdoc/>
        public IFluentResizabilityWithValueOnBreakpoint CanNotGrow()
        {
            return this.Is(ResizabilityOption.NoGrow);
        }

        /// <inheritdoc/>
        public IFluentResizabilityWithValueOnBreakpoint CanNotShrink()
        {
            return this.Is(ResizabilityOption.NoShrink);
        }

        /// <inheritdoc/>
        public IFluentResizabilityWithValueOnBreakpoint IsAutomatic()
        {
            return this.Is(ResizabilityOption.Auto);
        }

        /// <inheritdoc/>
        public IFluentResizabilityWithValueOnBreakpoint IsInitial()
        {
            return this.Is(ResizabilityOption.None);
        }

        /// <inheritdoc/>
        public IFluentResizabilityWithValueOnBreakpoint Is(ResizabilityOption value)
        {
            this.valueToApply = value;
            return this;
        }

        /// <inheritdoc/>
        public IFluentResizabilityWithValue OnDesktop()
        {
            this.breakpointDictionary[Breakpoint.Desktop] = this.valueToApply;
            return this;
        }

        /// <inheritdoc/>
        public IFluentResizabilityWithValue OnDesktopAndLarger()
        {
            this.SetBreakpointValues(this.valueToApply, Breakpoint.Desktop, Breakpoint.Widescreen, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentResizabilityWithValue OnDesktopAndSmaller()
        {
            this.SetBreakpointValues(this.valueToApply, Breakpoint.Mobile, Breakpoint.Tablet, Breakpoint.Desktop);
            return this;
        }

        /// <inheritdoc/>
        public IFluentResizabilityWithValue OnFullHD()
        {
            this.breakpointDictionary[Breakpoint.FullHD] = this.valueToApply;
            return this;
        }

        /// <inheritdoc/>
        public IFluentResizabilityWithValue OnFullHDAndSmaller()
        {
            this.SetBreakpointValues(this.valueToApply, Breakpoint.Mobile, Breakpoint.Tablet, Breakpoint.Desktop, Breakpoint.Widescreen, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentResizabilityWithValue OnMobile()
        {
            this.breakpointDictionary[Breakpoint.Mobile] = this.valueToApply;
            return this;
        }

        /// <inheritdoc/>
        public IFluentResizabilityWithValue OnMobileAndLarger()
        {
            this.SetBreakpointValues(this.valueToApply, Breakpoint.Mobile, Breakpoint.Tablet, Breakpoint.Desktop, Breakpoint.Widescreen, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentResizabilityWithValue OnTablet()
        {
            this.breakpointDictionary[Breakpoint.Tablet] = this.valueToApply;
            return this;
        }

        /// <inheritdoc/>
        public IFluentResizabilityWithValue OnTabletAndLarger()
        {
            this.SetBreakpointValues(this.valueToApply, Breakpoint.Tablet, Breakpoint.Desktop, Breakpoint.Widescreen, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentResizabilityWithValue OnTabletAndSmaller()
        {
            this.SetBreakpointValues(this.valueToApply, Breakpoint.Mobile, Breakpoint.Tablet);
            return this;
        }

        /// <inheritdoc/>
        public IFluentResizabilityWithValue OnWidescreen()
        {
            this.breakpointDictionary[Breakpoint.Widescreen] = this.valueToApply;
            return this;
        }

        /// <inheritdoc/>
        public IFluentResizabilityWithValue OnWidescreenAndLarger()
        {
            this.SetBreakpointValues(this.valueToApply, Breakpoint.Widescreen, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentResizabilityWithValue OnWidescreenAndSmaller()
        {
            this.SetBreakpointValues(this.valueToApply, Breakpoint.Mobile, Breakpoint.Tablet, Breakpoint.Desktop, Breakpoint.Widescreen);
            return this;
        }

        private string BuildClass()
        {
            StringBuilder builder = new StringBuilder();

            foreach (var kvp in this.breakpointDictionary)
            {
                builder.Append($"flex-resize{kvp.Key}{kvp.Value} ");
            }

            return builder.ToString().Trim();
        }

        private void SetBreakpointValues(ResizabilityOption value, params Breakpoint[] breakpoints)
        {
            foreach (var breakpoint in breakpoints)
            {
                this.breakpointDictionary[breakpoint] = value;
            }
        }
    }
}

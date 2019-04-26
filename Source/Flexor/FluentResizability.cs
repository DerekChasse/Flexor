// <copyright file="FluentResizability.cs" company="Derek Chasse">
// Copyright (c) Derek Chasse. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Text;

namespace Flexor
{
#pragma warning disable SA1600 // Elements should be documented
    public interface IResizability : ICssBacked, IEquatable<IResizability>
    {
    }

    public interface IFluentResizability : IFluentReactive<IFluentResizability, ResizabilityOption>, IResizability
    {
    }
#pragma warning restore SA1600 // Elements should be documented

    /// <summary>
    /// Define the ability to resize an item is displayed in a flex-line.
    /// </summary>
    public class FluentResizability : IFluentResizability
    {
        private readonly Dictionary<Breakpoint, ResizabilityOption> breakpointDictionary = new Dictionary<Breakpoint, ResizabilityOption>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FluentResizability"/> class.
        /// </summary>
        public FluentResizability()
            : this(ResizabilityOption.Default)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FluentResizability"/> class.
        /// </summary>
        /// <param name="initialValue">The initial <see cref="ResizabilityOption"/> across all media query breakpoints.</param>
        public FluentResizability(ResizabilityOption initialValue)
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
        public IFluentResizability OnDesktop(ResizabilityOption option)
        {
            this.SetBreakpointValues(option, Breakpoint.Desktop);
            return this;
        }

        /// <inheritdoc/>
        public IFluentResizability OnDesktopAndLarger(ResizabilityOption option)
        {
            this.SetBreakpointValues(option, Breakpoint.Desktop, Breakpoint.Widescreen, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentResizability OnDesktopAndSmaller(ResizabilityOption option)
        {
            this.SetBreakpointValues(option, Breakpoint.Mobile, Breakpoint.Tablet, Breakpoint.Desktop);
            return this;
        }

        /// <inheritdoc/>
        public IFluentResizability OnFullHD(ResizabilityOption option)
        {
            this.breakpointDictionary[Breakpoint.FullHD] = option;
            return this;
        }

        /// <inheritdoc/>
        public IFluentResizability OnFullHDAndSmaller(ResizabilityOption option)
        {
            this.SetBreakpointValues(option, Breakpoint.Mobile, Breakpoint.Tablet, Breakpoint.Desktop, Breakpoint.Widescreen, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentResizability OnMobile(ResizabilityOption option)
        {
            this.breakpointDictionary[Breakpoint.Mobile] = option;
            return this;
        }

        /// <inheritdoc/>
        public IFluentResizability OnMobileAndLarger(ResizabilityOption option)
        {
            this.SetBreakpointValues(option, Breakpoint.Mobile, Breakpoint.Tablet, Breakpoint.Desktop, Breakpoint.Widescreen, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentResizability OnTablet(ResizabilityOption option)
        {
            this.breakpointDictionary[Breakpoint.Tablet] = option;
            return this;
        }

        /// <inheritdoc/>
        public IFluentResizability OnTabletAndLarger(ResizabilityOption option)
        {
            this.SetBreakpointValues(option, Breakpoint.Tablet, Breakpoint.Desktop, Breakpoint.Widescreen, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentResizability OnTabletAndSmaller(ResizabilityOption option)
        {
            this.SetBreakpointValues(option, Breakpoint.Mobile, Breakpoint.Tablet);
            return this;
        }

        /// <inheritdoc/>
        public IFluentResizability OnWidescreen(ResizabilityOption option)
        {
            this.breakpointDictionary[Breakpoint.Widescreen] = option;
            return this;
        }

        /// <inheritdoc/>
        public IFluentResizability OnWidescreenAndLarger(ResizabilityOption option)
        {
            this.SetBreakpointValues(option, Breakpoint.Widescreen, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentResizability OnWidescreenAndSmaller(ResizabilityOption option)
        {
            this.SetBreakpointValues(option, Breakpoint.Mobile, Breakpoint.Tablet, Breakpoint.Desktop, Breakpoint.Widescreen);
            return this;
        }

        /// <inheritdoc/>
        public bool Equals(IResizability other)
        {
            return string.Equals(this.Class, other.Class);
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

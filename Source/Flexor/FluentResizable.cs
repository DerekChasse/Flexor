// <copyright file="FluentResizable.cs" company="Derek Chasse">
// Copyright (c) Derek Chasse. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Text;

namespace Flexor
{
#pragma warning disable SA1600 // Elements should be documented
    public interface IResizable : ICssBacked, IEquatable<IResizable>
    {
    }

    public interface IFluentResizable : IFluentReactive<IFluentResizable, ResizableOption>, IResizable
    {
    }
#pragma warning restore SA1600 // Elements should be documented

    /// <summary>
    /// Define the ability to resize an item displayed in a flex-line.
    /// </summary>
    public class FluentResizable : IFluentResizable
    {
        private readonly Dictionary<Breakpoint, ResizableOption> breakpointDictionary = new Dictionary<Breakpoint, ResizableOption>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FluentResizable"/> class.
        /// </summary>
        public FluentResizable()
            : this(ResizableOption.Default)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FluentResizable"/> class.
        /// </summary>
        /// <param name="initialValue">The initial <see cref="ResizableOption"/> across all media query breakpoints.</param>
        public FluentResizable(ResizableOption initialValue)
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
        public IFluentResizable OnDesktop(ResizableOption option)
        {
            this.SetBreakpointValues(option, Breakpoint.Desktop);
            return this;
        }

        /// <inheritdoc/>
        public IFluentResizable OnDesktopAndLarger(ResizableOption option)
        {
            this.SetBreakpointValues(option, Breakpoint.Desktop, Breakpoint.Widescreen, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentResizable OnDesktopAndSmaller(ResizableOption option)
        {
            this.SetBreakpointValues(option, Breakpoint.Mobile, Breakpoint.Tablet, Breakpoint.Desktop);
            return this;
        }

        /// <inheritdoc/>
        public IFluentResizable OnFullHD(ResizableOption option)
        {
            this.breakpointDictionary[Breakpoint.FullHD] = option;
            return this;
        }

        /// <inheritdoc/>
        public IFluentResizable OnFullHDAndSmaller(ResizableOption option)
        {
            this.SetBreakpointValues(option, Breakpoint.Mobile, Breakpoint.Tablet, Breakpoint.Desktop, Breakpoint.Widescreen, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentResizable OnMobile(ResizableOption option)
        {
            this.breakpointDictionary[Breakpoint.Mobile] = option;
            return this;
        }

        /// <inheritdoc/>
        public IFluentResizable OnMobileAndLarger(ResizableOption option)
        {
            this.SetBreakpointValues(option, Breakpoint.Mobile, Breakpoint.Tablet, Breakpoint.Desktop, Breakpoint.Widescreen, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentResizable OnTablet(ResizableOption option)
        {
            this.breakpointDictionary[Breakpoint.Tablet] = option;
            return this;
        }

        /// <inheritdoc/>
        public IFluentResizable OnTabletAndLarger(ResizableOption option)
        {
            this.SetBreakpointValues(option, Breakpoint.Tablet, Breakpoint.Desktop, Breakpoint.Widescreen, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentResizable OnTabletAndSmaller(ResizableOption option)
        {
            this.SetBreakpointValues(option, Breakpoint.Mobile, Breakpoint.Tablet);
            return this;
        }

        /// <inheritdoc/>
        public IFluentResizable OnWidescreen(ResizableOption option)
        {
            this.breakpointDictionary[Breakpoint.Widescreen] = option;
            return this;
        }

        /// <inheritdoc/>
        public IFluentResizable OnWidescreenAndLarger(ResizableOption option)
        {
            this.SetBreakpointValues(option, Breakpoint.Widescreen, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentResizable OnWidescreenAndSmaller(ResizableOption option)
        {
            this.SetBreakpointValues(option, Breakpoint.Mobile, Breakpoint.Tablet, Breakpoint.Desktop, Breakpoint.Widescreen);
            return this;
        }

        /// <inheritdoc/>
        public bool Equals(IResizable other)
        {
            return string.Equals(this.Class, other.Class);
        }

        private string BuildClass()
        {
            StringBuilder builder = new StringBuilder();

            foreach (var kvp in this.breakpointDictionary)
            {
                builder.Append($"flex-resize{kvp.Key}-{kvp.Value} ");
            }

            return builder.ToString().Trim();
        }

        private void SetBreakpointValues(ResizableOption value, params Breakpoint[] breakpoints)
        {
            foreach (var breakpoint in breakpoints)
            {
                this.breakpointDictionary[breakpoint] = value;
            }
        }
    }
}

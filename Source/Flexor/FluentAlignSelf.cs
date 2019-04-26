// <copyright file="FluentAlignSelf.cs" company="Derek Chasse">
// Copyright (c) Derek Chasse. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Text;

namespace Flexor
{
#pragma warning disable SA1600 // Elements should be documented
    public interface IAlignSelf : ICssBacked, IEquatable<IAlignSelf>
    {
    }

    public interface IFluentAlignSelf : IFluentReactive<IFluentAlignSelf, AlignSelfOption>, IAlignSelf
    {
    }
#pragma warning restore SA1600 // Elements should be documented

    /// <summary>
    /// Define how an individual item is aligned along a flex-line's cross axis.
    /// </summary>
    public class FluentAlignSelf : IFluentAlignSelf
    {
        private readonly Dictionary<Breakpoint, AlignSelfOption> breakpointDictionary = new Dictionary<Breakpoint, AlignSelfOption>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FluentAlignSelf"/> class.
        /// </summary>
        public FluentAlignSelf()
            : this(AlignSelfOption.Stretch)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FluentAlignSelf"/> class.
        /// </summary>
        /// <param name="initialValue">The initial value across all CSS media queries.</param>
        public FluentAlignSelf(AlignSelfOption initialValue)
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
        public bool Equals(IAlignSelf other)
        {
            return string.Equals(this.Class, other.Class);
        }

        /// <inheritdoc/>
        public IFluentAlignSelf OnDesktop(AlignSelfOption option)
        {
            this.SetBreakpointValues(option, Breakpoint.Desktop);
            return this;
        }

        /// <inheritdoc/>
        public IFluentAlignSelf OnDesktopAndLarger(AlignSelfOption option)
        {
            this.SetBreakpointValues(option, Breakpoint.Desktop, Breakpoint.Widescreen, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentAlignSelf OnDesktopAndSmaller(AlignSelfOption option)
        {
            this.SetBreakpointValues(option, Breakpoint.Mobile, Breakpoint.Tablet, Breakpoint.Desktop);
            return this;
        }

        /// <inheritdoc/>
        public IFluentAlignSelf OnFullHD(AlignSelfOption option)
        {
            this.SetBreakpointValues(option, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentAlignSelf OnFullHDAndSmaller(AlignSelfOption option)
        {
            this.SetBreakpointValues(option, Breakpoint.Mobile, Breakpoint.Tablet, Breakpoint.Desktop, Breakpoint.Widescreen, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentAlignSelf OnMobile(AlignSelfOption option)
        {
            this.SetBreakpointValues(option, Breakpoint.Mobile);
            return this;
        }

        /// <inheritdoc/>
        public IFluentAlignSelf OnMobileAndLarger(AlignSelfOption option)
        {
            this.SetBreakpointValues(option, Breakpoint.Mobile, Breakpoint.Tablet, Breakpoint.Desktop, Breakpoint.Widescreen, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentAlignSelf OnTablet(AlignSelfOption option)
        {
            this.SetBreakpointValues(option, Breakpoint.Tablet);
            return this;
        }

        /// <inheritdoc/>
        public IFluentAlignSelf OnTabletAndLarger(AlignSelfOption option)
        {
            this.SetBreakpointValues(option, Breakpoint.Tablet, Breakpoint.Desktop, Breakpoint.Widescreen, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentAlignSelf OnTabletAndSmaller(AlignSelfOption option)
        {
            this.SetBreakpointValues(option, Breakpoint.Mobile, Breakpoint.Tablet);
            return this;
        }

        /// <inheritdoc/>
        public IFluentAlignSelf OnWidescreen(AlignSelfOption option)
        {
            this.SetBreakpointValues(option, Breakpoint.Widescreen);
            return this;
        }

        /// <inheritdoc/>
        public IFluentAlignSelf OnWidescreenAndLarger(AlignSelfOption option)
        {
            this.SetBreakpointValues(option, Breakpoint.Widescreen, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentAlignSelf OnWidescreenAndSmaller(AlignSelfOption option)
        {
            this.SetBreakpointValues(option, Breakpoint.Mobile, Breakpoint.Tablet, Breakpoint.Desktop, Breakpoint.Widescreen);
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

        private void SetBreakpointValues(AlignSelfOption value, params Breakpoint[] breakpoints)
        {
            foreach (var breakpoint in breakpoints)
            {
                this.breakpointDictionary[breakpoint] = value;
            }
        }
    }
}

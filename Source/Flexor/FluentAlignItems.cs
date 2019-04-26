// <copyright file="FluentAlignItems.cs" company="Derek Chasse">
// Copyright (c) Derek Chasse. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Text;

namespace Flexor
{
#pragma warning disable SA1600 // Elements should be documented
    public interface IAlignItems : ICssBacked, IEquatable<IAlignItems>
    {
    }

    public interface IFluentAlignItems : IFluentReactive<IFluentAlignItems, AlignItemsOption>, IAlignItems
    {
    }
#pragma warning restore SA1600 // Elements should be documented

    /// <summary>
    /// Define how items are aligned along a flex-line's cross axis.
    /// </summary>
    public class FluentAlignItems : IFluentAlignItems
    {
        private readonly Dictionary<Breakpoint, AlignItemsOption> breakpointDictionary = new Dictionary<Breakpoint, AlignItemsOption>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FluentAlignItems"/> class.
        /// </summary>
        public FluentAlignItems()
            : this(AlignItemsOption.Stretch)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FluentAlignItems"/> class.
        /// </summary>
        /// <param name="initialValue">The initial value across all CSS media queries.</param>
        public FluentAlignItems(AlignItemsOption initialValue)
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
        public bool Equals(IAlignItems other)
        {
            return string.Equals(this.Class, other.Class);
        }

        /// <inheritdoc/>
        public IFluentAlignItems OnDesktop(AlignItemsOption option)
        {
            this.SetBreakpointValues(option, Breakpoint.Desktop);
            return this;
        }

        /// <inheritdoc/>
        public IFluentAlignItems OnDesktopAndLarger(AlignItemsOption option)
        {
            this.SetBreakpointValues(option, Breakpoint.Desktop, Breakpoint.Widescreen, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentAlignItems OnDesktopAndSmaller(AlignItemsOption option)
        {
            this.SetBreakpointValues(option, Breakpoint.Mobile, Breakpoint.Tablet, Breakpoint.Desktop);
            return this;
        }

        /// <inheritdoc/>
        public IFluentAlignItems OnFullHD(AlignItemsOption option)
        {
            this.SetBreakpointValues(option, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentAlignItems OnFullHDAndSmaller(AlignItemsOption option)
        {
            this.SetBreakpointValues(option, Breakpoint.Mobile, Breakpoint.Tablet, Breakpoint.Desktop, Breakpoint.Widescreen, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentAlignItems OnMobile(AlignItemsOption option)
        {
            this.SetBreakpointValues(option, Breakpoint.Mobile);
            return this;
        }

        /// <inheritdoc/>
        public IFluentAlignItems OnMobileAndLarger(AlignItemsOption option)
        {
            this.SetBreakpointValues(option, Breakpoint.Mobile, Breakpoint.Tablet, Breakpoint.Desktop, Breakpoint.Widescreen, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentAlignItems OnTablet(AlignItemsOption option)
        {
            this.SetBreakpointValues(option, Breakpoint.Tablet);
            return this;
        }

        /// <inheritdoc/>
        public IFluentAlignItems OnTabletAndLarger(AlignItemsOption option)
        {
            this.SetBreakpointValues(option, Breakpoint.Tablet, Breakpoint.Desktop, Breakpoint.Widescreen, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentAlignItems OnTabletAndSmaller(AlignItemsOption option)
        {
            this.SetBreakpointValues(option, Breakpoint.Mobile, Breakpoint.Tablet);
            return this;
        }

        /// <inheritdoc/>
        public IFluentAlignItems OnWidescreen(AlignItemsOption option)
        {
            this.SetBreakpointValues(option, Breakpoint.Widescreen);
            return this;
        }

        /// <inheritdoc/>
        public IFluentAlignItems OnWidescreenAndLarger(AlignItemsOption option)
        {
            this.SetBreakpointValues(option, Breakpoint.Widescreen, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentAlignItems OnWidescreenAndSmaller(AlignItemsOption option)
        {
            this.SetBreakpointValues(option, Breakpoint.Mobile, Breakpoint.Tablet, Breakpoint.Desktop, Breakpoint.Widescreen);
            return this;
        }

        private string BuildClass()
        {
            StringBuilder builder = new StringBuilder();

            foreach (var kvp in this.breakpointDictionary)
            {
                builder.Append($"align-items{kvp.Key}{kvp.Value} ");
            }

            return builder.ToString().Trim();
        }

        private void SetBreakpointValues(AlignItemsOption value, params Breakpoint[] breakpoints)
        {
            foreach (var breakpoint in breakpoints)
            {
                this.breakpointDictionary[breakpoint] = value;
            }
        }
    }
}

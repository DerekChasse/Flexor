// <copyright file="FluentDirection.cs" company="Derek Chasse">
// Copyright (c) Derek Chasse. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Text;

namespace Flexor
{
#pragma warning disable SA1600 // Elements should be documented
    public interface IDirection : ICssBacked, IEquatable<IDirection>
    {
    }

    public interface IFluentDirection : IFluentReactive<IFluentDirection, DirectionOption>, IDirection
    {
    }
#pragma warning restore SA1600 // Elements should be documented

    /// <summary>
    /// Define the direction items are added to a flex-line.
    /// </summary>
    public class FluentDirection : IFluentDirection
    {
        private readonly Dictionary<Breakpoint, DirectionOption> breakpointDictionary = new Dictionary<Breakpoint, DirectionOption>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FluentDirection"/> class.
        /// </summary>
        public FluentDirection()
            : this(DirectionOption.Row)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FluentDirection"/> class.
        /// </summary>
        /// <param name="initialValue">The initial value across all CSS media queries.</param>
        public FluentDirection(DirectionOption initialValue)
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
        public IFluentDirection OnDesktop(DirectionOption option)
        {
            this.breakpointDictionary[Breakpoint.Desktop] = option;
            return this;
        }

        /// <inheritdoc/>
        public IFluentDirection OnDesktopAndLarger(DirectionOption option)
        {
            this.SetBreakpointValues(option, Breakpoint.Desktop, Breakpoint.Widescreen, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentDirection OnDesktopAndSmaller(DirectionOption option)
        {
            this.SetBreakpointValues(option, Breakpoint.Mobile, Breakpoint.Tablet, Breakpoint.Desktop);
            return this;
        }

        /// <inheritdoc/>
        public IFluentDirection OnFullHD(DirectionOption option)
        {
            this.breakpointDictionary[Breakpoint.FullHD] = option;
            return this;
        }

        /// <inheritdoc/>
        public IFluentDirection OnFullHDAndSmaller(DirectionOption option)
        {
            this.SetBreakpointValues(option, Breakpoint.Mobile, Breakpoint.Tablet, Breakpoint.Desktop, Breakpoint.Widescreen, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentDirection OnMobile(DirectionOption option)
        {
            this.breakpointDictionary[Breakpoint.Mobile] = option;
            return this;
        }

        /// <inheritdoc/>
        public IFluentDirection OnMobileAndLarger(DirectionOption option)
        {
            this.SetBreakpointValues(option, Breakpoint.Mobile, Breakpoint.Tablet, Breakpoint.Desktop, Breakpoint.Widescreen, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentDirection OnTablet(DirectionOption option)
        {
            this.breakpointDictionary[Breakpoint.Tablet] = option;
            return this;
        }

        /// <inheritdoc/>
        public IFluentDirection OnTabletAndLarger(DirectionOption option)
        {
            this.SetBreakpointValues(option, Breakpoint.Tablet, Breakpoint.Desktop, Breakpoint.Widescreen, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentDirection OnTabletAndSmaller(DirectionOption option)
        {
            this.SetBreakpointValues(option, Breakpoint.Mobile, Breakpoint.Tablet);
            return this;
        }

        /// <inheritdoc/>
        public IFluentDirection OnWidescreen(DirectionOption option)
        {
            this.breakpointDictionary[Breakpoint.Widescreen] = option;
            return this;
        }

        /// <inheritdoc/>
        public IFluentDirection OnWidescreenAndLarger(DirectionOption option)
        {
            this.SetBreakpointValues(option, Breakpoint.Widescreen, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentDirection OnWidescreenAndSmaller(DirectionOption option)
        {
            this.SetBreakpointValues(option, Breakpoint.Mobile, Breakpoint.Tablet, Breakpoint.Desktop, Breakpoint.Widescreen);
            return this;
        }

        /// <inheritdoc/>
        public bool Equals(IDirection other)
        {
            return string.Equals(this.Class, other.Class);
        }

        private void SetBreakpointValues(DirectionOption value, params Breakpoint[] breakpoints)
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
                builder.Append($"flex{kvp.Key}-{kvp.Value} ");
            }

            return builder.ToString().Trim();
        }
    }
}

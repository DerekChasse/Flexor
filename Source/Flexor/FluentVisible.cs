// <copyright file="FluentVisible.cs" company="Derek Chasse">
// Copyright (c) Derek Chasse. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Text;

namespace Flexor
{
#pragma warning disable SA1600 // Elements should be documented
    public interface IVisible : ICssBacked, IEquatable<IVisible>
    {
    }

    public interface IFluentVisibleWithValue : IVisible
    {
        /// <summary>
        /// Chains visibility breakpoint conditional.
        /// </summary>
        IFluentVisibleWithValueOnBreakpoint And { get; }
    }

    public interface IFluentVisibleWithValueOnBreakpoint : IVisible, IFluentReactive<IFluentVisibleWithValue>
    {
    }
#pragma warning restore SA1600 // Elements should be documented

    /// <summary>
    /// Definition of when a flex-item should be visible.
    /// </summary>
    public class FluentVisible : IFluentVisibleWithValueOnBreakpoint, IFluentVisibleWithValue
    {
        private readonly Dictionary<Breakpoint, bool> breakpointDictionary = new Dictionary<Breakpoint, bool>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FluentVisible"/> class.
        /// </summary>
        public FluentVisible()
            : this(true)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FluentVisible"/> class.
        /// </summary>
        /// <param name="initialValue">The initial visibility across all media query breakpoints.</param>
        public FluentVisible(bool initialValue)
        {
            this.breakpointDictionary.Add(Breakpoint.Mobile, initialValue);
            this.breakpointDictionary.Add(Breakpoint.Tablet, initialValue);
            this.breakpointDictionary.Add(Breakpoint.Desktop, initialValue);
            this.breakpointDictionary.Add(Breakpoint.Widescreen, initialValue);
            this.breakpointDictionary.Add(Breakpoint.FullHD, initialValue);
        }

        /// <inheritdoc/>
        public IFluentVisibleWithValueOnBreakpoint And
        {
            get
            {
                return this;
            }
        }

        /// <inheritdoc/>
        public string Class => this.BuildClass();

        /// <inheritdoc/>
        public IFluentVisibleWithValue OnDesktop()
        {
            this.breakpointDictionary[Breakpoint.Desktop] = true;
            return this;
        }

        /// <inheritdoc/>
        public IFluentVisibleWithValue OnDesktopAndLarger()
        {
            this.SetBreakpointValues(true, Breakpoint.Desktop, Breakpoint.Widescreen, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentVisibleWithValue OnDesktopAndSmaller()
        {
            this.SetBreakpointValues(true, Breakpoint.Mobile, Breakpoint.Tablet, Breakpoint.Desktop);
            return this;
        }

        /// <inheritdoc/>
        public IFluentVisibleWithValue OnFullHD()
        {
            this.breakpointDictionary[Breakpoint.FullHD] = true;
            return this;
        }

        /// <inheritdoc/>
        public IFluentVisibleWithValue OnFullHDAndSmaller()
        {
            this.SetBreakpointValues(true, Breakpoint.Mobile, Breakpoint.Tablet, Breakpoint.Desktop, Breakpoint.Widescreen, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentVisibleWithValue OnMobile()
        {
            this.breakpointDictionary[Breakpoint.Mobile] = true;
            return this;
        }

        /// <inheritdoc/>
        public IFluentVisibleWithValue OnMobileAndLarger()
        {
            this.SetBreakpointValues(true, Breakpoint.Mobile, Breakpoint.Tablet, Breakpoint.Desktop, Breakpoint.Widescreen, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentVisibleWithValue OnTablet()
        {
            this.breakpointDictionary[Breakpoint.Tablet] = true;
            return this;
        }

        /// <inheritdoc/>
        public IFluentVisibleWithValue OnTabletAndLarger()
        {
            this.SetBreakpointValues(true, Breakpoint.Tablet, Breakpoint.Desktop, Breakpoint.Widescreen, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentVisibleWithValue OnTabletAndSmaller()
        {
            this.SetBreakpointValues(true, Breakpoint.Mobile, Breakpoint.Tablet);
            return this;
        }

        /// <inheritdoc/>
        public IFluentVisibleWithValue OnWidescreen()
        {
            this.breakpointDictionary[Breakpoint.Widescreen] = true;
            return this;
        }

        /// <inheritdoc/>
        public IFluentVisibleWithValue OnWidescreenAndLarger()
        {
            this.SetBreakpointValues(true, Breakpoint.Widescreen, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentVisibleWithValue OnWidescreenAndSmaller()
        {
            this.SetBreakpointValues(true, Breakpoint.Mobile, Breakpoint.Tablet, Breakpoint.Desktop, Breakpoint.Widescreen);
            return this;
        }

        /// <inheritdoc/>
        public bool Equals(IVisible other)
        {
            return string.Equals(this.Class, other.Class);
        }

        private string BuildClass()
        {
            StringBuilder builder = new StringBuilder();

            foreach (var kvp in this.breakpointDictionary)
            {
                string shouldShow = kvp.Value ? "show" : "hide";
                builder.Append($"flex{kvp.Key}-{shouldShow} ");
            }

            return builder.ToString().Trim();
        }

        private void SetBreakpointValues(bool value, params Breakpoint[] breakpoints)
        {
            foreach (var breakpoint in breakpoints)
            {
                this.breakpointDictionary[breakpoint] = value;
            }
        }
    }
}

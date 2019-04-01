// <copyright file="FluentJustifyContent.cs" company="Derek Chasse">
// Copyright (c) Derek Chasse. All rights reserved.
// </copyright>

using System.Collections.Generic;

namespace Flexor
{
    public interface IFluentJustifyContent
    {
    }

    public interface IFluentJustifyContentOnBreakpoint : IFluentJustifyContent, IFluentReactive<IFluentJustifyContentOnBreakpointWithValue, SpanAxisAlignment>
    {
    }

    public interface IFluentJustifyContentOnBreakpointWithValue : IFluentJustifyContentOnBreakpoint
    {
    }

    internal class FluentJustifyContent : IFluentJustifyContentOnBreakpointWithValue
    {
        private readonly Dictionary<Breakpoint, SpanAxisAlignment> breakpointDictionary = new Dictionary<Breakpoint, SpanAxisAlignment>();

        public FluentJustifyContent()
            : this(SpanAxisAlignment.Start)
        {
        }

        public FluentJustifyContent(SpanAxisAlignment initialValue)
        {
            this.SetBreakpointValues(initialValue, Breakpoint.Mobile, Breakpoint.Tablet, Breakpoint.Desktop, Breakpoint.Widescreen, Breakpoint.FullHD);
        }

        public IFluentJustifyContentOnBreakpointWithValue OnDesktop(SpanAxisAlignment value)
        {
            this.SetBreakpointValues(value, Breakpoint.Desktop);
            return this;
        }

        /// <inheritdoc/>
        public IFluentJustifyContentOnBreakpointWithValue OnDesktopAndLarger(SpanAxisAlignment value)
        {
            this.SetBreakpointValues(value, Breakpoint.Desktop, Breakpoint.Widescreen, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentJustifyContentOnBreakpointWithValue OnDesktopAndSmaller(SpanAxisAlignment value)
        {
            this.SetBreakpointValues(value, Breakpoint.Mobile, Breakpoint.Tablet, Breakpoint.Desktop);
            return this;
        }

        /// <inheritdoc/>
        public IFluentJustifyContentOnBreakpointWithValue OnFullHD(SpanAxisAlignment value)
        {
            this.SetBreakpointValues(value, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentJustifyContentOnBreakpointWithValue OnFullHDAndSmaller(SpanAxisAlignment value)
        {
            this.SetBreakpointValues(value, Breakpoint.Mobile, Breakpoint.Tablet, Breakpoint.Desktop, Breakpoint.Widescreen, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentJustifyContentOnBreakpointWithValue OnMobile(SpanAxisAlignment value)
        {
            this.SetBreakpointValues(value, Breakpoint.Mobile);
            return this;
        }

        /// <inheritdoc/>
        public IFluentJustifyContentOnBreakpointWithValue OnMobileAndLarger(SpanAxisAlignment value)
        {
            this.SetBreakpointValues(value, Breakpoint.Mobile, Breakpoint.Tablet, Breakpoint.Desktop, Breakpoint.Widescreen, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentJustifyContentOnBreakpointWithValue OnTablet(SpanAxisAlignment value)
        {
            this.SetBreakpointValues(value, Breakpoint.Tablet);
            return this;
        }

        /// <inheritdoc/>
        public IFluentJustifyContentOnBreakpointWithValue OnTabletAndLarger(SpanAxisAlignment value)
        {
            this.SetBreakpointValues(value, Breakpoint.Tablet, Breakpoint.Desktop, Breakpoint.Widescreen, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentJustifyContentOnBreakpointWithValue OnTabletAndSmaller(SpanAxisAlignment value)
        {
            this.SetBreakpointValues(value, Breakpoint.Mobile, Breakpoint.Tablet);
            return this;
        }

        /// <inheritdoc/>
        public IFluentJustifyContentOnBreakpointWithValue OnWidescreen(SpanAxisAlignment value)
        {
            this.SetBreakpointValues(value, Breakpoint.Widescreen);
            return this;
        }

        /// <inheritdoc/>
        public IFluentJustifyContentOnBreakpointWithValue OnWidescreenAndLarger(SpanAxisAlignment value)
        {
            this.SetBreakpointValues(value, Breakpoint.Widescreen, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentJustifyContentOnBreakpointWithValue OnWidescreenAndSmaller(SpanAxisAlignment value)
        {
            this.SetBreakpointValues(value, Breakpoint.Mobile, Breakpoint.Tablet, Breakpoint.Desktop, Breakpoint.Widescreen);
            return this;
        }

        private void SetBreakpointValues(SpanAxisAlignment value, params Breakpoint[] breakpoints)
        {
            foreach (var breakpoint in breakpoints)
            {
                this.breakpointDictionary[breakpoint] = value;
            }
        }
    }
}

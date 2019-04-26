// <copyright file="FluentSize.cs" company="Derek Chasse">
// Copyright (c) Derek Chasse. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Flexor
{
#pragma warning disable SA1600 // Elements should be documented
    public interface ISize : ICssBacked, IDynamicCssBacked, IEquatable<ISize>
    {
    }

    public interface IFluentSizeWithValue : ISize
    {
        IFluentSizeWithValueOnBreakpoint IsPixels(int value);

        IFluentSizeWithValueOnBreakpoint IsPercent(int value);

        IFluentSizeWithValueOnBreakpoint IsElement(decimal value);

        IFluentSizeWithValueOnBreakpoint IsViewportWidth(int value);

        IFluentSizeWithValueOnBreakpoint IsViewportHeight(int value);
    }

    public interface ISizeSetValue
    {
        void SetSize(decimal value, SizeUnit unit);
    }

    public interface IFluentSizeWithValueOnBreakpoint : IFluentReactive<IFluentSizeWithValue>, ISize
    {
        /// <summary>
        /// Configuration value will be applied to all media query breakpoints.
        /// </summary>
        /// <returns>The configuration object.</returns>
        ISize OnAll();
    }

#pragma warning restore SA1600 // Elements should be documented

    /// <summary>
    /// Define the size of an item displayed in a flex-line.
    /// </summary>
    public class FluentSize : IFluentSizeWithValue, IFluentSizeWithValueOnBreakpoint, ISizeSetValue
    {
        private readonly Dictionary<Breakpoint, Measurement> breakpointDictionary = new Dictionary<Breakpoint, Measurement>();
        private readonly Lazy<string> lazyClass;
        private readonly Lazy<IDictionary<string, string>> lazyCss;

        private Measurement valueToApply;

        /// <summary>
        /// Initializes a new instance of the <see cref="FluentSize"/> class.
        /// </summary>
        public FluentSize()
        {
            this.lazyClass = new Lazy<string>(this.InitLazyClass);
            this.lazyCss = new Lazy<IDictionary<string, string>>(this.InitLazyCss);

            this.breakpointDictionary.Add(Breakpoint.Mobile, default);
            this.breakpointDictionary.Add(Breakpoint.Tablet, default);
            this.breakpointDictionary.Add(Breakpoint.Desktop, default);
            this.breakpointDictionary.Add(Breakpoint.Widescreen, default);
            this.breakpointDictionary.Add(Breakpoint.FullHD, default);
        }

        internal FluentSize(decimal value, SizeUnit unit)
            : this()
        {
            this.SetSize(value, unit);

            this.SetBreakpointValues(this.valueToApply, Breakpoint.Mobile, Breakpoint.Tablet, Breakpoint.Desktop, Breakpoint.Widescreen, Breakpoint.FullHD);
        }

        /// <inheritdoc/>
        public string Class => this.lazyClass.Value.Trim();

        /// <inheritdoc/>
        public IDictionary<string, string> Css => this.lazyCss.Value;

        /// <inheritdoc/>
        public IFluentSizeWithValueOnBreakpoint IsElement(decimal value)
        {
            this.SetSize(value, SizeUnit.Element);
            return this;
        }

        /// <inheritdoc/>
        public IFluentSizeWithValueOnBreakpoint IsPercent(int value)
        {
            this.SetSize(value, SizeUnit.Percent);
            return this;
        }

        /// <inheritdoc/>
        public IFluentSizeWithValueOnBreakpoint IsPixels(int value)
        {
            this.SetSize(value, SizeUnit.Pixels);
            return this;
        }

        /// <inheritdoc/>
        public IFluentSizeWithValueOnBreakpoint IsViewportHeight(int value)
        {
            this.SetSize(value, SizeUnit.ViewportHeight);
            return this;
        }

        /// <inheritdoc/>
        public IFluentSizeWithValueOnBreakpoint IsViewportWidth(int value)
        {
            this.SetSize(value, SizeUnit.ViewportWidth);
            return this;
        }

        /// <inheritdoc/>
        public ISize OnAll()
        {
            this.SetBreakpointValues(this.valueToApply, Breakpoint.Mobile, Breakpoint.Tablet, Breakpoint.Desktop, Breakpoint.Widescreen, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentSizeWithValue OnDesktop()
        {
            this.breakpointDictionary[Breakpoint.Desktop] = this.valueToApply;
            return this;
        }

        /// <inheritdoc/>
        public IFluentSizeWithValue OnDesktopAndLarger()
        {
            this.SetBreakpointValues(this.valueToApply, Breakpoint.Desktop, Breakpoint.Widescreen, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentSizeWithValue OnDesktopAndSmaller()
        {
            this.SetBreakpointValues(this.valueToApply, Breakpoint.Mobile, Breakpoint.Tablet, Breakpoint.Desktop);
            return this;
        }

        /// <inheritdoc/>
        public IFluentSizeWithValue OnFullHD()
        {
            this.breakpointDictionary[Breakpoint.FullHD] = this.valueToApply;
            return this;
        }

        /// <inheritdoc/>
        public IFluentSizeWithValue OnFullHDAndSmaller()
        {
            this.SetBreakpointValues(this.valueToApply, Breakpoint.Mobile, Breakpoint.Tablet, Breakpoint.Desktop, Breakpoint.Widescreen, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentSizeWithValue OnMobile()
        {
            this.breakpointDictionary[Breakpoint.Mobile] = this.valueToApply;
            return this;
        }

        /// <inheritdoc/>
        public IFluentSizeWithValue OnMobileAndLarger()
        {
            this.SetBreakpointValues(this.valueToApply, Breakpoint.Mobile, Breakpoint.Tablet, Breakpoint.Desktop, Breakpoint.Widescreen, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentSizeWithValue OnTablet()
        {
            this.breakpointDictionary[Breakpoint.Tablet] = this.valueToApply;
            return this;
        }

        /// <inheritdoc/>
        public IFluentSizeWithValue OnTabletAndLarger()
        {
            this.SetBreakpointValues(this.valueToApply, Breakpoint.Tablet, Breakpoint.Desktop, Breakpoint.Widescreen, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentSizeWithValue OnTabletAndSmaller()
        {
            this.SetBreakpointValues(this.valueToApply, Breakpoint.Mobile, Breakpoint.Tablet);
            return this;
        }

        /// <inheritdoc/>
        public IFluentSizeWithValue OnWidescreen()
        {
            this.breakpointDictionary[Breakpoint.Widescreen] = this.valueToApply;
            return this;
        }

        /// <inheritdoc/>
        public IFluentSizeWithValue OnWidescreenAndLarger()
        {
            this.SetBreakpointValues(this.valueToApply, Breakpoint.Widescreen, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentSizeWithValue OnWidescreenAndSmaller()
        {
            this.SetBreakpointValues(this.valueToApply, Breakpoint.Mobile, Breakpoint.Tablet, Breakpoint.Desktop, Breakpoint.Widescreen);
            return this;
        }

        /// <inheritdoc/>
        public void SetSize(decimal value, SizeUnit unit)
        {
            this.valueToApply = new Measurement { Value = value, Unit = unit };
        }

        /// <inheritdoc/>
        public bool Equals(ISize other)
        {
            return string.Equals(this.Class, other.Class);
        }

        private void SetBreakpointValues(Measurement value, params Breakpoint[] breakpoints)
        {
            foreach (var breakpoint in breakpoints)
            {
                this.breakpointDictionary[breakpoint] = value;
            }
        }

        private IDictionary<string, string> InitLazyCss()
        {
            Dictionary<string, string> cssDictionary = new Dictionary<string, string>();

            foreach (var kvp in this.breakpointDictionary.Where(pair => pair.Value != null))
            {
                StringBuilder builder = new StringBuilder();

                string className = this.BuildDynamicCssClass(builder, kvp.Key, kvp.Value);

                cssDictionary.Add(className, builder.ToString());
            }

            return cssDictionary;
        }

        private string InitLazyClass()
        {
            if (!this.lazyCss.IsValueCreated)
            {
                _ = this.lazyCss.Value;
            }

            return string.Join(" ", this.lazyCss.Value.Keys);
        }

        private string BuildDynamicCssClass(StringBuilder builder, Breakpoint breakpoint, Measurement sizingUnit)
        {
            StringBuilder lineBuilder = new StringBuilder();

            if (breakpoint != Breakpoint.Mobile)
            {
                lineBuilder.Append($"@media (min-width: {breakpoint.MinWidth}px) {{");
            }

            string className = $"flexor{breakpoint}-{sizingUnit.ToCssSuffix()}";

            if (breakpoint == Breakpoint.Mobile)
            {
                lineBuilder.Append($".{className} {{-webkit-flex-basis: {sizingUnit}; flex-basis: {sizingUnit};}}");
            }
            else
            {
                lineBuilder.Append($".{className} {{-webkit-flex-basis: {sizingUnit} !important; flex-basis: {sizingUnit} !important;}}");
            }

            if (breakpoint != Breakpoint.Mobile)
            {
                lineBuilder.Append("}");
            }

            builder.Append(lineBuilder.ToString());

            return className;
        }

        private class Measurement
        {
            public decimal Value { get; set; }

            public SizeUnit Unit { get; set; }

            public override string ToString()
            {
                return $"{this.Value.ToString()}{this.Unit}";
            }

            internal string ToCssSuffix()
            {
                return $"{this.Value.ToString()}-{this.Unit}".Replace("%", "percent");
            }
        }
    }
}

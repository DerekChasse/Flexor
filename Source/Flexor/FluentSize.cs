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

    public interface IFluentSize : ISize, IFluentReactive<IFluentSize, string>
    {
    }

#pragma warning restore SA1600 // Elements should be documented

    /// <summary>
    /// Define the size of an item displayed in a flex-line.
    /// </summary>
    public class FluentSize : IFluentSize
    {
        private readonly Dictionary<Breakpoint, Measurement> breakpointDictionary = new Dictionary<Breakpoint, Measurement>();
        private readonly Lazy<string> lazyClass;
        private readonly Lazy<IDictionary<string, string>> lazyCss;

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

        internal FluentSize(string value)
            : this()
        {
            _ = this.OnMobileAndLarger(value);
        }

        /// <inheritdoc/>
        public string Class => this.lazyClass.Value.Trim();

        /// <inheritdoc/>
        public IDictionary<string, string> Css => this.lazyCss.Value;

        /// <inheritdoc/>
        public IFluentSize OnDesktop(string value)
        {
            this.SetBreakpointValues(value, Breakpoint.Desktop);
            return this;
        }

        /// <inheritdoc/>
        public IFluentSize OnDesktopAndLarger(string value)
        {
            this.SetBreakpointValues(value, Breakpoint.Desktop, Breakpoint.Widescreen, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentSize OnDesktopAndSmaller(string value)
        {
            this.SetBreakpointValues(value, Breakpoint.Mobile, Breakpoint.Tablet, Breakpoint.Desktop);
            return this;
        }

        /// <inheritdoc/>
        public IFluentSize OnFullHD(string value)
        {
            this.SetBreakpointValues(value, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentSize OnFullHDAndSmaller(string value)
        {
            this.SetBreakpointValues(value, Breakpoint.Mobile, Breakpoint.Tablet, Breakpoint.Desktop, Breakpoint.Widescreen, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentSize OnMobile(string value)
        {
            this.SetBreakpointValues(value, Breakpoint.Mobile);
            return this;
        }

        /// <inheritdoc/>
        public IFluentSize OnMobileAndLarger(string value)
        {
            this.SetBreakpointValues(value, Breakpoint.Mobile, Breakpoint.Tablet, Breakpoint.Desktop, Breakpoint.Widescreen, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentSize OnTablet(string value)
        {
            this.SetBreakpointValues(value, Breakpoint.Tablet);
            return this;
        }

        /// <inheritdoc/>
        public IFluentSize OnTabletAndLarger(string value)
        {
            this.SetBreakpointValues(value, Breakpoint.Tablet, Breakpoint.Desktop, Breakpoint.Widescreen, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentSize OnTabletAndSmaller(string value)
        {
            this.SetBreakpointValues(value, Breakpoint.Mobile, Breakpoint.Tablet);
            return this;
        }

        /// <inheritdoc/>
        public IFluentSize OnWidescreen(string value)
        {
            this.SetBreakpointValues(value, Breakpoint.Widescreen);
            return this;
        }

        /// <inheritdoc/>
        public IFluentSize OnWidescreenAndLarger(string value)
        {
            this.SetBreakpointValues(value, Breakpoint.Widescreen, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentSize OnWidescreenAndSmaller(string value)
        {
            this.SetBreakpointValues(value, Breakpoint.Mobile, Breakpoint.Tablet, Breakpoint.Desktop, Breakpoint.Widescreen);
            return this;
        }

        /// <inheritdoc/>
        public bool Equals(ISize other)
        {
            return string.Equals(this.Class, other.Class);
        }

        private void SetBreakpointValues(string value, params Breakpoint[] breakpoints)
        {
            if (Measurement.TryParse(value, out Measurement measurement))
            {
                foreach (var breakpoint in breakpoints)
                {
                    this.breakpointDictionary[breakpoint] = measurement;
                }
            }
            else
            {
                Console.WriteLine($"Unable to parse {value} as a valid measurement.");
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

            public static bool TryParse(string value, out Measurement measurement)
            {
                SizeUnit unit = SizeUnit.Pixels;
                string trimmedValue = value;

                if (value.EndsWith("px"))
                {
                    unit = SizeUnit.Pixels;
                    trimmedValue = value.Replace("px", string.Empty);
                }
                else if (value.EndsWith("%"))
                {
                    unit = SizeUnit.Percent;
                    trimmedValue = value.Replace("%", string.Empty);
                }
                else if (value.EndsWith("em"))
                {
                    unit = SizeUnit.Element;
                    trimmedValue = value.Replace("em", string.Empty);
                }
                else if (value.EndsWith("vh"))
                {
                    unit = SizeUnit.ViewportHeight;
                    trimmedValue = value.Replace("vh", string.Empty);
                }
                else if (value.EndsWith("vw"))
                {
                    unit = SizeUnit.ViewportWidth;
                    trimmedValue = value.Replace("vw", string.Empty);
                }
                else if (char.IsDigit(value.Last()))
                {
                    unit = SizeUnit.Percent;
                }

                if (decimal.TryParse(trimmedValue, out decimal parsedValue))
                {
                    measurement = new Measurement
                    {
                        Unit = unit,
                        Value = parsedValue,
                    };

                    return true;
                }

                measurement = null;
                return false;
            }

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

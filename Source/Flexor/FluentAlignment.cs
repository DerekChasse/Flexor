using System;
using System.Collections.Generic;
using System.Linq;

namespace Flexor
{
    public interface IFluentAlignment
    {
    }

    public interface IFluentSpanAlignment : IFluentAlignment
    {
    }

    public interface IFluentItemAlignment : IFluentAlignment
    {
    }

    public interface IFluentItemAlignmentOnBreakpoint : IFluentItemAlignment, IFluentReactive<IFluentItemAlignmentOnBreakpointWithValue, ItemAxisAlignment>
    {
    }

    public interface IFluentSpanAlignmentOnBreakpoint : IFluentItemAlignment, IFluentReactive<IFluentSpanAlignmentOnBreakpointWithValue, SpanAxisAlignment>
    {
    }

    public interface IFluentItemAlignmentOnBreakpointWithValue : IFluentItemAlignmentOnBreakpoint, IFluentItemAlignment
    {
    }

    public interface IFluentSpanAlignmentOnBreakpointWithValue : IFluentSpanAlignmentOnBreakpoint, IFluentItemAlignment
    {
    }

    public class FluentItemAlignment : IFluentItemAlignmentOnBreakpointWithValue, IFluentItemAlignmentOnBreakpoint, IFluentItemAlignment, IFluentAlignment
    {
        private Dictionary<Breakpoint, ItemAxisAlignment> breakpointDictionary = new Dictionary<Breakpoint, ItemAxisAlignment>();

        public FluentItemAlignment()
            : this(ItemAxisAlignment.Stretch)
        {
        }

        public FluentItemAlignment(ItemAxisAlignment initialValue)
        {
            this.SetBreakpointValues(initialValue, Breakpoint.Mobile, Breakpoint.Tablet, Breakpoint.Desktop, Breakpoint.Widescreen, Breakpoint.FullHD);
        }

        /// <inheritdoc/>
        public IFluentItemAlignmentOnBreakpointWithValue OnDesktop(ItemAxisAlignment value)
        {
            this.SetBreakpointValues(value, Breakpoint.Desktop);
            return this;
        }

        /// <inheritdoc/>
        public IFluentItemAlignmentOnBreakpointWithValue OnDesktopAndLarger(ItemAxisAlignment value)
        {
            this.SetBreakpointValues(value, Breakpoint.Desktop, Breakpoint.Widescreen, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentItemAlignmentOnBreakpointWithValue OnDesktopAndSmaller(ItemAxisAlignment value)
        {
            this.SetBreakpointValues(value, Breakpoint.Mobile, Breakpoint.Tablet, Breakpoint.Desktop);
            return this;
        }

        /// <inheritdoc/>
        public IFluentItemAlignmentOnBreakpointWithValue OnFullHD(ItemAxisAlignment value)
        {
            this.SetBreakpointValues(value, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentItemAlignmentOnBreakpointWithValue OnFullHDAndSmaller(ItemAxisAlignment value)
        {
            this.SetBreakpointValues(value, Breakpoint.Mobile, Breakpoint.Tablet, Breakpoint.Desktop, Breakpoint.Widescreen, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentItemAlignmentOnBreakpointWithValue OnMobile(ItemAxisAlignment value)
        {
            this.SetBreakpointValues(value, Breakpoint.Mobile);
            return this;
        }

        /// <inheritdoc/>
        public IFluentItemAlignmentOnBreakpointWithValue OnMobileAndLarger(ItemAxisAlignment value)
        {
            this.SetBreakpointValues(value, Breakpoint.Mobile, Breakpoint.Tablet, Breakpoint.Desktop, Breakpoint.Widescreen, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentItemAlignmentOnBreakpointWithValue OnTablet(ItemAxisAlignment value)
        {
            this.SetBreakpointValues(value, Breakpoint.Tablet);
            return this;
        }

        /// <inheritdoc/>
        public IFluentItemAlignmentOnBreakpointWithValue OnTabletAndLarger(ItemAxisAlignment value)
        {
            this.SetBreakpointValues(value, Breakpoint.Tablet, Breakpoint.Desktop, Breakpoint.Widescreen, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentItemAlignmentOnBreakpointWithValue OnTabletAndSmaller(ItemAxisAlignment value)
        {
            this.SetBreakpointValues(value, Breakpoint.Mobile, Breakpoint.Tablet);
            return this;
        }

        /// <inheritdoc/>
        public IFluentItemAlignmentOnBreakpointWithValue OnWidescreen(ItemAxisAlignment value)
        {
            this.SetBreakpointValues(value, Breakpoint.Widescreen);
            return this;
        }

        /// <inheritdoc/>
        public IFluentItemAlignmentOnBreakpointWithValue OnWidescreenAndLarger(ItemAxisAlignment value)
        {
            this.SetBreakpointValues(value, Breakpoint.Widescreen, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentItemAlignmentOnBreakpointWithValue OnWidescreenAndSmaller(ItemAxisAlignment value)
        {
            this.SetBreakpointValues(value, Breakpoint.Mobile, Breakpoint.Tablet, Breakpoint.Desktop, Breakpoint.Widescreen);
            return this;
        }

        private void SetBreakpointValues(ItemAxisAlignment value, params Breakpoint[] breakpoints)
        {
            foreach (var breakpoint in breakpoints)
            {
                this.breakpointDictionary[breakpoint] = value;
            }
        }
    }

    public class FluentSpanAlignment : IFluentSpanAlignmentOnBreakpointWithValue, IFluentSpanAlignmentOnBreakpoint, IFluentSpanAlignment, IFluentAlignment
    {
        private Dictionary<Breakpoint, SpanAxisAlignment> breakpointDictionary = new Dictionary<Breakpoint, SpanAxisAlignment>();

        public FluentSpanAlignment()
            : this(SpanAxisAlignment.Start)
        {
        }

        public FluentSpanAlignment(SpanAxisAlignment initialValue)
        {
            this.SetBreakpointValues(initialValue, Breakpoint.Mobile, Breakpoint.Tablet, Breakpoint.Desktop, Breakpoint.Widescreen, Breakpoint.FullHD);
        }

        /// <inheritdoc/>
        public IFluentSpanAlignmentOnBreakpointWithValue OnDesktop(SpanAxisAlignment value)
        {
            this.SetBreakpointValues(value, Breakpoint.Desktop);
            return this;
        }

        /// <inheritdoc/>
        public IFluentSpanAlignmentOnBreakpointWithValue OnDesktopAndLarger(SpanAxisAlignment value)
        {
            this.SetBreakpointValues(value, Breakpoint.Desktop, Breakpoint.Widescreen, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentSpanAlignmentOnBreakpointWithValue OnDesktopAndSmaller(SpanAxisAlignment value)
        {
            this.SetBreakpointValues(value, Breakpoint.Mobile, Breakpoint.Tablet, Breakpoint.Desktop);
            return this;
        }

        /// <inheritdoc/>
        public IFluentSpanAlignmentOnBreakpointWithValue OnFullHD(SpanAxisAlignment value)
        {
            this.SetBreakpointValues(value, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentSpanAlignmentOnBreakpointWithValue OnFullHDAndSmaller(SpanAxisAlignment value)
        {
            this.SetBreakpointValues(value, Breakpoint.Mobile, Breakpoint.Tablet, Breakpoint.Desktop, Breakpoint.Widescreen, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentSpanAlignmentOnBreakpointWithValue OnMobile(SpanAxisAlignment value)
        {
            this.SetBreakpointValues(value, Breakpoint.Mobile);
            return this;
        }

        /// <inheritdoc/>
        public IFluentSpanAlignmentOnBreakpointWithValue OnMobileAndLarger(SpanAxisAlignment value)
        {
            this.SetBreakpointValues(value, Breakpoint.Mobile, Breakpoint.Tablet, Breakpoint.Desktop, Breakpoint.Widescreen, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentSpanAlignmentOnBreakpointWithValue OnTablet(SpanAxisAlignment value)
        {
            this.SetBreakpointValues(value, Breakpoint.Tablet);
            return this;
        }

        /// <inheritdoc/>
        public IFluentSpanAlignmentOnBreakpointWithValue OnTabletAndLarger(SpanAxisAlignment value)
        {
            this.SetBreakpointValues(value, Breakpoint.Tablet, Breakpoint.Desktop, Breakpoint.Widescreen, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentSpanAlignmentOnBreakpointWithValue OnTabletAndSmaller(SpanAxisAlignment value)
        {
            this.SetBreakpointValues(value, Breakpoint.Mobile, Breakpoint.Tablet);
            return this;
        }

        /// <inheritdoc/>
        public IFluentSpanAlignmentOnBreakpointWithValue OnWidescreen(SpanAxisAlignment value)
        {
            this.SetBreakpointValues(value, Breakpoint.Widescreen);
            return this;
        }

        /// <inheritdoc/>
        public IFluentSpanAlignmentOnBreakpointWithValue OnWidescreenAndLarger(SpanAxisAlignment value)
        {
            this.SetBreakpointValues(value, Breakpoint.Widescreen, Breakpoint.FullHD);
            return this;
        }

        /// <inheritdoc/>
        public IFluentSpanAlignmentOnBreakpointWithValue OnWidescreenAndSmaller(SpanAxisAlignment value)
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

    public static class SpanAlignment
    {
        public static IFluentSpanAlignmentOnBreakpoint Is => new FluentSpanAlignment();

        public static IFluentSpanAlignmentOnBreakpoint Start => new FluentSpanAlignment(SpanAxisAlignment.Start);

        public static IFluentSpanAlignmentOnBreakpoint Center => new FluentSpanAlignment(SpanAxisAlignment.Center);

        public static IFluentSpanAlignmentOnBreakpoint End => new FluentSpanAlignment(SpanAxisAlignment.End);

        public static IFluentSpanAlignmentOnBreakpoint SpaceAround => new FluentSpanAlignment(SpanAxisAlignment.SpaceAround);

        public static IFluentSpanAlignmentOnBreakpoint SpaceBetween => new FluentSpanAlignment(SpanAxisAlignment.SpaceBetween);

        public static IFluentSpanAlignmentOnBreakpoint SpaceEvenly => new FluentSpanAlignment(SpanAxisAlignment.SpaceEvenly);
    }

    public static class ItemAlignment
    {
        public static IFluentItemAlignmentOnBreakpoint Is => new FluentItemAlignment();

        public static IFluentItemAlignmentOnBreakpoint Start => new FluentItemAlignment(ItemAxisAlignment.Start);

        public static IFluentItemAlignmentOnBreakpoint Center => new FluentItemAlignment(ItemAxisAlignment.Center);

        public static IFluentItemAlignmentOnBreakpoint End => new FluentItemAlignment(ItemAxisAlignment.End);

        public static IFluentItemAlignmentOnBreakpoint Stretch => new FluentItemAlignment(ItemAxisAlignment.Stretch);

        public static IFluentItemAlignmentOnBreakpoint Baseline => new FluentItemAlignment(ItemAxisAlignment.Baseline);
    }
}

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

    public interface IFluentItemAlignmentOnBreakpoint : IFluentItemAlignment
    {
        IFluentItemAlignmentOnBreakpointWithValue OnMobile(ItemAxisAlignment value);

        IFluentItemAlignmentOnBreakpointWithValue OnTablet(ItemAxisAlignment value);

        IFluentItemAlignmentOnBreakpointWithValue OnDesktop(ItemAxisAlignment value);

        IFluentItemAlignmentOnBreakpointWithValue OnWidescreen(ItemAxisAlignment value);

        IFluentItemAlignmentOnBreakpointWithValue OnFullHD(ItemAxisAlignment value);
    }

    public interface IFluentSpanAlignmentOnBreakpoint : IFluentItemAlignment
    {
        IFluentSpanAlignmentOnBreakpointWithValue OnMobile(SpanAxisAlignment value);

        IFluentSpanAlignmentOnBreakpointWithValue OnTablet(SpanAxisAlignment value);

        IFluentSpanAlignmentOnBreakpointWithValue OnDesktop(SpanAxisAlignment value);

        IFluentSpanAlignmentOnBreakpointWithValue OnWidescreen(SpanAxisAlignment value);

        IFluentSpanAlignmentOnBreakpointWithValue OnFullHD(SpanAxisAlignment value);
    }

    public interface IFluentItemAlignmentOnBreakpointWithValue : IFluentItemAlignmentOnBreakpoint, IFluentItemAlignment
    {
    }

    public interface IFluentSpanAlignmentOnBreakpointWithValue : IFluentSpanAlignmentOnBreakpoint, IFluentItemAlignment
    {
    }

    public class FluentAlignment : IFluentSpanAlignmentOnBreakpointWithValue, IFluentItemAlignmentOnBreakpointWithValue, IFluentSpanAlignmentOnBreakpoint, IFluentItemAlignmentOnBreakpoint, IFluentItemAlignment, IFluentSpanAlignment
    {
        private Dictionary<Breakpoint, ItemAxisAlignment> itemAxisBreakpointDictionary;
        private Dictionary<Breakpoint, SpanAxisAlignment> mainAxisBreakpointDictionary;

        public FluentAlignment()
            : this(SpanAxisAlignment.Start, ItemAxisAlignment.Stretch)
        {
        }

        public FluentAlignment(SpanAxisAlignment defaultValue)
            : this(defaultValue, ItemAxisAlignment.Stretch)
        {
        }

        public FluentAlignment(ItemAxisAlignment defaultValue)
            : this(SpanAxisAlignment.Start, defaultValue)
        {
        }

        private FluentAlignment(SpanAxisAlignment mainAxisDefault, ItemAxisAlignment itemAxisDefault)
        {
            this.InitializeBreakpointDictionaries(mainAxisDefault, itemAxisDefault);
        }

        public IFluentItemAlignmentOnBreakpointWithValue OnDesktop(ItemAxisAlignment value)
        {
            this.itemAxisBreakpointDictionary[Breakpoint.Desktop] = value;
            return this;
        }

        public IFluentSpanAlignmentOnBreakpointWithValue OnDesktop(SpanAxisAlignment value)
        {
            this.mainAxisBreakpointDictionary[Breakpoint.Desktop] = value;
            return this;
        }

        public IFluentItemAlignmentOnBreakpointWithValue OnFullHD(ItemAxisAlignment value)
        {
            this.itemAxisBreakpointDictionary[Breakpoint.FullHD] = value;
            return this;
        }

        public IFluentSpanAlignmentOnBreakpointWithValue OnFullHD(SpanAxisAlignment value)
        {
            this.mainAxisBreakpointDictionary[Breakpoint.FullHD] = value;
            return this;
        }

        public IFluentItemAlignmentOnBreakpointWithValue OnMobile(ItemAxisAlignment value)
        {
            this.itemAxisBreakpointDictionary[Breakpoint.Mobile] = value;
            return this;
        }

        public IFluentSpanAlignmentOnBreakpointWithValue OnMobile(SpanAxisAlignment value)
        {
            this.mainAxisBreakpointDictionary[Breakpoint.Mobile] = value;
            return this;
        }

        public IFluentItemAlignmentOnBreakpointWithValue OnTablet(ItemAxisAlignment value)
        {
            this.itemAxisBreakpointDictionary[Breakpoint.Tablet] = value;
            return this;
        }

        public IFluentSpanAlignmentOnBreakpointWithValue OnTablet(SpanAxisAlignment value)
        {
            this.mainAxisBreakpointDictionary[Breakpoint.Tablet] = value;
            return this;
        }

        public IFluentItemAlignmentOnBreakpointWithValue OnWidescreen(ItemAxisAlignment value)
        {
            this.itemAxisBreakpointDictionary[Breakpoint.Widescreen] = value;
            return this;
        }

        public IFluentSpanAlignmentOnBreakpointWithValue OnWidescreen(SpanAxisAlignment value)
        {
            this.mainAxisBreakpointDictionary[Breakpoint.Widescreen] = value;
            return this;
        }

        private void InitializeBreakpointDictionaries(SpanAxisAlignment spanAxisAlignment, ItemAxisAlignment itemAxisAlignment)
        {
            this.mainAxisBreakpointDictionary = Enum.GetValues(typeof(Breakpoint)).Cast<Breakpoint>().ToDictionary(breakpoint => breakpoint, x => spanAxisAlignment);

            this.itemAxisBreakpointDictionary = Enum.GetValues(typeof(Breakpoint)).Cast<Breakpoint>().ToDictionary(breakpoint => breakpoint, x => itemAxisAlignment);
        }
    }

    public static class Alignment
    {
        public static IFluentSpanAlignmentOnBreakpoint Span => new FluentAlignment(SpanAxisAlignment.Start);

        public static IFluentItemAlignmentOnBreakpoint Item => new FluentAlignment(ItemAxisAlignment.Stretch);

        public static IFluentAlignment Default => new FluentAlignment();

        public static IFluentSpanAlignmentOnBreakpoint SpanWithDefaultAlignment(SpanAxisAlignment value) => new FluentAlignment(value);

        public static IFluentItemAlignmentOnBreakpoint ItemsWithDefaultAlignment(ItemAxisAlignment value) => new FluentAlignment(value);
    }
}

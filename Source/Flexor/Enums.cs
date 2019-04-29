// <copyright file="Enums.cs" company="Derek Chasse">
// Copyright (c) Derek Chasse. All rights reserved.
// </copyright>

using System;

namespace Flexor
{
    /// <summary>
    /// Enumeration of ways items can be rendered in a flex-line.
    /// </summary>
    public class DirectionOption
    {
        private readonly string value;

        private DirectionOption(string value)
        {
            this.value = value;
        }

        /// <summary>
        /// Items within a flex-line are rendered horizontally.
        /// </summary>
        public static DirectionOption Row => new DirectionOption("row");

        /// <summary>
        /// Items within a flex-line are rendered vertically.
        /// </summary>
        public static DirectionOption Column => new DirectionOption("column");

        /// <summary>
        /// Items within a flex-line are rendered horizontally in reverse order.
        /// </summary>
        public static DirectionOption RowReverse => new DirectionOption("row-reverse");

        /// <summary>
        /// Items within a flex-line are rendered vertically in reverse order.
        /// </summary>
        public static DirectionOption ColumnReverse => new DirectionOption("column-reverse");

        public static implicit operator DirectionOption(string value)
        {
            if (value.Equals(Row.value, StringComparison.InvariantCultureIgnoreCase))
            {
                return Row;
            }

            if (value.Equals(Column.value, StringComparison.InvariantCultureIgnoreCase))
            {
                return Column;
            }

            if (value.Equals(RowReverse.value, StringComparison.InvariantCultureIgnoreCase))
            {
                return RowReverse;
            }

            if (value.Equals(ColumnReverse.value, StringComparison.InvariantCultureIgnoreCase))
            {
                return ColumnReverse;
            }

            Console.WriteLine($"{value} is not a supported direction.");
            return null;
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            return this.value;
        }
    }

    /// <summary>
    /// Enumeration of ways items can be rendered across a flex-line.
    /// This impacts items along the flex-line's primary axis.
    /// </summary>
    public class JustifyContentOption
    {
        private readonly string value;

        private JustifyContentOption(string value)
        {
            this.value = value;
        }

        /// <summary>
        /// Items are packed along start of the flex-line's primary axis.
        /// </summary>
        public static JustifyContentOption Start => new JustifyContentOption("start");

        /// <summary>
        /// Items are centered around the flex-line's center-line.
        /// </summary>
        public static JustifyContentOption Center => new JustifyContentOption("center");

        /// <summary>
        /// Items are packed along the end of the flex-line's primary axis.
        /// </summary>
        public static JustifyContentOption End => new JustifyContentOption("end");

        /// <summary>
        /// All items are spaced equally apart.
        /// </summary>
        public static JustifyContentOption SpaceAround => new JustifyContentOption("around");

        /// <summary>
        /// Items are spaced evenly with first and last items in contact
        /// with the start and end of the flex-line.
        /// </summary>
        public static JustifyContentOption SpaceBetween => new JustifyContentOption("between");

        public static implicit operator JustifyContentOption(string value)
        {
            if (value.Equals(Start.value, StringComparison.InvariantCultureIgnoreCase))
            {
                return Start;
            }

            if (value.Equals(Center.value, StringComparison.InvariantCultureIgnoreCase))
            {
                return Center;
            }

            if (value.Equals(End.value, StringComparison.InvariantCultureIgnoreCase))
            {
                return End;
            }

            if (value.Equals(SpaceAround.value, StringComparison.InvariantCultureIgnoreCase))
            {
                return SpaceAround;
            }

            if (value.Equals(SpaceBetween.value, StringComparison.InvariantCultureIgnoreCase))
            {
                return SpaceBetween;
            }

            Console.WriteLine($"{value} is not a supported content justification.");
            return null;
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            return this.value;
        }
    }

    /// <summary>
    /// Enumeration of ways items can be rendered within a flex-line.
    /// This impacts items along the flex-line's cross axis.
    /// </summary>
    public class AlignItemsOption
    {
        private readonly string value;

        private AlignItemsOption(string value)
        {
            this.value = value;
        }

        /// <summary>
        /// Flex-items are placed along the start of the flex-line's cross axis.
        /// </summary>
        public static AlignItemsOption Start => new AlignItemsOption("start");

        /// <summary>
        /// Flex-items are placed along the center of the flex-line's cross axis.
        /// </summary>
        public static AlignItemsOption Center => new AlignItemsOption("center");

        /// <summary>
        /// Flex-items are placed along the end of the flex-line's cross axis.
        /// </summary>
        public static AlignItemsOption End => new AlignItemsOption("end");

        /// <summary>
        /// Flex-items are stretched along the flex-line's cross axis.
        /// </summary>
        public static AlignItemsOption Stretch => new AlignItemsOption("stretch");

        /// <summary>
        /// Flex-items are baseline aligned along the flex-line's cross axis.
        /// </summary>
        public static AlignItemsOption Baseline => new AlignItemsOption("baseline");

        public static implicit operator AlignItemsOption(string value)
        {
            if (value.Equals(Start.value, StringComparison.InvariantCultureIgnoreCase))
            {
                return Start;
            }

            if (value.Equals(Center.value, StringComparison.InvariantCultureIgnoreCase))
            {
                return Center;
            }

            if (value.Equals(End.value, StringComparison.InvariantCultureIgnoreCase))
            {
                return End;
            }

            if (value.Equals(Stretch.value, StringComparison.InvariantCultureIgnoreCase))
            {
                return Stretch;
            }

            if (value.Equals(Baseline.value, StringComparison.InvariantCultureIgnoreCase))
            {
                return Baseline;
            }

            Console.WriteLine($"{value} is not a supported item alignment.");
            return null;
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            return this.value;
        }
    }

    /// <summary>
    /// Enumeration of ways an individual item can be rendered within a flex-line.
    /// This impacts the item along the flex-line's cross axis.
    /// </summary>
    public class AlignSelfOption
    {
        private readonly string value;

        private AlignSelfOption(string value)
        {
            this.value = value;
        }

        /// <summary>
        /// Inherit's the parent flex-line's item alignment definition.
        /// </summary>
        public static AlignSelfOption Auto => new AlignSelfOption("auto");

        /// <summary>
        /// Flex-item is placed on the start of the flex-line's cross axis.
        /// </summary>
        public static AlignSelfOption Start => new AlignSelfOption("start");

        /// <summary>
        /// Flex-item is placed on the center of the flex-line's cross axis.
        /// </summary>
        public static AlignSelfOption Center => new AlignSelfOption("center");

        /// <summary>
        /// Flex-item is placed on the end of the flex-line's cross axis.
        /// </summary>
        public static AlignSelfOption End => new AlignSelfOption("end");

        /// <summary>
        /// Flex-item is stretched across the flex-line's cross axis.
        /// </summary>
        public static AlignSelfOption Stretch => new AlignSelfOption("stretch");

        /// <summary>
        /// Flex-item is baseline aligned along the flex-line's cross axis.
        /// </summary>
        public static AlignSelfOption Baseline => new AlignSelfOption("baseline");

        public static implicit operator AlignSelfOption(string value)
        {
            if (value.Equals(Auto.value, StringComparison.InvariantCultureIgnoreCase))
            {
                return Auto;
            }

            if (value.Equals(Start.value, StringComparison.InvariantCultureIgnoreCase))
            {
                return Start;
            }

            if (value.Equals(Center.value, StringComparison.InvariantCultureIgnoreCase))
            {
                return Center;
            }

            if (value.Equals(End.value, StringComparison.InvariantCultureIgnoreCase))
            {
                return End;
            }

            if (value.Equals(Stretch.value, StringComparison.InvariantCultureIgnoreCase))
            {
                return Stretch;
            }

            if (value.Equals(Baseline.value, StringComparison.InvariantCultureIgnoreCase))
            {
                return Baseline;
            }

            Console.WriteLine($"{value} is not a supported self alignment.");
            return null;
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            return this.value;
        }
    }

    /// <summary>
    /// Enumeration of CSS media query breakpoints.
    /// </summary>
    public class Breakpoint
    {
        private readonly string value;

        private Breakpoint(string value, int minWidth)
        {
            this.value = value;
            this.MinWidth = minWidth;
        }

        /// <summary>
        /// Applicable to device widths of 575 pixels and smaller.
        /// </summary>
        public static Breakpoint Mobile => new Breakpoint(string.Empty, 0);

        /// <summary>
        /// Applicable to device widths between 576 and 767 pixels.
        /// </summary>
        public static Breakpoint Tablet => new Breakpoint("-sm", 576);

        /// <summary>
        /// Applicable to device widths between 768 and 991 pixels.
        /// </summary>
        public static Breakpoint Desktop => new Breakpoint("-md", 768);

        /// <summary>
        /// Applicable to device widths between 992 and 1199 pixels.
        /// </summary>
        public static Breakpoint Widescreen => new Breakpoint("-lg", 992);

        /// <summary>
        /// Applicable to device widths greater than 1200 pixels.
        /// </summary>
        public static Breakpoint FullHD => new Breakpoint("-xl", 1200);

        /// <summary>
        /// Gets the media query trigger's minimum width.
        /// </summary>
        public int MinWidth { get; }

        public static bool operator ==(Breakpoint obj1, Breakpoint obj2)
        {
            return obj1.Equals(obj2);
        }

        public static bool operator !=(Breakpoint obj1, Breakpoint obj2)
        {
            return !obj1.Equals(obj2);
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            return this.value;
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is Breakpoint breakpoint)
            {
                return breakpoint.value == this.value;
            }

            return false;
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            return this.value.GetHashCode();
        }
    }

    /// <summary>
    /// Enumeration of ways items are allowed to resize within a flex-line.
    /// </summary>
    public class ResizabilityOption
    {
        private readonly string value;

        private ResizabilityOption(string value)
        {
            this.value = value;
        }

        /// <summary>
        /// Item will be sized automatically.
        /// </summary>
        public static ResizabilityOption Default => new ResizabilityOption("unset");

        /// <summary>
        /// Item will be sized automatically.
        /// </summary>
        public static ResizabilityOption Auto => new ResizabilityOption("auto");

        /// <summary>
        /// Item will not grow past it's initial size..
        /// </summary>
        public static ResizabilityOption Initial => new ResizabilityOption("initial");

        /// <summary>
        /// Item will not resize.
        /// </summary>
        public static ResizabilityOption None => new ResizabilityOption("none");

        /// <summary>
        /// Item will fill all available horizontal and vertical space within the flex-line.
        /// </summary>
        public static ResizabilityOption Fill => new ResizabilityOption("fill");

        /// <summary>
        /// Item is allowed to grow to fill remaining space.
        /// </summary>
        public static ResizabilityOption Grow => new ResizabilityOption("grow");

        /// <summary>
        /// Item is not allowed to grow.
        /// </summary>
        public static ResizabilityOption NoGrow => new ResizabilityOption("nogrow");

        /// <summary>
        /// Item is not allowed to shrink.
        /// </summary>
        public static ResizabilityOption NoShrink => new ResizabilityOption("noshrink");

        public static implicit operator ResizabilityOption(string value)
        {
            if (value.Equals(Default.value, StringComparison.InvariantCultureIgnoreCase))
            {
                return Default;
            }

            if (value.Equals(Auto.value, StringComparison.InvariantCultureIgnoreCase))
            {
                return Auto;
            }

            if (value.Equals(Initial.value, StringComparison.InvariantCultureIgnoreCase))
            {
                return Initial;
            }

            if (value.Equals(None.value, StringComparison.InvariantCultureIgnoreCase))
            {
                return None;
            }

            if (value.Equals(Fill.value, StringComparison.InvariantCultureIgnoreCase))
            {
                return Fill;
            }

            if (value.Equals(Grow.value, StringComparison.InvariantCultureIgnoreCase))
            {
                return Grow;
            }

            if (value.Equals(NoGrow.value, StringComparison.InvariantCultureIgnoreCase))
            {
                return NoGrow;
            }

            if (value.Equals(NoShrink.value, StringComparison.InvariantCultureIgnoreCase))
            {
                return NoShrink;
            }

            Console.WriteLine($"{value} is not a supported resizability.");
            return null;
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            return this.value;
        }
    }

    /// <summary>
    ///  Enumeration of supported order of items within a flex-line.
    /// </summary>
    public class OrderOption
    {
        private readonly string value;

        private OrderOption(string value)
        {
            this.value = value;
        }

        /// <summary>
        /// Item will always be rendered first on a flex-line.
        /// </summary>
        public static OrderOption First => new OrderOption("first");

        /// <summary>
        /// Item will always be rendered last on a flex-line.
        /// </summary>
        public static OrderOption Last => new OrderOption("last");

        public static implicit operator OrderOption(int value)
        {
            if (value < 0 || value > 12)
            {
                Console.WriteLine($"Order {value} is outside the acceptable range of 0-12.");
                return null;
            }

            return new OrderOption(value.ToString());
        }

        public static implicit operator OrderOption(string value)
        {
            if (value.Equals(First.value, StringComparison.InvariantCultureIgnoreCase))
            {
                return First;
            }

            if (value.Equals(Last.value, StringComparison.InvariantCultureIgnoreCase))
            {
                return Last;
            }

            Console.WriteLine($"{value} is not a supported order.");
            return null;
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            return this.value;
        }
    }

    /// <summary>
    /// Enumeration of possibilities which flex-lines may wrap.
    /// </summary>
    public class WrapOption
    {
        private readonly string value;

        private WrapOption(string value)
        {
            this.value = value;
        }

        /// <summary>
        /// Items remain on a single line and will overflow.
        /// </summary>
        public static WrapOption NoWrap => new WrapOption("-nowrap");

        /// <summary>
        /// Items will be distributed across multiple lines if necessary.
        /// </summary>
        public static WrapOption Wrap => new WrapOption("-wrap");

        /// <summary>
        /// Items will be distributed across multiple lines if necessary.
        /// Additional lines will appear before the previous ones.
        /// </summary>
        public static WrapOption WrapReverse => new WrapOption("-wrap-reverse");

        /// <inheritdoc/>
        public override string ToString()
        {
            return this.value;
        }
    }

    /// <summary>
    /// Enumeration of sizing units used to describe a flex-item.
    /// </summary>
    public class SizeUnit
    {
        private readonly string value;

        private SizeUnit(string value)
        {
            this.value = value;
        }

        /// <summary>
        /// Sized in pixels ('px').
        /// </summary>
        public static SizeUnit Pixels => new SizeUnit("px");

        /// <summary>
        /// Size is a percentage of the flex-line's main-axis.
        /// </summary>
        public static SizeUnit Percent => new SizeUnit("%");

        /// <summary>
        /// Size is in CSS elements ('em').
        /// </summary>
        public static SizeUnit Element => new SizeUnit("em");

        /// <summary>
        /// Size is a representation of viewport height ('vh').
        /// </summary>
        public static SizeUnit ViewportHeight => new SizeUnit("vh");

        /// <summary>
        /// Size is a representation of viewport width ('vw').
        /// </summary>
        public static SizeUnit ViewportWidth => new SizeUnit("vw");

        /// <inheritdoc/>
        public override string ToString()
        {
            return this.value;
        }
    }
}

// <copyright file="Enums.cs" company="Derek Chasse">
// Copyright (c) Derek Chasse. All rights reserved.
// </copyright>

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
        public static DirectionOption Row => new DirectionOption("-row");

        /// <summary>
        /// Items within a flex-line are rendered vertically.
        /// </summary>
        public static DirectionOption Column => new DirectionOption("-column");

        /// <summary>
        /// Items within a flex-line are rendered horizontally in reverse order.
        /// </summary>
        public static DirectionOption RowReverse => new DirectionOption("-row-reverse");

        /// <summary>
        /// Items within a flex-line are rendered vertically in reverse order.
        /// </summary>
        public static DirectionOption ColumnReverse => new DirectionOption("-column-reverse");

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
        public static JustifyContentOption Start => new JustifyContentOption("-start");

        /// <summary>
        /// Items are centered around the flex-line's center-line.
        /// </summary>
        public static JustifyContentOption Center => new JustifyContentOption("-center");

        /// <summary>
        /// Items are packed along the end of the flex-line's primary axis.
        /// </summary>
        public static JustifyContentOption End => new JustifyContentOption("-end");

        /// <summary>
        /// All items are spaced equally apart.
        /// </summary>
        public static JustifyContentOption SpaceAround => new JustifyContentOption("-around");

        /// <summary>
        /// Items are spaced evenly with first and last items in contact
        /// with the start and end of the flex-line.
        /// </summary>
        public static JustifyContentOption SpaceBetween => new JustifyContentOption("-between");

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
        public static AlignItemsOption Start => new AlignItemsOption("-start");

        /// <summary>
        /// Flex-items are placed along the center of the flex-line's cross axis.
        /// </summary>
        public static AlignItemsOption Center => new AlignItemsOption("-center");

        /// <summary>
        /// Flex-items are placed along the end of the flex-line's cross axis.
        /// </summary>
        public static AlignItemsOption End => new AlignItemsOption("-end");

        /// <summary>
        /// Flex-items are stretched along the flex-line's cross axis.
        /// </summary>
        public static AlignItemsOption Stretch => new AlignItemsOption("-stretch");

        /// <summary>
        /// Flex-items are baseline aligned along the flex-line's cross axis.
        /// </summary>
        public static AlignItemsOption Baseline => new AlignItemsOption("-baseline");

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
        public static AlignSelfOption Auto => new AlignSelfOption("-auto");

        /// <summary>
        /// Flex-item is placed on the start of the flex-line's cross axis.
        /// </summary>
        public static AlignSelfOption Start => new AlignSelfOption("-start");

        /// <summary>
        /// Flex-item is placed on the center of the flex-line's cross axis.
        /// </summary>
        public static AlignSelfOption Center => new AlignSelfOption("-center");

        /// <summary>
        /// Flex-item is placed on the end of the flex-line's cross axis.
        /// </summary>
        public static AlignSelfOption End => new AlignSelfOption("-end");

        /// <summary>
        /// Flex-item is stretched across the flex-line's cross axis.
        /// </summary>
        public static AlignSelfOption Stretch => new AlignSelfOption("-stretch");

        /// <summary>
        /// Flex-item is baseline aligned along the flex-line's cross axis.
        /// </summary>
        public static AlignSelfOption Baseline => new AlignSelfOption("-baseline");

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
        public static ResizabilityOption Default => new ResizabilityOption("-unset");

        /// <summary>
        /// Item will be sized automatically.
        /// </summary>
        public static ResizabilityOption Auto => new ResizabilityOption("-auto");

        /// <summary>
        /// Item will not grow past it's initial size..
        /// </summary>
        public static ResizabilityOption Initial => new ResizabilityOption("-initial");

        /// <summary>
        /// Item will not resize.
        /// </summary>
        public static ResizabilityOption None => new ResizabilityOption("-none");

        /// <summary>
        /// Item will fill all available horizontal and vertical space within the flex-line.
        /// </summary>
        public static ResizabilityOption Fill => new ResizabilityOption("-fill");

        /// <summary>
        /// Item is allowed to grow to fill remaining space.
        /// </summary>
        public static ResizabilityOption Grow => new ResizabilityOption("-grow");

        /// <summary>
        /// Item is not allowed to grow.
        /// </summary>
        public static ResizabilityOption NoGrow => new ResizabilityOption("-nogrow");

        /// <summary>
        /// Item is not allowed to shrink.
        /// </summary>
        public static ResizabilityOption NoShrink => new ResizabilityOption("-noshrink");

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

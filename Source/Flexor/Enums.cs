// <copyright file="Enums.cs" company="Derek Chasse">
// Copyright (c) Derek Chasse. All rights reserved.
// </copyright>

namespace Flexor
{
    /// <summary>
    /// Enumeration of ways items can be rendered within a layout.
    /// </summary>
    public class DirectionOption
    {
        private readonly string value;

        private DirectionOption(string value)
        {
            this.value = value;
        }

        /// <summary>
        /// Items within a layout are rendered horizontally.
        /// </summary>
        public static DirectionOption Row => new DirectionOption("-row");

        /// <summary>
        /// Items within a layout are rendered vertically.
        /// </summary>
        public static DirectionOption Column => new DirectionOption("-column");

        /// <summary>
        /// Items within a layout are rendered horizontally in reverse order.
        /// </summary>
        public static DirectionOption RowReverse => new DirectionOption("-row-reverse");

        /// <summary>
        /// Items within a layout are rendered vertically in reverse order.
        /// </summary>
        public static DirectionOption ColumnReverse => new DirectionOption("-column-reverse");

        /// <inheritdoc/>
        public override string ToString()
        {
            return this.value;
        }
    }

    /// <summary>
    /// Enumeration of ways items can be rendered across a layout.
    /// This impacts items along the layout's primary axis.
    /// </summary>
    public class JustificationOption
    {
        private readonly string value;

        private JustificationOption(string value)
        {
            this.value = value;
        }

        /// <summary>
        /// Items are packed along start of the layout's primary axis.
        /// </summary>
        public static JustificationOption Start => new JustificationOption("-start");

        /// <summary>
        /// Items are centered around the layout's center-line.
        /// </summary>
        public static JustificationOption Center => new JustificationOption("-center");

        /// <summary>
        /// Items are packed along the end of the layout's primary axis.
        /// </summary>
        public static JustificationOption End => new JustificationOption("-end");

        /// <summary>
        /// All items are spaced equally apart.
        /// </summary>
        public static JustificationOption SpaceAround => new JustificationOption("-around");

        /// <summary>
        /// Items are spaced evenly with first and last items in contact
        /// with the start and end of a layout.
        /// </summary>
        public static JustificationOption SpaceBetween => new JustificationOption("-between");

        /// <inheritdoc/>
        public override string ToString()
        {
            return this.value;
        }
    }

    /// <summary>
    /// Enumeration of ways items can be rendered within a layout.
    /// This impacts items along the layout's cross axis.
    /// </summary>
    public class ItemAlignmentOption
    {
        private readonly string value;

        private ItemAlignmentOption(string value)
        {
            this.value = value;
        }

        /// <summary>
        /// Placed along the start of the cross axis.
        /// </summary>
        public static ItemAlignmentOption Start => new ItemAlignmentOption("-start");

        /// <summary>
        /// Centered along the primary axis.
        /// </summary>
        public static ItemAlignmentOption Center => new ItemAlignmentOption("-center");

        /// <summary>
        /// Placed along the end of the cross axis.
        /// </summary>
        public static ItemAlignmentOption End => new ItemAlignmentOption("-end");

        /// <summary>
        /// Stretch to fill the layout.
        /// </summary>
        public static ItemAlignmentOption Stretch => new ItemAlignmentOption("-stretch");

        /// <summary>
        /// Items are aligned such that their baselines align.
        /// </summary>
        public static ItemAlignmentOption Baseline => new ItemAlignmentOption("-baseline");

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

        /// <inheritdoc/>
        public override string ToString()
        {
            return this.value;
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is Breakpoint bp)
            {
                return bp.value == this.value;
            }

            if (obj is Breakpoint)
            {
                return ((Breakpoint)obj).value == this.value;
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
    /// Enumeration of ways items are allowed to resize within a flex-container.
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
        public static ResizabilityOption Auto => new ResizabilityOption("-auto");

        /// <summary>
        /// Item will not resize.
        /// </summary>
        public static ResizabilityOption None => new ResizabilityOption("-none");

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
    /// Enumeration of possibilities which layouts may wrap.
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
        /// Size is a percentage of the flex-container's main-axis.
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

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is SizeUnit)
            {
                return ((SizeUnit)obj).value == this.value;
            }

            return false;
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            return this.value.GetHashCode();
        }
    }
}

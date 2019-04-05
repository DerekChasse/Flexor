// <copyright file="Enums.cs" company="Derek Chasse">
// Copyright (c) Derek Chasse. All rights reserved.
// </copyright>

namespace Flexor
{
    /// <summary>
    /// Enumeration of ways items can be rendered within a layout.
    /// </summary>
    public enum DirectionValue
    {
        /// <summary>
        /// Items within a layout are rendered horizontally.
        /// </summary>
        Row,

        /// <summary>
        /// Items within a layout are rendered vertically.
        /// </summary>
        Column,

        /// <summary>
        /// Items within a layout are rendered horizontally in reverse order.
        /// </summary>
        RowReverse,

        /// <summary>
        /// Items within a layout are rendered vertically in reverse order.
        /// </summary>
        ColumnReverse,
    }

    /// <summary>
    /// Enumeration of ways items can be rendered across a layout.
    /// This impacts items along the layout's primary axis.
    /// </summary>
    public enum JustificationValue
    {
        /// <summary>
        /// Items are packed along start of the layout's primary axis
        /// </summary>
        Start,

        /// <summary>
        /// Items are centered around the layout's center-line.
        /// </summary>
        Center,

        /// <summary>
        /// Items are packed along the end of the layout's primary axis.
        /// </summary>
        End,

        /// <summary>
        /// All items are spaced equally apart.
        /// </summary>
        SpaceAround,

        /// <summary>
        /// Items are spaced evenly with first and last items in contact
        /// with the start and end of a layout.
        /// </summary>
        SpaceBetween,

        /// <summary>
        /// All items and layout start and end are spaced equally apart.
        /// </summary>
        SpaceEvenly,
    }

    /// <summary>
    /// Enumeration of ways items can be rendered within a layout.
    /// This impacts items along the layout's cross axis.
    /// </summary>
    public enum ItemAlignmentValue
    {
        /// <summary>
        /// Placed along the start of the cross axis.
        /// </summary>
        Start,

        /// <summary>
        /// Centered along the primary axis.
        /// </summary>
        Center,

        /// <summary>
        /// Placed along the end of the cross axis.
        /// </summary>
        End,

        /// <summary>
        /// Stretch to fill the layout
        /// </summary>
        Stretch,

        /// <summary>
        /// Items are aligned such that their baselines align.
        /// </summary>
        Baseline,
    }

    /// <summary>
    /// Enumeration of CSS media query breakpoints.
    /// </summary>
    public enum BreakpointValue
    {
        /// <summary>
        /// Unspecified on not impacted by media queries.
        /// </summary>
        None,

        /// <summary>
        /// Applicable to device widths of XXX pixels and smaller.
        /// </summary>
        Mobile,

        /// <summary>
        /// Applicable to device widths between XXX and YYY pixels.
        /// </summary>
        Tablet,

        /// <summary>
        /// Applicable to device widths between XXX and YYY pixels.
        /// </summary>
        Desktop,

        /// <summary>
        /// Applicable to device widths between XXX and YYY pixels.
        /// </summary>
        Widescreen,

        /// <summary>
        /// Applicable to device widths greater than XXX pixels.
        /// </summary>
        FullHD,
    }

    /// <summary>
    /// Enumeration of ways items are allowed to resize within a flex-container.
    /// </summary>
    public enum ResizabilityValue
    {
        /// <summary>
        /// Item will be sized automatically.
        /// </summary>
        Auto,

        /// <summary>
        /// Item will not resize.
        /// </summary>
        None,

        /// <summary>
        /// Item is allowed to grow to fill remaining space.
        /// </summary>
        Grow,

        /// <summary>
        /// Item is not allowed to grow.
        /// </summary>
        NoGrow,

        /// <summary>
        /// Item is not allowed to shrink.
        /// </summary>
        NoShrink,
    }

    /// <summary>
    /// Enumeration of sizing units used to describe a flex-item.
    /// </summary>
    public enum SizeUnit
    {
        /// <summary>
        /// Sized in pixels ('px').
        /// </summary>
        Pixels,

        /// <summary>
        /// Size is a percentage of the flex-container's main-axis.
        /// </summary>
        Percent,

        /// <summary>
        /// Size is in CSS elements ('em').
        /// </summary>
        Element,

        /// <summary>
        /// Size is a representation of viewport height ('vh').
        /// </summary>
        ViewportHeight,

        /// <summary>
        /// Size is a representation of viewport width ('vw').
        /// </summary>
        ViewportWidth,
    }

    /// <summary>
    /// Enumeration of possibilities which layouts may wrap.
    /// </summary>
    public enum WrapValue
    {
        /// <summary>
        /// Items remain on a single line and will overflow.
        /// </summary>
        NoWrap,

        /// <summary>
        /// Items will be distributed across multiple lines if necessary.
        /// </summary>
        Wrap,

        /// <summary>
        /// Items will be distributed across multiple lines if necessary.
        /// Additional lines will appear before the previous ones.
        /// </summary>
        WrapReverse,
    }
}

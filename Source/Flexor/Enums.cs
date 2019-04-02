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
        Auto,

        None,

        Grow,

        Shrink,

        NoGrow,

        NoShrink,
    }
}

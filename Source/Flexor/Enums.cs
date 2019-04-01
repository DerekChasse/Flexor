// <copyright file="Enums.cs" company="Derek Chasse">
// Copyright (c) Derek Chasse. All rights reserved.
// </copyright>

namespace Flexor
{
    /// <summary>
    /// Enumeration of ways items can be rendered within a layout.
    /// </summary>
    public enum Direction
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
    /// This impact items along the layout's primary axis.
    /// </summary>
    public enum SpanAxisAlignment
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

    public enum ItemAxisAlignment
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

    public enum Breakpoint
    {
        None,

        Mobile,

        Tablet,

        Desktop,

        Widescreen,

        FullHD,
    }

    public enum SizeModifier
    {
        Auto,

        None,

        Grow,

        Shrink,

        NoGrow,

        NoShrink,
    }
}

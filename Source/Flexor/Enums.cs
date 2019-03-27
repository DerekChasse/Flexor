// <copyright file="Enums.cs" company="Derek Chasse">
// Copyright (c) Derek Chasse. All rights reserved.
// </copyright>

namespace Flexor
{
    public enum Direction
    {
        Row,

        Column,

        RowReverse,

        ColumnReverse,
    }

    public enum MainAxisAlignment
    {
        Start,

        Center,

        End,

        SpaceAround,

        SpaceBetween,

        SpaceEvenly,
    }

    public enum CrossAxisAlignment
    {
        Start,

        Center,

        End,

        Stretch,

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
}

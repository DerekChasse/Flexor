// <copyright file="Size.cs" company="Derek Chasse">
// Copyright (c) Derek Chasse. All rights reserved.
// </copyright>

namespace Flexor
{
    public static class Size
    {
        public static IFluentSizeOnBreakpoint Is => new FluentSize();
    }
}
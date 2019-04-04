// <copyright file="Size.cs" company="Derek Chasse">
// Copyright (c) Derek Chasse. All rights reserved.
// </copyright>

namespace Flexor
{
    public static class Size
    {
        public static IFluentSizeWithValueOnBreakpoint IsPixels(int value) => new FluentSize(value, SizeUnit.Pixels);

        public static IFluentSizeWithValueOnBreakpoint IsPercent(int value) => new FluentSize(value, SizeUnit.Percent);

        public static IFluentSizeWithValueOnBreakpoint IsElement(decimal value) => new FluentSize(value, SizeUnit.Element);

        public static IFluentSizeWithValueOnBreakpoint IsViewportWidth(int value) => new FluentSize(value, SizeUnit.ViewportWidth);

        public static IFluentSizeWithValueOnBreakpoint IsViewportHeight(int value) => new FluentSize(value, SizeUnit.ViewportHeight);
    }
}

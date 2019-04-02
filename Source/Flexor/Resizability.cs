// <copyright file="Resizability.cs" company="Derek Chasse">
// Copyright (c) Derek Chasse. All rights reserved.
// </copyright>

namespace Flexor
{
    public static class Resizability
    {
        public static IFluentResizabilityOnBreakpoint Grow => new FluentResizability(ResizabilityValue.Grow);

        public static IFluentResizabilityOnBreakpoint Shrink => new FluentResizability(ResizabilityValue.Shrink);

        public static IFluentResizabilityOnBreakpoint Auto => new FluentResizability(ResizabilityValue.Auto);

        public static IFluentResizabilityOnBreakpoint NoGrow => new FluentResizability(ResizabilityValue.NoGrow);

        public static IFluentResizabilityOnBreakpoint NoShrink => new FluentResizability(ResizabilityValue.NoShrink);

        public static IFluentResizabilityOnBreakpoint Initial => new FluentResizability(ResizabilityValue.None);
    }
}

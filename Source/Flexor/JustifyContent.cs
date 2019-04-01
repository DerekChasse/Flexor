// <copyright file="JustifyContent.cs" company="Derek Chasse">
// Copyright (c) Derek Chasse. All rights reserved.
// </copyright>

namespace Flexor
{
    public static class JustifyContent
    {
        public static IJustifyContentOnBreakpointWithValue Is => new FluentJustifyContent();

        public static IJustifyContentOnBreakpointWithValue Start => new FluentJustifyContent(SpanAxisAlignment.Start);

        public static IJustifyContentOnBreakpointWithValue Center => new FluentJustifyContent(SpanAxisAlignment.Center);

        public static IJustifyContentOnBreakpointWithValue End => new FluentJustifyContent(SpanAxisAlignment.End);

        public static IJustifyContentOnBreakpointWithValue SpaceAround => new FluentJustifyContent(SpanAxisAlignment.SpaceAround);

        public static IJustifyContentOnBreakpointWithValue SpaceBetween => new FluentJustifyContent(SpanAxisAlignment.SpaceBetween);

        public static IJustifyContentOnBreakpointWithValue SpaceEvenly => new FluentJustifyContent(SpanAxisAlignment.SpaceEvenly);
    }
}

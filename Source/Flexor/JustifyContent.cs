// <copyright file="JustifyContent.cs" company="Derek Chasse">
// Copyright (c) Derek Chasse. All rights reserved.
// </copyright>

namespace Flexor
{
    /// <summary>
    /// Defines the alignment of items along a flex-container's main axis.
    /// </summary>
    public static class JustifyContent
    {
        /// <summary>
        /// The default alignment of <see cref="Justification.Start"/> across all CSS media query breakpoints.
        /// </summary>
        public static IFluentJustifyContentOnBreakpointWithValue Is => new FluentJustifyContent();

        /// <summary>
        /// Content is aligned along the start line of the flex-container's main axis.
        /// </summary>
        public static IFluentJustifyContentOnBreakpointWithValue Start => new FluentJustifyContent(Justification.Start);

        /// <summary>
        /// Content is centered along the midpoint of the flex-container's main axis.
        /// </summary>
        public static IFluentJustifyContentOnBreakpointWithValue Center => new FluentJustifyContent(Justification.Center);

        /// <summary>
        /// Content is aligned along the end line of the flex-container's main axis.
        /// </summary>
        public static IFluentJustifyContentOnBreakpointWithValue End => new FluentJustifyContent(Justification.End);

        /// <summary>
        /// Content is spaced evenly along the flex container's main axis.
        /// The space between container and adjacent items is half the space between items.
        /// </summary>
        public static IFluentJustifyContentOnBreakpointWithValue SpaceAround => new FluentJustifyContent(Justification.SpaceAround);

        /// <summary>
        /// Content is spaced evenly along the flex container's main axis.
        /// Items touch the container's start and end.
        /// </summary>
        public static IFluentJustifyContentOnBreakpointWithValue SpaceBetween => new FluentJustifyContent(Justification.SpaceBetween);

        /// <summary>
        /// Content is spaced evenly along the flex container's main axis.
        /// The space between all items and container ends are equal.
        /// </summary>
        public static IFluentJustifyContentOnBreakpointWithValue SpaceEvenly => new FluentJustifyContent(Justification.SpaceEvenly);
    }
}

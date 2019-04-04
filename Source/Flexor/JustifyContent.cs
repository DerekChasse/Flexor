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
        /// Content is aligned along the start line of the flex-container's main axis.
        /// Content is rendered this way consistently across all CSS media query breakpoints.
        /// </summary>
        public static IFluentJustifyContent Start => new FluentJustifyContent(JustificationValue.Start);

        /// <summary>
        /// Content is centered along the midpoint of the flex-container's main axis.
        /// Content is rendered this way consistently across all CSS media query breakpoints.
        /// </summary>
        public static IFluentJustifyContent Center => new FluentJustifyContent(JustificationValue.Center);

        /// <summary>
        /// Content is aligned along the end line of the flex-container's main axis.
        /// Content is rendered this way consistently across all CSS media query breakpoints.
        /// </summary>
        public static IFluentJustifyContent End => new FluentJustifyContent(JustificationValue.End);

        /// <summary>
        /// Content is spaced evenly along the flex container's main axis.
        /// Content is rendered this way consistently across all CSS media query breakpoints.
        /// The space between container and adjacent items is half the space between items.
        /// </summary>
        public static IFluentJustifyContent SpaceAround => new FluentJustifyContent(JustificationValue.SpaceAround);

        /// <summary>
        /// Content is spaced evenly along the flex container's main axis.
        /// Content is rendered this way consistently across all CSS media query breakpoints.
        /// Items touch the container's start and end.
        /// </summary>
        public static IFluentJustifyContent SpaceBetween => new FluentJustifyContent(JustificationValue.SpaceBetween);

        /// <summary>
        /// Content is spaced evenly along the flex container's main axis.
        /// Content is rendered this way consistently across all CSS media query breakpoints.
        /// The space between all items and container ends are equal.
        /// </summary>
        public static IFluentJustifyContent SpaceEvenly => new FluentJustifyContent(JustificationValue.SpaceEvenly);

        /// <summary>
        /// Content is rendered by default according to the supplied justification value.
        /// Rendering is configurable based on CSS media query breakpoints.
        /// </summary>
        /// <param name="justification">The default justification value.</param>
        /// <returns>The justification configuration.</returns>
        public static IFluentJustifyContentWithValueOnBreakpoint Is(JustificationValue justification) => new FluentJustifyContent(justification);
    }
}

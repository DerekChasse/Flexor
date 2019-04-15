// <copyright file="Size.cs" company="Derek Chasse">
// Copyright (c) Derek Chasse. All rights reserved.
// </copyright>

namespace Flexor
{
    /// <summary>
    /// Defines the size of an individual flex-item.
    /// </summary>
    public static class Size
    {
        /// <summary>
        /// The flex item's size is unspecified.
        /// </summary>
        /// <returns>The size configuration.</returns>
        public static ISize Default => new FluentSize();

        /// <summary>
        /// The flex item's size is defined in pixels.
        /// </summary>
        /// <param name="value">The flex item's size defined in pixels.</param>
        /// <returns>The size configuration.</returns>
        public static ISize IsPixelsByDefault(int value) => new FluentSize(value, SizeUnit.Pixels);

        /// <summary>
        /// The flex item's size is defined as a percentage of the parent container.
        /// </summary>
        /// <param name="value">The flex item's size defined as a percentage.</param>
        /// <returns>The size configuration.</returns>
        public static ISize IsPercentByDefault(int value) => new FluentSize(value, SizeUnit.Percent);

        /// <summary>
        /// The flex item's size is defined in CSS 'em' format.
        /// </summary>
        /// <param name="value">The flex item's size defined in 'em' units.</param>
        /// <returns>The size configuration.</returns>
        public static ISize IsElementByDefault(decimal value) => new FluentSize(value, SizeUnit.Element);

        /// <summary>
        /// The flex item's size is defined as a proportion of the viewport width 'vw'.
        /// </summary>
        /// <param name="value">The flex item's size defined as a proportion of the viewport width.</param>
        /// <returns>The size configuration.</returns>
        public static ISize IsViewportWidthByDefault(int value) => new FluentSize(value, SizeUnit.ViewportWidth);

        /// <summary>
        /// The flex item's size is defined as a proportion of the viewport height 'vh'.
        /// </summary>
        /// <param name="value">The flex item's size defined as a proportion of the viewport height.</param>
        /// <returns>The size configuration.</returns>
        public static ISize IsViewportHeightByDefault(int value) => new FluentSize(value, SizeUnit.ViewportHeight);

        /// <summary>
        /// The flex item's size is defined in pixels.
        /// </summary>
        /// <param name="value">The flex item's size defined in pixels.</param>
        /// <returns>The size configuration.</returns>
        public static IFluentSizeWithValueOnBreakpoint IsPixels(int value) => new FluentSize().IsPixels(value);

        /// <summary>
        /// The flex item's size is defined as a percentage of the parent container.
        /// </summary>
        /// <param name="value">The flex item's size defined as a percentage.</param>
        /// <returns>The size configuration.</returns>
        public static IFluentSizeWithValueOnBreakpoint IsPercent(int value) => new FluentSize().IsPercent(value);

        /// <summary>
        /// The flex item's size is defined in CSS 'em' format.
        /// </summary>
        /// <param name="value">The flex item's size defined in 'em' units.</param>
        /// <returns>The size configuration.</returns>
        public static IFluentSizeWithValueOnBreakpoint IsElement(decimal value) => new FluentSize().IsElement(value);

        /// <summary>
        /// The flex item's size is defined as a proportion of the viewport width 'vw'.
        /// </summary>
        /// <param name="value">The flex item's size defined as a proportion of the viewport width.</param>
        /// <returns>The size configuration.</returns>
        public static IFluentSizeWithValueOnBreakpoint IsViewportWidth(int value) => new FluentSize().IsViewportWidth(value);

        /// <summary>
        /// The flex item's size is defined as a proportion of the viewport height 'vh'.
        /// </summary>
        /// <param name="value">The flex item's size defined as a proportion of the viewport height.</param>
        /// <returns>The size configuration.</returns>
        public static IFluentSizeWithValueOnBreakpoint IsViewportHeight(int value) => new FluentSize().IsViewportHeight(value);
    }
}

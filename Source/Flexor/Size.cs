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
        /// The flex-item's size is unspecified.
        /// </summary>
        /// <returns>The size configuration.</returns>
        public static IFluentSize Default => new FluentSize();

        /// <summary>
        /// The flex-item's size is unspecified.
        /// </summary>
        /// <returns>The size configuration.</returns>
        public static IFluentSize Is => new FluentSize();

        /// <summary>
        /// The flex-item's size is defined in pixels.
        /// </summary>
        /// <param name="value">The flex-item's size defined in pixels.</param>
        /// <returns>The size configuration.</returns>
        public static ISize IsPixels(int value) => new FluentSize($"{value}px");

        /// <summary>
        /// The flex-item's size is defined as a percentage of the parent flex-line.
        /// </summary>
        /// <param name="value">The flex-item's size defined as a percentage.</param>
        /// <returns>The size configuration.</returns>
        public static ISize IsPercent(int value) => new FluentSize($"{value}%");

        /// <summary>
        /// The flex-item's size is defined in CSS 'em' format.
        /// </summary>
        /// <param name="value">The flex-item's size defined in 'em' units.</param>
        /// <returns>The size configuration.</returns>
        public static ISize IsElement(decimal value) => new FluentSize($"{value}em");

        /// <summary>
        /// The flex-item's size is defined as a proportion of the viewport width 'vw'.
        /// </summary>
        /// <param name="value">The flex-item's size defined as a proportion of the viewport width.</param>
        /// <returns>The size configuration.</returns>
        public static ISize IsViewportWidth(int value) => new FluentSize($"{value}vw");

        /// <summary>
        /// The flex-item's size is defined as a proportion of the viewport height 'vh'.
        /// </summary>
        /// <param name="value">The flex-item's size defined as a proportion of the viewport height.</param>
        /// <returns>The size configuration.</returns>
        public static ISize IsViewportHeight(int value) => new FluentSize($"{value}vh");
    }
}

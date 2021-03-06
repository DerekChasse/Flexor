﻿// <copyright file="AlignSelf.cs" company="Derek Chasse">
// Copyright (c) Derek Chasse. All rights reserved.
// </copyright>

namespace Flexor
{
    /// <summary>
    /// Defines how an individual flex-item is laid out along the flex-line's cross axis.
    /// </summary>
    public static class AlignSelf
    {
        /// <summary>
        /// The individual flex-item inherits the flex-line's item alignment value.
        /// The individual item is rendered this way consistently across all CSS media query breakpoints.
        /// </summary>
        public static IAlignSelf Auto => new FluentAlignSelf(AlignSelfOption.Auto);

        /// <summary>
        /// The individual item is aligned along the start of the flex-line's cross axis.
        /// The individual item is rendered this way consistently across all CSS media query breakpoints.
        /// </summary>
        public static IAlignSelf Start => new FluentAlignSelf(AlignSelfOption.Start);

        /// <summary>
        /// The individual item is aligned along the center of the flex-line's cross axis.
        /// The individual item is rendered this way consistently across all CSS media query breakpoints.
        /// </summary>
        public static IAlignSelf Center => new FluentAlignSelf(AlignSelfOption.Center);

        /// <summary>
        /// The individual item is aligned along the end of the flex-line's cross axis.
        /// The individual item is rendered this way consistently across all CSS media query breakpoints.
        /// </summary>
        public static IAlignSelf End => new FluentAlignSelf(AlignSelfOption.End);

        /// <summary>
        /// The individual item is stretched along the entirety of the flex-line's cross axis.
        /// The individual item is rendered this way consistently across all CSS media query breakpoints.
        /// </summary>
        public static IAlignSelf Stretch => new FluentAlignSelf(AlignSelfOption.Stretch);

        /// <summary>
        /// The individual item is aligned as their baseline is aligned.
        /// The individual item is rendered this way consistently across all CSS media query breakpoints.
        /// </summary>
        public static IAlignSelf Baseline => new FluentAlignSelf(AlignSelfOption.Baseline);

        /// <summary>
        /// The individual item will be rendered using default item alignment.
        /// Rendering is configurable based on CSS media query breakpoints.
        /// </summary>
        /// <returns>The item alignment configuration.</returns>
        public static IFluentAlignSelf Is => new FluentAlignSelf();
    }
}

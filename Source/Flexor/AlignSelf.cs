// <copyright file="AlignSelf.cs" company="Derek Chasse">
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
        public static IAlignSelf Auto => new FluentAlignSelf().Is(AlignSelfOption.Auto).OnAll();

        /// <summary>
        /// The individual item is aligned along the start of the flex-line's cross axis.
        /// The individual item is rendered this way consistently across all CSS media query breakpoints.
        /// </summary>
        public static IAlignSelf Start => new FluentAlignSelf().Is(AlignSelfOption.Start).OnAll();

        /// <summary>
        /// The individual item is aligned along the center of the flex-line's cross axis.
        /// The individual item is rendered this way consistently across all CSS media query breakpoints.
        /// </summary>
        public static IAlignSelf Center => new FluentAlignSelf().Is(AlignSelfOption.Center).OnAll();

        /// <summary>
        /// The individual item is aligned along the end of the flex-line's cross axis.
        /// The individual item is rendered this way consistently across all CSS media query breakpoints.
        /// </summary>
        public static IAlignSelf End => new FluentAlignSelf().Is(AlignSelfOption.End).OnAll();

        /// <summary>
        /// The individual item is stretched along the entirety of the flex-line's cross axis.
        /// The individual item is rendered this way consistently across all CSS media query breakpoints.
        /// </summary>
        public static IAlignSelf Stretch => new FluentAlignSelf().Is(AlignSelfOption.Stretch).OnAll();

        /// <summary>
        /// The individual item is aligned as their baseline is aligned.
        /// The individual item is rendered this way consistently across all CSS media query breakpoints.
        /// </summary>
        public static IAlignSelf Baseline => new FluentAlignSelf().Is(AlignSelfOption.Baseline).OnAll();

        /// <summary>
        /// The individual item will be rendered and configured with the supplied item alignment.
        /// Rendering is configurable based on CSS media query breakpoints.
        /// </summary>
        /// <param name="value">The default item alignment.</param>
        /// <returns>The item alignment configuration.</returns>
        public static IFluentAlignSelfWithValueOnBreakpoint Is(AlignSelfOption value) => new FluentAlignSelf().Is(value);
    }
}

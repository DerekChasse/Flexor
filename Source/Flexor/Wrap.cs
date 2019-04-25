// <copyright file="Wrap.cs" company="Derek Chasse">
// Copyright (c) Derek Chasse. All rights reserved.
// </copyright>

namespace Flexor
{
    /// <summary>
    /// Define the ability of a flex-line to wrap.
    /// </summary>
    public static class Wrap
    {
        /// <summary>
        /// Items remain on a single line and will overflow.
        /// </summary>
        public static IWrap NoWrap => new FluentWrap(WrapOption.NoWrap);

        /// <summary>
        /// Items will be distributed across multiple lines if necessary.
        /// </summary>
        public static IWrap CanWrap => new FluentWrap(WrapOption.Wrap);

        /// <summary>
        /// Items will be distributed across multiple lines if necessary.
        /// Additional lines will appear before the previous ones.
        /// </summary>
        public static IWrap WrapReverse => new FluentWrap(WrapOption.WrapReverse);

        /// <summary>
        /// The default order configuration of an item within a flex-line across all CSS media query breakpoints.
        /// </summary>
        /// <param name="value">The order of the item.</param>
        /// <returns>The order configuration.</returns>
        public static IFluentWrapWithValueOnBreakpoint Is(WrapOption value) => new FluentWrap().Is(value);
    }
}

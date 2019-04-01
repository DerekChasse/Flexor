// <copyright file="AlignSelf.cs" company="Derek Chasse">
// Copyright (c) Derek Chasse. All rights reserved.
// </copyright>

namespace Flexor
{
    public static class AlignSelf
    {
        public static IFluentAlignItemsOnBreakpoint Is => new FluentAlignItems();

        public static IFluentAlignItemsOnBreakpoint Start => new FluentAlignItems(ItemAxisAlignment.Start);

        public static IFluentAlignItemsOnBreakpoint Center => new FluentAlignItems(ItemAxisAlignment.Center);

        public static IFluentAlignItemsOnBreakpoint End => new FluentAlignItems(ItemAxisAlignment.End);

        public static IFluentAlignItemsOnBreakpoint Stretch => new FluentAlignItems(ItemAxisAlignment.Stretch);

        public static IFluentAlignItemsOnBreakpoint Baseline => new FluentAlignItems(ItemAxisAlignment.Baseline);
    }
}

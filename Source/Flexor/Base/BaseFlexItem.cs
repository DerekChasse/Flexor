// <copyright file="BaseFlexItem.cs" company="Derek Chasse">
// Copyright (c) Derek Chasse. All rights reserved.
// </copyright>

using Microsoft.AspNetCore.Components;

namespace Flexor.Base
{
    /// <summary>
    /// Base class for an item to be rendered in a FlexLayout.
    /// </summary>
    public abstract class BaseFlexItem : BaseFlexComponent
    {
        private IFluentOrder order = Flexor.Order.Default;
        private IFluentAlignItems itemAlignment = null;
        ////private bool fill;

        /// <summary>
        /// Defines the order in which items are rendered within the layout.
        ///
        /// Default is 'default'.
        /// </summary>
        [Parameter]
        protected IFluentOrder Order
        {
            get => this.order;
            set
            {
                this.order = value;
                this.StateHasChanged();
            }
        }

        /// <summary>
        /// Defines the alignment of an individual item across the layout's cross axis.
        ///
        /// Default is 'inherit'.
        /// </summary>
        [Parameter]
        protected IFluentAlignItems ItemAlignment
        {
            get => this.itemAlignment;
            set
            {
                this.itemAlignment = value;
                this.StateHasChanged();
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether an item should take up all remaining room within a flex layout.
        /// </summary>
        ////[Parameter]
        ////protected bool Fill
        ////{
        ////    get => this.fill; set
        ////    {
        ////        this.fill = value;
        ////        this.StateHasChanged();
        ////    }
        ////}
    }
}

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
        private IFluentOrder order;
        private IFluentAlignment itemAlignment;
        private bool fill;

        /// <summary>
        /// Gets or sets the order the item is rendered in within the flex layout.
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
        /// Gets or sets a description of how an individual item is alligned within a flex layout.
        /// </summary>
        [Parameter]
        protected IFluentAlignment ItemAlignment
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
        [Parameter]
        protected bool Fill
        {
            get => this.fill; set
            {
                this.fill = value;
                this.StateHasChanged();
            }
        }
    }
}

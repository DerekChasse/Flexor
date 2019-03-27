// <copyright file="BaseFlexItem.cs" company="Derek Chasse">
// Copyright (c) Derek Chasse. All rights reserved.
// </copyright>

using Microsoft.AspNetCore.Components;

namespace Flexor.Base
{
    public abstract class BaseFlexItem : BaseFlexComponent
    {
        private int order;
        private CrossAxisAlignment itemAlignment;
        private bool fill;

        [Parameter]
        protected int Order
        {
            get => this.order;
            set
            {
                this.order = value;
                this.StateHasChanged();
            }
        }

        [Parameter]
        protected CrossAxisAlignment ItemAlignment
        {
            get => this.itemAlignment;
            set
            {
                this.itemAlignment = value;
                this.StateHasChanged();
            }
        }

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

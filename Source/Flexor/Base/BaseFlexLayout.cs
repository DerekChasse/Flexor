// <copyright file="BaseFlexLayout.cs" company="Derek Chasse">
// Copyright (c) Derek Chasse. All rights reserved.
// </copyright>

using Microsoft.AspNetCore.Components;

namespace Flexor.Base
{
    public abstract class BaseFlexLayout : BaseFlexComponent
    {
        private IFluentFlexDirection direction;
        private bool wrap;
        private IFluentJustifyContent spanAlignment;
        private IFluentAlignItems itemAlignment;

        [Parameter]
        protected IFluentFlexDirection Direction
        {
            get => this.direction;
            set
            {
                this.direction = value;
                this.StateHasChanged();
            }
        }

        [Parameter]
        protected bool Wrap
        {
            get => this.wrap;
            set
            {
                this.wrap = value;
                this.StateHasChanged();
            }
        }

        [Parameter]
        protected IFluentJustifyContent SpanAlignment
        {
            get => this.spanAlignment;
            set
            {
                this.spanAlignment = value;
                this.StateHasChanged();
            }
        }

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
    }
}

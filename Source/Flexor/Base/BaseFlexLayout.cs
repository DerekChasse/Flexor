// <copyright file="BaseFlexLayout.cs" company="Derek Chasse">
// Copyright (c) Derek Chasse. All rights reserved.
// </copyright>

using Microsoft.AspNetCore.Components;

namespace Flexor.Base
{
    public abstract class BaseFlexLayout : BaseFlexComponent
    {
        private Direction direction;
        private bool wrap;
        private IFluentAlignment spanAlignment;
        private IFluentAlignment itemAlignment;

        [Parameter]
        protected Direction Direction
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
        protected IFluentAlignment SpanAlignment
        {
            get => this.spanAlignment;
            set
            {
                this.spanAlignment = value;
                this.StateHasChanged();
            }
        }

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
    }
}

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
        private MainAxisAlignment mainAxisAlignment;
        private CrossAxisAlignment crossAxisAlignment;

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
        protected MainAxisAlignment MainAxisAlignment
        {
            get => this.mainAxisAlignment;
            set
            {
                this.mainAxisAlignment = value;
                this.StateHasChanged();
            }
        }

        [Parameter]
        protected CrossAxisAlignment CrossAxisAlignment
        {
            get => this.crossAxisAlignment;
            set
            {
                this.crossAxisAlignment = value;
                this.StateHasChanged();
            }
        }
    }
}

// <copyright file="BaseFlexComponent.cs" company="Derek Chasse">
// Copyright (c) Derek Chasse. All rights reserved.
// </copyright>

using Microsoft.AspNetCore.Components;

namespace Flexor.Base
{
    public abstract class BaseFlexComponent : ComponentBase
    {
        private bool fill = false;
        private bool shrink = false;
        private bool grow = false;

        [Parameter]
        protected RenderFragment ChildContent { get; set; }

        [Parameter]
        protected bool Fill
        {
            get => this.fill;
            set
            {
                this.fill = value;
                this.StateHasChanged();
            }
        }

        [Parameter]
        protected bool Shrink
        {
            get => this.shrink; set
            {
                this.shrink = value;
                this.StateHasChanged();
            }
        }

        [Parameter]
        protected bool Grow
        {
            get => this.grow; set
            {
                this.grow = value;
                this.StateHasChanged();
            }
        }
    }
}

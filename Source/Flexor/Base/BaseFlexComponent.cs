// <copyright file="BaseFlexComponent.cs" company="Derek Chasse">
// Copyright (c) Derek Chasse. All rights reserved.
// </copyright>

using Microsoft.AspNetCore.Components;

namespace Flexor.Base
{
    /// <summary>
    /// Base class for all Flexor componets.
    /// </summary>
    public abstract class BaseFlexComponent : ComponentBase
    {
        private IFluentVisible visible;

        /// <summary>
        /// Gets or sets a configuration describing when a component is visible.
        /// </summary>
        [Parameter]
        protected IFluentVisible Visible
        {
            get => this.visible;
            set
            {
                this.visible = value;
                this.StateHasChanged();
            }
        }
    }
}

// <copyright file="BaseFlexComponent.cs" company="Derek Chasse">
// Copyright (c) Derek Chasse. All rights reserved.
// </copyright>

using Microsoft.AspNetCore.Components;

namespace Flexor.Base
{
    /// <summary>
    /// Base class for all Flexor components.
    /// </summary>
    public abstract class BaseFlexComponent : ComponentBase
    {
        private IFluentVisible visible = Flexor.Visible.Always;

        /// <summary>
        /// Defines when a flex-item is visible.
        ///
        /// Default is 'always'.
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

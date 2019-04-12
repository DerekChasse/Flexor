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
        private IVisible visible = Flexor.Visible.Always;

        /// <summary>
        /// Defines when a flex-item is visible.
        ///
        /// Default is 'always'.
        /// </summary>
        [Parameter]
        protected IVisible Visible
        {
            get => this.visible;
            set
            {
                this.visible = value;
                this.StateHasChanged();
            }
        }

        /// <summary>
        /// The inner content of the component.
        /// </summary>
        [Parameter]
        protected RenderFragment ChildContent
        {
            get;
            set;
        }

        /// <summary>
        /// Flexor specific javascript interop layer.
        /// </summary>
        [Inject]
        protected IFlexorJSInterop Interop { get; set; }
    }
}

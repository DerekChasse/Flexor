// <copyright file="BaseFlexComponent.cs" company="Derek Chasse">
// Copyright (c) Derek Chasse. All rights reserved.
// </copyright>

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.RenderTree;

namespace Flexor.Base
{
    /// <summary>
    /// Base class for all Flexor components.
    /// </summary>
    public abstract class BaseFlexComponent : ComponentBase
    {
        private IVisible visible = Flexor.Visible.Always;
        private string cssClass = string.Empty;
        private string cssStyle = string.Empty;

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
                if (!this.visible.Equals(value))
                {
                    this.visible = value;
                    this.StateHasChanged();
                }
            }
        }

        /// <summary>
        /// Custom CSS class to apply to the component.
        /// </summary>
        [Parameter]
        protected string Class
        {
            get => this.cssClass;
            set
            {
                if (!this.cssClass.Equals(value))
                {
                    this.cssClass = value;
                    this.StateHasChanged();
                }
            }
        }

        /// <summary>
        /// Custom CSS style to apply to the component.
        /// </summary>
        [Parameter]
        protected string Style
        {
            get => this.cssStyle;
            set
            {
                if (!this.cssStyle.Equals(value))
                {
                    this.cssStyle = value;
                    this.StateHasChanged();
                }
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

// <copyright file="BaseFlexLayout.cs" company="Derek Chasse">
// Copyright (c) Derek Chasse. All rights reserved.
// </copyright>

using Microsoft.AspNetCore.Components;

namespace Flexor.Base
{
    /// <summary>
    /// Base class for all Flexor flex-layouts.
    /// </summary>
    public abstract class BaseFlexLayout : BaseFlexComponent
    {
        private IFluentFlexDirection direction = Flexor.Direction.Row;
        private IFluentWrap wrap = Flexor.Wrap.NoWrap;
        private IFluentJustifyContent justifyContent = Flexor.JustifyContent.Start;
        private IFluentAlignItems itemAlignment = Flexor.ItemAlignment.Stretch;

        /// <summary>
        /// Defines the direction in which items are added to the layout.
        ///
        /// Default is 'row'.
        /// </summary>
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

        /// <summary>
        /// Items within the flex-layout will wrap on to multiple lines if necessary.
        ///
        /// Default is 'false'.
        /// </summary>
        [Parameter]
        protected IFluentWrap Wrap
        {
            get => this.wrap;
            set
            {
                this.wrap = value;
                this.StateHasChanged();
            }
        }

        /// <summary>
        /// Defines the alignment of items across the layout's main axis.
        ///
        /// Default is 'start'.
        /// </summary>
        [Parameter]
        protected IFluentJustifyContent JustifyContent
        {
            get => this.justifyContent;
            set
            {
                this.justifyContent = value;
                this.StateHasChanged();
            }
        }

        /// <summary>
        /// Defines the alignment of items across the layout's cross axis.
        ///
        /// Default is 'stretch'.
        /// </summary>
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

// <copyright file="BaseFlexLine.cs" company="Derek Chasse">
// Copyright (c) Derek Chasse. All rights reserved.
// </copyright>

using Microsoft.AspNetCore.Components;

namespace Flexor.Base
{
    /// <summary>
    /// Base class for all flex-lines.
    /// </summary>
    public abstract class BaseFlexLine : BaseFlexComponent
    {
        private IDirection direction = Flexor.Direction.Row;
        private IWrap wrap = Flexor.Wrap.NoWrap;
        private IJustifyContent justifyContent = Flexor.JustifyContent.Start;
        private IAlignItems alignItems = Flexor.AlignItems.Stretch;

        /// <summary>
        /// Defines the direction in which items are added to the flex-line.
        ///
        /// Default is 'row'.
        /// </summary>
        [Parameter]
        protected IDirection Direction
        {
            get => this.direction;
            set
            {
                if (!this.direction.Equals(value))
                {
                    this.direction = value;
                    this.StateHasChanged();
                }
            }
        }

        /// <summary>
        /// Items within the flex-line will wrap on to multiple lines if necessary.
        ///
        /// Default is 'false'.
        /// </summary>
        [Parameter]
        protected IWrap Wrap
        {
            get => this.wrap;
            set
            {
                if (!this.wrap.Equals(value))
                {
                    this.wrap = value;
                    this.StateHasChanged();
                }
            }
        }

        /// <summary>
        /// Defines the alignment of items across the flex-line's main axis.
        ///
        /// Default is 'start'.
        /// </summary>
        [Parameter]
        protected IJustifyContent JustifyContent
        {
            get => this.justifyContent;
            set
            {
                if (!this.justifyContent.Equals(value))
                {
                    this.justifyContent = value;
                    this.StateHasChanged();
                }
            }
        }

        /// <summary>
        /// Gets the flex-line's computed class.
        /// </summary>
        protected string ComputedClass =>
            string.Join(
                " ",
                this.Direction.Class,
                this.AlignItems.Class,
                this.JustifyContent.Class,
                this.Visible.Class,
                this.Wrap.Class,
                this.Class);

        /// <summary>
        /// Defines the alignment of items across the flex-line's cross axis.
        ///
        /// Default is 'stretch'.
        /// </summary>
        [Parameter]
        protected IAlignItems AlignItems
        {
            get => this.alignItems;
            set
            {
                if (!this.alignItems.Equals(value))
                {
                    this.alignItems = value;
                    this.StateHasChanged();
                }
            }
        }
    }
}

// <copyright file="BaseFlexLayout.cs" company="Derek Chasse">
// Copyright (c) Derek Chasse. All rights reserved.
// </copyright>

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.RenderTree;

namespace Flexor.Base
{
    /// <summary>
    /// Base class for all Flexor flex-layouts.
    /// </summary>
    public abstract class BaseFlexLayout : BaseFlexComponent
    {
        private IDirection direction = Flexor.Direction.Row;
        private IWrap wrap = Flexor.Wrap.NoWrap;
        private IJustifyContent justifyContent = Flexor.JustifyContent.Start;
        private IAlignItems itemAlignment = Flexor.AlignItems.Stretch;

        /// <summary>
        /// Defines the direction in which items are added to the layout.
        ///
        /// Default is 'row'.
        /// </summary>
        [Parameter]
        protected IDirection Direction
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
        protected IWrap Wrap
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
        protected IJustifyContent JustifyContent
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
        protected IAlignItems ItemAlignment
        {
            get => this.itemAlignment;
            set
            {
                this.itemAlignment = value;
                this.StateHasChanged();
            }
        }

        /// <inheritdoc/>
        protected override void BuildRenderTree(RenderTreeBuilder builder)
        {
            int seq = 0;

            builder.OpenElement(seq, "div");
            builder.AddAttribute(++seq, "class", this.GetLayoutClassDefinition());

            if (this.ChildContent != null)
            {
                builder.AddContent(++seq, this.ChildContent);
                this.ChildContent = null;
            }

            builder.CloseElement();
        }

        private string GetLayoutClassDefinition()
        {
            return string.Join(
                " ",
                this.Direction.Class,
                this.ItemAlignment.Class,
                this.JustifyContent.Class,
                this.Visible.Class,
                this.Wrap.Class);
        }
    }
}

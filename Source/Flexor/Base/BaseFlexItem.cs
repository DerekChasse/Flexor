// <copyright file="BaseFlexItem.cs" company="Derek Chasse">
// Copyright (c) Derek Chasse. All rights reserved.
// </copyright>

using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.RenderTree;

namespace Flexor.Base
{
    /// <summary>
    /// Base class for an item to be rendered in a FlexLayout.
    /// </summary>
    public abstract class BaseFlexItem : BaseFlexComponent
    {
        private IOrder order = Flexor.Order.Default;
        private IAlignItems itemAlignment = Flexor.ItemAlignment.Start;
        private ISize size = Flexor.Size.Default;

        /// <summary>
        /// Defines the order in which items are rendered within the layout.
        ///
        /// Default is 'default'.
        /// </summary>
        [Parameter]
        protected IOrder Order
        {
            get => this.order;
            set
            {
                this.order = value;
                this.StateHasChanged();
            }
        }

        /// <summary>
        /// Defines the alignment of an individual item across the layout's cross axis.
        ///
        /// Default is 'inherit'.
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

        /// <summary>
        /// Defines the size of a flex-item.
        ///
        /// Default is 'unspecified'.
        /// </summary>
        [Parameter]
        protected ISize Size
        {
            get => this.size;
            set
            {
                this.size = value;
                this.StateHasChanged();
            }
        }

        /// <inheritdoc/>
        protected override Task OnParametersSetAsync()
        {
            base.OnParametersSetAsync();

            foreach (var item in this.size.Css)
            {
                this.Interop.AddDynamicStyle(item.Key, item.Value);
            }

            return Task.CompletedTask;
        }

        /// <inheritdoc/>
        protected override void BuildRenderTree(RenderTreeBuilder builder)
        {
            int seq = 0;

            builder.OpenElement(seq, "div");
            builder.AddAttribute(++seq, "class", this.GetItemClassDefinition());

            if (this.ChildContent != null)
            {
                builder.AddContent(++seq, this.ChildContent);
                this.ChildContent = null;
            }

            builder.CloseElement();
        }

        private string GetItemClassDefinition()
        {
            return string.Join(
                " ",
                this.ItemAlignment.Class,
                this.Visible.Class,
                this.Size.Class);
        }
    }
}

// <copyright file="BaseFlexItem.cs" company="Derek Chasse">
// Copyright (c) Derek Chasse. All rights reserved.
// </copyright>

using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.RenderTree;

namespace Flexor.Base
{
    /// <summary>
    /// Base class for an item to be rendered in a flex-line.
    /// </summary>
    public abstract class BaseFlexItem : BaseFlexComponent
    {
        private IOrder order = Flexor.Order.Default;
        private IAlignSelf alignSelf = Flexor.AlignSelf.Auto;
        private ISize size = Flexor.Size.Default;
        private IResizability resizability = Flexor.Resizability.None;

        /// <summary>
        /// Defines the order in which items are rendered within the flex-line.
        ///
        /// Default is 'default'.
        /// </summary>
        [Parameter]
        protected IOrder Order
        {
            get => this.order;
            set
            {
                if (!this.order.Equals(value))
                {
                    this.order = value;
                    this.StateHasChanged();
                }
            }
        }

        /// <summary>
        /// Defines the alignment of an individual item across the flex-line's cross axis.
        ///
        /// Default is 'auto'.
        /// </summary>
        [Parameter]
        protected IAlignSelf AlignSelf
        {
            get => this.alignSelf;
            set
            {
                if (!this.alignSelf.Equals(value))
                {
                    this.alignSelf = value;
                    this.StateHasChanged();
                }
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
                if (!this.size.Equals(value))
                {
                    this.size = value;
                    this.StateHasChanged();
                }
            }
        }

        /// <summary>
        /// Defines the resizability of a flex-item.
        ///
        /// Default is 'auto'.
        /// </summary>
        [Parameter]
        protected IResizability Resizability
        {
            get => this.resizability;
            set
            {
                if (!this.resizability.Equals(value))
                {
                    this.resizability = value;
                    this.StateHasChanged();
                }
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
            base.BuildRenderTree(builder);

            builder.OpenElement(0, "div");
            builder.AddAttribute(1, "class", this.GetItemClassDefinition());

            if (this.ChildContent != null)
            {
                builder.AddContent(2, this.ChildContent);
                this.ChildContent = null;
            }

            builder.CloseElement();
        }

        private string GetItemClassDefinition()
        {
            return string.Join(
                " ",
                this.AlignSelf.Class,
                this.Visible.Class,
                this.Order.Class,
                this.Resizability.Class,
                this.Size.Class,
                this.Class);
        }
    }
}

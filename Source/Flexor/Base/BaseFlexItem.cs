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
    /// Base class for an item to be rendered in a FlexLayout.
    /// </summary>
    public abstract class BaseFlexItem : BaseFlexComponent
    {
        private IOrder order = Flexor.Order.Default;
        private IAlignSelf selfAlignment = Flexor.AlignSelf.Auto;
        private ISize size = Flexor.Size.Default;
        private IResizability resizability = Flexor.Resizability.Auto;

        private string divId;

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
                if (!this.order.Equals(value))
                {
                    this.order = value;
                    this.StateHasChanged();
                }
            }
        }

        /// <summary>
        /// Defines the alignment of an individual item across the layout's cross axis.
        ///
        /// Default is 'auto'.
        /// </summary>
        [Parameter]
        protected IAlignSelf AlignSelf
        {
            get => this.selfAlignment;
            set
            {
                if (!this.selfAlignment.Equals(value))
                {
                    this.selfAlignment = value;
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
            this.divId = Guid.NewGuid().ToString().Substring(0, 8);

            // TODO - Is this and the subsequent JavaScript necessary?
            builder.AddAttribute(1, "id", this.divId);
            builder.AddAttribute(2, "class", this.GetItemClassDefinition());

            if (this.ChildContent != null)
            {
                builder.AddContent(3, this.ChildContent);
                this.ChildContent = null;
            }

            builder.CloseElement();
        }

        /// <inheritdoc/>
        protected override void OnAfterRender()
        {
            this.Interop.DecorateChild(this.divId, this.GetItemClassDefinition());
            ////this.Interop.UnwrapDiv(this.divId);
        }

        private string GetItemClassDefinition()
        {
            return string.Join(
                " ",
                this.AlignSelf.Class,
                this.Visible.Class,
                this.Order.Class,
                this.Resizability.Class,
                this.Size.Class);
        }
    }
}

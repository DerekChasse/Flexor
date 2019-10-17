// <copyright file="BaseFlexItem.cs" company="Derek Chasse">
// Copyright (c) Derek Chasse. All rights reserved.
// </copyright>

using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

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
        private IResizable resizable = Flexor.Resizable.Default;

        /// <summary>
        /// Defines the order in which items are rendered within the flex-line.
        ///
        /// Default is 'default'.
        /// </summary>
        [Parameter]
        public IOrder Order
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
        public IAlignSelf AlignSelf
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
        public ISize Size
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
        /// Defines the ability to resize a flex-item.
        ///
        /// Default is 'auto'.
        /// </summary>
        [Parameter]
        public IResizable Resizable
        {
            get => this.resizable;
            set
            {
                if (!this.resizable.Equals(value))
                {
                    this.resizable = value;
                    this.StateHasChanged();
                }
            }
        }

        /// <summary>
        /// Gets the flex-item's computed class.
        /// </summary>
        protected string ComputedClass =>
            string.Join(
                " ",
                this.AlignSelf.Class,
                this.Visible.Class,
                this.Order.Class,
                this.Resizable.Class,
                this.Size.Class,
                this.Class);

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
    }
}

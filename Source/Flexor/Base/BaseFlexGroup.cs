// <copyright file="BaseFlexGroup.cs" company="Derek Chasse">
// Copyright (c) Derek Chasse. All rights reserved.
// </copyright>

using Microsoft.AspNetCore.Components;

namespace Flexor.Base
{
    public abstract class BaseFlexGroup : BaseFlexComponent
    {
        private Direction direction = Direction.Horizontal;
        private GroupAlignment groupAlignment = GroupAlignment.Start;
        private ItemAlignment itemAlignment = ItemAlignment.Stretch;
        private bool isWrap = false;

        /// <summary>
        /// Gets or sets a value indicating the direction a which group and its items span.
        /// </summary>
        [Parameter]
        protected Direction Direction
        {
            get => this.direction;
            set
            {
                this.direction = value;
                this.StateHasChanged();
            }
        }

        /// <summary>
        /// Gets or sets a value indicating how items are aligned across a group.
        /// </summary>
        [Parameter]
        protected GroupAlignment GroupAlignment
        {
            get => this.groupAlignment;
            set
            {
                this.groupAlignment = value;
                this.StateHasChanged();
            }
        }

        /// <summary>
        /// Gets or sets a value indicating how items are aligned against a group.
        /// </summary>
        [Parameter]
        protected ItemAlignment ItemAlignment
        {
            get => this.itemAlignment;
            set
            {
                this.itemAlignment = value;
                this.StateHasChanged();
            }
        }

        /// <summary>
        /// Gets or sets a value indicating that a groups items will wrap.
        /// </summary>
        [Parameter]
        protected bool IsWrap
        {
            get => this.isWrap;
            set
            {
                this.isWrap = value;
                this.StateHasChanged();
            }
        }
    }
}

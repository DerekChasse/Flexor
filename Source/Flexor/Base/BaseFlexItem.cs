// <copyright file="BaseFlexItem.cs" company="Derek Chasse">
// Copyright (c) Derek Chasse. All rights reserved.
// </copyright>

namespace Flexor.Base
{
    public abstract class BaseFlexItem : BaseFlexComponent
    {
        private ItemAlignment selfAlignment;

        protected ItemAlignment SelfAlignment
        {
            get => this.selfAlignment;
            set
            {
                this.selfAlignment = value;
                this.StateHasChanged();
            }
        }
    }
}

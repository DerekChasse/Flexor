// <copyright file="BaseFlexComponent.cs" company="Derek Chasse">
// Copyright (c) Derek Chasse. All rights reserved.
// </copyright>

using Microsoft.AspNetCore.Components;

namespace Flexor.Base
{
    public abstract class BaseFlexComponent : ComponentBase
    {
        private bool hide;
        private IFluentShow show;

        [Parameter]
        protected bool Hide
        {
            get { return this.hide; }
            set { this.hide = value; }
        }

        [Parameter]
        protected IFluentShow Show
        {
            get { return this.show; }
            set { this.show = value; }
        }
    }
}

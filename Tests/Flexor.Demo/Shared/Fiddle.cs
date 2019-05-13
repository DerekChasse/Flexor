using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.RenderTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flexor.Demo.Shared
{
    public class Fiddle : ComponentBase
    {

        [Parameter]
        protected string Code { get; set; }

        

        protected override void BuildRenderTree(RenderTreeBuilder builder)
        {
            base.BuildRenderTree(builder);

            builder.OpenElement(0, "div");
            builder.AddAttribute(1, "class", "h-100 mh-100 w-100 mw-100");

            builder.AddMarkupContent(2, this.Code);

            builder.CloseElement();

        }
    }
}

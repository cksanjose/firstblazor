#pragma checksum "C:\GitHub\cksanjose\FirstBlazor\FirstBlazor\Shared\MainLayout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "91e8b2d59b6d621b004c5c0eb302da3a9d418a54"
// <auto-generated/>
#pragma warning disable 1591
namespace FirstBlazor.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Net.Http;
    using Microsoft.AspNetCore.Blazor;
    using Microsoft.AspNetCore.Blazor.Components;
    using Microsoft.AspNetCore.Blazor.Layouts;
    using Microsoft.AspNetCore.Blazor.Routing;
    using FirstBlazor;
    using FirstBlazor.Shared;
    public class MainLayout : BlazorLayoutComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Blazor.RenderTree.RenderTreeBuilder builder)
        {
            base.BuildRenderTree(builder);
            builder.OpenElement(0, "div");
            builder.AddAttribute(1, "class", "sidebar");
            builder.AddContent(2, "\n    ");
            builder.OpenComponent<FirstBlazor.Shared.NavMenu>(3);
            builder.CloseComponent();
            builder.AddContent(4, "\n");
            builder.CloseElement();
            builder.AddContent(5, "\n\n");
            builder.OpenElement(6, "div");
            builder.AddAttribute(7, "class", "main");
            builder.AddContent(8, "\n    ");
            builder.OpenElement(9, "div");
            builder.AddAttribute(10, "class", "top-row px-4");
            builder.AddContent(11, "\n        ");
            builder.OpenElement(12, "a");
            builder.AddAttribute(13, "href", "http://blazor.net");
            builder.AddAttribute(14, "target", "_blank");
            builder.AddAttribute(15, "class", "ml-md-auto");
            builder.AddContent(16, "About");
            builder.CloseElement();
            builder.AddContent(17, "\n    ");
            builder.CloseElement();
            builder.AddContent(18, "\n\n    ");
            builder.OpenElement(19, "div");
            builder.AddAttribute(20, "class", "content px-4");
            builder.AddContent(21, "\n        ");
            builder.AddContent(22, Body);
            builder.AddContent(23, "\n    ");
            builder.CloseElement();
            builder.AddContent(24, "\n");
            builder.CloseElement();
            builder.AddContent(25, "\n\n");
            builder.OpenElement(26, "div");
            builder.AddAttribute(27, "class", "footer");
            builder.AddContent(28, "\n    ");
            builder.OpenComponent<FirstBlazor.Shared.Footer>(29);
            builder.CloseComponent();
            builder.AddContent(30, "\n");
            builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591

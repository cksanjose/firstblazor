#pragma checksum "C:\GitHub\cksanjose\FirstBlazor\FirstBlazor\Shared\NavMenu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "04c03f912e2f1511ba61891c088fdcf1d5998bc1"
// <auto-generated/>
#pragma warning disable 1591
namespace FirstBlazor.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Blazor;
    using Microsoft.AspNetCore.Blazor.Components;
    using System.Net.Http;
    using Microsoft.AspNetCore.Blazor.Layouts;
    using Microsoft.AspNetCore.Blazor.Routing;
    using FirstBlazor;
    using FirstBlazor.Shared;
    public class NavMenu : Microsoft.AspNetCore.Blazor.Components.BlazorComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Blazor.RenderTree.RenderTreeBuilder builder)
        {
            base.BuildRenderTree(builder);
            builder.OpenElement(0, "div");
            builder.AddAttribute(1, "class", "top-row pl-4 navbar navbar-dark");
            builder.AddContent(2, "\n    ");
            builder.OpenElement(3, "a");
            builder.AddAttribute(4, "class", "navbar-brand");
            builder.AddAttribute(5, "href", "/");
            builder.AddContent(6, "FirstBlazor");
            builder.CloseElement();
            builder.AddContent(7, "\n    ");
            builder.OpenElement(8, "button");
            builder.AddAttribute(9, "class", "navbar-toggler");
            builder.AddAttribute(10, "onclick", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetEventHandlerValue<Microsoft.AspNetCore.Blazor.UIMouseEventArgs>(ToggleNavMenu));
            builder.AddContent(11, "\n        ");
            builder.OpenElement(12, "span");
            builder.AddAttribute(13, "class", "navbar-toggler-icon");
            builder.CloseElement();
            builder.AddContent(14, "\n    ");
            builder.CloseElement();
            builder.AddContent(15, "\n");
            builder.CloseElement();
            builder.AddContent(16, "\n\n");
            builder.OpenElement(17, "div");
            builder.AddAttribute(18, "class", collapseNavMenu ? "collapse" : null);
            builder.AddAttribute(19, "onclick", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetEventHandlerValue<Microsoft.AspNetCore.Blazor.UIMouseEventArgs>(ToggleNavMenu));
            builder.AddContent(20, "\n    ");
            builder.OpenElement(21, "ul");
            builder.AddAttribute(22, "class", "nav flex-column");
            builder.AddContent(23, "\n        ");
            builder.OpenElement(24, "li");
            builder.AddAttribute(25, "class", "nav-item px-3");
            builder.AddContent(26, "\n            ");
            builder.OpenComponent<Microsoft.AspNetCore.Blazor.Routing.NavLink>(27);
            builder.AddAttribute(28, "class", "nav-link");
            builder.AddAttribute(29, "href", "/");
            builder.AddAttribute(30, "Match", Microsoft.AspNetCore.Blazor.Components.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Blazor.Routing.NavLinkMatch>(NavLinkMatch.All));
            builder.AddAttribute(31, "ChildContent", (Microsoft.AspNetCore.Blazor.RenderFragment)((builder2) => {
                builder2.AddContent(32, "\n                ");
                builder2.OpenElement(33, "span");
                builder2.AddAttribute(34, "class", "oi oi-home");
                builder2.AddAttribute(35, "aria-hidden", "true");
                builder2.CloseElement();
                builder2.AddContent(36, " Home\n            ");
            }
            ));
            builder.CloseComponent();
            builder.AddContent(37, "\n        ");
            builder.CloseElement();
            builder.AddContent(38, "\n        ");
            builder.OpenElement(39, "li");
            builder.AddAttribute(40, "class", "nav-item px-3");
            builder.AddContent(41, "\n            ");
            builder.OpenComponent<Microsoft.AspNetCore.Blazor.Routing.NavLink>(42);
            builder.AddAttribute(43, "class", "nav-link");
            builder.AddAttribute(44, "href", "/counter");
            builder.AddAttribute(45, "ChildContent", (Microsoft.AspNetCore.Blazor.RenderFragment)((builder2) => {
                builder2.AddContent(46, "\n                ");
                builder2.OpenElement(47, "span");
                builder2.AddAttribute(48, "class", "oi oi-plus");
                builder2.AddAttribute(49, "aria-hidden", "true");
                builder2.CloseElement();
                builder2.AddContent(50, " Counter\n            ");
            }
            ));
            builder.CloseComponent();
            builder.AddContent(51, "\n        ");
            builder.CloseElement();
            builder.AddContent(52, "\n        ");
            builder.OpenElement(53, "li");
            builder.AddAttribute(54, "class", "nav-item px-3");
            builder.AddContent(55, "\n            ");
            builder.OpenComponent<Microsoft.AspNetCore.Blazor.Routing.NavLink>(56);
            builder.AddAttribute(57, "class", "nav-link");
            builder.AddAttribute(58, "href", "/fetchdata");
            builder.AddAttribute(59, "ChildContent", (Microsoft.AspNetCore.Blazor.RenderFragment)((builder2) => {
                builder2.AddContent(60, "\n                ");
                builder2.OpenElement(61, "span");
                builder2.AddAttribute(62, "class", "oi oi-list-rich");
                builder2.AddAttribute(63, "aria-hidden", "true");
                builder2.CloseElement();
                builder2.AddContent(64, " Fetch data\n            ");
            }
            ));
            builder.CloseComponent();
            builder.AddContent(65, "\n        ");
            builder.CloseElement();
            builder.AddContent(66, "\n        ");
            builder.OpenElement(67, "li");
            builder.AddAttribute(68, "class", "nav-item px-3");
            builder.AddContent(69, "\n            ");
            builder.OpenComponent<Microsoft.AspNetCore.Blazor.Routing.NavLink>(70);
            builder.AddAttribute(71, "class", "nav-link");
            builder.AddAttribute(72, "href", "/golfholes");
            builder.AddAttribute(73, "ChildContent", (Microsoft.AspNetCore.Blazor.RenderFragment)((builder2) => {
                builder2.AddContent(74, "\n                ");
                builder2.OpenElement(75, "span");
                builder2.AddAttribute(76, "class", "oi oi-list-rich");
                builder2.AddAttribute(77, "aria-hidden", "true");
                builder2.CloseElement();
                builder2.AddContent(78, " Golf Holes\n            ");
            }
            ));
            builder.CloseComponent();
            builder.AddContent(79, "\n        ");
            builder.CloseElement();
            builder.AddContent(80, "\n        ");
            builder.OpenElement(81, "li");
            builder.AddAttribute(82, "class", "nav-item px-3");
            builder.AddContent(83, "\n            ");
            builder.OpenComponent<Microsoft.AspNetCore.Blazor.Routing.NavLink>(84);
            builder.AddAttribute(85, "class", "nav-link");
            builder.AddAttribute(86, "href", "/spacexlaunches");
            builder.AddAttribute(87, "ChildContent", (Microsoft.AspNetCore.Blazor.RenderFragment)((builder2) => {
                builder2.AddContent(88, "\n                ");
                builder2.OpenElement(89, "span");
                builder2.AddAttribute(90, "class", "oi oi-list-rich");
                builder2.AddAttribute(91, "aria-hidden", "true");
                builder2.CloseElement();
                builder2.AddContent(92, " Space X Launch\n            ");
            }
            ));
            builder.CloseComponent();
            builder.AddContent(93, "\n        ");
            builder.CloseElement();
            builder.AddContent(94, "\n    ");
            builder.CloseElement();
            builder.AddContent(95, "\n");
            builder.CloseElement();
        }
        #pragma warning restore 1998
#line 38 "C:\GitHub\cksanjose\FirstBlazor\FirstBlazor\Shared\NavMenu.cshtml"
            
    bool collapseNavMenu = true;

    void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
    }
}
#pragma warning restore 1591

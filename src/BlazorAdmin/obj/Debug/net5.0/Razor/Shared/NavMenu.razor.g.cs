#pragma checksum "C:\Users\Administrator\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\BlazorAdmin\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "31239926dbff42b1c701b8badc218726bc7d4106"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorAdmin.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Administrator\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\BlazorAdmin\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Administrator\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\BlazorAdmin\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Administrator\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\BlazorAdmin\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Administrator\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\BlazorAdmin\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Administrator\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\BlazorAdmin\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Administrator\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\BlazorAdmin\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Administrator\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\BlazorAdmin\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Administrator\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\BlazorAdmin\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Administrator\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\BlazorAdmin\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Administrator\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\BlazorAdmin\_Imports.razor"
using Microsoft.Extensions.Logging;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Administrator\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\BlazorAdmin\_Imports.razor"
using BlazorAdmin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Administrator\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\BlazorAdmin\_Imports.razor"
using BlazorAdmin.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Administrator\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\BlazorAdmin\_Imports.razor"
using BlazorAdmin.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Administrator\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\BlazorAdmin\_Imports.razor"
using BlazorAdmin.JavaScript;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Administrator\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\BlazorAdmin\_Imports.razor"
using BlazorShared.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Administrator\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\BlazorAdmin\_Imports.razor"
using BlazorShared.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\Administrator\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\BlazorAdmin\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\Administrator\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\BlazorAdmin\_Imports.razor"
using BlazorShared.Models;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : BlazorAdmin.Helpers.BlazorComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "top-row pl-4 navbar navbar-dark");
            __builder.AddMarkupContent(2, "<a class=\"navbar-brand\" href>eShopOnWeb Admin</a>\n    ");
            __builder.OpenElement(3, "button");
            __builder.AddAttribute(4, "class", "navbar-toggler");
            __builder.AddAttribute(5, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 4 "C:\Users\Administrator\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\BlazorAdmin\Shared\NavMenu.razor"
                                             ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(6, "<span class=\"navbar-toggler-icon\"></span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\n\n");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", 
#nullable restore
#line 9 "C:\Users\Administrator\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\BlazorAdmin\Shared\NavMenu.razor"
             NavMenuCssClass

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(10, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 9 "C:\Users\Administrator\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\BlazorAdmin\Shared\NavMenu.razor"
                                        ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(11, "ul");
            __builder.AddAttribute(12, "class", "nav flex-column");
            __builder.OpenElement(13, "li");
            __builder.AddAttribute(14, "class", "nav-item px-3");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(15);
            __builder.AddAttribute(16, "class", "nav-link");
            __builder.AddAttribute(17, "href", "admin");
            __builder.AddAttribute(18, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 12 "C:\Users\Administrator\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\BlazorAdmin\Shared\NavMenu.razor"
                                                          NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(20, "<span class=\"oi oi-home\" aria-hidden=\"true\"></span> Home\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(22);
            __builder.AddAttribute(23, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(24, "li");
                __builder2.AddAttribute(25, "class", "nav-item px-3");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(26);
                __builder2.AddAttribute(27, "class", "nav-link");
                __builder2.AddAttribute(28, "href", "manage/my-account");
                __builder2.AddAttribute(29, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 19 "C:\Users\Administrator\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\BlazorAdmin\Shared\NavMenu.razor"
                                                                              NavLinkMatch.All

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(30, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(31, "<span class=\"oi oi-person\" aria-hidden=\"true\"></span>                         ");
                    __builder3.AddContent(32, 
#nullable restore
#line 20 "C:\Users\Administrator\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\BlazorAdmin\Shared\NavMenu.razor"
                                                                                                       context.User.Identity.Name

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(33, "\n                ");
                __builder2.OpenElement(34, "li");
                __builder2.AddAttribute(35, "class", "nav-item px-3");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(36);
                __builder2.AddAttribute(37, "class", "nav-link");
                __builder2.AddAttribute(38, "href", "logout");
                __builder2.AddAttribute(39, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(40, "<span class=\"oi oi-account-logout\" aria-hidden=\"true\"></span> Logout\n                        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 34 "C:\Users\Administrator\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\BlazorAdmin\Shared\NavMenu.razor"
       

    private bool collapseNavMenu = true;

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591

#pragma checksum "D:\Projects\rezaffikri\Obonator\Obonator.Client\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6fa0197f0fd066933c3089bd1ad7de487a2ca830"
// <auto-generated/>
#pragma warning disable 1591
namespace Obonator.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Projects\rezaffikri\Obonator\Obonator.Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projects\rezaffikri\Obonator\Obonator.Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Projects\rezaffikri\Obonator\Obonator.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Projects\rezaffikri\Obonator\Obonator.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Projects\rezaffikri\Obonator\Obonator.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Projects\rezaffikri\Obonator\Obonator.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Projects\rezaffikri\Obonator\Obonator.Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Projects\rezaffikri\Obonator\Obonator.Client\_Imports.razor"
using Blazorise;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Projects\rezaffikri\Obonator\Obonator.Client\_Imports.razor"
using Blazorise.DataGrid;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Projects\rezaffikri\Obonator\Obonator.Client\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Projects\rezaffikri\Obonator\Obonator.Client\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\Projects\rezaffikri\Obonator\Obonator.Client\_Imports.razor"
using Obonator.Shared.Auth;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\Projects\rezaffikri\Obonator\Obonator.Client\_Imports.razor"
using Obonator.Shared.ServerList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "D:\Projects\rezaffikri\Obonator\Obonator.Client\_Imports.razor"
using Obonator.Library;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "D:\Projects\rezaffikri\Obonator\Obonator.Client\_Imports.razor"
using Obonator.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "D:\Projects\rezaffikri\Obonator\Obonator.Client\_Imports.razor"
using Obonator.Client.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "D:\Projects\rezaffikri\Obonator\Obonator.Client\_Imports.razor"
using Obonator.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "D:\Projects\rezaffikri\Obonator\Obonator.Client\_Imports.razor"
using Obonator.Client.Components.ExtractorBiller;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "D:\Projects\rezaffikri\Obonator\Obonator.Client\_Imports.razor"
using Obonator.Client.Helper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "D:\Projects\rezaffikri\Obonator\Obonator.Client\_Imports.razor"
using Obonator.Client.Components.LogBiller;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "D:\Projects\rezaffikri\Obonator\Obonator.Client\_Imports.razor"
using Obonator.Client.Components.Others;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projects\rezaffikri\Obonator\Obonator.Client\Shared\MainLayout.razor"
using Blazored.Toast.Configuration;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(2, "\r\n        ");
                __builder2.OpenElement(3, "nav");
                __builder2.AddAttribute(4, "class", "obon-navbar is-fixed-bottom");
                __builder2.AddAttribute(5, "role", "navigation");
                __builder2.AddAttribute(6, "aria-label", "main navigation");
                __builder2.AddMarkupContent(7, "\r\n            ");
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "obon-navbar-brand");
                __builder2.AddMarkupContent(10, "\r\n                ");
                __builder2.AddMarkupContent(11, "<a class=\"obon-navbar-item brand-text\" href>\r\n                    OBONATOR\r\n                </a>\r\n                ");
                __builder2.OpenElement(12, "div");
                __builder2.AddAttribute(13, "class", "obon-navbar-burger" + " " + (
#nullable restore
#line 11 "D:\Projects\rezaffikri\Obonator\Obonator.Client\Shared\MainLayout.razor"
                                                NavMenuCssClass

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(14, "aria-label", "menu");
                __builder2.AddAttribute(15, "aria-expanded", "false");
                __builder2.AddAttribute(16, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 11 "D:\Projects\rezaffikri\Obonator\Obonator.Client\Shared\MainLayout.razor"
                                                                                                                   ToggleNavMenu

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(17, "\r\n                    <span></span>\r\n                    <span></span>\r\n                    <span></span>\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(18, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(19, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(20, "\r\n        ");
                __builder2.OpenElement(21, "div");
                __builder2.AddAttribute(22, "class", "obon-main");
                __builder2.AddMarkupContent(23, "\r\n            ");
                __builder2.OpenComponent<Blazored.Toast.BlazoredToasts>(24);
                __builder2.AddAttribute(25, "Position", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazored.Toast.Configuration.ToastPosition>(
#nullable restore
#line 19 "D:\Projects\rezaffikri\Obonator\Obonator.Client\Shared\MainLayout.razor"
                                      ToastPosition.TopRight

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(26, "Timeout", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 20 "D:\Projects\rezaffikri\Obonator\Obonator.Client\Shared\MainLayout.razor"
                                     3

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(27, "IconType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazored.Toast.IconType?>(
#nullable restore
#line 21 "D:\Projects\rezaffikri\Obonator\Obonator.Client\Shared\MainLayout.razor"
                                      IconType.FontAwesome

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(28, "SuccessClass", "success-toast-override");
                __builder2.AddAttribute(29, "SuccessIcon", "fa fa-thumbs-up");
                __builder2.AddAttribute(30, "ErrorIcon", "fa fa-bug");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(31, "\r\n            ");
                __builder2.OpenElement(32, "aside");
                __builder2.AddAttribute(33, "class", "obon-menu" + " is-side" + " has-navbar-fixed-bottom" + " " + (
#nullable restore
#line 25 "D:\Projects\rezaffikri\Obonator\Obonator.Client\Shared\MainLayout.razor"
                                                                     NavMenuCssClass

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(34, "\r\n                ");
                __builder2.OpenComponent<Obonator.Client.Shared.NavMenu>(35);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(36, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(37, "\r\n");
#nullable restore
#line 28 "D:\Projects\rezaffikri\Obonator\Obonator.Client\Shared\MainLayout.razor"
             if (Installable)
            {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(38, "                ");
                __builder2.OpenElement(39, "div");
                __builder2.AddAttribute(40, "class", "fixed-bottom w-100 alert alert-dark d-flex align-items-center");
                __builder2.AddAttribute(41, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 30 "D:\Projects\rezaffikri\Obonator\Obonator.Client\Shared\MainLayout.razor"
                                                                                                     InstallClicked

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(42, "\r\n                    ");
                __builder2.AddMarkupContent(43, "<h3>Install this app?</h3>\r\n                    ");
                __builder2.OpenElement(44, "small");
                __builder2.AddAttribute(45, "class", "ml-auto mr-1 rounded-pill");
                __builder2.OpenElement(46, "button");
                __builder2.AddAttribute(47, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 32 "D:\Projects\rezaffikri\Obonator\Obonator.Client\Shared\MainLayout.razor"
                                                                                 ()=>Installable=false

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(48, "X");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(49, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(50, "\r\n");
#nullable restore
#line 34 "D:\Projects\rezaffikri\Obonator\Obonator.Client\Shared\MainLayout.razor"
            }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(51, "            ");
                __builder2.OpenElement(52, "div");
                __builder2.AddAttribute(53, "class", "obon-section has-navbar-fixed-bottom");
                __builder2.AddMarkupContent(54, "\r\n                ");
                __builder2.AddContent(55, 
#nullable restore
#line 36 "D:\Projects\rezaffikri\Obonator\Obonator.Client\Shared\MainLayout.razor"
                 Body

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(56, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(57, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(58, "\r\n    ");
            }
            ));
            __builder.AddAttribute(59, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(60, "\r\n        ");
                __builder2.OpenElement(61, "div");
                __builder2.AddAttribute(62, "class", "obon-main");
                __builder2.AddMarkupContent(63, "\r\n            ");
                __builder2.OpenElement(64, "div");
                __builder2.AddAttribute(65, "class", "obon-section");
                __builder2.AddMarkupContent(66, "\r\n                ");
                __builder2.AddContent(67, 
#nullable restore
#line 43 "D:\Projects\rezaffikri\Obonator\Obonator.Client\Shared\MainLayout.razor"
                 Body

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(68, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(69, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(70, "\r\n    ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 49 "D:\Projects\rezaffikri\Obonator\Obonator.Client\Shared\MainLayout.razor"
 
    [Inject] IJSRuntime JSRuntime { get; set; }
    static bool Installable = false;
    static Action ml;
    protected override void OnInitialized()
    {
        ml = () => InvokeAsync(StateHasChanged);
    }

    [JSInvokable("InstallPwaPrompt")]
    //a named method so that it is easy to call from JS Interop
    // with the following config
    // <ServiceWorkerRegisterInstallableType>installable-blazor</ServiceWorkerRegisterInstallableType>
    // <ServiceWorkerBlazorAssembly>TestPwa.Client</ServiceWorkerBlazorAssembly>
    // <ServiceWorkerBlazorInstallMethod>InstallPwaPrompt</ServiceWorkerBlazorInstallMethod>
    public static Task InstallPwaPrompt()
    {
        Installable = true;
        ml.Invoke();
        return Task.CompletedTask;
    }
    async void InstallClicked(MouseEventArgs args)
    {
        Installable = false;
        await JSRuntime.InvokeAsync<object>("BlazorPWA.installPWA");//this name comes from the nuget package that generates the pwa code, don't change it unless you change the generated code
    }

    private bool collapseNavMenu = false;

    private string NavMenuCssClass => collapseNavMenu ? "is-active" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService toastService { get; set; }
    }
}
#pragma warning restore 1591

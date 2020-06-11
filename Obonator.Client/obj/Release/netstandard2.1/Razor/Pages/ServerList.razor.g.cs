#pragma checksum "D:\Projects\rezaffikri\Obonator\Obonator.Client\Pages\ServerList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0ae1b9465818b406295707176542a397eaa39c35"
// <auto-generated/>
#pragma warning disable 1591
namespace Obonator.Client.Pages
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
using Obonator.Client.Services.Auth;

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
#line 3 "D:\Projects\rezaffikri\Obonator\Obonator.Client\Pages\ServerList.razor"
           [Authorize(Roles = "admin, se, qa")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/serverlist")]
    public partial class ServerList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<nav class=""obon-breadcrumb is-small"" aria-label=""breadcrumbs"">
    <ul>
        <li>
            <a href=""#"">
                Obonator
            </a>
        </li>
        <li class=""is-active"">
            <a href=""#"" aria-current=""page"">Server</a>
        </li>
    </ul>
</nav>

");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "obon-box");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.AddMarkupContent(4, "<div class=\"obon-box-header\">\r\n        <h1 class=\"subtitle has-text-centered\">\r\n            Server List\r\n        </h1>\r\n    </div>\r\n    ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "obon-box-body");
            __builder.AddMarkupContent(7, "\r\n        ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "obon-scrollbar is-x");
            __builder.AddMarkupContent(10, "\r\n            ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "field is-horizontal");
            __builder.AddMarkupContent(13, "\r\n                ");
            __builder.OpenComponent<Blazorise.DataGrid.DataGrid<ServerListModel>>(14);
            __builder.AddAttribute(15, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<ServerListModel>>(
#nullable restore
#line 27 "D:\Projects\rezaffikri\Obonator\Obonator.Client\Pages\ServerList.razor"
                                 serverListModels

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "Sortable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 28 "D:\Projects\rezaffikri\Obonator\Obonator.Client\Pages\ServerList.razor"
                                    false

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "Bordered", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 29 "D:\Projects\rezaffikri\Obonator\Obonator.Client\Pages\ServerList.razor"
                                    true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(18, "Striped", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 30 "D:\Projects\rezaffikri\Obonator\Obonator.Client\Pages\ServerList.razor"
                                   true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "Filterable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 31 "D:\Projects\rezaffikri\Obonator\Obonator.Client\Pages\ServerList.razor"
                                      true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(20, "Narrow", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 32 "D:\Projects\rezaffikri\Obonator\Obonator.Client\Pages\ServerList.razor"
                                  true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(21, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(22, "\r\n                    ");
                __builder2.OpenComponent<Blazorise.DataGrid.DataGridCommandColumn<ServerListModel>>(23);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(24, "\r\n                    ");
                __builder2.OpenComponent<Blazorise.DataGrid.DataGridColumn<ServerListModel>>(25);
                __builder2.AddAttribute(26, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 34 "D:\Projects\rezaffikri\Obonator\Obonator.Client\Pages\ServerList.razor"
                                                                    nameof(ServerListModel.ServerId)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(27, "Caption", "#");
                __builder2.AddAttribute(28, "Filterable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 34 "D:\Projects\rezaffikri\Obonator\Obonator.Client\Pages\ServerList.razor"
                                                                                                                              true

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(29, "\r\n                    ");
                __builder2.OpenComponent<Blazorise.DataGrid.DataGridColumn<ServerListModel>>(30);
                __builder2.AddAttribute(31, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 35 "D:\Projects\rezaffikri\Obonator\Obonator.Client\Pages\ServerList.razor"
                                                                    nameof(ServerListModel.ServerName)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(32, "Caption", "Server Name");
                __builder2.AddAttribute(33, "Filterable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 35 "D:\Projects\rezaffikri\Obonator\Obonator.Client\Pages\ServerList.razor"
                                                                                                                                          true

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(34, "\r\n                    ");
                __builder2.OpenComponent<Blazorise.DataGrid.DataGridColumn<ServerListModel>>(35);
                __builder2.AddAttribute(36, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 36 "D:\Projects\rezaffikri\Obonator\Obonator.Client\Pages\ServerList.razor"
                                                                    nameof(ServerListModel.ServerIp)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(37, "Caption", "Ip Address");
                __builder2.AddAttribute(38, "Filterable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 36 "D:\Projects\rezaffikri\Obonator\Obonator.Client\Pages\ServerList.razor"
                                                                                                                                       true

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(39, "\r\n                    ");
                __builder2.OpenComponent<Blazorise.DataGrid.DataGridColumn<ServerListModel>>(40);
                __builder2.AddAttribute(41, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 37 "D:\Projects\rezaffikri\Obonator\Obonator.Client\Pages\ServerList.razor"
                                                                    nameof(ServerListModel.Keterangan)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(42, "Caption", "Desc");
                __builder2.AddAttribute(43, "Filterable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 37 "D:\Projects\rezaffikri\Obonator\Obonator.Client\Pages\ServerList.razor"
                                                                                                                                   true

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(44, "\r\n                ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(45, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 44 "D:\Projects\rezaffikri\Obonator\Obonator.Client\Pages\ServerList.razor"
      
    List<ServerListModel> serverListModels = new List<ServerListModel>();

    protected override Task OnInitializedAsync()
    {
        try
        {
            int id = 1;
            ServerListModel serverList = new ServerListModel();
            serverList.ServerId = id;
            serverList.ServerName = "Universe";
            serverList.ServerIp = "52.187.163.21";
            serverList.Keterangan = "";
            serverListModels.Add(serverList);
        }
        catch (Exception ex)
        {
            toastService.ShowError("Error: " + ex.Message + ex.StackTrace, "FAIL");
        }

        return base.OnInitializedAsync();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService toastService { get; set; }
    }
}
#pragma warning restore 1591

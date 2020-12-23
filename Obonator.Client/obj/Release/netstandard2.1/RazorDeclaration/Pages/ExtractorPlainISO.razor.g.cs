#pragma checksum "D:\Projects\rezaffikri\Obonator\Obonator.Client\Pages\ExtractorPlainISO.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bb889ef32c1b3d8f8c0c7af3da0dee436ef51ece"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 1 "D:\Projects\rezaffikri\Obonator\Obonator.Client\Pages\ExtractorPlainISO.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projects\rezaffikri\Obonator\Obonator.Client\Pages\ExtractorPlainISO.razor"
using System.Text.Encodings.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Projects\rezaffikri\Obonator\Obonator.Client\Pages\ExtractorPlainISO.razor"
           [Authorize(Roles = "admin, qa")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/extractoriso")]
    public partial class ExtractorPlainISO : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 92 "D:\Projects\rezaffikri\Obonator\Obonator.Client\Pages\ExtractorPlainISO.razor"
      
    public int ddlSelected { get; set; }
    public string inputData { get; set; }
    public string outputData { get; set; }
    public int isSuccess = 0;

    protected void DdlClicked(ChangeEventArgs eventArgs)
    {
        ddlSelected = int.Parse(eventArgs.Value.ToString());
    }

    public void Extract()
    {
        try
        {
            if(string.IsNullOrEmpty(inputData)){
            outputData = "";
            toastService.ShowError("input data harus tidak boleh kosong", "FAIL");
            return;
            }
            switch (ddlSelected)
            {
                case 0:
                    outputData = Services.ExtractorISO.ExtractorISO.ExtractInqReq(inputData);
                    break;
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 125 "D:\Projects\rezaffikri\Obonator\Obonator.Client\Pages\ExtractorPlainISO.razor"
                             
            }
        }
        catch (Exception)
        {
            outputData = "";
            toastService.ShowError("Key atau input salah", "FAIL");
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService toastService { get; set; }
    }
}
#pragma warning restore 1591

#pragma checksum "D:\Projects\rezaffikri\Obonator\Obonator.Client\Components\Others\News.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "67737cb3d34a38ab9797fcf23fdb9db52a1aeb4f"
// <auto-generated/>
#pragma warning disable 1591
namespace Obonator.Client.Components.Others
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
using Obonator.Client.Components.Cryptography;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "D:\Projects\rezaffikri\Obonator\Obonator.Client\_Imports.razor"
using Obonator.Client.Components.ExtractorBiller;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "D:\Projects\rezaffikri\Obonator\Obonator.Client\_Imports.razor"
using Obonator.Client.Helper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "D:\Projects\rezaffikri\Obonator\Obonator.Client\_Imports.razor"
using Obonator.Client.Components.LogBiller;

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "D:\Projects\rezaffikri\Obonator\Obonator.Client\_Imports.razor"
using Obonator.Client.Components.Others;

#line default
#line hidden
#nullable disable
    public partial class News : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2>News</h2>\r\n");
            __builder.AddMarkupContent(1, "<h3>Roadmap</h3>\r\n");
            __builder.AddMarkupContent(2, "<ul>\r\n    <li>Log biller</li>\r\n    <li>Extractor biller</li>\r\n</ul>\r\n\r\n");
            __builder.OpenElement(3, "h3");
            __builder.AddContent(4, "Obonator ");
            __builder.AddContent(5, 
#nullable restore
#line 8 "D:\Projects\rezaffikri\Obonator\Obonator.Client\Components\Others\News.razor"
              _version

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n");
            __builder.AddMarkupContent(7, @"<ul>
    <li>Update Crypthography</li>
    <li>Create ObonLibrary</li>
    <li>Update Login Layout (minor)</li>
    <li>Octopus Password Fix</li>
    <li>Add Server List</li>
    <li>Add Triple Des  Output Format</li>
    <li>Add Responsive Scrollbar</li>
</ul>

");
            __builder.AddMarkupContent(8, "<h3>Obonator 4.1.0</h3>\r\n");
            __builder.AddMarkupContent(9, @"<ul>
    <li>Update Side Menu Layout</li>
    <li>Login Remember Me Option</li>
    <li>Update Login Layout (minor)</li>
    <li>Octopus Password Fix</li>
    <li>Add Server List</li>
    <li>Add Triple Des  Output Format</li>
    <li>Add Responsive Scrollbar</li>
</ul>

");
            __builder.AddMarkupContent(10, "<h3>Obonator 4.0.0</h3>\r\n");
            __builder.AddMarkupContent(11, "<ul>\r\n    <li>Add Octopus Password</li>\r\n    <li>Full Custom Obon CSS</li>\r\n    <li>Bug Fix Triple Des Hex</li>\r\n    <li>Add Login Auth</li>\r\n    <li>Update Side Menu Layout</li>\r\n    <li>Update Index Layout</li>\r\n</ul>\r\n");
            __builder.AddMarkupContent(12, "<h3>Obonator 3.2.0</h3>\r\n");
            __builder.AddMarkupContent(13, @"<ul>
    <li>Update Layout (Minor)</li>
    <li>Bug Fix Offside Layout</li>
    <li>Bug Fix AES Wrong Button</li>
    <li>Update Layout Mobile Friendly</li>
    <li>Add Obon scss base on Bulma</li>
    <li>Remove MatBlazor</li>
    <li>Add Blazorise</li>
    <li>Update Toast</li>
    <li>Add Font Awesome</li>
</ul>
");
            __builder.AddMarkupContent(14, "<h3>Obonator 3.1.0</h3>\r\n");
            __builder.AddMarkupContent(15, "<ul>\r\n    <li>Blazor PWA Offline Support</li>\r\n    <li>Update Layout (Major)</li>\r\n</ul>\r\n");
            __builder.AddMarkupContent(16, "<h3>Obonator 3.0.0</h3>\r\n");
            __builder.AddMarkupContent(17, "<ul>\r\n    <li>Move Blazor Server Side to Client Side</li>\r\n    <li>Remove Login Auth</li>\r\n</ul>\r\n");
            __builder.AddMarkupContent(18, "<h3>Obonator 2.2.0</h3>\r\n");
            __builder.AddMarkupContent(19, "<ul>\r\n    <li>Starfish SP Generator</li>\r\n</ul>\r\n");
            __builder.AddMarkupContent(20, "<h3>Obonator 2.1.0</h3>\r\n");
            __builder.AddMarkupContent(21, "<ul>\r\n    <li>Update Cryptography Method to Global</li>\r\n    <li>Update Form Title to Small</li>\r\n    <li>Merge Login and Index but Separate With Auth</li>\r\n</ul>\r\n");
            __builder.AddMarkupContent(22, "<h3>Obonator 2.0.4</h3>\r\n");
            __builder.AddMarkupContent(23, "<ul>\r\n    <li>Bug Fix Login Missing Param</li>\r\n    <li>Login Notification</li>\r\n</ul>\r\n");
            __builder.AddMarkupContent(24, "<h3>Obonator 2.0.3</h3>\r\n");
            __builder.AddMarkupContent(25, "<ul>\r\n    <li>Bug Fix Auth</li>\r\n    <li>Bug Fix Login</li>\r\n</ul>\r\n");
            __builder.AddMarkupContent(26, "<h3>Obonator 2.0.2</h3>\r\n");
            __builder.AddMarkupContent(27, "<ul>\r\n    <li>Add Success Log Biller PLN Nontaglis</li>\r\n    <li>Update Layout</li>\r\n</ul>\r\n");
            __builder.AddMarkupContent(28, "<h3>Obonator 2.0.1</h3>\r\n");
            __builder.AddMarkupContent(29, "<ul>\r\n    <li>Add Custom Not Auth Page</li>\r\n    <li>Show and Hide Menu Based on Role</li>\r\n    <li>Add Role</li>\r\n    <li>Show and Hide Menu Based on Role</li>\r\n</ul>\r\n");
            __builder.AddMarkupContent(30, "<h3>Obonator 2.0.0</h3>\r\n");
            __builder.AddMarkupContent(31, "<ul>\r\n    <li>Add Simple Login Auth</li>\r\n</ul>\r\n");
            __builder.AddMarkupContent(32, "<h3>Obonator 1.9.1</h3>\r\n");
            __builder.AddMarkupContent(33, "<ul>\r\n    <li>Update Layout</li>\r\n</ul>\r\n");
            __builder.AddMarkupContent(34, "<h3>Obonator 1.9.0</h3>\r\n");
            __builder.AddMarkupContent(35, "<ul>\r\n    <li>Move Toast to Global</li>\r\n    <li>Log Biller PLN Nontaglis</li>\r\n    <li>Update Structure File</li>\r\n</ul>\r\n");
            __builder.AddMarkupContent(36, "<h3>Obonator 1.8.0</h3>\r\n");
            __builder.AddMarkupContent(37, "<ul>\r\n    <li>Move Toast to Global</li>\r\n    <li>Json Escape and Unescape</li>\r\n    <li>Starfish Office SP Generator</li>\r\n    <li>Max SignalR Data to 1Mb</li>\r\n</ul>\r\n");
            __builder.AddMarkupContent(38, "<h3>Obonator 1.7.0</h3>\r\n");
            __builder.AddMarkupContent(39, "<ul>\r\n    <li>Bug Fix Ugly Button on Small Screen</li>\r\n    <li>Update Structure File</li>\r\n</ul>\r\n");
            __builder.AddMarkupContent(40, "<h3>Obonator 1.6.0</h3>\r\n");
            __builder.AddMarkupContent(41, "<ul>\r\n    <li>Clear Button on Extractor</li>\r\n    <li>Extractor Telco Postpaid</li>\r\n    <li>Extractor Telkom</li>\r\n</ul>\r\n");
            __builder.AddMarkupContent(42, "<h3>Obonator 1.5.0</h3>\r\n");
            __builder.AddMarkupContent(43, "<ul>\r\n    <li>Extractor BPJS</li>\r\n    <li>Extractor PBB</li>\r\n</ul>\r\n");
            __builder.AddMarkupContent(44, "<h3>Obonator 1.4.0</h3>\r\n");
            __builder.AddMarkupContent(45, "<ul>\r\n    <li>Extractor Rintis</li>\r\n    <li>Extractor Samolnas</li>\r\n</ul>\r\n");
            __builder.AddMarkupContent(46, "<h3>Obonator 1.3.2</h3>\r\n");
            __builder.AddMarkupContent(47, "<ul>\r\n    <li>All JSON Output is Now Beauty</li>\r\n</ul>\r\n");
            __builder.AddMarkupContent(48, "<h3>Obonator 1.3.1</h3>\r\n");
            __builder.AddMarkupContent(49, "<ul>\r\n    <li>Update Layout and Footer Experiment</li>\r\n</ul>\r\n");
            __builder.AddMarkupContent(50, "<h3>Obonator 1.3.0</h3>\r\n");
            __builder.AddMarkupContent(51, "<ul>\r\n    <li>Extractor PLN Postpaid</li>\r\n    <li>Extractor PLN Nontaglis</li>\r\n    <li>Remove Bootstrap and Full Use Bulma</li>\r\n</ul>\r\n");
            __builder.AddMarkupContent(52, "<h3>Obonator 1.2.1</h3>\r\n");
            __builder.AddMarkupContent(53, "<ul>\r\n    <li>Error catcher and notif to all pages</li>\r\n    <li>Update Cryptography TripleDes Hex Support</li>\r\n    <li>Add Logo</li>\r\n</ul>\r\n");
            __builder.AddMarkupContent(54, "<h3>Obonator 1.2.0</h3>\r\n");
            __builder.AddMarkupContent(55, "<ul>\r\n    <li>Add Bulma CSS</li>\r\n    <li>Add Obonator</li>\r\n    <li>Remove Global Custom Modal</li>\r\n    <li>Add Toast</li>\r\n</ul>\r\n");
            __builder.AddMarkupContent(56, "<h3>Obonator 1.1.0</h3>\r\n");
            __builder.AddMarkupContent(57, "<ul>\r\n    <li>Extractor PLN Prepaid</li>\r\n    <li>Add Global Custom Modal</li>\r\n</ul>\r\n");
            __builder.AddMarkupContent(58, "<h3>Obonator 1.0.0</h3>\r\n");
            __builder.AddMarkupContent(59, "<ul>\r\n    <li>Initial project using blazor server side</li>\r\n    <li>Cryptography AES</li>\r\n    <li>Cryptography MD5Hash</li>\r\n    <li>Cryptography TripleDes</li>\r\n</ul>");
        }
        #pragma warning restore 1998
#nullable restore
#line 175 "D:\Projects\rezaffikri\Obonator\Obonator.Client\Components\Others\News.razor"
      

    [Parameter] public string _version { get; set; }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService toastService { get; set; }
    }
}
#pragma warning restore 1591

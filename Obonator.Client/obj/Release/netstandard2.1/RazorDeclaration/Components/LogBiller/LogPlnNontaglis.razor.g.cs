#pragma checksum "D:\Projects\rezaffikri\Obonator\Obonator.Client\Components\LogBiller\LogPlnNontaglis.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a7075c1be06dd5b4d36edd60e6e27a462b3d831d"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Obonator.Client.Components.LogBiller
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
    public partial class LogPlnNontaglis : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 22 "D:\Projects\rezaffikri\Obonator\Obonator.Client\Components\LogBiller\LogPlnNontaglis.razor"
 
    private string outputdata;
    private string logSuccess = "{\"key\":\"CAE6EDC95A764BE7\",\n\"mti\":\"2100\",\n\"2\":\"99504\",\n\"11\":\"658388283779\",\n\"12\":\"20190808102819\",\n\"26\":\"6021\",\n\"32\":\"4410010\",\n\"33\":\"4411296\",\n\"41\":\"0000000001499001\",\n\"48\":\"00000001100000000001                   00000\"}\n\n{\"mti\":\"2110\",\n\"2\":\"99504\",\n\"4\":\"3600000000500000\",\n\"11\":\"658388283779\",\n\"12\":\"20190808102819\",\n\"26\":\"6021\",\n\"32\":\"4410010\",\n\"33\":\"4411296\",\n\"39\":\"0000\",\n\"41\":\"0000000001499001\",\n\"48\":\"00000001100000000001                   00000PERUBAHAN DAYA           2019080820190808123456789012SUBSRIBER NAME           0000000000000000000000000000000093F8552EDB0EB3433717ABC461FC885600005C74C7189660F83425DABE02D6A13656559200000000000001520000000005000000020000000005000000020000500000\",\n\"62\":\"02200000000050000000\"}\n\n{\"key\":\"CAE6EDC95A764BE7\",\n\"mti\":\"2200\",\n\"2\":\"99504\",\n\"4\":\"3600000000505000\",\n\"11\":\"658388283779\",\n\"12\":\"20190808102857\",\n\"26\":\"6021\",\n\"32\":\"4410010\",\n\"33\":\"4411296\",\n\"41\":\"0000000001499001\",\n\"48\":\"00000001100000000001                   00000PERUBAHAN DAYA           2019080820190808123456789012SUBSRIBER NAME           0000000000000000000000000000000093F8552EDB0EB3433717ABC461FC885600005C74C7189660F83425DABE02D6A13656559200000000000001520000000005050000020000000005000000020000500000\",\n\"62\":\"02200000000050000000\"}\n\n{\"mti\":\"2210\",\n\"2\":\"99504\",\n\"4\":\"3600000000505000\",\n\"11\":\"658388283779\",\n\"12\":\"20190808102857\",\n\"15\":\"20190808\",\n\"26\":\"6021\",\n\"32\":\"4410010\",\n\"33\":\"4411296\",\n\"39\":\"0000\",\n\"41\":\"0000000001499001\",\n\"48\":\"00000001100000000001                   00000PERUBAHAN DAYA           2019080820190808123456789012SUBSRIBER NAME           93F8552EDB0EB3433717ABC461FC8856044121CAD89F930EC1046D1B54588DDD00005C74C7189660F83425DABE02D6A13656559200000000000001520000000005050000020000000005000000020000500000\",\n\"61\":\"                                    00000000093F8552EDB0EB3433717ABC461FC8856\",\n\"62\":\"02200000000050000000\",\n\"63\":\"RINCIAN TAGIHAN DAPAT DIAKSES DI \\\"www.pln.co.id\\\" ATAU PLN TERDEKAT. Powered by Bukopinet.\"}"
        ;

    private void Success()
    {
        outputdata = logSuccess;
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService toastService { get; set; }
    }
}
#pragma warning restore 1591

#pragma checksum "D:\Projects\rezaffikri\Obonator\Obonator.Client\Components\ExtractorBiller\ExtractorPbb.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "85f10895e8c9440c2340e5163e76ec4c1081d0df"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Obonator.Client.Components.ExtractorBiller
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
#line 1 "D:\Projects\rezaffikri\Obonator\Obonator.Client\Components\ExtractorBiller\ExtractorPbb.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
    public partial class ExtractorPbb : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 54 "D:\Projects\rezaffikri\Obonator\Obonator.Client\Components\ExtractorBiller\ExtractorPbb.razor"
       

    public string inputData { get; set; }
    public string outputData { get; set; }
    public int isSuccess = 0;

    public class Extractor
    {
        public string f48_01_Product_2 { get; set; }
        public string f48_02_KodeBayar_18 { get; set; }
        public string f48_03_Tahun_4 { get; set; }
        public string f48_04_Nama_30 { get; set; }
        public string f48_05_Alamat_45 { get; set; }
        public string f48_06_Kecamatan_30 { get; set; }
        public string f48_08_Kotamadya_30 { get; set; }
        public string f48_09_JmlTagihan_12 { get; set; }
        public string f48_10_KodeRekPokok_10 { get; set; }
        public string f48_11_JmlPokok_12 { get; set; }
        public string f48_12_KodeRekSanksi_10 { get; set; }
        public string f48_13_JmlSanksi_12 { get; set; }
        public string f48_14_KodeRekBunga_10 { get; set; }
        public string f48_15_JmlBunga_12 { get; set; }
        public string f48_16_KodeRekDenda_10 { get; set; }
        public string f48_17_JmlDenda_12 { get; set; }
        public string f48_18_JmlAdmin_12 { get; set; }
        public string f48_19_Period_4 { get; set; }
        public string f48_20_BuktiBayar_16 { get; set; }
    }
    public void ExtractField48Inquiry()
    {
        try
        {
            ObonCommon.StrUtil s = new ObonCommon.StrUtil(inputData);
            Extractor extractor = new Extractor();

            extractor.f48_01_Product_2 = s.getString(2);
            extractor.f48_02_KodeBayar_18 = s.getString(18);
            extractor.f48_03_Tahun_4 = s.getString(4);
            extractor.f48_04_Nama_30 = s.getString(30);
            extractor.f48_05_Alamat_45 = s.getString(45);
            extractor.f48_06_Kecamatan_30 = s.getString(30);
            extractor.f48_08_Kotamadya_30 = s.getString(30);
            extractor.f48_09_JmlTagihan_12 = s.getString(12);
            extractor.f48_10_KodeRekPokok_10 = s.getString(10);
            extractor.f48_11_JmlPokok_12 = s.getString(12);
            extractor.f48_12_KodeRekSanksi_10 = s.getString(10);
            extractor.f48_13_JmlSanksi_12 = s.getString(12);
            extractor.f48_14_KodeRekBunga_10 = s.getString(10);
            extractor.f48_15_JmlBunga_12 = s.getString(12);
            extractor.f48_16_KodeRekDenda_10 = s.getString(10);
            extractor.f48_17_JmlDenda_12 = s.getString(12);
            extractor.f48_18_JmlAdmin_12 = s.getString(12);

            JsonSerializerOptions jsonSerializerOptions = new JsonSerializerOptions();
            jsonSerializerOptions.WriteIndented = true;
            outputData = JsonSerializer.Serialize(extractor, jsonSerializerOptions);

        }
        catch
        {
            outputData = "";
                        toastService.ShowError("Message salah", "FAIL");
        }

    }
    public void ExtractField48PaymentRequest()
    {
        try
        {
            ObonCommon.StrUtil s = new ObonCommon.StrUtil(inputData);
            Extractor extractor = new Extractor();

            extractor.f48_01_Product_2 = s.getString(2);
            extractor.f48_02_KodeBayar_18 = s.getString(18);
            extractor.f48_19_Period_4 = s.getString(4);
            extractor.f48_09_JmlTagihan_12 = s.getString(12);
            extractor.f48_11_JmlPokok_12 = s.getString(12);
            extractor.f48_13_JmlSanksi_12 = s.getString(12);
            extractor.f48_15_JmlBunga_12 = s.getString(12);
            extractor.f48_17_JmlDenda_12 = s.getString(12);
            extractor.f48_10_KodeRekPokok_10 = s.getString(10);
            extractor.f48_12_KodeRekSanksi_10 = s.getString(10);
            extractor.f48_14_KodeRekBunga_10 = s.getString(10);
            extractor.f48_16_KodeRekDenda_10 = s.getString(10);
            extractor.f48_18_JmlAdmin_12 = s.getString(12);

            JsonSerializerOptions jsonSerializerOptions = new JsonSerializerOptions();
            jsonSerializerOptions.WriteIndented = true;
            outputData = JsonSerializer.Serialize(extractor, jsonSerializerOptions);
        }
        catch
        {
            outputData = "";
            toastService.ShowError("Message salah", "FAIL");
        }
    }
    public void ExtractField48PaymentResponse()
    {
        try
        {
            ObonCommon.StrUtil s = new ObonCommon.StrUtil(inputData);
            Extractor extractor = new Extractor();

            extractor.f48_01_Product_2 = s.getString(2);
            extractor.f48_02_KodeBayar_18 = s.getString(18);
            extractor.f48_19_Period_4 = s.getString(4);
            extractor.f48_09_JmlTagihan_12 = s.getString(12);
            extractor.f48_11_JmlPokok_12 = s.getString(12);
            extractor.f48_13_JmlSanksi_12 = s.getString(12);
            extractor.f48_15_JmlBunga_12 = s.getString(12);
            extractor.f48_17_JmlDenda_12 = s.getString(12);
            extractor.f48_10_KodeRekPokok_10 = s.getString(10);
            extractor.f48_12_KodeRekSanksi_10 = s.getString(10);
            extractor.f48_14_KodeRekBunga_10 = s.getString(10);
            extractor.f48_16_KodeRekDenda_10 = s.getString(10);
            extractor.f48_18_JmlAdmin_12 = s.getString(12);
            extractor.f48_20_BuktiBayar_16 = s.getString(16);

            JsonSerializerOptions jsonSerializerOptions = new JsonSerializerOptions();
            jsonSerializerOptions.WriteIndented = true;
            outputData = JsonSerializer.Serialize(extractor, jsonSerializerOptions);
        }
        catch
        {
            outputData = "";
            toastService.ShowError("Message salah", "FAIL");
        }
    }
    public void ClearTextBox()
    {
        inputData = "";
        outputData = "";
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService toastService { get; set; }
    }
}
#pragma warning restore 1591

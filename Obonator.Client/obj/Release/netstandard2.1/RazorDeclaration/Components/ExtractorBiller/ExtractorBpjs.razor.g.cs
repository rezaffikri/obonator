#pragma checksum "D:\Projects\rezaffikri\Obonator\Obonator.Client\Components\ExtractorBiller\ExtractorBpjs.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fa9fb282d6e0d93a55d2d325bb6b27322e46f04b"
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
#line 1 "D:\Projects\rezaffikri\Obonator\Obonator.Client\Components\ExtractorBiller\ExtractorBpjs.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
    public partial class ExtractorBpjs : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 47 "D:\Projects\rezaffikri\Obonator\Obonator.Client\Components\ExtractorBiller\ExtractorBpjs.razor"
       

    public string inputData { get; set; }
    public string outputData { get; set; }
    public int isSuccess = 0;

    public class Extractor
    {
        public string f48_01_VersiFormat_1 { get; set; }
        public string f48_02_ProdukIndikator_4 { get; set; }
        public string f48_03_NoVA_24 { get; set; }
        public string f48_04_KodeBahasa_1 { get; set; }
        public string f48_05_InfoNilaiTagihan_2 { get; set; }
        public string f48_06_TotalTagihan_12 { get; set; }
        public string f48_07_BiayaAdmin_12 { get; set; }
        public string f48_08_Nama_30 { get; set; }
        public string f48_09_BillReference_20 { get; set; }
        public string f48_10_BussinessDate_5 { get; set; }
        public string f48_11_KodeCabang_5 { get; set; }
        public string f48_12_NamaCabang_30 { get; set; }
        public string f48_13_NoPesertaKK_20 { get; set; }
        public string f48_14_JmlPesertaKK_10 { get; set; }
        public string f48_15_BillInfo6_32 { get; set; }
        public string f48_16_BillInfo7_32 { get; set; }
        public string f48_17_BillInfo8_32 { get; set; }
        public string f48_18_TotalTagihanSampaiBulanIni_12 { get; set; }
        public string f48_19_TotalPembayaranTagihanDimuka_12 { get; set; }
        public string f48_20_OtherAmount3_12 { get; set; }
        public string f48_21_OtherAmount4_12 { get; set; }
        public string f48_20_OtherAmount5_12 { get; set; }
        public string f48_21_OtherAmount6_12 { get; set; }
        public string f48_20_OtherAmount7_12 { get; set; }
        public string f48_21_OtherAmount8_12 { get; set; }
    }
    public void ExtractField48Inquiry()
    {
        try
        {
            ObonCommon.StrUtil s = new ObonCommon.StrUtil(inputData);
            Extractor extractor = new Extractor();

            extractor.f48_01_VersiFormat_1 = s.getString(1);
            extractor.f48_02_ProdukIndikator_4 = s.getString(4);
            extractor.f48_03_NoVA_24 = s.getString(24);
            extractor.f48_04_KodeBahasa_1 = s.getString(1);
            extractor.f48_05_InfoNilaiTagihan_2 = s.getString(2);
            extractor.f48_06_TotalTagihan_12 = s.getString(12);
            extractor.f48_07_BiayaAdmin_12 = s.getString(12);
            extractor.f48_08_Nama_30 = s.getString(30);
            extractor.f48_09_BillReference_20 = s.getString(20);
            extractor.f48_10_BussinessDate_5 = s.getString(5);
            extractor.f48_11_KodeCabang_5 = s.getString(5);
            extractor.f48_12_NamaCabang_30 = s.getString(30);
            extractor.f48_13_NoPesertaKK_20 = s.getString(20);
            extractor.f48_14_JmlPesertaKK_10 = s.getString(10);
            extractor.f48_15_BillInfo6_32 = s.getString(32);
            extractor.f48_16_BillInfo7_32 = s.getString(32);
            extractor.f48_17_BillInfo8_32 = s.getString(32);
            extractor.f48_18_TotalTagihanSampaiBulanIni_12 = s.getString(12);
            extractor.f48_19_TotalPembayaranTagihanDimuka_12 = s.getString(12);
            extractor.f48_20_OtherAmount3_12 = s.getString(12);
            extractor.f48_21_OtherAmount4_12 = s.getString(12);
            extractor.f48_20_OtherAmount5_12 = s.getString(12);
            extractor.f48_21_OtherAmount6_12 = s.getString(12);
            extractor.f48_20_OtherAmount7_12 = s.getString(12);
            extractor.f48_21_OtherAmount8_12 = s.getString(12);

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
    public void ExtractField48Payment()
    {
        try
        {
            ObonCommon.StrUtil s = new ObonCommon.StrUtil(inputData);
            Extractor extractor = new Extractor();

            extractor.f48_01_VersiFormat_1 = s.getString(1);
            extractor.f48_02_ProdukIndikator_4 = s.getString(4);
            extractor.f48_03_NoVA_24 = s.getString(24);
            extractor.f48_04_KodeBahasa_1 = s.getString(1);
            extractor.f48_05_InfoNilaiTagihan_2 = s.getString(2);
            extractor.f48_06_TotalTagihan_12 = s.getString(12);
            extractor.f48_07_BiayaAdmin_12 = s.getString(12);
            extractor.f48_08_Nama_30 = s.getString(30);
            extractor.f48_09_BillReference_20 = s.getString(20);
            extractor.f48_10_BussinessDate_5 = s.getString(5);
            extractor.f48_11_KodeCabang_5 = s.getString(5);
            extractor.f48_12_NamaCabang_30 = s.getString(30);
            extractor.f48_13_NoPesertaKK_20 = s.getString(20);
            extractor.f48_14_JmlPesertaKK_10 = s.getString(10);
            extractor.f48_15_BillInfo6_32 = s.getString(32);
            extractor.f48_16_BillInfo7_32 = s.getString(32);
            extractor.f48_17_BillInfo8_32 = s.getString(32);
            extractor.f48_18_TotalTagihanSampaiBulanIni_12 = s.getString(12);
            extractor.f48_19_TotalPembayaranTagihanDimuka_12 = s.getString(12);
            extractor.f48_20_OtherAmount3_12 = s.getString(12);
            extractor.f48_21_OtherAmount4_12 = s.getString(12);
            extractor.f48_20_OtherAmount5_12 = s.getString(12);
            extractor.f48_21_OtherAmount6_12 = s.getString(12);
            extractor.f48_20_OtherAmount7_12 = s.getString(12);
            extractor.f48_21_OtherAmount8_12 = s.getString(12);

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

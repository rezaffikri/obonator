#pragma checksum "D:\Projects\rezaffikri\Obonator\Obonator.Client\Components\ExtractorBiller\ExtractorSamolnas.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "213341be883bc2a91a3437419a02ce13ee2570c5"
// <auto-generated/>
#pragma warning disable 1591
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
#nullable restore
#line 1 "D:\Projects\rezaffikri\Obonator\Obonator.Client\Components\ExtractorBiller\ExtractorSamolnas.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
    public partial class ExtractorSamolnas : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "field is-horizontal");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.AddMarkupContent(3, "<div class=\"field-label is-normal\"><label class=\"label\">Input</label></div>\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "field-body");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "field");
            __builder.AddMarkupContent(9, "\r\n            ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "control");
            __builder.AddMarkupContent(12, "\r\n                ");
            __builder.OpenElement(13, "textarea");
            __builder.AddAttribute(14, "class", "textarea ");
            __builder.AddAttribute(15, "rows", "3");
            __builder.AddAttribute(16, "placeholder", "Input");
            __builder.AddAttribute(17, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 10 "D:\Projects\rezaffikri\Obonator\Obonator.Client\Components\ExtractorBiller\ExtractorSamolnas.razor"
                                                            inputData

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(18, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => inputData = __value, inputData));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "field is-horizontal");
            __builder.AddMarkupContent(26, "\r\n    ");
            __builder.AddMarkupContent(27, "<div class=\"field-label is-normal\"><label class=\"label\">Output</label></div>\r\n    ");
            __builder.OpenElement(28, "div");
            __builder.AddAttribute(29, "class", "field-body");
            __builder.AddMarkupContent(30, "\r\n        ");
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "class", "field");
            __builder.AddMarkupContent(33, "\r\n            ");
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "class", "control");
            __builder.AddMarkupContent(36, "\r\n                ");
            __builder.OpenElement(37, "textarea");
            __builder.AddAttribute(38, "class", "textarea");
            __builder.AddAttribute(39, "rows", "9");
            __builder.AddAttribute(40, "placeholder", "Output");
            __builder.AddAttribute(41, "readonly", true);
            __builder.AddAttribute(42, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 20 "D:\Projects\rezaffikri\Obonator\Obonator.Client\Components\ExtractorBiller\ExtractorSamolnas.razor"
                                                           outputData

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(43, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => outputData = __value, outputData));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n\r\n");
            __builder.OpenElement(49, "div");
            __builder.AddAttribute(50, "class", "field is-horizontal");
            __builder.AddMarkupContent(51, "\r\n    <div class=\"field-label is-normal\"></div>\r\n    ");
            __builder.OpenElement(52, "div");
            __builder.AddAttribute(53, "class", "field-body");
            __builder.AddMarkupContent(54, "\r\n        ");
            __builder.OpenElement(55, "div");
            __builder.AddAttribute(56, "class", "field is-grouped");
            __builder.AddMarkupContent(57, "\r\n            ");
            __builder.OpenElement(58, "div");
            __builder.AddAttribute(59, "class", "control");
            __builder.AddMarkupContent(60, "\r\n                ");
            __builder.OpenElement(61, "button");
            __builder.AddAttribute(62, "class", "button is-primary");
            __builder.AddAttribute(63, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 31 "D:\Projects\rezaffikri\Obonator\Obonator.Client\Components\ExtractorBiller\ExtractorSamolnas.razor"
                                                            ExtractField62Inquiry

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(64, "\r\n                    Extract Inq\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n            ");
            __builder.OpenElement(67, "div");
            __builder.AddAttribute(68, "class", "control");
            __builder.AddMarkupContent(69, "\r\n                ");
            __builder.OpenElement(70, "button");
            __builder.AddAttribute(71, "class", "button is-primary");
            __builder.AddAttribute(72, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 36 "D:\Projects\rezaffikri\Obonator\Obonator.Client\Components\ExtractorBiller\ExtractorSamolnas.razor"
                                                            ExtractField61Payment

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(73, "\r\n                    Extract Pay\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\r\n            ");
            __builder.OpenElement(76, "div");
            __builder.AddAttribute(77, "class", "control");
            __builder.AddMarkupContent(78, "\r\n                ");
            __builder.OpenElement(79, "button");
            __builder.AddAttribute(80, "class", "button is-primary");
            __builder.AddAttribute(81, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 41 "D:\Projects\rezaffikri\Obonator\Obonator.Client\Components\ExtractorBiller\ExtractorSamolnas.razor"
                                                            ClearTextBox

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(82, "\r\n                    Clear\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(86, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 49 "D:\Projects\rezaffikri\Obonator\Obonator.Client\Components\ExtractorBiller\ExtractorSamolnas.razor"
       

    public string inputData { get; set; }
    public string outputData { get; set; }
    public int isSuccess = 0;

    public class Extractor
    {
        public string f62_01_kdbayar_16 { get; set; }
        public string f62_02_nopol_12 { get; set; }
        public string f62_03_ModulTransaksi_2 { get; set; }
        public string f62_04_Jenis_40 { get; set; }
        public string f62_05_Merk_20 { get; set; }
        public string f62_06_Type_20 { get; set; }
        public string f62_07_TahunPembuatan_4 { get; set; }
        public string f62_08_CC_5 { get; set; }
        public string f62_09_NoRangka_25 { get; set; }
        public string f62_10_NoMesin_25 { get; set; }
        public string f62_11_pkbpokok_12 { get; set; }
        public string f62_12_pkbdenda_12 { get; set; }
        public string f62_13_pkbbunga_12 { get; set; }
        public string f62_14_BebanPokok_12 { get; set; }
        public string f62_15_BebanDenda_12 { get; set; }
        public string f62_16_jrpokok_12 { get; set; }
        public string f62_17_jrdenda_12 { get; set; }
        public string f62_18_PNBP_12 { get; set; }
        public string f62_19_tnkb_12 { get; set; }
        public string f62_20_parkirpokok_12 { get; set; }
        public string f62_21_Nominal_Progresif_12 { get; set; }
        public string f62_22_Progresif_3 { get; set; }
        public string f62_23_Nama_25 { get; set; }
        public string f62_24_Alamat_40 { get; set; }
        public string f62_25_tglAwalPajak_8 { get; set; }
        public string f62_26_tglAkhirPajak_8 { get; set; }
        public string f62_27_KodeLoket_2 { get; set; }
        public string f62_28_BhnBakar_7 { get; set; }
        public string f62_29_warna_6 { get; set; }
        public string f62_30_ThRegistrasi_4 { get; set; }
        public string f62_31_thbuat_4 { get; set; }
        public string f62_32_NoBKKB_13 { get; set; }
        public string f62_33_NIK_16 { get; set; }
        public string f62_idreq_12 { get; set; }
        public string f62_kdval_12 { get; set; }
        public string f62_AdminBank_10 { get; set; }
        public string f62_TotalRP { get; set; }
        public string f62_BuktiBayar { get; set; }
    }
    public void ExtractField62Inquiry()
    {
        try
        {
            ObonCommon.StrUtil s = new ObonCommon.StrUtil(inputData);
            Extractor extractor = new Extractor();

            extractor.f62_01_kdbayar_16 = s.getString(18);
            extractor.f62_02_nopol_12 = s.getString(12);
            extractor.f62_03_ModulTransaksi_2 = s.getString(2);
            extractor.f62_04_Jenis_40 = s.getString(40);
            extractor.f62_05_Merk_20 = s.getString(20);
            extractor.f62_06_Type_20 = s.getString(20);
            extractor.f62_07_TahunPembuatan_4 = s.getString(4);
            extractor.f62_08_CC_5 = s.getString(5);
            extractor.f62_09_NoRangka_25 = s.getString(25);
            extractor.f62_10_NoMesin_25 = s.getString(25);
            extractor.f62_11_pkbpokok_12 = s.getString(12);
            extractor.f62_12_pkbdenda_12 = s.getString(12);
            extractor.f62_13_pkbbunga_12 = s.getString(12);
            extractor.f62_14_BebanPokok_12 = s.getString(12);
            extractor.f62_15_BebanDenda_12 = s.getString(12);
            extractor.f62_16_jrpokok_12 = s.getString(12);
            extractor.f62_17_jrdenda_12 = s.getString(12);
            extractor.f62_18_PNBP_12 = s.getString(12);
            extractor.f62_19_tnkb_12 = s.getString(12);
            extractor.f62_20_parkirpokok_12 = s.getString(12);
            extractor.f62_21_Nominal_Progresif_12 = s.getString(12);
            extractor.f62_22_Progresif_3 = s.getString(3);
            extractor.f62_23_Nama_25 = s.getString(25);
            extractor.f62_24_Alamat_40 = s.getString(40);
            extractor.f62_25_tglAwalPajak_8 = s.getString(8);
            extractor.f62_26_tglAkhirPajak_8 = s.getString(8);
            extractor.f62_27_KodeLoket_2 = s.getString(3);
            extractor.f62_28_BhnBakar_7 = s.getString(7);
            extractor.f62_29_warna_6 = s.getString(6);
            extractor.f62_30_ThRegistrasi_4 = s.getString(4);
            extractor.f62_31_thbuat_4 = s.getString(4);
            extractor.f62_32_NoBKKB_13 = s.getString(13);
            extractor.f62_33_NIK_16 = s.getString(16);
            extractor.f62_idreq_12 = s.getString(12);
            extractor.f62_kdval_12 = s.getString(16);
            extractor.f62_AdminBank_10 = s.getString(10);
            extractor.f62_TotalRP = s.getString(12);

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
    public void ExtractField61Payment()
    {
        try
        {
            ObonCommon.StrUtil s = new ObonCommon.StrUtil(inputData);
            Extractor extractor = new Extractor();

            extractor.f62_01_kdbayar_16 = s.getString(18);
            extractor.f62_02_nopol_12 = s.getString(12);
            extractor.f62_03_ModulTransaksi_2 = s.getString(2);
            extractor.f62_04_Jenis_40 = s.getString(40);
            extractor.f62_05_Merk_20 = s.getString(20);
            extractor.f62_06_Type_20 = s.getString(20);
            extractor.f62_07_TahunPembuatan_4 = s.getString(4);
            extractor.f62_08_CC_5 = s.getString(5);
            extractor.f62_09_NoRangka_25 = s.getString(25);
            extractor.f62_10_NoMesin_25 = s.getString(25);
            extractor.f62_11_pkbpokok_12 = s.getString(12);
            extractor.f62_12_pkbdenda_12 = s.getString(12);
            extractor.f62_13_pkbbunga_12 = s.getString(12);
            extractor.f62_14_BebanPokok_12 = s.getString(12);
            extractor.f62_15_BebanDenda_12 = s.getString(12);
            extractor.f62_16_jrpokok_12 = s.getString(12);
            extractor.f62_17_jrdenda_12 = s.getString(12);
            extractor.f62_18_PNBP_12 = s.getString(12);
            extractor.f62_19_tnkb_12 = s.getString(12);
            extractor.f62_20_parkirpokok_12 = s.getString(12);
            extractor.f62_21_Nominal_Progresif_12 = s.getString(12);
            extractor.f62_22_Progresif_3 = s.getString(3);
            extractor.f62_23_Nama_25 = s.getString(25);
            extractor.f62_24_Alamat_40 = s.getString(40);
            extractor.f62_25_tglAwalPajak_8 = s.getString(8);
            extractor.f62_26_tglAkhirPajak_8 = s.getString(8);
            extractor.f62_27_KodeLoket_2 = s.getString(3);
            extractor.f62_28_BhnBakar_7 = s.getString(7);
            extractor.f62_29_warna_6 = s.getString(6);
            extractor.f62_30_ThRegistrasi_4 = s.getString(4);
            extractor.f62_31_thbuat_4 = s.getString(4);
            extractor.f62_32_NoBKKB_13 = s.getString(13);
            extractor.f62_33_NIK_16 = s.getString(16);
            extractor.f62_kdval_12 = s.getString(16);
            extractor.f62_AdminBank_10 = s.getString(10);
            extractor.f62_TotalRP = s.getString(12);
            extractor.f62_BuktiBayar = s.getString(16);

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

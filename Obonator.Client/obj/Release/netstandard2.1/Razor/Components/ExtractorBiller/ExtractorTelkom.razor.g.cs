#pragma checksum "D:\Projects\rezaffikri\Obonator\Obonator.Client\Components\ExtractorBiller\ExtractorTelkom.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2505130e8ddc3b63d606b26ddff639925d0d9df7"
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
#line 1 "D:\Projects\rezaffikri\Obonator\Obonator.Client\Components\ExtractorBiller\ExtractorTelkom.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
    public partial class ExtractorTelkom : Microsoft.AspNetCore.Components.ComponentBase
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
#line 10 "D:\Projects\rezaffikri\Obonator\Obonator.Client\Components\ExtractorBiller\ExtractorTelkom.razor"
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
#line 20 "D:\Projects\rezaffikri\Obonator\Obonator.Client\Components\ExtractorBiller\ExtractorTelkom.razor"
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
#line 31 "D:\Projects\rezaffikri\Obonator\Obonator.Client\Components\ExtractorBiller\ExtractorTelkom.razor"
                                                            ExtractField61Inquiry

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(64, "\r\n                    Extract 61\r\n                ");
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
#line 36 "D:\Projects\rezaffikri\Obonator\Obonator.Client\Components\ExtractorBiller\ExtractorTelkom.razor"
                                                            ClearTextBox

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(73, "\r\n                    Clear\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 44 "D:\Projects\rezaffikri\Obonator\Obonator.Client\Components\ExtractorBiller\ExtractorTelkom.razor"
       

    public string inputData { get; set; }
    public string outputData { get; set; }
    public int isSuccess = 0;

    public class Extractor
    {
        public string f01_kode_area_4 { get; set; }
        public string f02_nomor_telepon_9 { get; set; }
        public string f03_kode_divre_2 { get; set; }
        public string f04_kode_datel_4 { get; set; }
        public string f05_jumlah_tagihan_1 { get; set; }
        public string f06_nomor_referensi3_11 { get; set; }
        public string f07_nilai_tagihan3_12 { get; set; }
        public string f08_nomor_referensi2_11 { get; set; }
        public string f09_nilai_tagihan2_12 { get; set; }
        public string f10_nomor_referensi1_11 { get; set; }
        public string f11_nilai_tagihan1_12 { get; set; }
        public string f12_nama_pelanggan_30 { get; set; }
        public string f13_npwp_15 { get; set; }
        public string f14_product_desc_25 { get; set; }
        public string f15_biaya_admin_8 { get; set; }
    }
    public void ExtractField61Inquiry()
    {
        try
        {
            ObonCommon.StrUtil s = new ObonCommon.StrUtil(inputData);
            Extractor extractor = new Extractor();

            extractor.f01_kode_area_4 = s.getString(4);
            extractor.f02_nomor_telepon_9 = s.getString(9);
            extractor.f03_kode_divre_2 = s.getString(2);
            extractor.f04_kode_datel_4 = s.getString(4);
            extractor.f05_jumlah_tagihan_1 = s.getString(1);
            extractor.f06_nomor_referensi3_11 = s.getString(11);
            extractor.f07_nilai_tagihan3_12 = s.getString(12);
            extractor.f08_nomor_referensi2_11 = s.getString(11);
            extractor.f09_nilai_tagihan2_12 = s.getString(12);
            extractor.f10_nomor_referensi1_11 = s.getString(11);
            extractor.f11_nilai_tagihan1_12 = s.getString(12);
            extractor.f12_nama_pelanggan_30 = s.getString(30);
            extractor.f13_npwp_15 = s.getString(15);
            extractor.f14_product_desc_25 = s.getString(25);
            extractor.f15_biaya_admin_8 = s.getString(8);

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

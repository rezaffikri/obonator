#pragma checksum "D:\Projects\rezaffikri\Obonator\Obonator.Client\Components\ExtractorBiller\ExtractorPlnPrepaid.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1b355dddcb68939b4e0bf6ad96573de0cacca071"
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
#line 1 "D:\Projects\rezaffikri\Obonator\Obonator.Client\Components\ExtractorBiller\ExtractorPlnPrepaid.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
    public partial class ExtractorPlnPrepaid : Microsoft.AspNetCore.Components.ComponentBase
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
#line 10 "D:\Projects\rezaffikri\Obonator\Obonator.Client\Components\ExtractorBiller\ExtractorPlnPrepaid.razor"
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
#line 20 "D:\Projects\rezaffikri\Obonator\Obonator.Client\Components\ExtractorBiller\ExtractorPlnPrepaid.razor"
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
#line 31 "D:\Projects\rezaffikri\Obonator\Obonator.Client\Components\ExtractorBiller\ExtractorPlnPrepaid.razor"
                                                            ExtractField48Inquiry

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
#line 36 "D:\Projects\rezaffikri\Obonator\Obonator.Client\Components\ExtractorBiller\ExtractorPlnPrepaid.razor"
                                                            ExtractField48Payment

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(73, "\r\n                    Extract Pay\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\r\n\r\n            ");
            __builder.OpenElement(76, "div");
            __builder.AddAttribute(77, "class", "control");
            __builder.AddMarkupContent(78, "\r\n                ");
            __builder.OpenElement(79, "button");
            __builder.AddAttribute(80, "class", "button is-primary");
            __builder.AddAttribute(81, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 42 "D:\Projects\rezaffikri\Obonator\Obonator.Client\Components\ExtractorBiller\ExtractorPlnPrepaid.razor"
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
#line 50 "D:\Projects\rezaffikri\Obonator\Obonator.Client\Components\ExtractorBiller\ExtractorPlnPrepaid.razor"
       

    public string inputData { get; set; }
    public string outputData { get; set; }
    public int isSuccess = 0;

    public class Extractor
    {
        //field 48 inquiry
        public string f48_inq_01_gateway_id_7 { get; set; }
        public string f48_inq_02_meter_serial_number_11 { get; set; }
        public string f48_inq_03_subscriber_id_12 { get; set; }
        public string f48_inq_04_flag_1 { get; set; }
        public string f48_inq_05_pln_reference_number_32 { get; set; }
        public string f48_inq_06_ca_receipt_reference_number_32 { get; set; }
        public string f48_inq_07_subscriber_name_25 { get; set; }
        public string f48_inq_08_subscriber_segmentation_4 { get; set; }
        public string f48_inq_09_power_consuming_category_9 { get; set; }
        public string f48_inq_10_minor_unit_of_admin_charge_1 { get; set; }
        public string f48_inq_11_admin_charge_10 { get; set; }

        //field 48 payment
        public string f48_pay_01_gateway_id_7 { get; set; }
        public string f48_pay_02_meter_serial_number_11 { get; set; }
        public string f48_pay_03_subscriber_id_12 { get; set; }
        public string f48_pay_04_flag_1 { get; set; }
        public string f48_pay_05_pln_reference_number_32 { get; set; }
        public string f48_pay_06_ca_receipt_reference_number_32 { get; set; }
        public string f48_pay_07_vending_receipt_number_8 { get; set; }
        public string f48_pay_08_subscriber_name_25 { get; set; }
        public string f48_pay_09_subscriber_segmentation_4 { get; set; }
        public string f48_pay_10_power_consuming_category_9 { get; set; }
        public string f48_pay_11_buying_option_1 { get; set; }
        public string f48_pay_12_minor_unit_of_admin_charge_1 { get; set; }
        public string f48_pay_13_admin_charge_10 { get; set; }
        public string f48_pay_14_minor_unit_of_stamp_duty_1 { get; set; }
        public string f48_pay_15_stamp_duty_10 { get; set; }
        public string f48_pay_16_minor_unit_of_value_added_tax_1 { get; set; }
        public string f48_pay_17_value_added_tax_10 { get; set; }
        public string f48_pay_18_minor_unit_of_public_lightning_tax_1 { get; set; }
        public string f48_pay_19_public_lightning_tax_10 { get; set; }
        public string f48_pay_20_minor_unit_of_customer_paybles_installment_1 { get; set; }
        public string f48_pay_21_customer_payables_installment_10 { get; set; }
        public string f48_pay_22_minor_unit__of_power_purchase_1 { get; set; }
        public string f48_pay_23_power_purchase_12 { get; set; }
        public string f48_pay_24_minor_unit_of_purchased_kwh_unit_1 { get; set; }
        public string f48_pay_25_purchased_kwh_unit_10 { get; set; }
        public string f48_pay_26_token_number_20 { get; set; }
    }


    public void ExtractField48Inquiry()
    {
        try
        {
            ObonCommon.StrUtil s = new ObonCommon.StrUtil(inputData);
            Extractor extractor = new Extractor();

            extractor.f48_inq_01_gateway_id_7 = s.getString(7);
            extractor.f48_inq_02_meter_serial_number_11 = s.getString(11);
            extractor.f48_inq_03_subscriber_id_12 = s.getString(12);
            extractor.f48_inq_04_flag_1 = s.getString(1);
            extractor.f48_inq_05_pln_reference_number_32 = s.getString(32);
            extractor.f48_inq_06_ca_receipt_reference_number_32 = s.getString(32);
            extractor.f48_inq_07_subscriber_name_25 = s.getString(25);
            extractor.f48_inq_08_subscriber_segmentation_4 = s.getString(4);
            extractor.f48_inq_09_power_consuming_category_9 = s.getString(9);
            extractor.f48_inq_10_minor_unit_of_admin_charge_1 = s.getString(1);
            extractor.f48_inq_11_admin_charge_10 = s.getString(10);
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
            extractor.f48_pay_01_gateway_id_7 = s.getString(7);
            extractor.f48_pay_02_meter_serial_number_11 = s.getString(11);
            extractor.f48_pay_03_subscriber_id_12 = s.getString(12);
            extractor.f48_pay_04_flag_1 = s.getString(1);
            extractor.f48_pay_05_pln_reference_number_32 = s.getString(32);
            extractor.f48_pay_06_ca_receipt_reference_number_32 = s.getString(32);
            extractor.f48_pay_07_vending_receipt_number_8 = s.getString(8);
            extractor.f48_pay_08_subscriber_name_25 = s.getString(25);
            extractor.f48_pay_09_subscriber_segmentation_4 = s.getString(4);
            extractor.f48_pay_10_power_consuming_category_9 = s.getString(9);
            extractor.f48_pay_11_buying_option_1 = s.getString(1);
            extractor.f48_pay_12_minor_unit_of_admin_charge_1 = s.getString(1);
            extractor.f48_pay_13_admin_charge_10 = s.getString(10);
            extractor.f48_pay_14_minor_unit_of_stamp_duty_1 = s.getString(1);
            extractor.f48_pay_15_stamp_duty_10 = s.getString(10);
            extractor.f48_pay_16_minor_unit_of_value_added_tax_1 = s.getString(1);
            extractor.f48_pay_17_value_added_tax_10 = s.getString(10);
            extractor.f48_pay_18_minor_unit_of_public_lightning_tax_1 = s.getString(1);
            extractor.f48_pay_19_public_lightning_tax_10 = s.getString(10);
            extractor.f48_pay_20_minor_unit_of_customer_paybles_installment_1 = s.getString(1);
            extractor.f48_pay_21_customer_payables_installment_10 = s.getString(10);
            extractor.f48_pay_22_minor_unit__of_power_purchase_1 = s.getString(1);
            extractor.f48_pay_23_power_purchase_12 = s.getString(12);
            extractor.f48_pay_24_minor_unit_of_purchased_kwh_unit_1 = s.getString(1);
            extractor.f48_pay_25_purchased_kwh_unit_10 = s.getString(10);
            extractor.f48_pay_26_token_number_20 = s.getString(20);
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

#pragma checksum "D:\Projects\rezaffikri\Obonator\Obonator.Client\Components\ExtractorBiller\ExtractorPlnPostpaid.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d8e9430691cdcdb5fdfb69fab5d9f69e4a3cd530"
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
#line 1 "D:\Projects\rezaffikri\Obonator\Obonator.Client\Components\ExtractorBiller\ExtractorPlnPostpaid.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
    public partial class ExtractorPlnPostpaid : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 49 "D:\Projects\rezaffikri\Obonator\Obonator.Client\Components\ExtractorBiller\ExtractorPlnPostpaid.razor"
       

    public string inputData { get; set; }
    public string outputData { get; set; }
    public int isSuccess = 0;

    public class Extractor
    {
        //field 48
        public string F48_01_gateway_id_7 { get; set; }
        public string F48_02_subscriber_id_12 { get; set; }
        public string F48_03_bill_status_1 { get; set; }
        public string F48_03_payment_status_1 { get; set; }
        public string F48_04_total_outstanding_2 { get; set; }
        public string F48_05_pln_reference_number_32 { get; set; }
        public string F48_06_subscriber_name_25 { get; set; }
        public string F48_07_service_unit_5 { get; set; }
        public string F48_08_service_unit_phone_15 { get; set; }
        public string F48_09_subsriber_segmentation_4 { get; set; }
        public string F48_10_power_consuming_category_9 { get; set; }
        public string F48_11_total_admin_charge_9 { get; set; }

        //repeated
        public string[] F48_12_bill_period_6 { get; set; }
        public string[] F48_13_due_date_8 { get; set; }
        public string[] F48_14_meter_read_date_8 { get; set; }
        public string[] F48_15_total_electricity_bill_12 { get; set; }
        public string[] F48_16_incentive_11 { get; set; }
        public string[] F48_17_value_added_tax_10 { get; set; }
        public string[] F48_18_penalty_fee_12 { get; set; }
        public string[] F48_19_previous_meter_reading_1_8 { get; set; }
        public string[] F48_20_current_meter_reading_1_8 { get; set; }
        public string[] F48_21_previous_meter_reading_2_8 { get; set; }
        public string[] F48_22_current_meter_reading_2_8 { get; set; }
        public string[] F48_23_previous_meter_reading_3_8 { get; set; }
        public string[] F48_24_current_meter_reading_3_8 { get; set; }
    }


    public void ExtractField48Inquiry()
    {
        try
        {
            ObonCommon.StrUtil s = new ObonCommon.StrUtil(inputData);
            Extractor extractor = new Extractor();

            extractor.F48_01_gateway_id_7 = s.getString(7);
            extractor.F48_02_subscriber_id_12 = s.getString(12);
            extractor.F48_03_bill_status_1 = s.getString(1);
            extractor.F48_04_total_outstanding_2 = s.getString(2);
            extractor.F48_05_pln_reference_number_32 = s.getString(32);
            extractor.F48_06_subscriber_name_25 = s.getString(25);
            extractor.F48_07_service_unit_5 = s.getString(5);
            extractor.F48_08_service_unit_phone_15 = s.getString(15);
            extractor.F48_09_subsriber_segmentation_4 = s.getString(4);
            extractor.F48_10_power_consuming_category_9 = s.getString(9);
            extractor.F48_11_total_admin_charge_9 = s.getString(9);

            //repeat
            int max = int.Parse(extractor.F48_03_bill_status_1);

            extractor.F48_12_bill_period_6 = new string[max];
            extractor.F48_13_due_date_8 = new string[max];
            extractor.F48_14_meter_read_date_8 = new string[max];
            extractor.F48_15_total_electricity_bill_12 = new string[max];
            extractor.F48_16_incentive_11 = new string[max];
            extractor.F48_17_value_added_tax_10 = new string[max];
            extractor.F48_18_penalty_fee_12 = new string[max];
            extractor.F48_19_previous_meter_reading_1_8 = new string[max];
            extractor.F48_20_current_meter_reading_1_8 = new string[max];
            extractor.F48_21_previous_meter_reading_2_8 = new string[max];
            extractor.F48_22_current_meter_reading_2_8 = new string[max];
            extractor.F48_23_previous_meter_reading_3_8 = new string[max];
            extractor.F48_24_current_meter_reading_3_8 = new string[max];

            for (int i = 0; i < max; i++)
            {
                extractor.F48_12_bill_period_6[i] = s.getString(6);
                extractor.F48_13_due_date_8[i] = s.getString(8);
                extractor.F48_14_meter_read_date_8[i] = s.getString(8);
                extractor.F48_15_total_electricity_bill_12[i] = s.getString(12);
                extractor.F48_16_incentive_11[i] = s.getString(11);
                extractor.F48_17_value_added_tax_10[i] = s.getString(10);
                extractor.F48_18_penalty_fee_12[i] = s.getString(12);
                extractor.F48_19_previous_meter_reading_1_8[i] = s.getString(8);
                extractor.F48_20_current_meter_reading_1_8[i] = s.getString(8);
                extractor.F48_21_previous_meter_reading_2_8[i] = s.getString(8);
                extractor.F48_22_current_meter_reading_2_8[i] = s.getString(8);
                extractor.F48_23_previous_meter_reading_3_8[i] = s.getString(8);
                extractor.F48_24_current_meter_reading_3_8[i] = s.getString(8);
            }
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
            extractor.F48_01_gateway_id_7 = s.getString(7);
            extractor.F48_02_subscriber_id_12 = s.getString(12);
            extractor.F48_03_bill_status_1 = s.getString(1);
            extractor.F48_03_payment_status_1 = s.getString(1);
            extractor.F48_04_total_outstanding_2 = s.getString(2);
            extractor.F48_05_pln_reference_number_32 = s.getString(32);
            extractor.F48_06_subscriber_name_25 = s.getString(25);
            extractor.F48_07_service_unit_5 = s.getString(5);
            extractor.F48_08_service_unit_phone_15 = s.getString(15);
            extractor.F48_09_subsriber_segmentation_4 = s.getString(4);
            extractor.F48_10_power_consuming_category_9 = s.getString(9);
            extractor.F48_11_total_admin_charge_9 = s.getString(9);

            //repeat
            int max = int.Parse(extractor.F48_03_bill_status_1);

            extractor.F48_12_bill_period_6 = new string[max];
            extractor.F48_13_due_date_8 = new string[max];
            extractor.F48_14_meter_read_date_8 = new string[max];
            extractor.F48_15_total_electricity_bill_12 = new string[max];
            extractor.F48_16_incentive_11 = new string[max];
            extractor.F48_17_value_added_tax_10 = new string[max];
            extractor.F48_18_penalty_fee_12 = new string[max];
            extractor.F48_19_previous_meter_reading_1_8 = new string[max];
            extractor.F48_20_current_meter_reading_1_8 = new string[max];
            extractor.F48_21_previous_meter_reading_2_8 = new string[max];
            extractor.F48_22_current_meter_reading_2_8 = new string[max];
            extractor.F48_23_previous_meter_reading_3_8 = new string[max];
            extractor.F48_24_current_meter_reading_3_8 = new string[max];

            for (int i = 0; i < max; i++)
            {
                extractor.F48_12_bill_period_6[i] = s.getString(6);
                extractor.F48_13_due_date_8[i] = s.getString(8);
                extractor.F48_14_meter_read_date_8[i] = s.getString(8);
                extractor.F48_15_total_electricity_bill_12[i] = s.getString(12);
                extractor.F48_16_incentive_11[i] = s.getString(11);
                extractor.F48_17_value_added_tax_10[i] = s.getString(10);
                extractor.F48_18_penalty_fee_12[i] = s.getString(12);
                extractor.F48_19_previous_meter_reading_1_8[i] = s.getString(8);
                extractor.F48_20_current_meter_reading_1_8[i] = s.getString(8);
                extractor.F48_21_previous_meter_reading_2_8[i] = s.getString(8);
                extractor.F48_22_current_meter_reading_2_8[i] = s.getString(8);
                extractor.F48_23_previous_meter_reading_3_8[i] = s.getString(8);
                extractor.F48_24_current_meter_reading_3_8[i] = s.getString(8);
            }
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

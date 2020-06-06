#pragma checksum "D:\Projects\rezaffikri\Obonator\Obonator.Client\Components\ExtractorBiller\ExtractorPlnNontaglis.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3d6455fc832aed4f2b3bba71811ebc77d018d027"
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
#line 1 "D:\Projects\rezaffikri\Obonator\Obonator.Client\Components\ExtractorBiller\ExtractorPlnNontaglis.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
    public partial class ExtractorPlnNontaglis : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 44 "D:\Projects\rezaffikri\Obonator\Obonator.Client\Components\ExtractorBiller\ExtractorPlnNontaglis.razor"
       

    public string inputData { get; set; }
    public string outputData { get; set; }
    public int isSuccess = 0;

    public class Extractor
    {
        public string F48_01_gateway_id_7 { get; set; }
        public string F48_02_registration_number_32 { get; set; }
        public string F48_03_area_code_2 { get; set; }
        public string F48_04_transaction_code_3 { get; set; }
        public string F48_05_transaction_name_25 { get; set; }
        public string F48_06_registration_date_8 { get; set; }
        public string F48_07_expiration_date_8 { get; set; }
        public string F48_08_subscriber_id_12 { get; set; }
        public string F48_09_subscriber_name_25 { get; set; }
        public string F48_10_pln_reference_number_32 { get; set; }
        public string F48_11_gsp_reference_number_32 { get; set; }
        public string F48_12_service_unit_5 { get; set; }
        public string F48_13_service_unit_address_35 { get; set; }
        public string F48_14_service_unit_phone_15 { get; set; }
        public string F48_15_total_transaction_amount_minor_unit_1 { get; set; }
        public string F48_16_total_transaction_amount_17 { get; set; }
        public string F48_17_pln_bill_minor_unit_1 { get; set; }
        public string F48_18_pln_bill_value_rptag_17 { get; set; }
        public string F48_19_administration_charge_minor_unit_1 { get; set; }
        public string F48_20_administration_charge_10 { get; set; }
    }


    public void ExtractField48()
    {
        try
        {
            ObonCommon.StrUtil s = new ObonCommon.StrUtil(inputData);
            Extractor extractor = new Extractor();

            extractor.F48_01_gateway_id_7 = s.getString(7);
            extractor.F48_02_registration_number_32 = s.getString(32);
            extractor.F48_03_area_code_2 = s.getString(2);
            extractor.F48_04_transaction_code_3 = s.getString(3);
            extractor.F48_05_transaction_name_25 = s.getString(25);
            extractor.F48_06_registration_date_8 = s.getString(8);
            extractor.F48_07_expiration_date_8 = s.getString(8);
            extractor.F48_08_subscriber_id_12 = s.getString(12);
            extractor.F48_09_subscriber_name_25 = s.getString(25);
            extractor.F48_10_pln_reference_number_32 = s.getString(32);
            extractor.F48_11_gsp_reference_number_32 = s.getString(32);
            extractor.F48_12_service_unit_5 = s.getString(5);
            extractor.F48_13_service_unit_address_35 = s.getString(35);
            extractor.F48_14_service_unit_phone_15 = s.getString(15);
            extractor.F48_15_total_transaction_amount_minor_unit_1 = s.getString(1);
            extractor.F48_16_total_transaction_amount_17 = s.getString(17);
            extractor.F48_17_pln_bill_minor_unit_1 = s.getString(1);
            extractor.F48_18_pln_bill_value_rptag_17 = s.getString(17);
            extractor.F48_19_administration_charge_minor_unit_1 = s.getString(1);
            extractor.F48_20_administration_charge_10 = s.getString(10);
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

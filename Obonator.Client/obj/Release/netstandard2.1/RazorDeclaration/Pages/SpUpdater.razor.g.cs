#pragma checksum "D:\Projects\rezaffikri\Obonator\Obonator.Client\Pages\SpUpdater.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "87ae2dbe415e4bfda506c7427cff4a3da64b0c81"
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
#line 1 "D:\Projects\rezaffikri\Obonator\Obonator.Client\Pages\SpUpdater.razor"
using System.Text;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projects\rezaffikri\Obonator\Obonator.Client\Pages\SpUpdater.razor"
using Obonator.Client.Services.SpUpdater;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Projects\rezaffikri\Obonator\Obonator.Client\Pages\SpUpdater.razor"
           [Authorize(Roles = "admin, se")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/spupdater")]
    public partial class SpUpdater : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 148 "D:\Projects\rezaffikri\Obonator\Obonator.Client\Pages\SpUpdater.razor"
      
    DateTime? dateDesc;
    public int ddlSelected { get; set; }

    protected void DdlClicked(ChangeEventArgs countryEvent)
    {
        ddlSelected = int.Parse(countryEvent.Value.ToString());


        switch (ddlSelected)
        {
            case 1:
                SupportedSp = "Supported SP: uspStatisticMonitoringDownline_CA, uspStatisticMonitoringDownline_SubCA, " +
    "uspStatisticMultiBiller_Cabang, uspStatisticMultiBiller_CollectingAgent, uspStatisticMultiBiller_Partner, " +
    "uspStatisticMultiBiller_SubCollectingAgent, uspStatisticMultiBillerPeriodic_Cabang, " +
    "uspStatisticMultiBillerPeriodic_CollectingAgent, uspStatisticMultiBillerPeriodic_Partner, " +
    "uspStatisticMultiBillerPeriodic_SubCollectingAgent";
                break;
            case 2:
                SupportedSp = "Supported SP: uspReportCommision_Ca, uspReportCommision_SubCa";
                break;
            default:
                SupportedSp = "";
                break;
        }
    }
    private string SupportedSp { get; set; }
    private DateTime historyDateData { get; set; }
    private string historyUserData { get; set; }
    private string historyNoteData { get; set; }
    private string nameData { get; set; }
    private string nameQueryData { get; set; }
    private string billerCodeData { get; set; }
    private string inputData { get; set; }
    private string outputData { get; set; }

    private void BtnGenerate()
    {
        switch (ddlSelected)
        {
            case 1:
                GenerateStarfishOfficeSp();
                break;
            case 2:
                GenerateStarfishSp();
                break;
            default:
                toastService.ShowError("Pilih salah satu template terlebih dahulu", "FAIL");
                break;
        }
    }

    private void BtnShowExample()
    {
        switch (ddlSelected)
        {
            case 1:
                inputData = StarfishOffice.StarfishOfficeSpExample();
                break;
            case 2:
                inputData = Starfish.StarfishSpExample();
                break;
            default:
                toastService.ShowError("Pilih salah satu template terlebih dahulu", "FAIL");
                break;
        }
    }

    private void GenerateStarfishOfficeSp()
    {
        try
        {
            historyDateData = dateDesc ?? DateTime.Now;
            string history = historyDateData.ToString("yyyy-MM-dd").PadRight(16, ' ') + historyUserData.PadRight(20, ' ') + historyNoteData;
            StringBuilder REVISED = new StringBuilder();
            REVISED.AppendLine(history);
            REVISED.Append("	End Revised");

            string jumlah = nameQueryData + "_JUMLAH";
            string rupiah = nameQueryData + "_RUPIAH";
            string komisi = nameQueryData + "_KOMISI";
            string total = nameQueryData + "_TOTAL";


            StringBuilder ONE = new StringBuilder();
            ONE.AppendLine("-- " + nameData + " --");
            ONE.AppendLine("			T2." + jumlah + ",");
            ONE.AppendLine("			T2." + rupiah + ",");
            ONE.AppendLine("			T2." + komisi + ",");
            ONE.AppendLine("			T2." + total + ",");
            ONE.AppendLine("			-- END OF " + nameData + " --");
            ONE.Append("			-- END OF GENERATOR ONE --");

            StringBuilder TWO = new StringBuilder();
            TWO.AppendLine("-- " + nameData + " --");
            TWO.AppendLine("			T." + jumlah + ",");
            TWO.AppendLine("			T." + rupiah + ",");
            TWO.AppendLine("			T." + komisi + ",");
            TWO.AppendLine("			(T." + rupiah + " + T." + komisi + ") AS " + total + ",");
            TWO.AppendLine("			-- END OF " + nameData + " --");
            TWO.Append("			-- END OF GENERATOR TWO --");

            StringBuilder THREE = new StringBuilder();
            THREE.AppendLine("+ T." + jumlah);
            THREE.Append("			-- END OF GENERATOR THREE --");

            StringBuilder FOUR = new StringBuilder();
            FOUR.AppendLine("+ T." + rupiah);
            FOUR.Append("			-- END OF GENERATOR FOUR --");

            StringBuilder FIVE = new StringBuilder();
            FIVE.AppendLine("+ T." + komisi);
            FIVE.Append("			-- END OF GENERATOR FIVE --");

            StringBuilder SIX = new StringBuilder();
            SIX.AppendLine(",");
            SIX.AppendLine("			-- " + nameData + " --");
            SIX.AppendLine("			ISNULL(SUM(" + nameQueryData + ".JUMLAH),0) AS " + jumlah + ",");
            SIX.AppendLine("			ISNULL(SUM(" + nameQueryData + ".RUPIAH),0) AS " + rupiah + ",");
            SIX.AppendLine("			ISNULL(SUM(" + nameQueryData + ".KOMISI),0) AS " + komisi);
            SIX.AppendLine("			-- END OF " + nameData + " --");
            SIX.Append("			-- END OF GENERATOR SIX --");

            StringBuilder SEVEN = new StringBuilder();
            SEVEN.AppendLine("			-- " + nameData + " --");
            SEVEN.AppendLine("			LEFT JOIN (");
            SEVEN.AppendLine("			select * from cteData where biller_id = '" + billerCodeData + "'");
            SEVEN.AppendLine("			) AS " + nameQueryData + " ON " + nameQueryData + ".transaction_id = tt.transaction_id");
            SEVEN.AppendLine("			-- END OF " + nameData + " --");
            SEVEN.Append("			-- END OF GENERATOR SEVEN --");

            StringBuilder QuerySP = new StringBuilder(inputData);
            QuerySP.Replace("End Revised", REVISED.ToString());
            QuerySP.Replace("-- END OF GENERATOR ONE --", ONE.ToString());
            QuerySP.Replace("-- END OF GENERATOR TWO --", TWO.ToString());
            QuerySP.Replace("-- END OF GENERATOR THREE --", THREE.ToString());
            QuerySP.Replace("-- END OF GENERATOR FOUR --", FOUR.ToString());
            QuerySP.Replace("-- END OF GENERATOR FIVE --", FIVE.ToString());
            QuerySP.Replace("-- END OF GENERATOR SIX --", SIX.ToString());
            QuerySP.Replace("-- END OF GENERATOR SEVEN --", SEVEN.ToString());

            outputData = QuerySP.ToString();
            toastService.ShowSuccess("Generator berhasil", "SUCCESS");
        }
        catch (Exception)
        {
            outputData = "";
            toastService.ShowError("Pastikan semua data benar", "FAIL");
        }
    }

    private void GenerateStarfishSp()
    {
        try
        {
            historyDateData = dateDesc ?? DateTime.Now;
            string history = historyDateData.ToString("yyyy-MM-dd").PadRight(16, ' ') + historyUserData.PadRight(20, ' ') + historyNoteData;
            StringBuilder REVISED = new StringBuilder();
            REVISED.AppendLine(history);
            REVISED.Append("	End Revised");

            string jumlah = nameQueryData + "_JUMLAH";
            string rupiah = nameQueryData + "_RUPIAH";
            string komisi = nameQueryData + "_KOMISI";

            StringBuilder ONE = new StringBuilder();
            ONE.AppendLine("-- " + nameData + " --");
            ONE.AppendLine("				" + jumlah + ",");
            ONE.AppendLine("				" + rupiah + ",");
            ONE.AppendLine("				" + komisi + ",");
            ONE.AppendLine("				-- END OF " + nameData + " --");
            ONE.Append("				-- END OF GENERATOR ONE --");

            StringBuilder TWO = new StringBuilder();
            TWO.AppendLine("-- " + nameData + " --");
            TWO.AppendLine("				+ " + jumlah);
            TWO.AppendLine("				-- END OF " + nameData + " --");
            TWO.Append("				-- END OF GENERATOR TWO --");

            StringBuilder THREE = new StringBuilder();
            THREE.AppendLine("-- " + nameData + " --");
            THREE.AppendLine("				+ " + rupiah);
            THREE.AppendLine("				-- END OF " + nameData + " --");
            THREE.Append("				-- END OF GENERATOR THREE --");

            StringBuilder FOUR = new StringBuilder();
            FOUR.AppendLine("-- " + nameData + " --");
            FOUR.AppendLine("				+ " + komisi);
            FOUR.AppendLine("				-- END OF " + nameData + " --");
            FOUR.Append("				-- END OF GENERATOR FOUR --");

            StringBuilder FIVE = new StringBuilder();
            FIVE.AppendLine("+ " + rupiah + " ");
            FIVE.Append("		 -- END OF GENERATOR FIVE --");

            StringBuilder SIX = new StringBuilder();
            SIX.AppendLine("+ " + komisi + " ");
            SIX.Append("		 -- END OF GENERATOR SIX --");

            StringBuilder SEVEN = new StringBuilder();
            SEVEN.AppendLine("+ " + rupiah + " ");
            SEVEN.Append("		 -- END OF GENERATOR SEVEN --");

            StringBuilder EIGHT = new StringBuilder();
            EIGHT.AppendLine("+ " + komisi + " ");
            EIGHT.Append("		 -- END OF GENERATOR EIGHT --");

            StringBuilder NINE = new StringBuilder();
            NINE.AppendLine("-- " + nameData + " --");
            NINE.AppendLine("		ISNULL(" + nameQueryData + ".jumlah,0) AS " + jumlah + ",");
            NINE.AppendLine("		ISNULL(" + nameQueryData + ".rupiah,0) AS " + rupiah + ",");
            NINE.AppendLine("		(ISNULL(" + nameQueryData + ".jumlah,0) * ISNULL(" + nameQueryData + ".amount,0)) AS " + komisi + ",");
            NINE.AppendLine("		-- END OF " + nameData + " --");
            NINE.Append("		-- END OF GENERATOR NINE --");

            StringBuilder TENCA = new StringBuilder();
            TENCA.AppendLine("-- " + nameData + " --");
            TENCA.AppendLine("				LEFT JOIN (");
            TENCA.AppendLine("				select * from CTE_DATA where biller_id = '" + billerCodeData + "'");
            TENCA.AppendLine("				) AS " + nameQueryData + " ON " + nameQueryData + ".institution_id = ins.sub_collecting_agent_id");
            TENCA.AppendLine("				-- END OF " + nameData + " --");
            TENCA.Append("				-- END OF GENERATOR TEN CA --");

            StringBuilder TENSUBCA = new StringBuilder();
            TENSUBCA.AppendLine("-- " + nameData + " --");
            TENSUBCA.AppendLine("				LEFT JOIN (");
            TENSUBCA.AppendLine("				select * from CTE_DATA where biller_id = '" + billerCodeData + "'");
            TENSUBCA.AppendLine("				) AS " + nameQueryData + " ON " + nameQueryData + ".institution_id = ins.partner_id");
            TENSUBCA.AppendLine("				-- END OF " + nameData + " --");
            TENSUBCA.Append("				-- END OF GENERATOR TEN SUB CA --");

            StringBuilder ELEVEN = new StringBuilder();
            ELEVEN.AppendLine(",");
            ELEVEN.AppendLine("	-- " + nameData + " --");
            ELEVEN.AppendLine("	" + nameQueryData + ".jumlah,");
            ELEVEN.AppendLine("	" + nameQueryData + ".rupiah,");
            ELEVEN.AppendLine("	" + nameQueryData + ".amount");
            ELEVEN.AppendLine("	-- END OF " + nameData + " --");
            ELEVEN.Append("	-- END OF GENERATOR ELEVEN --");

            StringBuilder QuerySP = new StringBuilder(inputData);
            QuerySP.Replace("End Revised", REVISED.ToString());
            QuerySP.Replace("-- END OF GENERATOR ONE --", ONE.ToString());
            QuerySP.Replace("-- END OF GENERATOR TWO --", TWO.ToString());
            QuerySP.Replace("-- END OF GENERATOR THREE --", THREE.ToString());
            QuerySP.Replace("-- END OF GENERATOR FOUR --", FOUR.ToString());
            QuerySP.Replace("-- END OF GENERATOR FIVE --", FIVE.ToString());
            QuerySP.Replace("-- END OF GENERATOR SIX --", SIX.ToString());
            QuerySP.Replace("-- END OF GENERATOR SEVEN --", SEVEN.ToString());
            QuerySP.Replace("-- END OF GENERATOR EIGHT --", EIGHT.ToString());
            QuerySP.Replace("-- END OF GENERATOR NINE --", NINE.ToString());
            QuerySP.Replace("-- END OF GENERATOR TEN CA --", TENCA.ToString());
            QuerySP.Replace("-- END OF GENERATOR TEN SUB CA --", TENSUBCA.ToString());
            QuerySP.Replace("-- END OF GENERATOR ELEVEN --", ELEVEN.ToString());

            outputData = QuerySP.ToString();
            toastService.ShowSuccess("Generator berhasil", "SUCCESS");
        }
        catch (Exception)
        {
            outputData = "";
            toastService.ShowError("Pastikan semua data benar", "FAIL");
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService toastService { get; set; }
    }
}
#pragma warning restore 1591

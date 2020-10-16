using Obonator.Client.Helper;
using Obonator.Shared.ExtractorISO;
using System.Text.Json;
using System.Text.Encodings.Web;

namespace Obonator.Client.Services.ExtractorISO
{
    public static class ExtractorISO
    {
        public static string GetExampleInqReq()
        {
            string inputData = "21004030004180810000059950100000034185120200630100543602107441001007441091000DTA6400DATST010190000000535514278415";
            return inputData;
        }

        public static string ExtractInqReq(string inputData)
        {
            ObonCommon.StrUtil iso = new ObonCommon.StrUtil(inputData);
            ExtractorISOModel iSOModel = new ExtractorISOModel();
            iSOModel.MTI = iso.getString(4);
            iSOModel.Bit1_BITMAP = iso.getString(16);
            iSOModel.Bit2_PAN = iso.getString(7);
            iSOModel.Bit11_TraceNumber = iso.getString(12);
            iSOModel.Bit12_DateTimeTran = iso.getString(14);
            iSOModel.Bit26_Merchant = iso.getString(4);
            iSOModel.Bit32_BankCode = iso.getString(9);
            iSOModel.Bit33_CID = iso.getString(9);
            iSOModel.BIT41_TerminalID = iso.getString(16);
            iSOModel.BIT48 = iso.getString(22);
            JsonSerializerOptions jsonSerializerOption = new JsonSerializerOptions();
            jsonSerializerOption.WriteIndented = true;
            string outputData = JsonSerializer.Serialize(iSOModel, jsonSerializerOption);
            return outputData;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Obonator.Shared.ExtractorISO
{
    public class ExtractorISOModel
    {
        public string MTI { get; set; }
        public string Bit1_BITMAP { get; set; }
        public string Bit2_PAN { get; set; }
        public string Bit11_TraceNumber { get; set; }
        public string Bit12_DateTimeTran { get; set; }
        public string Bit26_Merchant { get; set; }
        public string Bit32_BankCode { get; set; }
        public string Bit33_CID { get; set; }
        public string BIT41_TerminalID { get; set; }
        public string BIT48 { get; set; }
    }
}

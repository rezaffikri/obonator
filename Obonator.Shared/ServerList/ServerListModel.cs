using System;
using System.Collections.Generic;
using System.Text;

namespace Obonator.Shared.ServerList
{
    public class ServerListModel
    {
        public int ServerId { get; set; }
        public string ServerName { get; set; }
        public string ServerIp { get; set; }
        public string Keterangan { get; set; }
    }
}

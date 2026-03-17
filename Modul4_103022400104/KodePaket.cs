using System;
using System.Collections.Generic;
using System.Text;

namespace Modul4_103022400104
{
    internal class KodePaket
    {
        private Dictionary<string, string> paketTable = new Dictionary<string, string>()  
    {
            {"Basic", "P201"},
            {"Standard", "P202"},
            {"Premium", "P203"},
            {"Unlimited", "P204"},
            {"Gaming", "P205"},
            {"Streaming", "P206"},
            {"Familly", "P207"},
            {"Business", "P208"},
            {"Student", "P209"},
            {"Traveler", "P210"}
};
            public string GetKodePaket(string namaPaket)
        {
            if (paketTable.ContainsKey(namaPaket))
            {
                return paketTable[namaPaket];
            }
                return "Kode paket tidak ditemukan.";
            }
        }
    }

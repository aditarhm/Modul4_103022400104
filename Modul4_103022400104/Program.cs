using System;
using System.Collections.Generic;
using System.Text;
using Modul4_103022400104;

namespace TP_MODUL4_103022400104
{ 

    internal class Program
    {
        static void Main(string[] args)
        {
            KodePaket kode = new KodePaket();

            Console.WriteLine("Masukkan nama paket: ");
            string namaPaket = Console.ReadLine();

            string hasil = kode.GetKodePaket(namaPaket);
            Console.WriteLine("Kode paket:" + hasil);
        }
    }
}
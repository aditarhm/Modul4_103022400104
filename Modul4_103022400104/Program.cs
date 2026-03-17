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
            MesinKopi mesinKopi = new MesinKopi();

            mesinKopi.PowerOn();
            mesinKopi.StartBrew();
            mesinKopi.FinishBrew();
            mesinKopi.StartMaintenance(); 
            mesinKopi.FinishMaintenance(); 
            mesinKopi.StartBrew();
        }
    }
}
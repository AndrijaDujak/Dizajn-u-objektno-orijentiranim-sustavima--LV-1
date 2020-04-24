using System;
using System.Collections.Generic;

namespace Dizaj_LV_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Zabiljeska zab1,zab2,zab3;
            zab1 = new Zabiljeska("ovo je dan");
            zab2 = new Zabiljeska("koji nikad", "Andrija2");
            zab3 = new Zabiljeska("ne zelim vidjeti", "Andrija3", 4);
            System.Console.WriteLine(zab1.getzabiljeska()+","+ zab1.getautor() + "\n");
            System.Console.WriteLine(zab2.getzabiljeska() + "," + zab2.getautor()+"\n");
            System.Console.WriteLine(zab3.getzabiljeska() + "," + zab3.getautor() + "\n");
            List < Zabiljeska > Zadaci = new List<Zabiljeska>();
            Zadaci.Add(zab1);
            Zadaci.Add(zab2);
            Zadaci.Add(zab3);
        }

        private static void SortZadatke(List<Zabiljeska> zadaci)
        {
            int temp;
            for(int i=zadaci.Count-1;i >= 0; i--)
            {
                for (int j = zadaci.Count - 2; j >= 0; j--)
                {
                    if (zadaci[i].getvaznost() < zadaci[j].getvaznost()) {
                        temp = zadaci[j].getvaznost();
                        zadaci[j].setvaznost(zadaci[i].getvaznost());
                        zadaci[i].setvaznost(temp);
                    }
                }
            }
        }

        private static void ObavitiZadatke(List<Zabiljeska> zadaci)
        {
            foreach(Zabiljeska zadatak in zadaci)
            {
                Console.WriteLine(zadatak);
                zadaci.Remove(zadatak);
            }
        }
    }
}

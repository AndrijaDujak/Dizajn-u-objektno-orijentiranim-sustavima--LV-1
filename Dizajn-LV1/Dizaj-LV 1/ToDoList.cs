using System;
using System.Collections.Generic;
using System.Text;

namespace Dizaj_LV_1
{
    class ToDoList
    {
        private static List<Zabiljeska> zadaci = new List<Zabiljeska>();
        public  ToDoList()
        {
        
        }
        public static void SortZadatke()
        {
            int temp;
            for (int i = zadaci.Count - 1; i >= 0; i--)
            {
                for (int j = zadaci.Count - 2; j >= 0; j--)
                {
                    if (zadaci[i].getvaznost() < zadaci[j].getvaznost())
                    {
                        temp = zadaci[j].getvaznost();
                        zadaci[j].setvaznost(zadaci[i].getvaznost());
                        zadaci[i].setvaznost(temp);
                    }
                }
            }
        }
        public Zabiljeska ObaviZadatak()
        {
            Zabiljeska temp = zadaci[0];
            zadaci.RemoveAt(0);
            return temp;
        }

        public void DodajZabiljesku(Zabiljeska zadatak)
        {
            zadaci.Add(zadatak);
        }

        public string Pretrazi(int i) 
        {
            return zadaci[i].zabiljeska;
        }
    }
}

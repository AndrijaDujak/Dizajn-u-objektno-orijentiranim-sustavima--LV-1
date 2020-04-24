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
            Console.WriteLine(zab1.zabiljeska);
            Console.WriteLine(zab2.zabiljeska);
            Console.WriteLine(zab3.zabiljeska);
            System.Console.WriteLine(zab1.ToString());
            System.Console.WriteLine(zab2.ToString());
            System.Console.WriteLine(zab3.ToString());
            ToDoList lista = new ToDoList();
            lista.DodajZabiljesku(zab1);
            lista.DodajZabiljesku(zab2);
            lista.DodajZabiljesku(zab3);
            System.Console.WriteLine(lista.ObaviZadatak());
            System.Console.WriteLine(lista.ObaviZadatak());
            System.Console.WriteLine(lista.ObaviZadatak());
        }

        

        
    }
}

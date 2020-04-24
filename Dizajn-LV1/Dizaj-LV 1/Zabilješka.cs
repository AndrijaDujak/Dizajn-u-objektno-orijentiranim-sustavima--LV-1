using System;
using System.Collections.Generic;
using System.Text;

namespace Dizaj_LV_1
{
    class Zabiljeska
    {
        protected string zabiljeska {
            get { return this.zabiljeska; }
            set { this.zabiljeska = value; }
        }
        protected string autor
        {
            get { return this.autor; }
            set { if (this.autor == null) { this.autor = value; } }
        }
        protected int vaznost
        {
            get { return this.vaznost; }
            set { this.vaznost = value; }
        }

        public string getzabiljeska() { return this.zabiljeska; }
        public string getautor() { return this.autor; }
        public int getvaznost() { return this.vaznost; }
        public void setzabiljeska(string zabiljeska) { this.zabiljeska = zabiljeska; }
        public void setauthor(string author) { if (this.autor == null) {this.autor = author; } }
        public void setvaznost(int vaznost) { this.vaznost = vaznost; }

        public Zabiljeska(string zabiljeska, string autor)
        {
            this.zabiljeska = zabiljeska;
            this.autor = autor;
            this.vaznost = 1;
        }
        public Zabiljeska(string zabiljeska, string autor, int vaznost)
        {
            this.zabiljeska = zabiljeska;
            this.autor = autor;
            this.vaznost = vaznost;
        }
        public Zabiljeska(string zabiljeska)
        {
            this.zabiljeska = zabiljeska;
            this.autor = "Andrija";
            this.vaznost = 2;
        }
        public Zabiljeska()
        {
            this.zabiljeska = "standard";
            this.autor = "Andrija";
            this.vaznost = 3;
        }
        public override string ToString()
        {
            return this.zabiljeska +","+ this.autor;
        }
    }
}

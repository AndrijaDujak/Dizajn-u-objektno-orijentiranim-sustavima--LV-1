using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Dizaj_LV_1
{
    class ZabilješkaSVremenom : Zabiljeska
    {
        private DateTime vrijeme {
            get { return this.vrijeme; }
            set { this.vrijeme = DateTime.Now; }
        }
        public ZabilješkaSVremenom(string zabiljeska)
        {
            this.zabiljeska = zabiljeska;
            this.autor = "Andrija";
            this.vaznost = 4;
            this.vrijeme = DateTime.Now;
        }
        public override string ToString()
        {
            return this.zabiljeska + "," + this.autor+","+this.vrijeme;
        }
    }
}

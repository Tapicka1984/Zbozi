using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Produkt : Zbozi
    {
        string jmeno;
        double cena;
        DateTime Datum_vyroby;

        public Produkt(string jmeno, int cena, DateTime Datum_vyroby) : base(jmeno, cena, Datum_vyroby)
        {
            this.jmeno = jmeno;
            this.cena = cena;
            this.Datum_vyroby = Datum_vyroby;
        }

        public override string Cena_DPH()
        {
            if(Splnuje_Trvanlivost() == true)
            {
                cena = double.Parse(Cena_DPH());
                return "Neni prosle \na cena tak zustava" + cena;
            }
            else
            {
                double promena = double.Parse(Cena_DPH());
                cena = (promena - ((promena / 100) * 40));
                return "Zbozi je prosle\nCena se proto snizuje na" + cena;
            }
        }

        public virtual string ToString()
        {
            return base.ToString() + Cena_DPH();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Zbozi
    {
        string jmeno;
        int cena;
        DateTime Datum_vyroby;
        int trvanlivost = 30;

        public Zbozi(string jmeno, int cena, DateTime Datum_vyroby)
        {
            this.jmeno = jmeno;
            this.cena = cena;
            this.Datum_vyroby = Datum_vyroby;
        }

        public virtual bool Splnuje_Trvanlivost()
        {
            TimeSpan Doba = DateTime.Now - Datum_vyroby;
            if(Doba.TotalDays > 30)
            {
                return false;
            }
            else if(Doba.TotalDays <= 30)
            {
                return true;
            }
            return true;
        }

        public virtual string Cena_DPH()
        {
            double DPH = ((cena / 100) * 21);
            return "" + (cena + DPH);
        }

        public override string ToString()
        {
            return "Jmeno zbozi: " + jmeno + "\n Cena zbozi: " + cena + "\ncena s DPH: " + Cena_DPH() + "\n";  
        }
    }
}

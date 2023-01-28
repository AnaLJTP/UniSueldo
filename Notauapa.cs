using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniSueldo
{
    class Notauapa
    {
        public Notauapa() { }

       
       public double Calcularnota (double examen,double finalwork,double valo_acti,double plataforma)
        {
            return (examen + finalwork + valo_acti + plataforma);
        }

        public string Apro_repro(double total_nota)
        {
            if (total_nota < 70)
            {
                return "Reprobó";
            }

            else
            {
                return "Aprobó";
            }

        }

        public string definirliteral(double total_nota)
        {
            if (total_nota>89)
            {
                return "A";

            }

            else if (total_nota>=80 )
            {
                return "B";
            }

            else if (total_nota>=70 )
            {
                return "C";
            }

            else if (total_nota>=60)
            {
                return "D";
            }

            else
            {
                return "F";
            }
        }

    }
}

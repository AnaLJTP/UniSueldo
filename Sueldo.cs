using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniSueldo
{
    class Sueldo
    {
        private const double AFP = 0.07, ISR= 0.27, ARS=0.03;
        public Sueldo() { }

        public double AFPcal(double salary)
        {
            return (salary * AFP);
        }

        public double ISRcal(double salary)
        {
            return (salary * ISR);
        }

        public double ARScal(double salary)
        {
            return (salary * ARS);
        }

        public double Totaldescuento(double salary)
        {
            return (ISRcal(salary)+AFPcal(salary)+ISRcal(salary));
        }

        public double NetSalary(double salary)
        {
            return (salary - Totaldescuento(salary));
        }
    }
}

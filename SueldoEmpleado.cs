using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniSueldo
{
    public partial class SueldoEmpleado : Form
    {
        public SueldoEmpleado()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Sueldo salary = new  Sueldo();
            arstxt.Text = Convert.ToString(salary.ARScal(Convert.ToDouble(salarytxt.Text)));
            isrtxt.Text = Convert.ToString(salary.ISRcal(Convert.ToDouble(salarytxt.Text)));
            afptxt.Text = Convert.ToString(salary.AFPcal(Convert.ToDouble(salarytxt.Text)));
            totaldescuentotxt.Text = Convert.ToString(salary.Totaldescuento(Convert.ToDouble(salarytxt.Text)));
            sueldonetotxt.Text = Convert.ToString(salary.NetSalary(Convert.ToDouble(salarytxt.Text)));
        }
    }
}

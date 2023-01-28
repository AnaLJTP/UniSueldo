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
    public partial class EstuUapa : Form
    {
        public EstuUapa()
        {
            InitializeComponent();
        }

        private void calcular_nota_Click(object sender, EventArgs e)
        {
            double totalnota;
            Notauapa nota = new Notauapa();

            totalnota = nota.Calcularnota(Convert.ToDouble(Examentxt.Text),Convert.ToDouble(finalworktxt.Text), Convert.ToDouble(activalotxt.Text), Convert.ToDouble(platatxt.Text));
            Totalnotatxt.Text = Convert.ToString(totalnota);

            if(totalnota<70)
            {

                MessageBox.Show("Este estudiante reprobó", "Sorry tendrás que repetir");
            }

            else
            {
                MessageBox.Show("Este estudiante Aprobó", "Amonosssssssssssssssss");
            }
            
        }
    }
}

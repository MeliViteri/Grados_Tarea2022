using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grados_Tarea2022
{
    public partial class Form1 : Form
    {
        GradosF_C gradosf_c = new GradosF_C();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            try
            {
                gradosf_c.GradosFt_Cs = Convert.ToDouble(txtGradosFt_Cs.Text);
                double grados = gradosf_c.CalcularGradosF_C();
                frmResultado resultado = new frmResultado();
                this.Hide();
                resultado.lblResultado.Text= grados.ToString();
                resultado.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

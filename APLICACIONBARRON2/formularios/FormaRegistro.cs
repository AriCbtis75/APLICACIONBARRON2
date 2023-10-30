using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace APLICACIONBARRON2.formularios
{
    public partial class FormaRegistro : Form
    {
        public FormaRegistro()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonRegresar_Click(object sender, EventArgs e)
        {
            Close();
            Form1 form = new Form1();
            form.Show();
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            Close();

            FormaMenu menu = new FormaMenu();
            menu.Show();

         
        }
    }
}

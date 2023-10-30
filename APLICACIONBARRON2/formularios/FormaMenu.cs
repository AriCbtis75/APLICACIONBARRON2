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
    public partial class FormaMenu : Form
    {
        public FormaMenu()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void regresarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();

            Form1 form = new Form1();
            form.Show();
        }

        private void editarListaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();

            FormaListaTienda listaTienda = new FormaListaTienda();
            listaTienda.Show();
        }

        private void listaDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();

            FormaListaTienda formaLista = new FormaListaTienda();
            formaLista.Show();
        }

        private void configuracionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void empleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();

            FormaEmpleado formaEmpleados = new FormaEmpleado();
            formaEmpleados.Show();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();

            FormaUsuario formaUsuarios = new FormaUsuario();
            formaUsuarios.Show();
        }
    }
}

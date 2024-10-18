using SistemaGestionBiblioteca.Vistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestionBiblioteca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void librosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formulario_de_libros newform = new Formulario_de_libros();
            newform.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formulario_de_usuarios newform = new Formulario_de_usuarios();
            newform.Show();
        }

        private void reservasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formulario_de_reservas newform = new Formulario_de_reservas();
            newform.Show();
        }
    }
}

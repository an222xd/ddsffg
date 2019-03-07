using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ddsffg.modelo;
using ddsffg.vista;

namespace ddsffg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Estudiante student1 = new Estudiante();
            var student2 = new Estudiante();

            student1.edad = 17;
			student1.genero = 'H';
            student1.numeroControl = 1218100524;
            student1.nombre = "Jose Antonio Garcia Mtz. ";
			//se manda allamar los resultados ingresados en el programa
			textoNombre.Text = student1.nombre;
			textoNumero.Text = student1.numeroControl.ToString();
			textoGenero.Text = student1.genero.ToString();
			textoedad.Text = student1.edad.ToString();

		}
    }
}

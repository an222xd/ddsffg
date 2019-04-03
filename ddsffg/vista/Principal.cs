using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ddsffg.vista;

namespace ddsffg.vista
{
	public partial class Principal : Form
	{
		public Principal()
		{
			InitializeComponent();
		}

		private void label1_MouseEnter(object sender, EventArgs e)
		{
			this.label1.ForeColor = System.Drawing.Color.Green;
		}

		private void label1_MouseLeave(object sender, EventArgs e)
		{
			this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
		}

		private void buttonCampeonato_MouseEnter(object sender, EventArgs e)
		{
			this.buttonCampeonato.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

		}

		private void buttonCampeonato_MouseLeave(object sender, EventArgs e)
		{
			this.buttonCampeonato.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void buttonCampeonato_Click(object sender, EventArgs e)
		{
			formChampinonship fh = new formChampinonship();
			this.Hide();
			fh.ShowDialog();
			this.Close();
		}

		private void buttonEquipos_Click(object sender, EventArgs e)
		{
			pag fh = new pag();
			this.Hide();
			fh.ShowDialog();
			this.Close();
		}
	}
}

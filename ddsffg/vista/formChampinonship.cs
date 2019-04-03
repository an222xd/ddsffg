using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ddsffg.vista
{
	public partial class formChampinonship : Form
	{
		private string path = @"C:\PerfLogs\campeonato.txt";
		public formChampinonship()
		{
			InitializeComponent();
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			Principal fh = new Principal();
			this.Hide();
			fh.ShowDialog();
			this.Close();
		}
		private void loadGrid()
		{
			dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dataGridView1.Rows.Clear();
			dataGridView1.AllowUserToAddRows = false;
			if(File.Exists(path))
			{
				StreamReader streamReader = new StreamReader(path, Encoding.Default);
				string text;
				while ((text = streamReader.ReadLine()) != null)
				{
					String[] array = text.Split('|');
					dataGridView1.Rows.Add(array);
				}
				streamReader.Close();
			}
			else
			{
				File.Create(path);
			}
		}
	}
}

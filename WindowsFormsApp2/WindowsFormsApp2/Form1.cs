using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			panel1.Visible = true;
			label11.Text = textBox1.Text;
			label12.Text = textBox2.Text;
			label13.Text = textBox3.Text;
			label14.Text = comboBox1.Text;
			label15.Text = textBox4.Text;
		}

		private void label14_Click(object sender, EventArgs e)
		{

		}
	}
}

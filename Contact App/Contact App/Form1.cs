using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Contact_App
{
    public partial class Form1 : Form
    {
        SqlConnection sqc = new SqlConnection("Data Source=DESKTOP-BHBB5O1\\SQLEXPRESS;Initial Catalog=Contact;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listContect();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (sqc.State == ConnectionState.Closed) {
                sqc.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqc;
                cmd.CommandText = "insert into Contact(name,surname,phone) values('"+textBox1.Text+"','"+textBox2.Text+"','"+textBox3.Text+"')";
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                sqc.Close();
                listContect();
                MessageBox.Show("Contact Added");
            }
        }

        void listContect() {
            if (sqc.State == ConnectionState.Closed)
            {
                sqc.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqc;
                cmd.CommandText = "select * from Contact";
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds, "Contact");
                dataGridView1.DataSource = ds.Tables["Contact"];
                dataGridView1.Columns[0].Visible = false;
                sqc.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                if (sqc.State == ConnectionState.Closed)
                {
                    sqc.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = sqc;
                    cmd.CommandText = "delete from Contact where id=@id";
                    cmd.Parameters.AddWithValue("@id", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    sqc.Close();
                    listContect();
                }
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (sqc.State == ConnectionState.Closed)
            {
                sqc.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqc;
                cmd.CommandText = "update Contact set name='"+textBox1.Text+"',surname='"+textBox2.Text+"',phone='"+textBox3.Text+"' where id=@id";
                cmd.Parameters.AddWithValue("@id", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                sqc.Close();
                MessageBox.Show("Update Done");
                listContect();
            }
        }

        private void cell_Click(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }
    }
}

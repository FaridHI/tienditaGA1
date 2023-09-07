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

namespace Tiendapues
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Form1 login = new Form1();
            login.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 login1 = new Form1();
            login1.Show();
            this.Hide();

            using (SqlConnection cn = new SqlConnection("Data Source=DESKTOP-7LDGQBD;Initial Catalog=Inicio;Integrated Security=True"))
            {
                SqlCommand cmd = new SqlCommand("insert into USUARIO(id, usuario, Contraseña) values ("+ textBox1.Text +",'"+ textBox2.Text + "','" + textBox3.Text + "')", cn);
                cmd.CommandType = CommandType.Text;

                cn.Open();

                cmd.ExecuteNonQuery();
            }
        }
    }
}

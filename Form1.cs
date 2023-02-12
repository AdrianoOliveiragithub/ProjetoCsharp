using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SAGI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Conexao cn = new Conexao();
            try
            {
              cn.conectar();
                string sql = "SELECT * FROM login WHERE login='" + textBox2.Text + "' AND senha ='" + textBox1.Text + "'";
                MySqlDataAdapter Dados = new MySqlDataAdapter(sql, cn.Mcon);
                DataTable usuario = new DataTable();  // instanciia a datatable
                Dados.Fill(usuario); // joga o resultado do data adapter para o datatable;
                if (usuario.Rows.Count < 1)
                {
                    MessageBox.Show("LOGIN OU SENHA INVÁLIDOS!");
                    textBox1.Clear();
                    textBox2.Clear();

                } 
                else
                {
                    MessageBox.Show("SEJA BEM VINDO !");
                    textBox1.Clear();
                    textBox2.Clear();
                    Home Tela = new Home();
                    Tela.Show();
                }


            }
            catch(Exception E)
            {
                MessageBox.Show("erro de conexão!");

            }
            

        }
    }
}

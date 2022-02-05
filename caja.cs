using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Prueba
{
    public partial class caja : Form
    {
        public caja(string usuario)
        {
            InitializeComponent();
            dgbcaja();
            dgbefectivo();
            lblusuario.Text = usuario;
        }
        conexion abrir = new conexion();

        public void dgbcaja()//Genera la visualizacion del inventario
        {
            string selectQuery = "select * from caja";
            DataTable inventario = new DataTable();
            MySqlDataAdapter adaptar = new MySqlDataAdapter(selectQuery, abrir._conexion);
            adaptar.Fill(inventario);
            dgvcaja.DataSource = inventario;
        }
        public void dgbefectivo()//Genera la visualizacion del inventario
        {
            string selectQuery = "select * from Totalcaja";
            DataTable inventario = new DataTable();
            MySqlDataAdapter adaptar = new MySqlDataAdapter(selectQuery, abrir._conexion);
            adaptar.Fill(inventario);
            dgvefectivo.DataSource = inventario;
        }
        private void caja_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            string usuario=lblusuario.Text;
            Infz_gerente abrir = new Infz_gerente(usuario);
            abrir.Show();
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string movimiento=lblusuario.Text;
            corte abrir = new corte(movimiento);
            abrir.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dgbcaja();
            dgbefectivo();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string usuario = lblusuario.Text;
            Entrada_efectivo entrar = new Entrada_efectivo(usuario);
            entrar.Show();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

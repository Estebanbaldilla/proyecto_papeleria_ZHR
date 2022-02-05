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
    public partial class Inventario : Form
    {
        public Inventario(string usuario)
        {
            InitializeComponent();
            lblusuario.Text = usuario;
            
        
        }
        conexion abrir = new conexion();
        private void Inventario_Load(object sender, EventArgs e)
        {
            dgbinventario();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string usuario = lblusuario.Text;
            Form1 abrir = new Form1(usuario);
            abrir.Show();
            this.Hide();
        }
        public void dgbinventario()//Genera la visualizacion del inventario
        {
            string selectQuery = "select * from inventario";
            DataTable inventario = new DataTable();
            MySqlDataAdapter adaptar = new MySqlDataAdapter(selectQuery, abrir._conexion);
            adaptar.Fill(inventario);
            dgvinventario.DataSource = inventario;
        }
        private void button1_Click(object sender, EventArgs e)
        {
           string usuario= lblusuario.Text;
            Sumar_producto sumar = new Sumar_producto(usuario);
            sumar.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string usuario = lblusuario.Text;
            Infz_gerente abrir = new Infz_gerente(usuario);
            this.Hide();
            abrir.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Borrar_producto borrar = new Borrar_producto();
            borrar.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string user = lblusuario.Text;
            compras comprar = new compras(user);
            comprar.Show();

        }
    }
}

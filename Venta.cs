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
    public partial class Venta : Form
    {
        public Venta()
        {
            InitializeComponent();
            
        }
        conexion abrir = new conexion();
        
        private void button1_Click(object sender, EventArgs e)
        {
            dgbbusqueda();
        }
        public void dgbventa()
        {
            string selectQuery = "select * from inventario";
            DataTable inventario = new DataTable();
            MySqlDataAdapter adaptar = new MySqlDataAdapter(selectQuery, abrir._conexion);
            adaptar.Fill(inventario);
            dgventa.DataSource = inventario;
        }
        public void dgbbusqueda()
        {
            string selectQuery = "select *from inventario where producto='"+txtnombre.Text+"';";
            DataTable inventario = new DataTable();
            MySqlDataAdapter adaptar = new MySqlDataAdapter(selectQuery, abrir._conexion);
            adaptar.Fill(inventario);
            dgventa.DataSource = inventario;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dgbventa();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

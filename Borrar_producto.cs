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
    public partial class Borrar_producto : Form
    {
        public Borrar_producto()
        {
            InitializeComponent();
            dgbinventario();
        }
        conexion abrir = new conexion();
        public static string id;
        public static string producto;
        public void dgbinventario()//Genera la visualizacion del inventario
        {
            string selectQuery = "select * from inventario";
            DataTable inventario = new DataTable();
            MySqlDataAdapter adaptar = new MySqlDataAdapter(selectQuery, abrir._conexion);
            adaptar.Fill(inventario);
            dgvinventario.DataSource = inventario;
        }
        public void dgbbusqueda()//Realiza la busqueda de un producto
        {
            string selectQuery = "select *from inventario where producto='" + txt.Text + "';";
            DataTable inventario = new DataTable();
            MySqlDataAdapter adaptar = new MySqlDataAdapter(selectQuery, abrir._conexion);
            adaptar.Fill(inventario);
            dgvinventario.DataSource = inventario;
        }
        private void Borrar_producto_Load(object sender, EventArgs e)
        {

        }

        private void dgvinventario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            producto = dgvinventario.Rows[e.RowIndex].Cells["producto"].Value.ToString();
            id = dgvinventario.Rows[e.RowIndex].Cells["id_inventario"].Value.ToString();
            txt.Text = producto;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt.Text) && string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Porfabor rellene los campos", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }else
            {
                string borrar = "DELETE FROM inventario where id_inventario=" + id + "";
                abrir.executeMyQuery(borrar);
                MessageBox.Show("Producto borrado con exito");
                this.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt.Text) && string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Porfabor rellene los campos", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }
            else
            {
                dgbbusqueda();
            }
        }
    }
}

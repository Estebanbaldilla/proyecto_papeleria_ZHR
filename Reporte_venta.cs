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
    public partial class Reporte_venta : Form
    {
        public Reporte_venta()
        {
            InitializeComponent();
        }
        conexion abrir = new conexion(); 
        public void dgbventa()//Muestra las ventas de tal fecha
        {
            string selectQuery = "select  producto,cantidad,fecha from venta where fecha='"+txtaño.Text+"-"+txtmes.Text+"-"+txtdia.Text+"'";
            DataTable venta = new DataTable();
            MySqlDataAdapter adaptar = new MySqlDataAdapter(selectQuery, abrir._conexion);
            adaptar.Fill(venta);
            dgbreporte.DataSource = venta;
        }

        public void dgbcompra()//Muestra las ventas de tal fecha
        {
            string selectQuery = "select producto,precio,cantidad,fecha from compra where fecha='" + txtaño.Text + "-" + txtmes.Text + "-" + txtdia.Text + "'";
            DataTable compra = new DataTable();
            MySqlDataAdapter adaptar = new MySqlDataAdapter(selectQuery, abrir._conexion);
            adaptar.Fill(compra);
            dgbreporte.DataSource = compra;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtmes.Text) && string.IsNullOrEmpty(txtdia.Text) && string.IsNullOrEmpty(txtaño.Text))
            {
                MessageBox.Show("Porfabor rellene los campos", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                dgbventa();
            }
                
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dgbcompra();
        }

        private void Reporte_venta_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(":c");
        }
    }
}

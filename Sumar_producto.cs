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
    public partial class Sumar_producto : Form
    {
        public Sumar_producto(string usuario)
        {
            InitializeComponent();
            lblusuario.Text = usuario;
        }
        conexion abrir = new conexion();
        public static string codigo;
        public static string nombre="vacio";
        private void Sumar_producto_Load(object sender, EventArgs e)
        {
            dgbinventario();
        }
        public void dgbinventario()//Genera la visualizacion del inventario
        {
            string selectQuery = "select * from inventario";
            DataTable inventario = new DataTable();
            MySqlDataAdapter adaptar = new MySqlDataAdapter(selectQuery, abrir._conexion);
            adaptar.Fill(inventario);
            dgvinventario.DataSource = inventario;
        }
        private void dgvinventario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtpro.Text = dgvinventario.Rows[e.RowIndex].Cells["producto"].Value.ToString();
            txtco.Text = dgvinventario.Rows[e.RowIndex].Cells["codigo"].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(nombre=="vacio")
            {
                MessageBox.Show("Porfavor selecciona una fila", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                txtpro.Text = nombre;
                txtco.Text = codigo;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string usuario = lblusuario.Text;
            Inventario abrir = new Inventario(usuario);
            abrir.Show();
            this.Hide();
        }

        private void btnsumar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtco.Text) && string.IsNullOrEmpty(txtsum.Text))
            {
                MessageBox.Show("Porfabor rellene los campos", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;

            }
            else
            {
                string sumar = "UPDATE inventario SET cantidad= cantidad+" + int.Parse(txtsum.Text) + " WHERE codigo='" + txtco.Text + "'";
                abrir.executeMyQuery(sumar);
                dgbinventario();
                MessageBox.Show("Productos cargados con exito", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}

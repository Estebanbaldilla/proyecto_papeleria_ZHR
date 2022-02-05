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
    public partial class Borrar_empleado : Form
    {
        public Borrar_empleado()
        {
            InitializeComponent();
        }
        conexion abrir = new conexion();
        public static string id;
        public void dgvborrar()//Genera la visualizacion de los usuarios
        {
            string selectQuery = "select * from usuario";
            DataTable inventario = new DataTable();
            MySqlDataAdapter adaptar = new MySqlDataAdapter(selectQuery, abrir._conexion);
            adaptar.Fill(inventario);
            dgbborrar.DataSource = inventario;
        }
        private void Borrar_empleado_Load(object sender, EventArgs e)
        {
            dgvborrar();
        }

        private void dgbborrar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtusuario.Text = dgbborrar.Rows[e.RowIndex].Cells["nombre_empleado"].Value.ToString();
            id =dgbborrar.Rows[e.RowIndex].Cells["id_usuario"].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //agregar usuario
            if (string.IsNullOrEmpty(txtusuario.Text))
            {
                MessageBox.Show("Porfabor Seleccione un usuario", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;

            }
            else
            {
                string borrar = "DELETE FROM usuario where id_usuario="+id+"";
                abrir.executeMyQuery(borrar);
                MessageBox.Show("Usuario Borrado con exito");
                this.Hide();
            }
        }
    }
}

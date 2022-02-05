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
    public partial class Entrada_efectivo : Form
    {
        public Entrada_efectivo(string usuario)
        {
            InitializeComponent();
            lblusuario.Text = usuario;
        }
        conexion abrir = new conexion();
        private void button1_Click(object sender, EventArgs e)
        {
            string leer = txtcantidad.Text;
            if (string.IsNullOrEmpty(txtcantidad.Text))
            {
                MessageBox.Show("Campo vacio");
            }
            else
            {
                string usuario = lblusuario.Text;
                string relleno = "UPDATE Totalcaja SET Dinero= Dinero+" + int.Parse(txtcantidad.Text)+ "";
                abrir.executeMyQuery(relleno);
                MessageBox.Show("Efectivo registrado con exito");
                string fecha = DateTime.Today.ToString("yyyy-MM-dd");
                string agregar = "insert into caja values('0','" + int.Parse(txtcantidad.Text) + "','Ingreso de efectivo','" + fecha + "','" + usuario + "')";
                abrir.executeMyQuery(agregar);
                this.Close();
            }
        }

        private void Entrada_efectivo_Load(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class corte : Form
    {
        public corte(string movimiento)
        {
            InitializeComponent();
            lblusuario.Text = movimiento;
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
                string corte = "UPDATE Totalcaja SET Dinero= Dinero+" + int.Parse(txtcantidad.Text)*-1 +"";
                abrir.executeMyQuery(corte);
                MessageBox.Show("Corte Realizado con exito");
                string fecha = DateTime.Today.ToString("yyyy-MM-dd");
                string agregar = "insert into caja values('0','" + int.Parse(txtcantidad.Text) * -1 + "','Corte de caja','" + fecha + "','" + usuario + "')";
                abrir.executeMyQuery(agregar);
                this.Close();
            }
        }

        private void corte_Load(object sender, EventArgs e)
        {

        }
    }
}

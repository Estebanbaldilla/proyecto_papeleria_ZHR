using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba
{
    public partial class Infz_empleado : Form
    {
        public Infz_empleado(string usuario)
        {
            InitializeComponent();
            lblusuario.Text = usuario;
        }
        

        private void Infz_empleado_Load(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Inicio abrir = new Inicio();
            abrir.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = lblusuario.Text;
            Ventana_venta abrir = new Ventana_venta(usuario);
            abrir.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Reporte_venta venta = new Reporte_venta();
            venta.Show();
           
        }
    }
}

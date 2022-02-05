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
    public partial class Infz_gerente : Form
    {
        public Infz_gerente(string usuario)
        {
            InitializeComponent();
            string usuario2 = usuario;
            lblusuario.Text = usuario2;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Reporte_venta reporte = new Reporte_venta();
            reporte.Show();
        }

        private void Infz_gerente_Load(object sender, EventArgs e)
        {
           
        }


        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            Inicio abrir = new Inicio();
            abrir.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario;
            usuario = lblusuario.Text;
            Inventario open = new Inventario(usuario);
            open.Show();
            this.Hide();
           

        }

        private void button3_Click(object sender, EventArgs e)//Entrar en Caja
        {
            string usuario=lblusuario.Text;
            caja cj = new caja(usuario);
            cj.Show();
            this.Close();
        }
    }
}

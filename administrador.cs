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
    public partial class administrador : Form
    {
        public administrador(string usuario)
        {
            InitializeComponent();
            lblusuario.Text = usuario;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = lblusuario.Text;
            Inicio abrir = new Inicio();
            abrir.Show();
            this.Hide();

        }

        private void administrador_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string usuario = lblusuario.Text;
            Infz_empleado abrir = new Infz_empleado(usuario);
            abrir.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string usuario = lblusuario.Text;
            Infz_gerente abrir = new Infz_gerente(usuario);
            abrir.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            usuario_agregar abrir = new usuario_agregar();
            abrir.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Borrar_empleado abrir = new Borrar_empleado();
            abrir.Show();
        }
    }
}

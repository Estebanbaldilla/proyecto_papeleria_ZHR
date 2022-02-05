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
    public partial class usuario_agregar : Form
    {
        public usuario_agregar()
        {
            InitializeComponent();
        }
        conexion abrir = new conexion();
        private void check_tipo1_CheckedChanged(object sender, EventArgs e)
        {
            check_tipo2.Checked = false;
            check_tipo3.Checked = false;
        }

        private void check_tipo3_CheckedChanged(object sender, EventArgs e)
        {
            check_tipo2.Checked = false;
            check_tipo1.Checked = false;
        }

        private void check_tipo2_CheckedChanged(object sender, EventArgs e)
        {
            check_tipo3.Checked = false;
            check_tipo1.Checked = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int tipo = 0;
            if (check_tipo2.Checked == true)
            {
                tipo = 2;
                check_tipo3.Checked = false;
            }
            else if (check_tipo3.Checked == true)
            {
                tipo = 3;

            }
            else if (check_tipo1.Checked == true)
            {
                tipo = 1;
            }

            //agregar usuario
            if (string.IsNullOrEmpty(txtcontra.Text) && string.IsNullOrEmpty(txtcorreo.Text)&& string.IsNullOrEmpty(txtnum.Text)&& string.IsNullOrEmpty(txtusuario.Text))
            {
                MessageBox.Show("Porfabor rellene los campos", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;

            }
            else
            {
                string sumar = "insert into usuario values('0','"+txtusuario.Text+"','"+tipo+"','"+txtcontra.Text+"','"+txtnum.Text+"','"+txtcorreo.Text+"')";
                abrir.executeMyQuery(sumar);
                MessageBox.Show("Usuario agregado con exito");
                this.Hide();
            }
        }

        private void usuario_agregar_Load(object sender, EventArgs e)
        {

        }
    }
}

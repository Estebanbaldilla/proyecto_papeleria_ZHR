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
    public partial class Estado_productos : Form
    {
        public Estado_productos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int precio_total = (int.Parse(txtnombre.Text) * int.Parse(txtcantidad.Text));
            MessageBox.Show("hola"+precio_total);
        }
    }
}

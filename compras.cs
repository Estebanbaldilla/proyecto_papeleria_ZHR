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
    public partial class compras : Form
    {
        public compras(string user)
        {
            InitializeComponent();
            lblusuario.Text = user;
        }
        conexion abrir = new conexion();
        public static int resta=0 ;
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtpro.Text) && string.IsNullOrEmpty(txtpre.Text) && string.IsNullOrEmpty(txtcan.Text))
            {
                MessageBox.Show("Porfabor rellene los campos", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;

            }else
            {
                resta = resta + int.Parse(txtpre.Text);
                string fecha = DateTime.Today.ToString("yyyy-MM-dd");
                string agregar = "insert into compra values('0','" + txtpro.Text+ "','"+txtpre.Text+"','"+txtcan.Text+"','000compra','" + fecha + "','0')";
                abrir.executeMyQuery(agregar); 
                string dinero = "UPDATE Totalcaja SET Dinero= Dinero+" + (int.Parse(txtpre.Text))*-1 + "";
                abrir.executeMyQuery(dinero);
            
            }
        }

        private void compras_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(resta==0)
            {
                this.Hide();
            }
            else
            {
                string fecha = DateTime.Today.ToString("yyyy-MM-dd");
                string agregar = "insert into caja values('0','" + (resta)*-1 + "','Productos comprados','" + fecha + "','" + lblusuario.Text+ "')";
                abrir.executeMyQuery(agregar);
                this.Close();
            }
        }
    }
}

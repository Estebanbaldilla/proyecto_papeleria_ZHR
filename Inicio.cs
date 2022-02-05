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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
            
        }
        
       
       
        
       
    
        private void Inicio_Load(object sender, EventArgs e)
        {
            
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
            else if(check_tipo1.Checked==true)
            {
                tipo = 1;
            }
            MySqlConnection conectar = new MySqlConnection("server=localhost; database=prueba; uid=root; pwd=;");
            conectar.Open();
            MySqlCommand codigo = new MySqlCommand();
            MySqlConnection conectanos = new MySqlConnection();
            codigo.Connection = conectar;
            codigo.CommandText = ("select *from usuario where nombre_empleado='" + txtnombre.Text + "'and contraseña='" + txtcontra.Text + "'and tipo='" + tipo + "'");
            MySqlDataReader leer = codigo.ExecuteReader();
            if (leer.Read())
            {
                string usuario = txtnombre.Text;
               
                MessageBox.Show("BIENVENIDO " + txtnombre.Text);
                
                Infz_empleado abrir = new Infz_empleado(usuario);
                Infz_gerente dato = new Infz_gerente(usuario);
                administrador admin = new administrador(usuario);
                if (tipo == 2)
                {
                    dato.Show();
                    this.Hide();
                }
                else if(tipo==3)
                {
                    abrir.Show();
                    this.Hide();
                }else if (tipo==1)
                {
                    admin.Show();
                    this.Hide();
                }
                
            }
            else
            {
                MessageBox.Show("DATOS INCORRECTOS O FALTANTES","Atencion",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            conectar.Close();
           
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

        private void check_tipo1_CheckedChanged(object sender, EventArgs e)
        {
            check_tipo2.Checked = false;
            check_tipo3.Checked = false;
        }
        //metodo de llamada de empleado

    }
}

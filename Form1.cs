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
    public partial class Form1 : Form
    {
        
        public Form1(string usuario)
        {
            InitializeComponent();
            lblusuario.Text = usuario;
            //dgv

        }
       
        
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtproducto.Text)&& string.IsNullOrEmpty(txtcantidad.Text)&& string.IsNullOrEmpty(txtprecio.Text)&& string.IsNullOrEmpty(txtdesc.Text))
            {
                MessageBox.Show("RELLENE TODOS LOS CAMPOS","Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
                return;

            }else
            {
                string insertar = "insert into inventario values('0','" + txtproducto.Text + "','" + txtcodigo.Text + "','" + int.Parse(txtcantidad.Text) + "','" + int.Parse(txtprecio.Text) + "','" + txtdesc.Text + "','"+txtmarca.Text+"')";
                abrir.executeMyQuery(insertar);
                dgbinventario();
                txtcantidad.Clear();
                txtdesc.Clear();
                txtproducto.Clear();
                txtprecio.Clear();
                txtcodigo.Clear();
                txtmarca.Clear();
                MessageBox.Show("Producto registrado con exito", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }    
            
        }
        Venta venta = new Venta();
        conexion abrir = new conexion();
       
        
        private void Form1_Load(object sender, EventArgs e)
        {
            dgbinventario();//Ejecuta la visualizacion del inventario
        }
        
        public void dgbinventario()//Genera la visualizacion del inventario
        {
            string selectQuery = "select * from inventario";
            DataTable inventario = new DataTable();
            MySqlDataAdapter adaptar = new MySqlDataAdapter(selectQuery, abrir._conexion);
            adaptar.Fill(inventario);
            dgvinventario.DataSource = inventario;
        }
        
        private void lblusuario_Click(object sender, EventArgs e)
        {

        }

        private void btnsumar_Click(object sender, EventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string usuario = lblusuario.Text;
            Inventario abrir = new Inventario(usuario);
            abrir.Show();
            this.Close();
        }
    }
}

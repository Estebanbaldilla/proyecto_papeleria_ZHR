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
    public partial class Ventana_venta : Form
    {
        public Ventana_venta(string usuario)
        {
            InitializeComponent();
            lblusuario.Text = usuario;
            
            
        }
        conexion abrir = new conexion();
        int contador=0;
        public static string[] producto= new string[100];
        
        public static string[] precio = new string[100];
        public static string[] cantidad= new string[100];
        public static int suma;
   
        private void Ventana_venta_Load(object sender, EventArgs e)
        {
            dgbinventario();
           
        }
        public void dgbinventario()//Genera la visualizacion del inventario
        {
            string selectQuery = "select * from inventario";
            DataTable inventario = new DataTable();
            MySqlDataAdapter adaptar = new MySqlDataAdapter(selectQuery, abrir._conexion);
            adaptar.Fill(inventario);
            dgvinventario.DataSource = inventario;
        }
        public void dgbbusqueda()//Realiza la busqueda de un producto
        {
            string selectQuery = "select *from inventario where producto='" + txtnombre.Text + "';";
            DataTable inventario = new DataTable();
            MySqlDataAdapter adaptar = new MySqlDataAdapter(selectQuery, abrir._conexion);
            adaptar.Fill(inventario);
            dgvinventario.DataSource = inventario;
           
        }
        public void dgbventa()//Realiza la vista de los productos a vender
        {
            string selectQuery = "select *from productos_venta" ;
            DataTable productos_venta = new DataTable();
            MySqlDataAdapter adaptar = new MySqlDataAdapter(selectQuery, abrir._conexion);
            adaptar.Fill(productos_venta);
            dgventa.DataSource = productos_venta;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            string usuario = lblusuario.Text;
            Infz_empleado abrir = new Infz_empleado(usuario);
            abrir.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgbbusqueda();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dgbinventario();
        }

        private void dgvinventario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            producto[contador] = dgvinventario.Rows[e.RowIndex].Cells["producto"].Value.ToString();
            precio[contador] = dgvinventario.Rows[e.RowIndex].Cells["precio"].Value.ToString();
            txtnombre.Text = producto[contador];
        }
        //Borrar un areglo https://docs.microsoft.com/en-us/dotnet/api/system.array.clear?view=net-5.0

        private void button2_Click(object sender, EventArgs e)
        {
           
            if (producto== null)
            {
                MessageBox.Show("Porfavor selecciona una fila", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                cantidad[contador] = txtcan.Text;
                if (cantidad[contador] =="")
                {
                    MessageBox.Show("Porfavor inserte la cantidad", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {//Registra los productos para vender
                    int multiplicacion = (int.Parse(precio[contador]) * int.Parse(cantidad[contador]));
                    string precio_total = multiplicacion.ToString();
                    string agregar = "insert into productos_venta values('"+producto[contador]+"','"+float.Parse(precio[contador])+"','"+int.Parse(cantidad[contador])+"','"+int.Parse(precio_total)+"')";
                    abrir.executeMyQuery(agregar);
                    dgbventa();
                    suma = suma + int.Parse(precio_total);
                    lbltotal.Text = suma.ToString();
                    contador = contador + 1;

                    //Limpieza
                    txtcan.Clear();
                    txtnombre.Clear();
                }

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

            if ((seguro.Checked == true) )
            {
               
                //Procesos al vender
                //Primer proceso Caja
                string fecha = DateTime.Today.ToString("yyyy-MM-dd");
                string agregar = "insert into caja values('0','" + suma + "','Productos vendidos','" + fecha + "','" + lblusuario.Text + "')";
                abrir.executeMyQuery(agregar);
                string dinero = "UPDATE Totalcaja SET Dinero= Dinero+" + suma + "";
                abrir.executeMyQuery(dinero);


                //Segundo Proceso ventas
                for (int i = 0; i < contador; i++)
                {
                    string venta = "insert into venta values('0','" + int.Parse(cantidad[i]) + "','" + producto[i] + "','" + fecha + "')";
                    abrir.executeMyQuery(venta);
                }

                //Tercer Proceso Inventario
                for (int i = 0; i < contador; i++)
                {
                    string inventario = "UPDATE inventario SET cantidad= cantidad+" + int.Parse(cantidad[i]) * -1 + " WHERE producto='" + producto[i] + "'";

                    abrir.executeMyQuery(inventario);
                }
                
                //Borrado de ventas temp
                string borrar = "truncate table productos_venta;";
                abrir.executeMyQuery(borrar);
                MessageBox.Show("Compra Realizada");
                for (int i = 0; i <= contador; i++)
                {
                    producto[i] = "";
                    cantidad[i] = "";
                }
                suma = 0;
                lbltotal.Text = suma.ToString();
                contador = 0;
                dgbventa();
                dgbinventario();


            }
            else
            {
                MessageBox.Show("Porfavor marque la casilla si esta seguro");
            }
           
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string borrar = "truncate table productos_venta;";
            abrir.executeMyQuery(borrar);
            string usuario = lblusuario.Text;
            Infz_empleado empleado = new Infz_empleado(usuario);
            empleado.Show();
            this.Close();
            

        }

        private void button7_Click(object sender, EventArgs e)
        {
            

        }

        private void seguro_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            string borrar = "truncate table productos_venta;";
            abrir.executeMyQuery(borrar);
            for(int i=1;i<=contador;i++)
            {
                producto[i] ="0";
                cantidad[i] = "0";
                precio[i] = "0";
                suma = 0;
                lbltotal.Text = "9";
            }
            contador = 0;
            dgbventa();
        }
    }
}

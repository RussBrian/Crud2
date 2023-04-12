using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crud2
{
    public partial class Form1 : Form
    {
        CDatos datos= new CDatos();
        producto producto = new producto();
        private int id;
        
        private void cargarDatos()
        {
            var lst = datos.Read();
            dgvDatos.DataSource= lst;
        }
        public Form1()
        {
            InitializeComponent();
        }
       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargarDatos();
            
        }
        private void subirDatos()
        {
            producto.id= id;
            producto.fabricante= txtFabricante.Text;
            producto.serial= txtSerial.Text;
            producto.detalles= txtDetalles.Text;
            producto.nombre= txtNombre.Text;
            producto.modelo= txtModelo.Text;

            cargarDatos();
        }

        private void limpiar()
        {
            txtNombre.Focus();
            txtModelo.Text= string.Empty;
            txtDetalles.Text= string.Empty;
            txtSerial.Text= string.Empty;
            txtFabricante.Text= string.Empty;
        }
        private void accionCrear()
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            cargarDatos();
            subirDatos();
            MessageBox.Show("sa");
            datos.Crear(producto);
            limpiar();
           
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (id!=0)
            {
               cargarDatos
            }
        }
    }
}

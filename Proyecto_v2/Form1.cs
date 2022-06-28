using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using libreria_productos;

namespace Proyecto_v2
{
    public partial class FPrincipal : Form
    {
        #region Variables Globales
        Coleccion datos;
        #endregion

        #region Métodos Propios
        private void actualizarProveedores()
        {
            List<string> lista, listaNombres;
            listaNombres = datos.NombresProveedores();

            cbProveedores.Items.Clear();
            cbProveedores.Items.Add("Todos");
            foreach (string nombre in listaNombres)
                cbProveedores.Items.Add(nombre);
            cbProveedores.SelectedIndex = 0;

            if (rbTodosProv.Checked)
                lista = datos.ListarProveedores();
            else
                lista = datos.ListarProveedores(rbNacionales.Checked);

            lbProveedores.Items.Clear();
            foreach (string dato in lista)
                lbProveedores.Items.Add(dato);
        }

        private void actualizarProductos()
        {
            List<string> lista;
            string selecCategoria, selecTipo, selecProveedor;

            selecTipo = (rbTodosProd.Checked) ? rbTodosProd.Text : (rbInstrumentos.Checked) ? rbInstrumentos.Text : rbAccesorios.Text;
            selecCategoria = cbCategoria.Text.Trim().ToUpper();

            selecProveedor = cbProveedores.Text;

            lista = datos.ListarProductos(selecTipo,selecCategoria,selecProveedor);

            lbProductos.Items.Clear();
            foreach (string s in lista)
                lbProductos.Items.Add(s);
        }
        #endregion

        #region Eventos
        public FPrincipal()
        {
            InitializeComponent();
            datos = new Coleccion();
            dtInicio.MaxDate = DateTime.Today;
            dtFin.MaxDate = DateTime.Today;
            dtInicio.MinDate = DateTime.Today.AddYears(-10);
            dtFin.MinDate = DateTime.Today.AddYears(-10);
        }

        private void miAgregarProveedor_Click(object sender, EventArgs e)
        {
            FProveedor fCargarProveedor = new FProveedor(datos);
            fCargarProveedor.ShowDialog();
            if (fCargarProveedor.DialogResult == DialogResult.OK)
            {
                MessageBox.Show("Se agrego un nuevo proveedor","Info", MessageBoxButtons.OK,MessageBoxIcon.Information);
                actualizarProveedores();
            }
            else
                MessageBox.Show("Nuevo proveedor cancelado", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void miModificarProveedor_Click(object sender, EventArgs e)
        {
            string cuit_proveedor = "";
            FProveedor fCargarProveedor = new FProveedor(datos,cuit_proveedor);
            fCargarProveedor.ShowDialog();

            if (fCargarProveedor.DialogResult == DialogResult.OK)
            {
                MessageBox.Show("Se modificó el proveedor", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                actualizarProveedores();
            }
            else
                MessageBox.Show("Se canceló modificar proveedor", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void miEliminarProveedor_Click(object sender, EventArgs e)
        {
            string cuit_proveedor = "";
            DialogResult respuesta = MessageBox.Show("¿Está seguro que quiere eliminar el proveedor?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(respuesta == DialogResult.Yes)
            {
                datos.EliminarProveedor(cuit_proveedor);
                MessageBox.Show("Se eliminó el proveedor", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                actualizarProveedores();
                actualizarProductos();
            }
            else
                MessageBox.Show("Eliminar proveedor cancelado", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void miAgregarIntrumento_Click(object sender, EventArgs e)
        {

        }

        private void miModificarInstrumento_Click(object sender, EventArgs e)
        {

        }

        private void miEliminarInstrumento_Click(object sender, EventArgs e)
        {

        }

        private void miAgregarAccesorio_Click(object sender, EventArgs e)
        {

        }

        private void miModificarAccesorio_Click(object sender, EventArgs e)
        {

        }

        private void miEliminarAccesorio_Click(object sender, EventArgs e)
        {

        }

        private void msiAcercaDe_Click(object sender, EventArgs e)
        {

        }

        private void msiSalir_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Quiere salir del programa", "Confirmar Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
                Close();
        }
        #endregion

        private void dtFin_ValueChanged(object sender, EventArgs e)
        {
        }

        private void dtInicio_ValueChanged(object sender, EventArgs e)
        {
            dtFin.MinDate = dtInicio.Value;
        }

        private void rbTodosProv_CheckedChanged(object sender, EventArgs e)
        {
            actualizarProveedores();
        }

        private void rbExtranjeros_CheckedChanged(object sender, EventArgs e)
        {
            actualizarProveedores();
        }
    }
}

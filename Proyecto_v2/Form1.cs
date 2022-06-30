using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            
            listaNombres = (rbTodosProv.Checked) ? datos.NombresProveedores(): datos.NombresProveedores(rbNacionales.Checked);

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

            lCantProvLista.Text = "Cantidad de proveedores en la lista: " + lbProveedores.Items.Count;
            lTotalProveedores.Text = "Cantidad total de proveedores: " + datos.CantidadProveedores();
        }

        private void actualizarCategorias()
        {
            string tipo = (rbTodosProd.Checked) ? rbTodosProd.Text : (rbInstrumentos.Checked) ? rbInstrumentos.Text : rbAccesorios.Text;
            string origen = (rbTodosProv.Checked) ? rbTodosProv.Text : (rbNacionales.Checked) ? rbNacionales.Text : rbExtranjeros.Text;
            string cuit_proveedor = datos.ProveedorCuit(cbProveedores.Text);

            List<string> listaCategorias = datos.ProductoCategorias(tipo, origen, cuit_proveedor);
            
            cbCategoria.Items.Clear();
            cbCategoria.Items.Add("Todas");

            foreach (string categoria in listaCategorias)
                cbCategoria.Items.Add(categoria);

            cbCategoria.SelectedIndex = 0;

            actualizarProductos();
        }

        private void actualizarProductos()
        {
            List<string> lista;
            string selecCategoria, selecTipo, selecProveedor, selecOrigen;

            selecTipo = (rbTodosProd.Checked) ? rbTodosProd.Text : (rbInstrumentos.Checked) ? rbInstrumentos.Text : rbAccesorios.Text;
            selecCategoria = cbCategoria.Text.Trim();
            selecProveedor = datos.ProveedorCuit(cbProveedores.Text);
            selecOrigen = (rbTodosProv.Checked) ? rbTodosProv.Text : (rbExtranjeros.Checked) ? rbExtranjeros.Text : rbNacionales.Text;

            lista = datos.ListarProductos(selecTipo,selecCategoria,selecProveedor, selecOrigen, dtInicio.Value,dtFin.Value);

            lbProductos.Items.Clear();
            foreach (string item in lista)
                lbProductos.Items.Add(item);

            lCantProdLista.Text = "Cantidad de productos en la lista: " + lbProductos.Items.Count;
            lTotalProductos.Text = "Cantidad total de productos: " + datos.CantidadProductos();
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
            dtFin.MinDate = dtInicio.Value;

            cbProveedores.Items.Add("Todos");
            cbProveedores.SelectedIndex = 0;
        }

        private void rbTipo_Click(object sender, EventArgs e)
        {
            actualizarCategorias();
        }

        private void rbOrigen_Click(object sender, EventArgs e)
        {
            actualizarProveedores();
        }

        private void cbProveedores_SelectedIndexChanged(object sender, EventArgs e)
        {
            actualizarCategorias();
        }

        private void ActualizarListadoProductos(object sender, EventArgs e)
        {
            actualizarProductos();
        }

        private void chOrdenarProd_CheckedChanged(object sender, EventArgs e)
        {
            lbProductos.Sorted = chOrdenarProd.Checked;
            actualizarProductos();
        }

        private void chOrdenarProv_CheckedChanged(object sender, EventArgs e)
        {
            lbProveedores.Sorted = chOrdenarProv.Checked;
            actualizarProveedores();
        }

        private void dtInicio_ValueChanged(object sender, EventArgs e)
        {
            actualizarProductos();
            dtFin.MinDate = dtInicio.Value;
        }

        private void lbProveedores_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbProveedores.SelectedIndex != -1)
            {
                string cuit = lbProveedores.Text.Split()[0];
                string nombre_proveedor = datos.ProveedorRazonSocial(cuit);

                if (cbProveedores.Items.Contains(nombre_proveedor))
                    cbProveedores.SelectedIndex = cbProveedores.Items.IndexOf(nombre_proveedor);
                else
                    cbProveedores.SelectedIndex = 0;
            }
        }

        private void miAgregarProveedor_Click(object sender, EventArgs e)
        {
            FProveedor fCargarProveedor = new FProveedor(datos);
            fCargarProveedor.ShowDialog();
            if (fCargarProveedor.DialogResult == DialogResult.OK)
            {
                actualizarProveedores();

                if (datos.CantidadProveedores() > 0)
                {
                    miModificarProveedor.Enabled = true;
                    miEliminarProveedor.Enabled = true;
                    miAgregarProd.Enabled = true;

                    if (datos.CantidadProductos() > 0)
                        miModificarProd.Enabled = true;
                }

                MessageBox.Show("Se agrego un nuevo proveedor","Info", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Nuevo proveedor cancelado", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void miModificarProveedor_Click(object sender, EventArgs e)
        {
            if (lbProveedores.SelectedIndex != -1)
            {
                string cuit_proveedor = lbProveedores.Text.Split()[0];

                FProveedor fCargarProveedor = new FProveedor(datos, cuit_proveedor);
                fCargarProveedor.ShowDialog();

                if (fCargarProveedor.DialogResult == DialogResult.OK)
                {
                    actualizarProveedores();
                    
                    MessageBox.Show("Se modificó el proveedor", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Se canceló modificar proveedor", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Debe seleccionar un proveedor de la lista","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        private void miEliminarProveedor_Click(object sender, EventArgs e)
        {
            if(lbProveedores.SelectedIndex != -1)
            {
                bool eliminacionExitosa = false;
                string cuit_proveedor = lbProveedores.Text.Split()[0];

                DialogResult respuesta = MessageBox.Show("¿Está seguro que quiere eliminar el proveedor?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if(respuesta == DialogResult.Yes)
                {
                    
                    eliminacionExitosa = datos.EliminarProveedor(cuit_proveedor);

                    if (eliminacionExitosa)
                    {
                        actualizarProveedores();
                        actualizarProductos();

                        if (datos.CantidadProveedores() == 0)
                        {
                            miModificarProveedor.Enabled = false;
                            miEliminarProveedor.Enabled = false;
                            miAgregarProd.Enabled = false;
                            miModificarProd.Enabled = false;
                        }

                        MessageBox.Show("Se eliminó el proveedor", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("No se pudo eliminar al proveedor, porque tiene productos asociados.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                    MessageBox.Show("Eliminar proveedor cancelado", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Debe seleccionar un proveedor de la lista", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void miAgregarProd_Click(object sender, EventArgs e)
        {
            FProducto fCargarProducto = new FProducto(datos);
            fCargarProducto.ShowDialog();
            if (fCargarProducto.DialogResult == DialogResult.OK)
            {
                actualizarCategorias();

                if (datos.CantidadProductos() == 1)
                {
                    miModificarProd.Enabled = true;
                    miEliminarProd.Enabled = true;
                }

                MessageBox.Show("Se agrego un nuevo producto", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Nuevo producto cancelado", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void miModificarProd_Click(object sender, EventArgs e)
        {
            if (lbProductos.SelectedIndex != -1)
            {
                int codigo = Convert.ToInt32(lbProductos.Text.Split()[0]);
                FProducto fCargarProducto = new FProducto(datos, codigo);
                fCargarProducto.ShowDialog();
                if (fCargarProducto.DialogResult == DialogResult.OK)
                {
                    actualizarCategorias();

                    MessageBox.Show("Se modifico el producto", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Modificar producto cancelado", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Debe seleccionar un producto de la lista", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void miEliminarProd_Click(object sender, EventArgs e)
        {
            if (lbProductos.SelectedIndex != -1)
            {
                int codigo = Convert.ToInt32(lbProductos.Text.Split()[0]);

                DialogResult respuesta = MessageBox.Show("¿Está seguro que quiere eliminar el producto?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    datos.EliminarProducto(codigo);

                    actualizarProveedores();
                    actualizarProductos();

                    if (datos.CantidadProductos() == 0)
                    {
                        miModificarProd.Enabled = false;
                        miEliminarProd.Enabled = false;
                    }

                    MessageBox.Show("Se eliminó el producto", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Eliminar producto cancelado", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Debe seleccionar un producto de la lista", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void msiAcercaDe_Click(object sender, EventArgs e)
        {
            string mensaje = "Integrantes del grupo:\n\n  > Rossi, Fiorella\n  > Sanhueza, Eduardo";
            MessageBox.Show(mensaje,"", MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void msiSalir_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Quiere salir del programa", "Confirmar Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
                Close();
        }
        #endregion
    }
}
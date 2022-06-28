﻿using System;
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
    public partial class FProducto : Form
    {
        Coleccion datos;
        bool agregarProducto;
        int codigo;

        public FProducto(Coleccion conexion)
        {
            InitializeComponent();
            datos = conexion;
            agregarProducto = true;
            codigo = 0;
        }

        public FProducto(Coleccion conexion, int codigo)
        {
            InitializeComponent();
            datos = conexion;
            agregarProducto = false;
            this.codigo = codigo;
        }

        private void FProducto_Load(object sender, EventArgs e)
        {
            List<string> lista = datos.ListarProveedores();
            cbProveedor.Items.Clear();
            foreach (string item in lista)
                cbProveedor.Items.Add(item);
            if (cbProveedor.Items.Count > 0)
                cbProveedor.SelectedIndex = 0;

            if (agregarProducto)
            {
                Text = "Agregar Nuevo Producto";
                mtCodigo.Clear();

                mtCodigo.Enabled = true;
                gbTipo.Enabled = true;
                rbInstrumento.Checked = true;

                tNombre.Clear();
                cbCategoria.Text = "";
                mtPrecio.Clear();
                dtFecha.Value = DateTime.Today;
                cbProveedor.Text = "";
            }
            else
            {
                Text = "Modificar Producto";
                mtCodigo.Text = codigo.ToString("0000");

                mtCodigo.Enabled = false;
                gbTipo.Enabled = false;

                rbInstrumento.Checked = datos.ExisteInstrumento(codigo);
                tNombre.Text = datos.ProductoNombre(codigo);
                cbCategoria.Text = datos.ProductoCategoria(codigo);
                mtPrecio.Text = datos.ProductoPrecio(codigo).ToString("F2");
                dtFecha.Value = datos.ProductoFecha(codigo);
                cbProveedor.Text = datos.ProductoNombre(codigo);
            }
        }

        private void bAceptar_Click(object sender, EventArgs e)
        {
            int nuevoCodigo = (mtCodigo.MaskFull) ? Convert.ToInt32(mtCodigo.Text) : 0;
            string nuevoNombre = tNombre.Text.Trim();
            string nuevaCategoria = cbCategoria.Text.Trim();
            double nuevoPrecio = (mtPrecio.MaskFull) ? Convert.ToDouble(mtPrecio.Text) : 0;
            DateTime nuevaFecha = dtFecha.Value;
            string nuevoProveedor = cbProveedor.Text;

            if (!mtCodigo.MaskFull)
            {
                MessageBox.Show("Ingresar un número de código", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mtCodigo.Focus();
            }
            else if (nuevoPrecio == 0)
            {
                MessageBox.Show("Debe ingresar un valor en precio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mtPrecio.Focus();
            }
            else if (nuevoProveedor == "")
            {
                MessageBox.Show("Debe seleccionar un proveedor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbProveedor.Focus();
            }
            else if (agregarProducto)
            {
                if (datos.ExisteAccesorio(nuevoCodigo) || datos.ExisteInstrumento(nuevoCodigo))
                {
                    MessageBox.Show("Ya existe un producto con el código ingresado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    mtCodigo.Focus();
                }
                else
                {
                    string cuit_proveedor = nuevoProveedor.Split()[0];

                    if (rbAccesorio.Checked)
                        datos.InsertarAccesorio(nuevoCodigo, nuevoNombre, nuevaCategoria, nuevoPrecio, nuevaFecha, cuit_proveedor);
                    else
                        datos.InsertarInstrumento(nuevoCodigo, nuevoNombre, nuevaCategoria, nuevoPrecio, nuevaFecha, cuit_proveedor);

                    DialogResult = DialogResult.OK;
                }
            }
            else
            {
                string cuit_proveedor = nuevoProveedor.Split()[0];

                if (rbAccesorio.Checked)
                    datos.ModificarAccesorio(nuevoCodigo, nuevoNombre, nuevaCategoria, nuevoPrecio, nuevaFecha, cuit_proveedor);
                else
                    datos.ModificarInstrumento(nuevoCodigo, nuevoNombre, nuevaCategoria, nuevoPrecio, nuevaFecha, cuit_proveedor);

                DialogResult = DialogResult.OK;
            }
        }

        private void mtCodigo_Validating(object sender, CancelEventArgs e)
        {
            epCodigo.Clear();
            if (!mtCodigo.MaskFull)
                epCodigo.SetError(mtCodigo,"Ingresar código");
        }

        private void tNombre_Validating(object sender, CancelEventArgs e)
        {
            epNombre.Clear();
            if (tNombre.Text.Trim() == "")
                epNombre.SetError(tNombre,"Ingresar nombre");
        }

        private void mtPrecio_Validating(object sender, CancelEventArgs e)
        {
            epPrecio.Clear();
            if (mtPrecio.Text.Trim() == ".")
                epPrecio.SetError(mtPrecio, "Ingresar precio");
        }

        private void cbProveedor_Validating(object sender, CancelEventArgs e)
        {
            epProveedor.Clear();
            if (cbProveedor.Text.Trim() == "")
                epProveedor.SetError(cbProveedor, "Ingresar Proveedor");
        }
    }
}

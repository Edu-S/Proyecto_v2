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
    public partial class FProveedor : Form
    {
        #region Variables
        Coleccion datos;
        bool agregaProveedor;
        string cuit_actual;
        #endregion
        
        #region Métodos Propios
        private int ObtenerCodigoVerificador(string cuit)
        {
            int nro_actual, codigo, resto, suma = 0;

            for(int indice = 0; indice <= 9; indice++)
            {
                codigo = (9 - indice) % 6 + 2;
                nro_actual = Convert.ToInt32(cuit.Substring(indice, 1));

                suma += codigo * nro_actual;
            }

            resto = suma % 11;
            return (resto == 0) ? 0 : (resto == 1) ? 9 : 11 - resto;
        }

        private bool esCuitValido(string cuit)
        {
            int codigo = Convert.ToInt32(cuit.Substring(10, 1));
            return tipoCuitValido(cuit) && ObtenerCodigoVerificador(cuit) == codigo;
        }

        private bool tipoCuitValido(string cuit)
        {
            bool esValido = false;
            int tipo = Convert.ToInt32(cuit.Substring(0, 2));

            switch (tipo)
            {
                case 20: case 23: case 24:
                case 25: case 26: case 27:
                case 30: case 33: case 34:
                    esValido = true;
                    break;
            }
            return esValido;
        }
        #endregion

        #region Eventos
        public FProveedor(Coleccion conexion)
        {
            InitializeComponent();
            datos = conexion;
            agregaProveedor = true;
            cuit_actual = "";
        }

        public FProveedor(Coleccion conexion, string cuit)
        {
            InitializeComponent();
            datos = conexion;
            agregaProveedor = false;
            cuit_actual = cuit;
        }

        private void FProveedor_Load(object sender, EventArgs e)
        {
            if (agregaProveedor)
            {
                Text = "Agregar Nuevo Proveedor";
                bAceptar.Text = "&Agregar";
                mtCuit.Text = "";
                tRazonSocial.Text = "";
                chNacional.Checked = true;
                mtCuit.Enabled = true;
            }
            else
            {
                Text = "Modificar Proveedor";
                bAceptar.Text = "&Modificar";
                mtCuit.Text = cuit_actual;
                mtCuit.Enabled = false;
                tRazonSocial.Text = datos.ProveedorRazonSocial(cuit_actual);
                chNacional.Checked = datos.ProveedorEsNacional(cuit_actual);
            }
        }

        private void mtCuit_Validating(object sender, CancelEventArgs e)
        {
            epCUIT.Clear();
            if (!mtCuit.MaskFull)
                epCUIT.SetError(mtCuit, "CUIT incompleto");
            else if (!tipoCuitValido(mtCuit.Text))
                epCUIT.SetError(mtCuit, "Tipo de CUIT no válido");
            else if (!esCuitValido(mtCuit.Text))
                epCUIT.SetError(mtCuit, "CUIT no válido [ Código: " + ObtenerCodigoVerificador(mtCuit.Text) + " ]");
        }

        private void tRazonSocial_Validating(object sender, CancelEventArgs e)
        {
            epRazon.Clear();
            if (tRazonSocial.Text.Trim() == "")
                epRazon.SetError(tRazonSocial, "Ingresar una razón social");
        }

        private void bAceptar_Click(object sender, EventArgs e)
        {
            string nuevoCuit = (mtCuit.MaskFull) ? mtCuit.Text : "";
            string nuevaRazon = tRazonSocial.Text.Trim();
            bool nuevoNacional = chNacional.Checked;

            if (!mtCuit.MaskFull)
            {
                MessageBox.Show("Falta completar CUIT.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mtCuit.Focus();
            }
            else if (!tipoCuitValido(nuevoCuit))
            {
                MessageBox.Show("El tipo de CUIT no válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mtCuit.Focus();
            }
            else if (!esCuitValido(nuevoCuit))
            {
                MessageBox.Show("El CUIT ingresado no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mtCuit.Focus();
            }
            else if (nuevaRazon == "")
            {
                MessageBox.Show("Falta ingresar la razón social.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tRazonSocial.Focus();
            }
            else if (agregaProveedor)
            {
                if (datos.ExisteCuitProveedor(nuevoCuit))
                {
                    MessageBox.Show("El CUIT ingresado ya existe. Ingrese otro proveedor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    mtCuit.Focus();
                }
                else if (datos.ExisteRazonProveedor(nuevaRazon))
                {
                    MessageBox.Show("La razón social ya existe. Ingrese otro proveedor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tRazonSocial.Focus();
                }
                else
                {
                    datos.InsertarProveedor(nuevoCuit, nuevaRazon, nuevoNacional);
                    DialogResult = DialogResult.OK;
                }
            }
            else
            {
                string anteriorRazon = datos.ProveedorRazonSocial(cuit_actual);
                if (anteriorRazon != nuevaRazon && datos.ExisteRazonProveedor(nuevaRazon))
                {
                    MessageBox.Show("Ya existe la razón social. Ingrese otro proveedor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tRazonSocial.Focus();
                }
                else
                {
                    datos.ModificarProveedor(cuit_actual, nuevaRazon, nuevoNacional);
                    DialogResult = DialogResult.OK;
                }
            }
        }
        #endregion
    }
}

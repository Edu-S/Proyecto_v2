using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using libreria_productos;

namespace Proyecto_v2
{
    public class Coleccion
    {
        #region Variables
        List<Producto> listaProductos;
        List<Proveedor> listaProveedores;
        #endregion

        #region Consultas Productos
        public int CantidadProductos()
        {
            return listaProductos.Count;
        }

        public bool ExisteInstrumento(int codigo)
        {
            Instrumento instrumento = new Instrumento(codigo);
            return listaProductos.Contains(instrumento);
        }

        public bool ExisteAccesorio(int codigo)
        {
            Accesorio accesorio = new Accesorio(codigo);
            return listaProductos.Contains(accesorio);
        }

        public List<string> ListarProductos(string tipo, string categoria, string cuit_proveedor)
        {
            List<string> listado = new List<string>();
            bool filtroTipoOk, filtroCatOk, filtroProvOk;
            foreach(Producto producto in listaProductos)
            {
                filtroTipoOk = false;
                filtroCatOk = false;
                filtroProvOk = false;

                // Filtra tipo
                switch (tipo)
                {
                    case "Todos":
                        filtroTipoOk = true;
                        break;
                    case "Instrumentos":
                        filtroTipoOk = (producto.GetType() == typeof(Instrumento));
                        break;
                    case "Accesorios":
                        filtroTipoOk = (producto.GetType() == typeof(Accesorio));
                        break;
                }

                // Filtra Categoria
                if (categoria == "" || categoria == "Todas")
                    filtroCatOk = true;
                else
                    filtroCatOk = producto.categoria == categoria;

                // filtra Proveedor
                if (cuit_proveedor == "")
                    filtroProvOk = true;
                else
                {
                    Proveedor proveedor = new Proveedor(cuit_proveedor);
                    filtroProvOk = producto.proveedor.Equals(proveedor);
                }

                if (filtroTipoOk && filtroCatOk && filtroProvOk)
                    listado.Add(producto.ToString());
            }

            return listado;
        }
        #endregion

        #region Consultas Proveedores
        public int CantidadProveedores()
        {
            return listaProveedores.Count;
        }

        public bool ExisteCuitProveedor(string cuit)
        {
            Proveedor proveedor = new Proveedor(cuit);
            return listaProveedores.Contains(proveedor);
        }

        public bool ExisteRazonProveedor(string razonSocial)
        {
            List<string> nombres = NombresProveedores();
            return nombres.Contains(razonSocial);
        }

        public List<string> ListarProveedores()
        {
            List<string> lista = new List<string>();
            foreach (Proveedor proveedor in listaProveedores)
                lista.Add(proveedor.ToString());
            return lista;
        }

        public List<string> ListarProveedores(bool es_nacional)
        {
            List<string> lista = new List<string>();
            foreach (Proveedor proveedor in listaProveedores)
            {
                if (proveedor.es_nacional == es_nacional)
                    lista.Add(proveedor.ToString());
            }
            return lista;
        }

        public List<string> NombresProveedores()
        {
            List<string> nombres = new List<string>();
            foreach (Proveedor proveedor in listaProveedores)
                nombres.Add(proveedor.razon_social);
            return nombres;
        }

        public string ProveedorCuit(string razonSocial)
        {
            List<string> nombres = NombresProveedores();
            int posicion = nombres.IndexOf(razonSocial);
            string cuit = "";

            if (posicion != -1)
                cuit = listaProveedores.ElementAt(posicion).cuit;

            return cuit;
        }

        public string ProveedorRazonSocial(string cuit)
        {
            Proveedor proveedor = new Proveedor(cuit);
            int posicion = listaProveedores.IndexOf(proveedor);
            if (posicion >= 0)
                proveedor = listaProveedores.ElementAt(posicion);
            return proveedor.razon_social;
        }

        public bool ProveedorEsNacional(string cuit)
        {
            Proveedor proveedor = new Proveedor(cuit);
            int posicion = listaProveedores.IndexOf(proveedor);
            if (posicion >= 0)
                proveedor = listaProveedores.ElementAt(posicion);
            return proveedor.es_nacional;
        }
        #endregion

        #region Comandos Productos
        public void InsertarInstrumento(int codigo,string nombre, string categoria, double precio_compra, DateTime fecha_compra, Proveedor proveedor)
        {
            Instrumento instrumento = new Instrumento(codigo, nombre, categoria, precio_compra, fecha_compra, proveedor);
            if (!listaProductos.Contains(instrumento))
                listaProductos.Add(instrumento);
        }

        public void ModificarInstrumento(int codigo, string nombre, string categoria, double precio_compra, DateTime fecha_compra, Proveedor proveedor)
        {
            Instrumento instrumento = new Instrumento(codigo, nombre, categoria, precio_compra, fecha_compra, proveedor);
            int posicion = listaProductos.IndexOf(instrumento);
            if (posicion >= 0)
            {
                listaProductos.RemoveAt(posicion);
                listaProductos.Insert(posicion, instrumento);
            }
        }

        public void EliminarInstrumento(int codigo)
        {
            Instrumento instrumento = new Instrumento(codigo);
            int posicion = listaProductos.IndexOf(instrumento);
            if (posicion >= 0)
                listaProductos.RemoveAt(posicion);
        }

        public void InsertarAccesorio(int codigo, string nombre, string categoria, double precio_compra, DateTime fecha_compra, Proveedor proveedor)
        {
            Accesorio accesorio = new Accesorio(codigo, nombre, categoria, precio_compra, fecha_compra, proveedor);
            if (!listaProductos.Contains(accesorio))
                listaProductos.Add(accesorio);
        }

        public void ModificarAccesorio(int codigo, string nombre, string categoria, double precio_compra, DateTime fecha_compra, Proveedor proveedor)
        {
            Accesorio accesorio = new Accesorio(codigo, nombre, categoria, precio_compra, fecha_compra, proveedor);
            int posicion = listaProductos.IndexOf(accesorio);
            if (posicion >= 0)
            {
                listaProductos.RemoveAt(posicion);
                listaProductos.Insert(posicion, accesorio);
            }
        }

        public void EliminarAccesorio(int codigo)
        {
            Accesorio accesorio = new Accesorio(codigo);
            int posicion = listaProductos.IndexOf(accesorio);
            if (posicion >= 0)
                listaProductos.RemoveAt(posicion);
        }
        #endregion

        #region Comandos Proveedores
        public void InsertarProveedor(string cuit, string razon_social, bool es_nacional)
        {
            Proveedor proveedor = new Proveedor(cuit, razon_social, es_nacional);
            if (!listaProveedores.Contains(proveedor))
                listaProveedores.Add(proveedor);
        }

        public void ModificarProveedor(string cuit, string razon_social, bool es_nacional)
        {
            Proveedor proveedor = new Proveedor(cuit, razon_social, es_nacional);
            int posicion = listaProveedores.IndexOf(proveedor);

            if (posicion >= 0)
            {
                listaProveedores.RemoveAt(posicion);
                listaProveedores.Insert(posicion, proveedor);
            }
        }

        public void EliminarProveedor(string cuit_proveedor)
        {
            Proveedor proveedor = new Proveedor(cuit_proveedor);
            int posicion = listaProveedores.IndexOf(proveedor);
            if (posicion >= 0)
                listaProveedores.RemoveAt(posicion);
        }
        #endregion

        #region Constructores
        public Coleccion()
        {
            listaProductos = new List<Producto>();
            listaProveedores = new List<Proveedor>();
        }
        #endregion
    }
}
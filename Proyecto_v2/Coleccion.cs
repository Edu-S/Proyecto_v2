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

        public List<string> ProductoCategorias(string tipoSeleccion)
        {
            List<string> categorias = new List<string>();
            string categoria;

            switch (tipoSeleccion)
            {
                case "Todos":
                    foreach(Producto producto in listaProductos)
                    {
                        categoria = producto.categoria;
                        if (!categorias.Contains(categoria))
                            categorias.Add(categoria);
                    }
                    break;
                case "Instrumentos":
                    foreach (Producto producto in listaProductos)
                    {
                        if(producto.GetType() == typeof(Instrumento))
                        {
                            categoria = producto.categoria;
                            if (!categorias.Contains(categoria))
                                categorias.Add(categoria);
                        }
                    }
                    break;
                case "Accesorios":
                    foreach (Producto producto in listaProductos)
                    {
                        if (producto.GetType() == typeof(Accesorio))
                        {
                            categoria = producto.categoria;
                            if (!categorias.Contains(categoria))
                                categorias.Add(categoria);
                        }
                    }
                    break;
            }

            return categorias;
        }

        public string ProductoNombre(int codigo)
        {
            Producto producto;
            string nombre = "";
            int posicion;

            if (ExisteAccesorio(codigo))
            {
                producto = new Accesorio(codigo);
                posicion = listaProductos.IndexOf(producto);
            }
            else
            {
                producto = new Instrumento(codigo);
                posicion = listaProductos.IndexOf(producto);
            }

            if (posicion != -1)
                nombre = listaProductos.ElementAt(posicion).nombre;

            return nombre;
        }

        public string ProductoCategoria(int codigo)
        {
            Producto producto;
            int posicion;
            string categoria = "";

            if (ExisteAccesorio(codigo))
            {
                producto = new Accesorio(codigo);
                posicion = listaProductos.IndexOf(producto);
            }
            else
            {
                producto = new Instrumento(codigo);
                posicion = listaProductos.IndexOf(producto);
            }

            if (posicion != -1)
                categoria = listaProductos.ElementAt(posicion).categoria;

            return categoria;
        }

        public double ProductoPrecio(int codigo)
        {
            Producto producto;
            int posicion;
            double precio = 0;

            if (ExisteAccesorio(codigo))
            {
                producto = new Accesorio(codigo);
                posicion = listaProductos.IndexOf(producto);
            }
            else
            {
                producto = new Instrumento(codigo);
                posicion = listaProductos.IndexOf(producto);
            }

            if (posicion != -1)
                precio = listaProductos.ElementAt(posicion).precio_compra;

            return precio;
        }

        public DateTime ProductoFecha(int codigo)
        {
            Producto producto;
            int posicion;
            DateTime fecha = DateTime.Today;

            if (ExisteAccesorio(codigo))
            {
                producto = new Accesorio(codigo);
                posicion = listaProductos.IndexOf(producto);
            }
            else
            {
                producto = new Instrumento(codigo);
                posicion = listaProductos.IndexOf(producto);
            }

            if (posicion != -1)
                fecha = listaProductos.ElementAt(posicion).fecha_compra;

            return fecha;
        }

        public string ProductoProveedor(int codigo)
        {
            Producto producto;
            int posicion;
            string nombre_proveedor = "";

            if (ExisteAccesorio(codigo))
            {
                producto = new Accesorio(codigo);
                posicion = listaProductos.IndexOf(producto);
            }
            else
            {
                producto = new Instrumento(codigo);
                posicion = listaProductos.IndexOf(producto);
            }

            if (posicion != -1)
                nombre_proveedor = listaProductos.ElementAt(posicion).proveedor.razon_social;

            return nombre_proveedor;
        }

        public bool ExisteInstrumento(int codigo)
        {
            Producto instrumento = new Instrumento(codigo);
            return listaProductos.Contains(instrumento);
        }

        public bool ExisteAccesorio(int codigo)
        {
            Producto accesorio = new Accesorio(codigo);
            return listaProductos.Contains(accesorio);
        }

        public List<string> ListarProductos(string tipo, string categoria, string cuit_proveedor, DateTime fecha_inicio, DateTime fecha_final)
        {
            List<string> listado = new List<string>();
            bool filtroTipoOk, filtroCatOk, filtroProvOk, filtroFechaOk;
            foreach(Producto producto in listaProductos)
            {
                filtroTipoOk = false;
                filtroCatOk = false;
                filtroProvOk = false;
                filtroFechaOk = false;

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
                if (cuit_proveedor == "" || cuit_proveedor == "Todos")
                    filtroProvOk = true;
                else
                {
                    Proveedor proveedor = new Proveedor(cuit_proveedor);
                    filtroProvOk = producto.proveedor.Equals(proveedor);
                }

                filtroFechaOk = producto.fecha_compra.Date >= fecha_inicio.Date && producto.fecha_compra.Date <= fecha_final.Date;

                if (filtroTipoOk && filtroCatOk && filtroProvOk && filtroFechaOk)
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
        public void InsertarInstrumento(int codigo,string nombre, string categoria, double precio_compra, DateTime fecha_compra, string cuit_proveedor)
        {
            Proveedor proveedor = new Proveedor(cuit_proveedor);
            int posicion = listaProveedores.IndexOf(proveedor);
            if (posicion >= 0)
            {
                Instrumento instrumento = new Instrumento(codigo, nombre, categoria, precio_compra, fecha_compra, listaProveedores.ElementAt(posicion));
                if (!listaProductos.Contains(instrumento))
                    listaProductos.Add(instrumento);
            }
        }

        public void ModificarInstrumento(int codigo, string nombre, string categoria, double precio_compra, DateTime fecha_compra, string  cuit_proveedor)
        {
            Proveedor proveedor = new Proveedor(cuit_proveedor);
            int posicion = listaProveedores.IndexOf(proveedor);
            
            if (posicion >= 0)
            {
                Instrumento instrumento = new Instrumento(codigo, nombre, categoria, precio_compra, fecha_compra, listaProveedores.ElementAt(posicion));
                posicion = listaProductos.IndexOf(instrumento);
                
                if (posicion >= 0)
                {
                    listaProductos.RemoveAt(posicion);
                    listaProductos.Insert(posicion, instrumento);
                }
            }
        }

        public void EliminarInstrumento(int codigo)
        {
            Instrumento instrumento = new Instrumento(codigo);
            int posicion = listaProductos.IndexOf(instrumento);
            if (posicion >= 0)
                listaProductos.RemoveAt(posicion);
        }

        public void InsertarAccesorio(int codigo, string nombre, string categoria, double precio_compra, DateTime fecha_compra, string cuit_proveedor)
        {
            Proveedor proveedor = new Proveedor(cuit_proveedor);
            int posicion = listaProveedores.IndexOf(proveedor);
            if (posicion >= 0)
            {
                Accesorio accesorio = new Accesorio(codigo, nombre, categoria, precio_compra, fecha_compra, listaProveedores.ElementAt(posicion));
                if (!listaProductos.Contains(accesorio))
                    listaProductos.Add(accesorio);
            }
        }

        public void ModificarAccesorio(int codigo, string nombre, string categoria, double precio_compra, DateTime fecha_compra, string cuit_proveedor)
        {
            Proveedor proveedor = new Proveedor(cuit_proveedor);
            int posicion = listaProveedores.IndexOf(proveedor);

            if (posicion >= 0)
            {
                Accesorio accesorio = new Accesorio(codigo, nombre, categoria, precio_compra, fecha_compra, listaProveedores.ElementAt(posicion));
                posicion = listaProductos.IndexOf(accesorio);
                if (posicion >= 0)
                {
                    listaProductos.RemoveAt(posicion);
                    listaProductos.Insert(posicion, accesorio);
                }
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
            {
                //// Elimina todos los productos con el proveedor a eliminar
                //List<Producto> lista = new List<Producto>();
                //foreach (Producto prod in listaProductos)
                //    if (prod.proveedor.Equals(proveedor))
                //        lista.Add(prod);
                //foreach (Producto prod in lista)
                //    listaProductos.Remove(prod);

                foreach (Producto prod in listaProductos)
                    if (prod.proveedor.Equals(proveedor))
                        prod.proveedor = new Proveedor();

                listaProveedores.RemoveAt(posicion);
            }
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
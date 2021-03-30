using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso
{
    public class Estante
    {
        private Producto[] productos;
        private int ubicacionEstante;

        private Estante(int capacidad)
        {
            this.productos = new Producto[capacidad];
        }

        public Estante(int capacidad, int ubicacion)
            : this(capacidad)
        {
            this.ubicacionEstante = ubicacion;
        }

        public Producto[] GetProductos()
        {
            return this.productos;
        }

        public static string MostrarEstante(Estante e)
        {
            StringBuilder auxRetorno = new StringBuilder();

            auxRetorno.AppendLine($"Mi estante || Ubicacion {e.ubicacionEstante} || Capacidad {e.productos.Length}\n");
            foreach(Producto producto in e.GetProductos())
            {
                
                    auxRetorno.AppendLine($"{Producto.MostrarProducto(producto)}");
               
            }
            return auxRetorno.ToString();
        }

        public static bool operator ==(Estante e, Producto p)
        {
            bool auxRetorno = false;

            for(int i = 0; i<e.GetProductos().Length; i++)
            {
                if(p == e.productos[i])
                {
                    auxRetorno = true;
                }
            }

            return auxRetorno;
        }

        public static bool operator !=(Estante e, Producto p)
        {
            return !(e == p);
        }

        public static bool operator +(Estante e, Producto p)
        {
            bool auxRetorno = false;

            for(int i = 0; i<e.GetProductos().Length; i++)
            {
                if ((e.productos[i] is null) && (e != p))
                {
                    e.productos[i] = p;
                    auxRetorno = true;
                }
            }
           
            return auxRetorno;
        }

        public static Estante operator -(Estante e, Producto p)
        {
            for(int i=0; i<e.productos.Length; i++)
            {
                if(p == e.productos[i])
                {
                    e.productos[i] = null;
                }
            }

            return e;
        }
    }
}

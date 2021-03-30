using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso
{
    public class Producto
    {
        private string codigoDeBarra;
        private string marca;
        private float precio;

        public Producto(string marca, string codigoDeBarra, float precio)
        {
            this.codigoDeBarra = codigoDeBarra;
            this.marca = marca;
            this.precio = precio;
        }

        public string GetMarca()
        {
            return this.marca;
        }

        public float GetPrecio()
        {
            return this.precio;
        }

        public static string MostrarProducto(Producto p)
        {
            StringBuilder auxRetorno = new StringBuilder();

            auxRetorno.AppendLine($"CODIGO DE BARRA: {p.codigoDeBarra}");
            auxRetorno.AppendLine($"MARCA: {p.GetMarca()}");
            auxRetorno.AppendLine($"PRECIO: $ {p.GetPrecio()}");

            return auxRetorno.ToString();
        }

        public static explicit operator string(Producto p)
        {
            string auxRetorno;

            auxRetorno = p.codigoDeBarra;

            return auxRetorno;
        }

        public static bool operator ==(Producto p1, Producto p2)
        {
            bool auxRetorno = false;

            if(!(p1 is null) && !(p2 is null))
            {
                if ((p1.codigoDeBarra == p2.codigoDeBarra) && (p1.marca == p2.marca))
                {
                    auxRetorno = true;
                }
            }

            return auxRetorno;
        }

        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1 == p2);
        }

        public static bool operator ==(Producto p1, string marca)
        {
            bool auxRetorno = false;

            if(p1.GetMarca() == marca)
            {
                auxRetorno = true;
            }

            return auxRetorno;
        }

        public static bool operator !=(Producto p1, string marca)
        {
            return !(p1 == marca);
        }
    }
}

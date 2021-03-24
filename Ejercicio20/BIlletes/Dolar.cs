using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIlletes
{
    public class Dolar
    {
        private double cantidad;
        private static double cotizRespectoDolar;

        static Dolar()
        {
            cotizRespectoDolar = 1;
        }

        public Dolar(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Dolar(double cantidad, double cotizacion)
            : this(cantidad)
        {
            cotizRespectoDolar = cotizacion;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static double GetCotizacion()
        {
            return cotizRespectoDolar;
        }

        public static explicit operator Euro(Dolar d)
        {
            return new Euro((d.cantidad * Euro.GetCotizacion()));
        }

        public static explicit operator Pesos(Dolar d)
        {
            return new Pesos((d.cantidad * Pesos.GetCotizacion()));
        }

        public static implicit operator Dolar(double d)
        {
            return new Dolar(d);
        }


    }
}

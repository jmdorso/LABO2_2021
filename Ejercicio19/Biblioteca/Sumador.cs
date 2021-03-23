using System;

namespace Biblioteca
{
    public class Sumador
    {
        private int cantidadSumas;


        public Sumador(int cantidadSumas)
        {
            this.cantidadSumas = cantidadSumas;
        }

        public Sumador()
            : this(0)
        {

        }


        public long Sumar(long a, long b)
        {
            long resultado;

            this.cantidadSumas++;

            resultado = a + b;

            return resultado;
        }

        public string Sumar(string a, string b)
        {
            string resultado;

            this.cantidadSumas++;

            resultado = a + b;

            return resultado;
        }

        public static explicit operator int(Sumador s)
        {
            int resultado = s.cantidadSumas;

            return resultado;
        }

        public static long operator +(Sumador s1, Sumador s2)
        {
            long resultado;

            resultado = s1.cantidadSumas + s2.cantidadSumas;

            return resultado;
        }

        public static bool operator |(Sumador s1, Sumador s2)
        {
            bool resultado = false;

            if(s1.cantidadSumas == s2.cantidadSumas)
            {
                resultado = true;
            }

            return resultado;
        }
    }
}

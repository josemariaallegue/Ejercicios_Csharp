using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicio_47
{
    class Contabilidad<T,U> where T: Documento where U:Documento
    {
        private List<T> _egresos;
        private List<U> _ingresos;

        public Contabilidad()
        {
            _egresos = new List<T>();
            _ingresos = new List<U>();
        }

        public static Contabilidad<T,U> operator +(Contabilidad<T,U> c, T egreso)
        {
            
            c._egresos.Add(egreso);

            foreach(T egresoAux in c._egresos)
            {
                Console.WriteLine(Convert.ToString(egresoAux.Numero));   
            }

            return c;
        }

        public static Contabilidad<T,U> operator -(Contabilidad<T,U> c, U ingreso)
        {
            c._ingresos.Add(ingreso);

            foreach (U ingresoAux in c._ingresos)
            {
                Console.WriteLine(Convert.ToString(ingresoAux.Numero));
            }

            return c;
        }
    }
}

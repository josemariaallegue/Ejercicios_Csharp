using System;

namespace capitulo3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Null-Coalescing Operator. consulta de izquierda a derecha hasta encontrar algo distinto a null 
            y lo devuelve*/
            int? numero = null;
            int? numero2= null;
            int numero3 = numero ?? numero2 ?? 10;
            Console.WriteLine(numero ?? numero2 ?? 19);

            /*directivas. Tienen varios usos para manejar que codigo se usa segun el compilador o 
             sistema operativo. Tambien se puede usar para manejar warning o armar segmentos de codigo*/
            #region segmento 1
            
                //zaraza

            #endregion

        }
    }
}

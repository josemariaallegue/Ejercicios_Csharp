using System;
using System.Collections.Generic;
using System.Text;

namespace delegados
{
    class Caja
    {
        //Los delegados son punteros a funcion
        //se debe crear una firma que deben cumplir los metodos a los que apunta
        public delegate void MostrarMensaje(string mensaje);

        #region metodos

        //otras formas de usar delegados sin la declaracion de la firma
        //func se declara un metodo dentro de la lista de parametros (el ultimo valor que se pasa es
        //el tipo de retorno)
        //action es lo mismo que func pero no tiene retorno

        public static void OperacionHabitual(MostrarMensaje InicioCompra,
            Func<int, int,int> suma,
            Action<string> MuestraResultado)
        {
            int resultado;

            InicioCompra("Se inicio la compra");
            resultado = suma(10, 10);
            MuestraResultado(Convert.ToString(resultado));
        }

        #endregion
    }
}

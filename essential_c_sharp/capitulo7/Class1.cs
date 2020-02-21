using System;
using System.Collections.Generic;
using System.Text;

namespace capitulo7
{
    class Class1:Interface1, Interface2
    {

        /*Implementacion implicita
         Se usa en todos los casos que no se usa la explicita
         Se pone igual que en la interfaz + modificadores de visibilidad y otros como virtual*/
        public void Metodo1()
        {
            Console.WriteLine("Implementacion implicita");
        }

        /*Implementacion explicita
         Se usa en: cuando al llamar a la funcion se genera una confucion de lo puede hacer el metodo en la clase. 
         Por ejemplo jirafa1.Dump.
         Tambien se usa cuando ya hay otro metodo con el mismo nombre.
         Se pone igual que en la interfaz pero precedido con el nombre de la interfaz + un punto */
        void Interface2.Metodo2()
        {
            Console.WriteLine("Implementacion explicita");
        }

    }
}

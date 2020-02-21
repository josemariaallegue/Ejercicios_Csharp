using System;

namespace capitulo6
{
    class Program
    {
        public class PdaItem
        {
            protected string Name { get; set; }
            public DateTime LastUpdated { get; set; }

            public virtual void Mostrar()
            {
                Console.WriteLine($"{Name} {LastUpdated}");
            }
        }

        //heredo todos los miembros y demas de la clase PdaItem
        public class Contact : PdaItem
        {
            public string Address { get; set; }

            public string Phone { get; set; }

            //al hacer un override el metodo o propiedad original no se puede llamar
            public override void Mostrar()
            {
                Console.WriteLine($"{this.Name}{this.Address}{this.Phone}");
            }

        }
        static void Main(string[] args)
        {
            Contact contact = new Contact();
            /*clases derivadas pueden convertirse a clases base de forma implicita*/
            PdaItem item = contact;

            /*clases base pueden convertirse a clases derivadas de forma explicita*/
            contact = (Contact)item;

            contact.Mostrar();


        }

    }
}

using System.Threading;
namespace ejercicio_63
{
    class Program
    {
        static void Main(string[] args)
        {
            Caja caja1 = new Caja();
            Caja caja2 = new Caja();
            Negocio negocio1 = new Negocio(caja1, caja2);
            string[] clientes =
            {
                "Jose1", "Cristino1", "Maria1", "Carlos1",
                "Jose2", "Cristino2", "Maria2", "Carlos2",
                "Jose3", "Cristino3", "Maria3", "Carlos3",
                "Jose4", "Cristino4", "Maria4", "Carlos4",
                "Jose5", "Cristino5", "Maria5", "Carlos5",
                "Jose6", "Cristino6", "Maria6", "Carlos6"
            };
            Thread t1 = new Thread(caja1.AtenderClientes);
            Thread t2 = new Thread(caja2.AtenderClientes);
            Thread t3 = new Thread(negocio1.AsignarCaja);

            negocio1.Clientes.AddRange(clientes);
            t1.Name = "Caja 1";
            t2.Name = "Caja 2";

            t3.Start();
            t3.Join();
            t1.Start();
            t2.Start();

        }
    }
}

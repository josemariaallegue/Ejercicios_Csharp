using System;

namespace ejercicio_47
{
    class Program
    {
        static void Main(string[] args)
        {
            Factura factura1 = new Factura(100);
            Recibo recibo1 = new Recibo(50);
            Contabilidad<Factura, Recibo> contabilidad1 = new Contabilidad<Factura, Recibo>();

            contabilidad1 += factura1;
            contabilidad1 -= recibo1;

        }
    }
}

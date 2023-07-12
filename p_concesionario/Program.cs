using p_concesionario.Clases;

namespace p_concesionario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Concesionario conc1 = new Concesionario("El Honesto Joe", "Circular 1");
            



            Cliente cltel = new Cliente("1234564675", "John_albertooo", 0.02f);
            Vendedor vendedor = new Vendedor("104829393", "Juan david rmieres", 0.017f);

            Taxi t1 = new Taxi("ATE671", "Hyndai", "Atos", 2023, 1200, 5, 5, 120000000, "T0010", "Copebombas");
            Deportivo d1 = new Deportivo("ATR623", "Audi", "Atos", 2023, 5200, 2, 2, 20000000000);

            Console.WriteLine(d1 is Taxi);
            Console.WriteLine(d1 is Deportivo);
            Console.WriteLine(d1 is Automovil);

            //vendemos
            Console.WriteLine(conc1.Registrar_Venta(cltel, vendedor, d1));

            Console.WriteLine(d1.Lavar());
            Console.WriteLine(d1.Revisar_10mil());
            Console.WriteLine(d1.Revisar_20mil());

            Console.WriteLine(t1.Revisar_20mil());

            //Console.WriteLine(cltel.Id + " nombre: "+cltel.Name+" Descuento: "+cltel.Descuento);
        }
    }
}
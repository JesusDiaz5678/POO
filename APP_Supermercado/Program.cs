using APP_Supermercado.Clases;

namespace APP_Supermercado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Supermercado laolimpica = new Supermercado("LaOlimpica", "la_90", "carrera70_#_90");
            Caja caja1 = new Caja(4, "pedro_sandero");
            Cliente erik = new Cliente("juancho", 495848594, 5707356, "carrera70-13-100");

            Console.WriteLine(laolimpica.Adicionar_caja(caja1));
            Console.WriteLine(laolimpica.Adicionar_Premio(1, 5, "Perros calientes"));
            Console.WriteLine(laolimpica.Adicionar_Premio(6, 20, "Hamburguesas"));

            laolimpica.Adicionar_Registro(laolimpica.L_cajas[0].Registrar_compra(erik, 300));
            
            Console.WriteLine(laolimpica.L_cajas[0].Cerrar());
            Console.WriteLine(laolimpica.Consultar_premio(erik));
            Console.WriteLine(laolimpica.Reclamar_premio(erik, "hamburguesas"));

        }
    }
}
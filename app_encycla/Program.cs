using app_encycla.Clases;

namespace app_encycla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Estacion la70 = new Estacion("encycla70", "carrera70");
            Usuario juan = new Usuario("Juancho", 8292942, 40);
            Usuario pedro = new Usuario("pedro", 8292942, 40);

            Console.WriteLine(la70.Prestar_bicicleta(juan));
            Console.WriteLine(la70.Cons_bicicletas_prestadas());
            Console.WriteLine(la70.Cons_bicicletas_disponibles());
            Console.WriteLine(la70.Recibir_bicicleta_prestada(juan));
            Console.WriteLine(la70.Cons_bicicletas_prestadas());
            Console.WriteLine(la70.Cons_bicicletas_disponibles());
            Console.WriteLine(la70.Prestar_bicicleta(pedro));
            Console.WriteLine(la70.Prestar_bicicleta(juan));
            Console.WriteLine(la70.Cons_bicicletas_prestadas());
            Console.WriteLine(la70.Cons_bicicletas_disponibles());

        }
    }
}
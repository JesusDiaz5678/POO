using Evt_Notas.Clases;

namespace Evt_Notas
{
    internal class Program
    {
        static void Main(string[] args)
        {
			try
			{
				Registro r1 = new Registro();
				Console.WriteLine("La nota final fue "+r1.Calcular_Nota_Final(5, 5, 5, 5));
			}
			catch (Exception error )
			{

				Console.WriteLine(error.ToString());
			}
        }
    }
}
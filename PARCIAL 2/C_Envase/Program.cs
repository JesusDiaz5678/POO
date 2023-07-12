using C_Envase.Clases;

namespace C_Envase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vidrio vidrio = new Vidrio();
            Console.WriteLine(vidrio.Lavar());
            Plastica plastica = new Plastica();
            Console.WriteLine(plastica.Lavar());

        }
    }
}
using App_Bicicleta.Clases;

namespace App_Bicicleta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bicicleta B1 = new Bicicleta("Lamoboni", Bicicleta.l_color.Negro, Bicicleta.l_material.Aluminio, 10, Bicicleta.l_tam_marco.S);
            Console.WriteLine("Cambio actual "+B1.Cambio_actual);
            Console.WriteLine("Velocidad actual " + B1.Vel_actual);
            B1.Subir_cambio();
            B1.Subir_cambio();
            B1.Subir_cambio();
            B1.Subir_cambio();
            B1.Acelerar(45.5f);
            Console.WriteLine("Cambio actual " + B1.Cambio_actual);
            Console.WriteLine("Velocidad actual " + B1.Vel_actual);
            B1.Frenar(45.4f);
            Console.WriteLine("Cambio actual " + B1.Cambio_actual);
            Console.WriteLine("Velocidad actual " + B1.Vel_actual);
        }
    }
}
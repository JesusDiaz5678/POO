using app_Lampara.Clases;

namespace app_Lampara
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("INFORMACION LAMPARA");
            Lampara lampara1 = new Lampara("AKTPR400", 900000, (float)(4.3), "RPT50234", Lampara.l_colores.Rojo,
                Lampara.l_voltajes.v110, Lampara.l_tipo_bombilla.LED);
            Lampara lampara2 = new Lampara("AKTPR401", 700000, (float)(4.0), "RPT50231", Lampara.l_colores.Negro,
                Lampara.l_voltajes.v110, Lampara.l_tipo_bombilla.LED);
            
            lampara1.Cambiar_cable((float)(4.5));
            lampara1.Encender();
            


            Console.WriteLine("PRIMERA LAMPARA: "+lampara1.Marca);
            Console.WriteLine("ESTADO: "+lampara1.Estado);
            Console.WriteLine("Longitud del cable: " + lampara1.Longitud_cable);



            Console.WriteLine("\n\nSEGUNDA LAMPARA: " + lampara2.Marca);
            Console.WriteLine("Cambio de bombilla "+ lampara2.Cambiar_bombillo());
            lampara2.Cambiar_cable((float)(4.5));
            Console.WriteLine("Longitud del cable: " + lampara2.Longitud_cable);
            lampara2.Encender();
            lampara2.Apagar();
            Console.WriteLine("ESTADO: " + lampara2.Estado);

        }
    }
}
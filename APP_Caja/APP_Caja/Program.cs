using APP_Caja.Clases;

namespace APP_Caja
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CAJAS BANCOS");
            Caja caja1 = new Caja("Juan pablo", 3453433, 1066865870);
            Console.WriteLine(caja1.Consignar(7483785383, 100000));
            Console.WriteLine(caja1.Enviar_giro(7483785383, 200000));
            Console.WriteLine(caja1.Retirar(200000));
            Console.WriteLine(caja1.Arquear());
            
        }

        
    }
}
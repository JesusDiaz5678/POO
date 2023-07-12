using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_concesionario.Clases
{
    internal abstract class Automovil
    {
        private string placa;
        private string marca;
        private string modelo;
        private ushort ano;
        private ushort cilindraje;
        private byte nro_puestos;
        private uint kilometraje = 0;
        private byte nro_puertas;
        private ulong valor_bruto;
        public static readonly ulong valor_minimo_nuevo = 60000000; //valor minimo para vender un carro



        public Automovil(string placa, string marca, string modelo, ushort ano, ushort cilindraje,
            byte nro_puestos, byte nro_puertas, ulong valor_bruto)
        {
            Placa = placa;
            Marca = marca;
            Modelo = modelo;
            Ano = ano;
            Cilindraje = cilindraje;
            Nro_puestos = nro_puestos;
            Nro_puertas = nro_puertas;
            Valor_bruto = valor_bruto;
            kilometraje = 0;
        }



        public string Placa
        {
            get => placa; set
            {

                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value) || value.Length != 6 ||
                    value.Substring(0, 2).ToCharArray().Any(c => !char.IsLetter(c)))

                    //configurar placa
                    throw new Exception("Placa Inválida");

                else placa = value;
            }

        }
        public string Marca
        {
            get => marca; set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value) || value.Length < 2)
                    throw new Exception("Marca Inválida");
                else marca = value;
            }



        }



        public string Modelo
        {
            get => modelo; set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value) || value.Length < 2)
                    throw new Exception("Modelo Inválido");
                else modelo = value;
            }

        }
        public ushort Ano
        {
            get => ano; set
            {
                if (value < DateTime.Now.Year || value > DateTime.Now.Year + 2)
                    throw new Exception("Año Inválido");
                else ano = value;
            }
        }
        public ushort Cilindraje
        {
            get => cilindraje; set
            {
                if (value < 1000 || value > 6000)
                    throw new Exception("Cilindraje Inválido");
                else cilindraje = value;
            }
        }



        public byte Nro_puestos
        {
            get => nro_puestos; set
            {
                if (value < 2 || value > 7)
                    throw new Exception("Número de puestos No válido");
                else nro_puestos = value;
            }
        }



        public byte Nro_puertas
        {
            get => nro_puertas; set
            {
                if (value != 2 && value != 3 && value != 5)
                    throw new Exception("Número de puertas No válido");
                else nro_puertas = value;
            }
        }



        public ulong Valor_bruto
        {
            get => valor_bruto; set
            {



                if (value < valor_minimo_nuevo)
                    throw new Exception("Valor del auto No válido");
                else valor_bruto = value;
            }
        }


        //POLIMORFISMO
        public abstract string Lavar(); //a usted lo van a lavar, usted pone las condiciones
        //metodo abstracto que yo le heredo al hijo
        

        //Metodo virtual, 2 forma polimorfismo
        //En este metodo, si se debe implementar el metodo en el padre
        //NO LO DEJE VACIO
        public virtual string Revisar_10mil()
        {
            return "Revision 10.00 en la clase automovil";
        }

        public string Revisar_20mil()
        {
            return "Revision 20.00 en la clase automovil";
        }
    }
}

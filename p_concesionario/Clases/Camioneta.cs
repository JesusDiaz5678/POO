using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_concesionario.Clases
{
    internal class Camioneta : Automovil
    {
        private bool doble = false;
        private byte nro_exploradoras;



        public Camioneta(string placa, string marca, string modelo, ushort ano, ushort cilindraje, byte nro_puestos, byte nro_puertas,
            ulong valor_bruto, bool doble, byte nro_exploradoras) :
            base(placa, marca, modelo, ano, cilindraje, nro_puestos, nro_puertas, valor_bruto)
        {
            Nro_exploradoras = nro_exploradoras;
            this.doble = doble;
        }



        public byte Nro_exploradoras
        {
            get => nro_exploradoras; set
            {
                if (value < 2 || value > 6)
                    throw new Exception("Número de exploradoras No válido");
                else nro_exploradoras = value;
            }
        }

        public override string Lavar()//Aqui se esta implementando el metodo que el papá le hereda
                                    //override sobreescribe el metodo
        {
            return "Lavar en la clase camioneta";
        }

        public override string Revisar_10mil()
        {
            return "Revisar 10mil en la clase camioneta";
        }
    }
}

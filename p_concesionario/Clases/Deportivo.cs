using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_concesionario.Clases
{
    internal class Deportivo : Automovil
    {
        private bool coupe;
        private bool descapotable;

        public Deportivo(string placa, string marca, string modelo, ushort ano,
            ushort cilindraje, byte nro_puestos, byte nro_puertas, ulong valor_bruto, bool coupe = true, bool descapotable = true) :

            base(placa, marca, modelo, ano, cilindraje, nro_puestos, nro_puertas, valor_bruto)
            //base: poder usar los atributos del padre en el hijo
        {
            this.coupe = coupe;
            this.descapotable = descapotable;

        }

        public override string Lavar()//Aqui se esta implementando el metodo que el papá le hereda
                                      //override sobreescribe el metodo
        {
            return "Lavar en la clase Deportivo";
        }

        
    }
}

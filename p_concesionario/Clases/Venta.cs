using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_concesionario.Clases
{
    internal class Venta
    {
        private List<Persona> l_personas;
        private Automovil auto_vendido;
        private DateTime fecha;
        private ulong valor;



        public Venta(List<Persona> l_personas, Automovil auto_vendido, ulong valor)
        {
            L_personas = l_personas;
            this.auto_vendido = auto_vendido;
            fecha = DateTime.Now;
            Valor = valor;
        }



        public ulong Valor
        {
            get => valor; set
            {
                if (value < Automovil.valor_minimo_nuevo)
                    throw new Exception("El valor no es válido");
                else valor = value;
            }



        }
        
        //Tengo que validar que en la lista venga un cliente y un vendedor
        //operador is para clases hijos y clase padre
        internal List<Persona> L_personas
        {
            get => l_personas;
            set
            {



                byte cont_ven = 0, cont_cli = 0;


                //puedo saber con is de que tipo es el objeto
                foreach (Persona elemento in value)
                {
                    if (elemento is Cliente) cont_cli++;
                    else if (elemento is Vendedor) cont_ven++;
                }



                if (cont_ven == 1 && cont_cli == 1) l_personas = value;
                else throw new Exception("La venta debe tener un vendedor y un cliente");
            }



        }
        internal Automovil Auto_vendido { get => auto_vendido;}
    }
}

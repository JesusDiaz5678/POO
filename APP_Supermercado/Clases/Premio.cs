using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_Supermercado.Clases
{
    internal class Premio
    {
        //ATRIBUTOS
        private ulong ptos_min;
        private ulong ptos_max;
        private string descripcion;

        //CONSTRUCTOR
        public Premio(ulong ptos_min, ulong ptos_max, string descripcion)
        {
            Ptos_min = ptos_min;
            Ptos_max = ptos_max;
            Descripcion = descripcion;
        }

        //ACCESORES
        public ulong Ptos_min
        { 
            get => ptos_min;

            set
            {
                if(value > 0)
                {
                    ptos_min = value;
                }
                else
                {
                    throw new Exception("Los puntos minimos de un premio no pueden ser cero");
                }
            }

        }
        public ulong Ptos_max
        { 
            get => ptos_max;

            set
            {
                if(value > ptos_min && ptos_min > 0)
                {
                    ptos_max = value;
                }
                else
                {
                    throw new Exception("Los puntos maximos de un premio no pueden ser iguales a los puntos minimo"+
                        "Tampoco, pueden ser cero");
                }
            }
        
        }
        public string Descripcion
        { 
            get => descripcion;

            set
            {
                if(value.Length > 6 && !String.IsNullOrEmpty(value))
                {
                    descripcion = value.ToUpper();
                }
                else
                {
                    throw new Exception("La descripción del premio debe ser mayor a seis caracteres");
                }
            }
        
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_concesionario.Clases
{
    internal class Cliente : Persona
    {
        //ATRIBUTOS DEL CLIENTE
        private float descuento;

        //Para yo crear un cliente necesito los atributos del papa y los atributos hijos
        public Cliente(string id, string name, float descuento) : base(id, name)//lo que me esta dando el padre
                                                                                //en la base guardo el valor del parametro
                                                                                //Ya el hijos los hereda
        {
            Descuento = descuento;
        }

        public float Descuento
        { 
            get => descuento;

            set
            {
                if (value < Concesionario.descto_menor || value > Concesionario.descto_mayor)
                    throw new Exception("Descuento No válido");

                else descuento = value;
            } 
        
        }
    }
}

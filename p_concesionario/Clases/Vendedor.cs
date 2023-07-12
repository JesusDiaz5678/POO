using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_concesionario.Clases
{
    internal class Vendedor : Persona
    {
        private float comision;
        public Vendedor(string id, string nombre, float comision) : base(id, nombre)
        {
            Comision = comision;
        }



        public float Comision
        {
            get => comision;
            
            set
            {
                if (value < Concesionario.comision_menor || value > Concesionario.comision_mayor)
                    throw new Exception("Comisión No válida");
                else comision = value;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_concesionario.Clases
{
    internal abstract class Persona //solo se puede usar dentro del proyecto
        //si tenemos cosas abstractas no podemos generar
    {
        private string id;
        private string name;

        protected Persona(string id, string name)
        {
            Id = id;
            Name = name;
        }

        public string Id 
        { 
            get => id;

            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value) || value.Length < 5)
                    throw new Exception("Id Inválido");

                else id = value;
            }
        
        }
        public string Name
        { 
            get => name;

            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value) || value.Length < 10)
                    throw new Exception("Nombre Inválido");
                else name = value;
            }
        
        }
    }
}

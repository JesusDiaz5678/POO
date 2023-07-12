using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace app_encycla.Clases
{
    internal class Usuario
    {
        //ATRIBUTOS
        private string nombre;
        private long num_documento;
        private byte edad;
        
        

        //CONSTRUCTOR
        public Usuario(string nombre, long num_documento, byte edad)
        {
            Nombre = nombre;
            Num_documento = num_documento;
            Edad = edad;
            
        }

        //ACCESORES
        public string Nombre
        {
            get => nombre;

            set
            {
                if (value.Length > 1 && !String.IsNullOrWhiteSpace(value)
                    && !String.IsNullOrEmpty(value))
                {
                    nombre = value.ToUpper();
                }
                else
                {
                    throw new Exception("El nombre debe ser mayor a un digito, no puede tener espacios en blanco ni nulos");
                }
            }

        }
        public long Num_documento
        {
            get => num_documento;

            set
            {
                if (value > 9999)
                {
                    num_documento = value;
                }
                else
                {
                    throw new Exception("La cedula debe tener al menos 5 digitos");
                }
            }
        }
        
        public byte Edad
        { 
            get => edad;

            set
            {
                if(value > 0)
                {
                    edad = value;
                }
                else
                {
                    throw new Exception("La edad no puede ser cero");
                }
            }
        }

        
    }

}


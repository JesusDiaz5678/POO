using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_Supermercado.Clases
{
    internal class Cliente
    {
        //ATRIBUTOS
        private string nombre;
        private ulong nro_identificacion;
        private ulong telefono;
        private string direccion;
        private ulong saldo_puntos;

        //CONSTRUCTOR
        public Cliente(string nombre, ulong nro_identificacion, ulong telefono, string direccion)
        {
            Nombre = nombre;
            Nro_identificacion = nro_identificacion;
            Telefono = telefono;
            Direccion = direccion;
            saldo_puntos = 0;
        }

        //ACCESORES
        public string Nombre
        { 
            get => nombre;

            set
            {
                if (value.Length > 4 && !String.IsNullOrWhiteSpace(value)
                    && !String.IsNullOrEmpty(value))
                {
                    nombre = value.ToUpper();
                }

                else
                {
                    throw new Exception("El nombre debe ser mayor a 4 caracteres, no debe tener espacios en blanco o nulos");
                }

            }
        }
        public ulong Nro_identificacion
        { 
            get => nro_identificacion;

            set
            {
                if (value > 9999)
                {
                    nro_identificacion = value;
                }

                else
                {
                    throw new Exception("El numero de identificacion debe ser mayor a 4 digitos");
                }
            }
        }
        public ulong Telefono
        {
            get => telefono;

            set
            {
                if (value > 9999)
                {
                    telefono = value;
                }

                else
                {
                    throw new Exception("El numero de telefono debe ser mayor a 4 digitos");
                }
            }
        
        }
        public string Direccion
        { 
            get => direccion;

            set
            {
                if (value.Length > 4 && !String.IsNullOrWhiteSpace(value)
                    && !String.IsNullOrEmpty(value))
                {
                    nombre = value;
                }

                else
                {
                    throw new Exception("La direccion debe ser mayor a 4 caracteres, no debe tener espacios en blanco o nulos");
                }

            }

        }
        public ulong Saldo_puntos { get => saldo_puntos; set => saldo_puntos = value; }
    }
}

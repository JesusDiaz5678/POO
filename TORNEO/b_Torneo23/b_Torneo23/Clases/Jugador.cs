using System;
using System.Collections.Generic;
using System.Text;

namespace b_Torneo23.Clases
{
    public class Jugador
    {
        public enum l_posiciones {Arquero,Defensa, Medio, Delantero};

        private string nombre;
        private DateTime f_nacimiento;
        private string nacionalidad;
        private ushort nro_camisa;
        private l_posiciones posicion;
        private byte edad;

        public Jugador(string nombre, DateTime f_nacimiento,
            string nacionalidad, ushort nro_camisa, l_posiciones posicion)
        {
            Nombre = nombre;
            F_nacimiento = f_nacimiento;
            Nacionalidad = nacionalidad;
            Nro_camisa = nro_camisa;
            this.posicion = posicion;
        }
        public string Nombre { get => nombre.ToUpper(); 
            
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                    throw new Exception("El nombre del jugador no puede ir en blanco o nulo");
                else
                    nombre = value.ToUpper();

            }

        }
        public DateTime F_nacimiento { get => f_nacimiento;
            set
            {
                if ((DateTime.Now.Year - value.Year) < Torneo.edad_minima)
                    throw new Exception("La edad del jugador es menor que la edad mínima del torneo ");
                else
                {
                    f_nacimiento = value;
                    edad = (byte)(DateTime.Now.Year - value.Year);
                }
            }
        }
        public string Nacionalidad { get => nacionalidad.ToUpper(); set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                    throw new Exception("La nacionalidad del jugador no puede ir en blanco o nulo");
                else
                    nacionalidad = value.ToUpper();

            }
        }
        public ushort Nro_camisa { get => nro_camisa; set
            {
                if (value >= 0 && value <=999 ) 
                    nro_camisa = value;
                else
                    throw new Exception("El valor del número de la camisa debe estar entre 0 y 999");
            }
        }

        public override string ToString()
        {
            return Nombre;
        }


    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace b_Torneo23.Clases
{
    public class Torneo
    {
        internal static byte edad_minima = 14; //para que sea variable de clase
        internal static uint capacidad_minima = 12000;
        internal static byte nro_jugadores_xequipo = 20;
        internal static DateTime f_inicio = new DateTime(2023,3,1);
        internal static DateTime f_final = new DateTime(2023,12,1);

        private string nombre;
        private List<Enfrentamiento> l_enfrentamientos;

        
        public Torneo(string nombre)
        {
            Nombre = nombre;
            l_enfrentamientos = new List<Enfrentamiento>();
        }

        public string Nombre
        {
            get => nombre;

            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                    throw new Exception("El nombre del torneo no puede ir en blanco o nulo");
                else
                    nombre = value.ToUpper();

            }
        }
        public override string ToString()
        {
            return Nombre;
        }
    }

}

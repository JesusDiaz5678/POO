using System;
using System.Collections.Generic;
using System.Text;

namespace b_Torneo23.Clases
{
    public class Equipo
    {
        private string nombre;
        private List<Jugador> l_jugadores;
        private Tecnico d_tecnico;

        public Equipo(string nombre, List<Jugador> l_jugadores, Tecnico d_tecnico)
        {
            Nombre = nombre;
            L_jugadores = l_jugadores;
            this.d_tecnico = d_tecnico;
        }

        public string Nombre { get => nombre;

            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                    throw new Exception("El nombre del equipo no puede ir en blanco o nulo");
                else
                    nombre = value.ToUpper();

            }
        }


        public List<Jugador> L_jugadores { get => l_jugadores; 
            
            set
            {
                if (value.Count == Torneo.nro_jugadores_xequipo)
                    l_jugadores = value;
                else
                    throw new Exception("La lista de jugadores debe contener exactamente " 
                        + Torneo.nro_jugadores_xequipo + " jugadores ");
            }
        
        }

        public override string ToString()
        {
            return Nombre;
        }
    }
}

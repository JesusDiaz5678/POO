using System;
using System.Collections.Generic;
using System.Text;

namespace b_Torneo23.Clases
{
    public class Tecnico
    {
        private string nombre;
        private List<Torneo> l_torneos;
        private List<string> l_cursos;

        public Tecnico(string nombre, List<Torneo> l_torneos, List<string> l_cursos)
        {
            Nombre = nombre;
            this.l_torneos = new List<Torneo>();
            this.l_cursos = new List<string>();
        }

        public string Nombre
        {
            get => nombre.ToUpper();

            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                    throw new Exception("El nombre del director técnico no puede ir en blanco o nulo");
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

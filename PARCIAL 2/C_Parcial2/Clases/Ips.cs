using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C_Parcial2.Interfaces;

namespace C_Parcial2.Clases
{
    internal class Ips : IVacuna
    {
        private List<Persona> l_personas;
        private int cont_contra = 0;
        private int cont_usuario = 0;
        private int cont_empleado = 0;

        public Ips()
        {
            l_personas = new List<Persona>();
            cont_contra = 0;
            cont_usuario = 0;
            cont_empleado = 0;
        }

        //METODO IMPLEMENTADO DE LA INTERFACE IVacuna
        public void Ivacunar(Persona persona)
        {
            try
            {
                if(persona is Contratista)
                {
                    cont_contra++;
                    l_personas.Add(persona);
                }
                else if(persona is Usuario)
                {
                    cont_usuario++;
                    l_personas.Add(persona);
                }
                else if(persona is Empleado)
                {
                    cont_empleado++;
                    l_personas.Add(persona);
                }
            }
            catch (Exception error)
            {

                throw new Exception ("Ocurrio un error en el metodo Ivacunar en Ips "+error);
            }
        }
    }
}

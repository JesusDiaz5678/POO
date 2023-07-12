using System;
using System.Collections.Generic;
using System.Text;

namespace b_Torneo23.Clases
{
    public class Boleta
    {
        private uint nro_boleta = 19830;
        private Torneo torneoActual;
        private Enfrentamiento enfrentamientoActual;
        private Escenario escenarioActual;
        private DateTime fecha_horaActual;



        public Boleta(uint nro_boleta)
        {
            Nro_boleta = nro_boleta;

        }

        public uint Nro_boleta { get => nro_boleta; set => nro_boleta = value; }
        public Torneo TorneoActual { get => torneoActual; set => torneoActual = value; }
        public Enfrentamiento EnfrentamientoActual { get => enfrentamientoActual; set => enfrentamientoActual = value; }
        public Escenario EscenarioActual { get => escenarioActual; set => escenarioActual = value; }
        public DateTime Fecha_horaActual { get => fecha_horaActual; set => fecha_horaActual = value; }




        public void Llenar_Boleta(Torneo torneo, Enfrentamiento enfrentamiento, Escenario escenario, DateTime dateTime)
        {
            try
            {
                TorneoActual = torneo;
                EnfrentamientoActual = enfrentamiento;
                EscenarioActual = escenario;
                Fecha_horaActual = dateTime;
            }
            catch(Exception error)
            {
                throw new Exception("Hay un error llenar " + error);
            }
        }

        public string Llamar_Boleta()
        {
            try
            {
                string retornar = "\n--------------------------------------------\n"+
                                  "Boleta Número " + Nro_boleta+"\n" +
                                  "Torneo: " + TorneoActual.Nombre.ToString()+"\n"+
                                  "Enfrentamiento: " + EnfrentamientoActual.ToString() + "\n"+
                                  "Escenario: " + EscenarioActual.Nombre.ToString() + "\n"+
                                  "Fecha y hora: " + Fecha_horaActual + "\n"+
                                  "----------------------------------------------\n";

                return retornar;

            }
            catch (Exception error)
            {
                throw new Exception("Hay un error llenar " + error);
            }
        }
    }
}

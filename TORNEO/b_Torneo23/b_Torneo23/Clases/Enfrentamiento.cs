using System;
using System.Collections.Generic;
using System.Text;

namespace b_Torneo23.Clases
{
    public class Enfrentamiento
    {
        private Equipo eq_local;
        private Equipo eq_visitante;
        private Escenario escenario;
        private DateTime fecha_hora;
        private byte gol_local;
        private byte gol_visitante;
        private Jugador jugador_destacado;
        private bool finalizo;
        private List<Boleta> aux_boletas;

        public Enfrentamiento(Equipo eq_local, Equipo eq_visitante,
            Escenario escenario, DateTime fecha_hora)
        {
            this.eq_local = eq_local;
            Eq_visitante = eq_visitante;
            this.escenario = escenario;
            this.Fecha_hora = fecha_hora;

            aux_boletas =   new List<Boleta>();

            gol_local = 0;
            gol_visitante = 0;

            finalizo = false;


            
            uint consta = 200;
            uint cant_boletas = Escenario.Capacidad / Escenario.Max_nro_taquillas;

            for (byte i = 0; i <cant_boletas; i++)
            {
                aux_boletas.Add(new Boleta(consta));
            }
            for (byte i = 1; i <= Escenario.Max_nro_taquillas; i++)
            {
                Escenario.L_taquillas.Add(new Taquilla((byte)(Escenario.Cons_taquilla), aux_boletas));
                Escenario.Cons_taquilla++;
            }


        }



        public DateTime Fecha_hora { get => fecha_hora;

            set
            {
                if (value >= Torneo.f_inicio && value <= Torneo.f_final)
                    fecha_hora = value;
                else
                    throw new Exception("La fecha no está en el rango de fechas del torneo");
            }
        
        }

        public byte Gol_local { get => gol_local;  }
        public byte Gol_visitante { get => gol_visitante;  }
        public Jugador Jugador_destacado { get => jugador_destacado;  }
        public bool Finalizo { get => finalizo;  }
        public Equipo Eq_local { get => eq_local;  }
        
        public Escenario Escenario { get => escenario;   }
        
        public Equipo Eq_visitante { get => eq_visitante; 
            internal set
            {
                if (value == eq_local)
                    throw new Exception("Error: el equipo visitante no debe ser el mismo que el local");
                else
                    eq_visitante = value;
            }
        
        }

        public void Anotar_gol_local()
        {
            try
            {
                gol_local++;
            }
            catch (Exception error)
            {
                throw new Exception("Error en anotar gol local");
            }
                
        }

        public void Anotar_gol_vistantes()
        {
            try
            {
                gol_visitante++;
            }
            catch (Exception error)
            {
                throw new Exception("Error en anotar gol visitante");
            }

        }

        public void Anular_gol_local()
        {
            try
            {
                if(gol_local >0) gol_local--;
            }
            catch (Exception error)
            {
                throw new Exception("Error en anular gol local");
            }

        }

        public void Anular_gol_vistantes()
        {
            try
            {
                if(gol_visitante >0) gol_visitante--;
            }
            catch (Exception error)
            {
                throw new Exception("Error en anular gol visitante");
            }

        }

        public void Elegir_destacado()
        {
            try
            {
                if(finalizo)
                {
                   Random aleatorio = new Random();
                    if (gol_visitante > gol_local)
                        jugador_destacado = eq_visitante.L_jugadores[aleatorio.Next(0,Torneo.nro_jugadores_xequipo)];

                    else if(gol_visitante < gol_local)
                        jugador_destacado = eq_local.L_jugadores[aleatorio.Next(0, Torneo.nro_jugadores_xequipo)];
                    else
                    {
                        if (aleatorio.Next(0, 2) == 0)
                            jugador_destacado = eq_visitante.L_jugadores[aleatorio.Next(0, Torneo.nro_jugadores_xequipo)];
                        else
                            jugador_destacado = eq_local.L_jugadores[aleatorio.Next(0, Torneo.nro_jugadores_xequipo)];

                    }

                }
                else
                    throw new Exception("El partido no ha finalizado, no se puede elegir jugador destacado");
            }
            catch (Exception error)
            {
                throw new Exception("Error en elegir jugador destacado");
            }
        }

        public void Finalizar_partido()
        {
            try
            {
                if(!finalizo) 
                    finalizo = true;
            }
            catch (Exception )
            {
                throw new Exception("Error en anular gol visitante");
            }
        }

        public override string ToString()
        {
            return Eq_local.Nombre + " - " + Eq_visitante.Nombre;
        }
    }
}

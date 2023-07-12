using System;
using System.Collections.Generic;
using System.Text;

namespace b_Torneo23.Clases
{
    public class Escenario
    {
        private string nombre;
        private string direccion;
        private uint capacidad;
        private List<Taquilla> l_taquillas;
        private byte cons_taquilla = 1;
        private readonly byte max_nro_taquillas=25;

        public Escenario(string nombre, string direccion, uint capacidad)
        {
            Nombre = nombre;
            Direccion = direccion;
            Capacidad = capacidad;

            L_taquillas = new List<Taquilla>();
            List<Boleta> aux_boletas = new List<Boleta>();
            uint cant_bol = capacidad / max_nro_taquillas;

            //crear una lista vacía de boletas
            /*
            uint consta = 10;

            for (uint i=1; i <= cant_bol; i++){
                aux_boletas.Add(new Boleta(consta));
            }
            

            //crear las taquillas para el escenario
            
            for(byte i=1; i<=max_nro_taquillas; i++)
            {
                L_taquillas.Add(new Taquilla(Cons_taquilla, aux_boletas));
                Cons_taquilla++;
            }
            
            */

        }

        public string Nombre { get => nombre; 
            
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                    throw new Exception("El nombre del escenario no puede ir en blanco o nulo");
                else
                    nombre = value.ToUpper();
            }
        }
        public string Direccion { get => direccion; set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                    throw new Exception("La dirección del escenario no puede ir en blanco o nulo");
                else
                    direccion = value.ToUpper();
            }
        }
        
        public uint Capacidad { get => capacidad; 
            
            set {
                if (value < Torneo.capacidad_minima)
                    throw new Exception("La capacidad del escenario no puede ser menor a " + Torneo.capacidad_minima);
                else
                    capacidad = value;
            } 
        }

        public List<Taquilla> L_taquillas { get => l_taquillas; set => l_taquillas = value; }

        public byte Max_nro_taquillas => max_nro_taquillas;

        public byte Cons_taquilla { get => Cons_taquilla; set => Cons_taquilla = value; }


        public override string ToString()
        {
            return Nombre;
        }

    }
}

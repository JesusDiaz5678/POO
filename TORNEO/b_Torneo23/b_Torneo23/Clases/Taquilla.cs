using System;
using System.Collections.Generic;
using System.Text;

namespace b_Torneo23.Clases
{
    public class Taquilla
    {
        private byte numero;
        private List<Boleta> l_boletas_vender;
        private List<Boleta> l_boletas_vendidas;
        private bool abierta = false;
        private readonly byte max_nro_bol_clte = 10;

        public Taquilla(byte numero, List<Boleta> l_boletas_vender)
        {
            this.numero = numero;
            this.L_boletas_vender = l_boletas_vender;
            l_boletas_vendidas = new List<Boleta>();
        }

        public bool Abierta { get => abierta;  }
        public List<Boleta> L_boletas_vender { get => l_boletas_vender; set => l_boletas_vender = value; }

        public void Abrir()
        {
            try
            {
                if (L_boletas_vender.Count > 0 && !abierta)
                    abierta = true;
                else
                    throw new Exception("la taquilla está abierta o no tiene boletas");

            }
            catch (Exception error)
            {
                throw new Exception("Ocurrió un error en abrir taquilla \n" + error.Message);
            }
        }

        public void Cerrar()
        {
            try
            {
                if (abierta)
                    abierta = false;
                else
                    throw new Exception("la taquilla está cerrada");
            }
            catch (Exception error)
            {
                throw new Exception("Ocurrió un error en cerrar taquilla \n" + error.Message);
            }
        }


        public void Vender_boleta()
        {
            try
            {
                if (L_boletas_vender.Count > 0 && abierta)
                {
                    l_boletas_vendidas.Add(L_boletas_vender[0]);
                    L_boletas_vender.RemoveAt(0);

                }
            }
            catch (Exception error)
            {
                throw new Exception("Ocurrió un error en vender boleta \n" + error.Message);
            }
        }


        public void Vender_boleta(byte cantidad)
        {
            try
            {
                if (cantidad <= max_nro_bol_clte && 
                    L_boletas_vender.Count >= cantidad && 
                    cantidad >0 && abierta)
                {
                    for(byte i=1; i<cantidad; i++)
                    {
                        l_boletas_vendidas.Add(L_boletas_vender[0]);
                        L_boletas_vender.RemoveAt(0);
                    }

                }


            }
            catch (Exception error)
            {
                throw new Exception("Ocurrió un error en vender boleta cantidad \n" + error.Message);
            }
        }




    }
}

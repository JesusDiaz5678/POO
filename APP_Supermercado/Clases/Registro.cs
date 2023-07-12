using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_Supermercado.Clases
{
    internal class Registro
    {
        //ATRIBUTOS
        private Caja caja;
        private Cliente cliente;
        private ulong monto_compra;
        private ulong ptos_acumX_compra;
        private DateTime fecha_hora;

        //CONSTRUCTOR
        public Registro(Caja caja, Cliente cliente, ulong monto_compra, ulong ptos_acumX_compra)
        {
            Caja = caja;
            Cliente = cliente;
            Monto_compra = monto_compra;
            Ptos_acumX_compra = ptos_acumX_compra;
            fecha_hora = DateTime.Now;
        }

        //ACCESORES
        public ulong Monto_compra
        { 
            get => monto_compra;

            set
            {
                if(value > 0)
                {
                    monto_compra = value;
                }
                else
                {
                    throw new Exception("El valor de la compra debe ser mayor a 0");
                }
            }
        
        }
        public ulong Ptos_acumX_compra { get => ptos_acumX_compra; set => ptos_acumX_compra = value; }
        public DateTime Fecha_hora { get => fecha_hora;}
        internal Caja Caja { get => caja; set => caja = value; }
        internal Cliente Cliente { get => cliente; set => cliente = value; }

    }
}

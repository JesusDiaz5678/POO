using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_Supermercado.Clases
{
    internal class Caja
    {
        //ATRIBUTOS
        private byte num_caja;
        private string nombre_cajero;
        private ulong saldo_caja;
        private List<Cliente> l_clientes;
        private bool estado;

        //CONSTRUCTOR
        public Caja(byte num_caja, string nombre_cajero)
        {
            Num_caja = num_caja;
            Nombre_cajero = nombre_cajero;
            saldo_caja = 0;
            l_clientes = new List<Cliente>();
            estado = true;
        }

        //ACCESORES
        public byte Num_caja { get => num_caja; set => num_caja = value; }
        public string Nombre_cajero 
        {
            
            get => nombre_cajero;

            set
            {
                if (value.Length > 5 && !String.IsNullOrWhiteSpace(value)
                    && !String.IsNullOrEmpty(value))
                {
                    nombre_cajero = value.ToUpper();
                }

                else
                {
                    throw new Exception("El nombre del cajero debe ser mayor a 5 caracteres");
                }
            }
        }
        public ulong Saldo_caja { get => saldo_caja;}
        public bool Estado { get => estado; }
        internal List<Cliente> L_clientes { get => l_clientes;}

        //METODOS
        public Registro Registrar_compra (Cliente cliente, ulong val_compra)
        {
            try
            {
                //this, sirve para invocar un objeto a el mismo
                

                ulong ptos_compra;
                if(estado == true && val_compra > 0)
                {
                    ptos_compra = val_compra/Supermercado.ptos_Xcompra;
                    saldo_caja += val_compra;
                    cliente.Saldo_puntos = +ptos_compra;
                    return new Registro(this, cliente, val_compra, ptos_compra);
                }
                else if(estado == false && val_compra > 0)
                {
                    throw new Exception("La caja esta cerrada, para registrar la compra debe estar abierta");
                }
                else
                {
                    throw new Exception("El valor de la compra debe ser mayor a cero");
                }
            }
            catch (Exception error)
            {

                throw new Exception("Ocurrio un error en el metodo Registrar Compra " + error);
            }
        }

        public string Cerrar()
        {
            try
            {
                string text_ret;
                if(estado == true)
                {
                    text_ret = "\n=========================\n"
                        +"Cajero #"+num_caja+" ha sido CERRADO\n"
                        +"Nombre del cajero: "+nombre_cajero+"\n"
                        +"Supermercado: " + Supermercado.nombre+"\n"
                        +"Saldo total recaudado: "+saldo_caja.ToString("C2")+
                        "\n=========================\n";
                    saldo_caja = 0;
                    estado = false;

                    return text_ret;
                }
                else
                {
                    throw new Exception("La caja ya habia sido cerrada");
                }
            }
            catch (Exception error)
            {
                throw new Exception("Ocurrio un error en el metodo Cerrar caja " + error);

            }
        }

        public string Abrir()
        {
            try
            {
                string text_ret;
                if (estado == false)
                {
                    saldo_caja = 0;
                    estado = true;
                    text_ret = "\nLa caja #" + num_caja + " ha sido ABIERTA";

                    return text_ret;
                }
                else
                {
                    throw new Exception("La caja ya habia sido abierta");
                }
            }
            catch (Exception error)
            {
                throw new Exception("Ocurrio un error en el metodo Abrir caja " + error);

            }
        }
    }
}

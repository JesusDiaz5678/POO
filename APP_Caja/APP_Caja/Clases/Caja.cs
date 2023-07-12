using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_Caja.Clases
{
    internal class Caja
    {
        //PORCENTAJE DE COMISION A TODOS LAS CAJAS
        internal static float porc_comision = (float)0.2;
        //CANTIDAD MAXIMA DE RETIRO
        internal static ulong sald_max_retiro = 250000; 

        //ATRIBUTOS
        private string nombre_cajero;
        private uint cod_usu_caj;
        private ulong ced_cajero;

        private ulong saldo_inicial;
        private DateTime fecha_apertura;
        private float porc_comision_caj;
        private ulong saldo;
        private ulong max_retiro;
        private ulong total_ingresos;
        private ulong total_egresos;

        //Constructor
        public Caja(string nombre_cajero, uint cod_usu_caj, ulong ced_cajero)
        {
            Nombre_cajero = nombre_cajero;
            Cod_usu_caj = cod_usu_caj;
            Ced_cajero = ced_cajero;

            saldo_inicial = 2000000;
            fecha_apertura = DateTime.Now;
            porc_comision_caj = porc_comision;
            saldo = Saldo_inicial;
            max_retiro = sald_max_retiro;
            total_ingresos = 0;
            total_egresos = 0;
        }

        //ACCESORES
        public string Nombre_cajero
        { 
            get => nombre_cajero;

            set
            {
                if(value != null && value.Length >3 && !String.IsNullOrEmpty(value))
                {
                    nombre_cajero = value.ToUpper();
                }
                else
                {
                    throw new Exception("El nombre del cajero no puede estar nulo");
                }
            }
        }
        public uint Cod_usu_caj
        { 
            get => cod_usu_caj;

            set
            {
                if (value > 999)
                {
                    cod_usu_caj = value;
                }
                else
                {
                    throw new Exception("El codigo del cajero debe tener al menos 4 digitos");
                }
            }
        }
        public ulong Ced_cajero
        { 
            get => ced_cajero;

            set
            {
                if (value > 99999)
                {
                   ced_cajero = value;
                }
                else
                {
                    throw new Exception("La cedula del cajero debe ser de 6 digitos");
                }
            }
        }

        public ulong Saldo_inicial { get => saldo_inicial;}
        public DateTime Fecha_apertura1 { get => fecha_apertura;}
        public float Porc_comision_caj { get => porc_comision_caj;}
        public ulong Saldo { get => saldo;}
        public ulong Max_retiro { get => max_retiro;}
        public ulong Total_ingresos { get => total_ingresos;}
        public ulong Total_egresos { get => total_egresos;}

        //METODOS
        public string Consignar(ulong num_cuenta, uint cant_consignar)
        {
            try
            {
                string text_ret;
                if (num_cuenta > 999 && cant_consignar >0)
                {
                    text_ret = "\n======================================="+
                        "\nNombre del cajero: "+nombre_cajero+
                        "\nFecha de atención: "+DateTime.Now+
                        "\nNumero de cuenta: "+num_cuenta+
                        "\nCantidad a consignar: $"+cant_consignar.ToString("C2");

                    saldo += cant_consignar;
                    total_ingresos += cant_consignar;
                }
                else
                {
                    throw new Exception("Verifique el numero de cuenta y la cantidad a consignar");
                }
                return text_ret;
            }
            catch(Exception error)
            {
                throw new Exception("Ocurrio un error en el metodo Consignar "+error);
            }
        }
        public string Retirar(uint cant_retirar)
        {
            try
            {
                string text_ret;
                if (cant_retirar > 0 && cant_retirar <= max_retiro && saldo >= cant_retirar)
                {
                    text_ret = "\n=======================================\n" +
                        "Nombre del cajero: " + nombre_cajero +
                        "\nFecha de atención: " + DateTime.Now+
                        "\nCantidad a retirar: $" + cant_retirar.ToString("C2");

                    saldo -= cant_retirar;
                    total_egresos += cant_retirar;
                }
                else
                {
                    throw new Exception("Verifique que la cantidad a retirar no sea mayor a 250.000");
                }
                return text_ret;
            }
            catch (Exception error)
            {
                throw new Exception("Ocurrio un error en el metodo Consignar " + error);
            }
        }
        public string Enviar_giro(ulong num_cuenta, uint cant_Girar)
        {
            try
            {
                string text_ret;
                float val_comision;

                if (num_cuenta > 999 && cant_Girar > 0)
                {
                    val_comision = cant_Girar * porc_comision_caj;

                    text_ret = "\n=======================================" +
                        "\nNombre del cajero: " + nombre_cajero +
                        "\nFecha de atención: " + DateTime.Now.ToString() +
                        "\nNumero de cuenta: " + num_cuenta +
                        "\nCantidad a Girar: $" + cant_Girar.ToString("C2")+
                        "\nValor de la comision: $" + val_comision.ToString("C2");

                    saldo += cant_Girar + (uint)val_comision;
                    total_ingresos += cant_Girar + (uint)val_comision;
                }
                else
                {
                    throw new Exception("Verifique el numero de cuenta y la cantidad a Girar");
                }
                return text_ret;

            }
            catch(Exception error)
            {
                throw new Exception("Ocurrio un error en el metodo Enviar_giro" + error);
            }
        }
        public string Consultar_saldo()
        {
            try
            {
                string text_ret;
                
                text_ret = "\n=======================================" +
                        "\nNombre del cajero: " + nombre_cajero +
                        "\nFecha de atención: " + DateTime.Now.ToString() +
                        "\nSaldo en caja: $" + saldo.ToString("C2");

                return text_ret;

            }
            catch (Exception error)
            {
                throw new Exception("Ocurrio un error en el metodo Enviar_giro" + error);
            }
        }
        public string Arquear()
        {
            try
            {
                string text_ret;
                ulong arqueo;
                arqueo = (saldo_inicial + total_ingresos) - total_egresos;

                text_ret = "\n=======================================" +
                        "\nNombre del cajero: " + nombre_cajero +
                        "\nFecha de atención: " + DateTime.Now.ToString() +
                        "\nSaldo en caja: $" + saldo.ToString("C2") +
                        "\nArqueo: $" + arqueo.ToString("C2");

                return text_ret;
            }
            catch (Exception error)
            {
                throw new Exception("Ocurrio un error en el metodo Enviar_giro" + error);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_Supermercado.Clases
{
    internal class Supermercado
    {
        //ATRIBUTOS
        internal readonly static byte num_cajax_superm = 4;
        internal readonly static byte num_premx_superm = 4;
        internal readonly static byte ptos_Xcompra = 50;
        private byte consecutivo_num_caja;

        //¿Que modificador usar si quiero ver el valor de nombre en otra clase, pero sin poder modificarlo en el program?
        internal static string nombre;
        private string sucursal;
        private string direccion;
        private List<Registro> l_registros;
        private List<Caja> l_cajas;
        private List<Premio> l_premios;

        //CONSTRUCTOR
        public Supermercado(string nombre, string sucursal, string direccion)
        {
            Nombre = nombre;
            Sucursal = sucursal;
            Direccion = direccion;
            l_registros = new List<Registro>();
            l_cajas = new List<Caja>();
            l_premios = new List<Premio>();
            consecutivo_num_caja = 1;
        }

        //ACCESORES
        public string Nombre 
        { 
            get => nombre;

            set
            {
                if (value.Length > 4 && !String.IsNullOrWhiteSpace(value)
                    && !String.IsNullOrEmpty(value))
                {
                    nombre = value;
                }
                else
                {
                    throw new Exception("El nombre del supermercado debe ser mayor a 4 caracteres "+
                        "no debe tener espacios en blanco");
                }
            }
        
        }
        public string Sucursal
        { 
            get => sucursal;

            set
            {
                if (value.Length > 3 && !String.IsNullOrWhiteSpace(value)
                    && !String.IsNullOrEmpty(value))
                {
                    sucursal = value;
                }
                else
                {
                    throw new Exception("La sucursal del supermercado debe ser mayor a 4 caracteres " +
                        "no debe tener espacios en blanco");
                }
            }
        }
        public string Direccion 
        { 
            get => direccion;

            set
            {
                if (value.Length > 5 && !String.IsNullOrWhiteSpace(value)
                    && !String.IsNullOrEmpty(value))
                {
                    direccion = value;
                }
                else
                {
                    throw new Exception("La dirección del supermercado debe ser mayor a 5 caracteres " +
                        "no debe tener espacios en blanco");
                }
            }
        }
        internal List<Registro> L_registros { get => l_registros;}
        internal List<Caja> L_cajas { get => l_cajas; set => l_cajas = value; }
        internal List<Premio> L_premios { get => l_premios;}


        //METODOS
        public string Adicionar_caja(Caja caja)
        {
            try
            {
                string text_ret="";
                if(consecutivo_num_caja <= num_cajax_superm)
                {
                    l_cajas.Add(caja);
                    text_ret = "\nSe ha añadido la caja # "+caja.Num_caja+" al supermercado "+nombre+"\n";
                    consecutivo_num_caja++;
                }
                else
                {
                    text_ret = "\nEl numero de cajas permitidas en el supermecado ha sido completadas\n";
                }
                return text_ret;
            }
            catch (Exception error)
            {

                throw new Exception ("Ocurrio un error en el metodo Adicionar caja "+error);
            }
        }

        public string Adicionar_Premio(ulong ptos_min, ulong ptos_max, string descripcion)
        {
            try
            {
                string text_ret;
                if(l_premios.Count < num_premx_superm)
                {
                    l_premios.Add(new Premio(ptos_min, ptos_max, descripcion));
                    text_ret = "\nHa sido añadido un premio a la lista.\n";
                }
                else
                {
                    text_ret = "\nLa cantidad de premios en la lista ha sido completada\n";
                }
                return text_ret;
                
            }
            catch (Exception error)
            {

                throw new Exception("Ocurrio un error en el metodo Adicionar premio "+error);
            }
        }

        public void Adicionar_Registro(Registro registro)
        {
            try
            {

                l_registros.Add(registro);

            }
            catch (Exception error)
            {
                throw new Exception("Ocurrio un error en adicionar registro "+error);
            }
        }

        public string Consultar_premio (Cliente cliente)
        {
            try
            {
                string text_ret = "\n=========================\n";

                foreach (Premio item in l_premios)
                {
                    if (cliente.Saldo_puntos >= item.Ptos_min)
                    {
                        text_ret += ("Premio: " + item.Descripcion + "\n"
                            + "Puntos minimos: " + item.Ptos_min + "\n"
                            + "Puntos maximos: " + item.Ptos_max + "\n");
                    }
                }
                text_ret += "Saldo: "+cliente.Saldo_puntos;
                text_ret += "\n=========================\n";
                return text_ret;
            }
            catch (Exception error)
            {

                throw new Exception("Ocurrio un error en el metodo Consultar premio "+error);
            }
        }

        public string Reclamar_premio(Cliente cliente, string premio)
        {
            try
            {
                string text_ret = ""; 

                foreach (Premio item in l_premios)
                {
                    if (cliente.Saldo_puntos >= item.Ptos_min  && item.Descripcion.Equals(premio.ToUpper()))
                    {
                        text_ret = "\nUsted ha reclamado el premio \n"+item.Descripcion
                            +"\nSus puntos utilizados han sido: "+cliente.Saldo_puntos;

                        if(cliente.Saldo_puntos < item.Ptos_max)
                        {
                            cliente.Saldo_puntos = 0;
                        }
                        else
                        {
                            cliente.Saldo_puntos = cliente.Saldo_puntos - item.Ptos_max;
                        }
                    }
                }

                return text_ret;

            }
            catch (Exception error)
            {

                throw new Exception("Ocurrio un error en el metodo Reclamar premio " + error);
            }
        }
    }
}

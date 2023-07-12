using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_concesionario.Clases
{
    internal class Concesionario
    {
        internal readonly static float descto_menor = 0.01f; //atributos estaticos, atributos de clase
        internal readonly static float descto_mayor = 0.025f;
        internal readonly static float comision_menor = 0.015f;
        internal readonly static float comision_mayor = 0.02f;

        private string nombre;
        private string direccion;
        private List<Venta> l_ventas;

        public Concesionario(string nombre, string direccion)
        {
            Nombre = nombre;
            Direccion = direccion;
            l_ventas = new List<Venta>(); //Aqui creo una lista cada vez que creo un Concesionario
        }



        public string Nombre
        {
            get => nombre; set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value) || value.Length < 5)
                    throw new Exception("Nombre Inválido");
                else nombre = value;
            }
        }
        public string Direccion
        {
            get => direccion; set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value) || value.Length < 10)
                    throw new Exception("Dirección no válida");
                else direccion = value;
            }
        }
        internal List<Venta> L_ventas { get => l_ventas; set => l_ventas = value; }



        public string Registrar_Venta(Cliente cliente, Vendedor vendedor, Automovil auto)
        {
            try
            {
                string txt_venta = "";
                ulong valor_neto = 0; //valor del carro - el decuento del cliente
                string tipo = "";


                //Saber de que tipo de automovil es
                if (auto is Camioneta) tipo = "Camioneta";
                else if (auto is Deportivo) tipo = "Deportivo";
                else if (auto is Taxi) tipo = "Taxi";


                //Nueva lista que creo en ese metodo
                List<Persona> l_personas = new List<Persona>();
                l_personas.Add(cliente);
                l_personas.Add(vendedor);



                valor_neto = (ulong)(auto.Valor_bruto * (1 - cliente.Descuento));



                //Venta v1 = new Venta(l_personas, auto, valor_neto);
                L_ventas.Add(new Venta(l_personas, auto, valor_neto));



                txt_venta = "Cliente: " + cliente.Id + " " + cliente.Name +
                    "\nMarca y Modelo: " + auto.Marca + " " + auto.Modelo +
                    "\nTipo: " + tipo + " Cilindraje: " + auto.Cilindraje +
                    "\nAño: " + auto.Ano +
                    "\nValor Bruto: $" + auto.Valor_bruto + " Valor Neto: $" + valor_neto;
                

                l_personas.Clear();

                return txt_venta;
            }



            catch (Exception error)
            {
                throw new Exception("Ocurrió un eror registrando la venta. " + error);
            }
        }

    }
}

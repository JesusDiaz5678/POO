using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app_Lampara.Clases
{
    internal class Lampara
    {
        //ATRIBUTOS
        public enum l_colores {Negro, Cromo, Rojo};
        public enum l_voltajes {v110, v220};
        public enum l_tipo_bombilla { Halogena, LED };

        private string marca;
        private uint duracion_bombilla;
        private float longitud_cable;
        private bool estado;
        private string codigo_tablero;
        private l_colores color;
        private l_voltajes voltaje;
        private l_tipo_bombilla tipo_bombilla;

        //CONSTRUCTOR
        public Lampara(string marca, uint duracion_bombilla, float longitud_cable,
            string codigo_tablero, l_colores color, l_voltajes voltaje, l_tipo_bombilla tipo_bombilla)
        {
            this.marca = marca;
            this.duracion_bombilla = duracion_bombilla;
            this.longitud_cable = longitud_cable;
            estado = false;
            this.codigo_tablero = codigo_tablero;
            this.color = color;
            this.voltaje = voltaje;
            this.tipo_bombilla = tipo_bombilla;
        }

        //ACCESORES
        public string Marca
        { 
            get => marca;

            set
            {
                if(value.Length >= 6 && !String.IsNullOrWhiteSpace(value)
                    && !String.IsNullOrEmpty(value))
                {
                    marca = value.ToUpper();
                }
                else
                {
                    throw new Exception("La marca de la lampara debe ser mayor a seis caracteres \n" +
                        "No debe tener espacios en blanco");
                }
            }
        }
        public uint Duracion_bombilla 
        { 
            get => duracion_bombilla;

            set
            {
                if(value >= 500000 && value <= 1000000)
                {
                    duracion_bombilla = value;
                }
                else
                {
                    throw new Exception("La duración de la bombilla debe estar entre el rango del 500000 y 1000000 horas");
                }
            }
        }
        public float Longitud_cable
        { 
            get => longitud_cable;

            set
            {
                if(value >=1.5 && value <= 4.5)
                {
                    longitud_cable = value;
                }
                else
                {
                    throw new Exception("La longitud del cable debe estar entre 1.5 - 4.5 metros");
                }
            }
        }
        public bool Estado { get => estado;}
        public string Codigo_tablero
        { 
            get => codigo_tablero;

            set
            {
                if(value.Length >= 6 && !String.IsNullOrWhiteSpace(value)
                    && !String.IsNullOrEmpty(value))
                {
                    codigo_tablero = value.ToUpper();
                }
                else
                {
                    throw new Exception("El codigo del tablero debe ser mayor a seis caracteres \n" +
                        "No debe tener espacios en blanco");
                }
            }
        }
        internal l_colores Color { get => color; set => color = value; }
        internal l_voltajes Voltaje { get => voltaje; set => voltaje = value; }
        internal l_tipo_bombilla Tipo_bombilla { get => tipo_bombilla; set => tipo_bombilla = value; }

        //METODOS
        public void Encender()
        {
            try
            {
                if(estado == false)
                {
                    estado = true;
                }
            }
            catch(Exception error)
            {
                throw new Exception("Ocurrio un error en el metodo Encender lampara "+error);
            }
        }
        public string Cambiar_bombillo()
        {
            try
            {
                string texto_ret;
                if(estado == false)
                {
                    texto_ret = "El bombillo fue cambiado exitosamente";
                }
                else
                {
                    texto_ret = "No se pudo realizar el cambio de bombillo debido a que la lampara esta encendida"+
                        "\nApague la lampara para realizar el cambio";
                }
                return texto_ret;
            }
            catch (Exception error)
            {
                throw new Exception("Ocurrio un error en el metodo Cambiar_bombillo " + error);
            }
        }
        public void Apagar()
        {
            try
            {
                if (estado == true)
                {
                    estado = false;
                }
            }
            catch (Exception error)
            {
                throw new Exception("Ocurrio un error en el metodo Apagar lampara " + error);
            }
        }
        public bool Cambiar_cable(float longitud)
        {
            try
            {
                bool cambio;

                if(longitud >= 1.5 && longitud <= 4.5 && estado == false)
                {
                    longitud_cable = longitud;
                    cambio = true;
                }
                else
                {
                    cambio = false;
                }
                return cambio;
            }
            catch (Exception error)
            {

                throw new Exception("Ocurrio un error en el método cambiar cable. "+ error);
            }
        }
        public void asignar_tablero(string nuevo_codigo)
        {
            try
            {
                if(nuevo_codigo.Length > 6 && !String.IsNullOrWhiteSpace(nuevo_codigo)
                    && !String.IsNullOrEmpty(nuevo_codigo))
                {
                    codigo_tablero = nuevo_codigo;
                }
                else
                {
                    throw new Exception("El codigo del tablero debe ser mayor a seis caracteres"+
                        "\nNo debe tener espacios en blanco");
                }
            }
            catch(Exception error)
            {
                throw new Exception("Ocurrio un error en el método asignar_tablero" + error);
            }
        }
    }
}

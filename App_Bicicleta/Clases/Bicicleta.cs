using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Bicicleta.Clases
{
    internal class Bicicleta
    {
        //Atributos
        public enum l_color { Blanco, Rojo, Negro, Gris };
        public enum l_material { Titanio, Aluminio, Hierro };
        public enum l_tam_marco { L, M, S };

        private string marca;
        private l_color color;
        private l_material material;
        private byte nro_cambios;
        private l_tam_marco tam_marco;
        private byte cambio_actual;
        private float vel_actual;

        //Constructor
        public Bicicleta(string marca, l_color color, l_material material, byte nro_cambios, l_tam_marco tam_marco)
        {
            Marca = marca;
            Color = color;
            Material = material;
            Nro_cambios = nro_cambios;
            Tam_marco = tam_marco;
            cambio_actual = 1;
            vel_actual = 0;
        }

        //Accesores
        public string Marca
        { 
            get => marca;

            set
            {
                if (value.Length > 6 && !String.IsNullOrWhiteSpace(value)
                    && !String.IsNullOrEmpty(value))
                {
                    marca = value;
                }

                else
                {
                    throw new Exception("La marca debe ser mayor a 6 digitos y no debe tener espacios nulos o blancos");
                }
            }
        
        }

        internal l_color Color { get => color; set => color = value; }
        internal l_material Material { get => material; set => material = value; }
        public byte Nro_cambios
        { 
            get => nro_cambios;

            set
            {
                if(value > 0 & value < 11)
                {
                    nro_cambios = value;
                }

                else
                {
                    throw new Exception("El numero de cambios de la bicicleta debe estar entre 1-10 cambios");
                }

            }
        }

        internal l_tam_marco Tam_marco { get => tam_marco; set => tam_marco = value; }
        public byte Cambio_actual { get => cambio_actual;}
        public float Vel_actual { get => vel_actual;}


        //Metodo
        public bool Subir_cambio()
        {
            try
            {
                if(cambio_actual < nro_cambios)
                {
                    cambio_actual++;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception error)
            {

                throw new Exception("Ocurrio un error en el metodo Subir_cambio "+error);
            }
        }

        public bool Bajar_cambio()
        {
            try
            {
                if(cambio_actual > 0)
                {
                    cambio_actual--;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception error)
            {

                throw new Exception("Ocurrio un error en el metodo Bajar_cambio "+error);
            }
        }

        public void Acelerar(float vel_objetivo)
        {
            try
            {
                if(vel_objetivo > 0 && vel_objetivo > vel_actual && vel_objetivo <= 100)
                {
                    vel_actual = vel_objetivo;
                }
                else
                {
                    throw new Exception("La velocidad objetivo debe estar entre 1-100 km/h");
                }
            }
            catch (Exception error)
            {

                throw new Exception("Ocurrio un error en el metodo Acelerar "+error);
            }
        }

        public void Frenar(float vel_objetivo)
        {
            try
            {
                if (vel_objetivo < vel_actual && vel_objetivo >= 0)
                {
                    vel_actual = vel_objetivo;
                }
                else
                {
                    throw new Exception("La velocidad objetivo debe ser menor a "+vel_actual);
                }
            }
            catch (Exception error)
            {

                throw new Exception("Ocurrio un error en el metodo Acelerar " + error);
            }
        }



    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app_encycla.Clases
{
    internal class Bicicleta
    {
        //ATRIBUTOS
        private byte num_serie;
        private string marca;
        private string color;

        //CONSTRUCTOR
        public Bicicleta(byte num_serie)
        {
            Num_serie = num_serie;
            marca = "encycla";
            color = "azul";
        }

        //ACCESORES
        public byte Num_serie { get => num_serie; set => num_serie = value; }
        public string Marca { get => marca;}
        public string Color { get => color;}
    }
}

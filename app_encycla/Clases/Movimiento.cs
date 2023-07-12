using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app_encycla.Clases
{
    internal class Movimiento
    {
        //ATRIBUTOS
        private Bicicleta bicicleta;
        private Usuario usuario;

        //CONSTRUCTOR
        public Movimiento(Bicicleta bicicleta, Usuario usuario)
        {
            this.bicicleta = bicicleta;
            this.usuario = usuario;
        }

        //ACCESORES
        internal Bicicleta Bicicleta { get => bicicleta;}
        internal Usuario Usuario { get => usuario;}
    }
}

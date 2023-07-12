using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using punto_error.Interfaces;

namespace punto_error.Clases
{
	//CLASE CELULAR
    internal class Celular : IError
    {
        public string Mostrar_Error()
        {
			try
			{
				string text_rt = "Error enviado a la pantalla";

				return text_rt;
			}
			catch (Exception error)
			{

				throw new Exception ("Ocurrio un error en el metodo Mostrar_error de la clase Celular " + error);
			}
        }
    }
}

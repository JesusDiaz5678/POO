using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using punto_error.Interfaces;

namespace punto_error.Clases
{
    //clase website
    internal class Website : IError
    {
        public string Mostrar_Error()
        {
			try
			{
                string text_rt = "window.alert(Error)";

                return text_rt;
            }
			catch (Exception error)
			{

				throw new Exception ("Ocurrio un error en la clase website "+error);
			}
        }
    }
}

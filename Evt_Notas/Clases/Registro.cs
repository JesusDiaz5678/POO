using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Evt_Notas.Eventos;

namespace Evt_Notas.Clases
{
    internal class Registro
    {
        //DEFINIMOS PORCENTAJES
        internal float porc_nota = 0.25f;

        // DECLARO ATRIBUTO DE LA CLASE PUBLISHER
        // NO LO INSTANCIO, SOLO DECLARO
        internal Publisher_Becas publicador;


        //STOR, CONSTRUCTOR VACIO
        // CONSTRUCTOR DOMIN
        public Registro()
        {

        }


        //CREAMOS EL METODO PARA MANEJAR EL EVENTO
        // Se ejecuta ante del evento
        internal void EventHandler()
        {
            //probamos esto
            Console.WriteLine("Estoy manejando el evento...");
        }

        //METODOS
        internal float Calcular_Nota_Final(float n1, float n2, float n3, float n4)
        {
            try
            {
                float nota_final = 0;

                if (n1 >= 0 && n1 <= 5
                    && n2 >= 0 && n2 <= 5
                    && n3 >= 0 && n3 <= 5
                    && n4 >= 0 && n4 <= 5)
                {
                    nota_final = n1 * porc_nota + n2 * porc_nota + n3 * porc_nota + n4 * porc_nota;

                    //EL PUBLICADOR TIENE CONSTRUCTOR POR DEFECTO

                    //1. SE INSTANCIA EL PUBLISHER, ARRIBA LO DECLARAMOS
                    publicador = new Publisher_Becas();

                    //2. SUBCRIBIR A LOS EVENTOS. los rayitos sale para indicarnos que es un evento
                    //la subcripcion de un evento se hace con un += con el manejador de event EventHandler
                    //Para desubcribirse es con -=
                    publicador.evt_beca += EventHandler;

                    //AHORA SI PUEDO LLAMAR AL METODO DEL EVENTO
                    publicador.Informar_Beca_Excelencia(nota_final);
                    publicador.Informar_Beca_Superior(nota_final);

                    return nota_final;

                }
                else
                {
                    throw new Exception("Error calculando nota final");
                }

            }
            

            catch (Exception error)
            {

                throw new Exception ("Error calculando nota \n" + error.ToString());
            }
        }


    }
}

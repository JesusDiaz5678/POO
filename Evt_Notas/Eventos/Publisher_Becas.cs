using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evt_Notas.Eventos
{
    internal class Publisher_Becas
    {
        //DELEGADO QUE VA APUNTAR METODOS VOID
        internal delegate void delegado_beca();

        //DECLARAMOS EL EVENTO con el delegado que me va apuntar a el
        internal event delegado_beca evt_beca; //asi se llama el evento

        //ATRIBUTOS
        internal float min_nota_beca_s = 4.2f;
        internal float min_nota_beca_e = 4.2f;

        //LOS METODOS SON LA OFERTA DEL PUBLICADOR
        //OFERTA DEL PUBLICADOR(METODOS)
        public void Informar_Beca_Superior(float nota)
        {
            try
            {
                //PRIMERO DEBO PREGUNTAR QUE ALGUIEN ESTA SUBCRITO AL EVENTO
                //EN TIEMPO DE EJECUCION SALE UN NULL
                //YO DEBO ESTAR SUBCRITO AL EVENTO PARA INVOCAR AL METODO DEL EVENTO

                if(evt_beca != null)
                {
                    //AQUI ESTOY LEVANTANDO EL APUNTADOS, SABER DONDE ESTA GUARDADO EN LA MEMORIA
                    evt_beca();

                    if(nota >= min_nota_beca_s)
                    {
                        //OJO, ESTO ES SOLO PARA VER QUE ESTA FUNCIONANO, NO USE ESTO
                        Console.WriteLine("Le informo que Gana Beca Superior");
                    }
                }

                else
                {
                    //PUEDO TIRAR UNA EXCEPTION,ES UN EVENTO
                    Console.WriteLine("NO SE HA SUBCRIPTO AL EVENTO");
                }
            }
            catch (Exception error)
            {

                throw new Exception ("Error método IBS, publisher \n"+ error);
            }
        }
        public void Informar_Beca_Excelencia(float nota)
        {
            try
            {
                //PRIMERO DEBO PREGUNTAR QUE ALGUIEN ESTA SUBCRITO AL EVENTO
                //EN TIEMPO DE EJECUCION SALE UN NULL
                //YO DEBO ESTAR SUBCRITO AL EVENTO PARA INVOCAR AL METODO DEL EVENTO

                if (evt_beca != null)
                {
                    //AQUI ESTOY LEVANTANDO EL APUNTADOS, SABER DONDE ESTA GUARDADO EN LA MEMORIA
                    evt_beca();

                    if (nota >= min_nota_beca_e && nota <= min_nota_beca_s)
                    {
                        //OJO, ESTO ES SOLO PARA VER QUE ESTA FUNCIONANO, NO USE ESTO
                        Console.WriteLine("Le informo que Gana Beca Excelencia");
                    }
                }

                else
                {
                    //PUEDO TIRAR UNA EXCEPTION,ES UN EVENTO
                    Console.WriteLine("NO SE HA SUBCRIPTO AL EVENTO");
                }
            }
            catch (Exception error)
            {

                throw new Exception("Error método IBS, publisher \n"+error);
            }
        }
    }
}

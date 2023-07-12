using System.IO; //para trabajar liberia de archivos planos
using b_Torneo23.Clases; //Debo importar la biblioteca de clases, la invoco
namespace C_torneo23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            try
            {
                //Creo una lista jugadores
                List<Jugador> l_jugadores = Cargar_jugadores("C:\\Users\\JESUS ALBERTO\\Desktop\\UNIVERSIDAD\\PROGRAMACION Y DISEÑO ORIENTADO\\ARCHIVOS_TXT\\jugador1.txt");
                List<Torneo> l_torneos = Cargar_torneos("C:\\Users\\JESUS ALBERTO\\Desktop\\UNIVERSIDAD\\PROGRAMACION Y DISEÑO ORIENTADO\\ARCHIVOS_TXT\\d_torneo.txt");
                List<Tecnico> l_tecnicos = Cargar_tecnicos("C:\\Users\\JESUS ALBERTO\\Desktop\\UNIVERSIDAD\\PROGRAMACION Y DISEÑO ORIENTADO\\ARCHIVOS_TXT\\tecnico1.txt", l_torneos);

                
                //List<string> l_cursos = new List<string>();
                


                if (l_jugadores.Count == 0)
                {
                    Console.WriteLine("Error en la carga de los jugadores, esta vacio o con problemas");
                }
                else
                {
                    foreach (Jugador elemento in l_jugadores)
                    {
                        Console.WriteLine(elemento.Nombre.ToString());
                    }
                }


                if (l_torneos.Count == 0)
                {
                    Console.WriteLine("Error en la carga de los Torneos, esta vacio o con problemas");
                }
                else
                {
                    Console.WriteLine("\n\n");
                    foreach (Torneo elemento in l_torneos)
                    {
                        Console.WriteLine(elemento.Nombre.ToString());
                    }
                }
                Escenario wembley = new Escenario("Estadio de wembley", "Londres", 80000);
                /*l_cursos.Add("AFA");
                //l_cursos.Add("UEFA");
                //l_tecnicos.Add(new Tecnico("Salvador Bilardo", l_torneos, l_cursos));
                l_tecnicos.Add(new Tecnico("Carlos Ancelotti", l_torneos, l_cursos));*/

                Console.WriteLine("\nTecnicos\n" + l_tecnicos[0] + "\n" + l_tecnicos[1]);

                Equipo Colombia = new Equipo("Colombia", Cargar_jugadores("C:\\Users\\JESUS ALBERTO\\Desktop\\UNIVERSIDAD\\PROGRAMACION Y DISEÑO ORIENTADO\\ARCHIVOS_TXT\\jugador1.txt"), l_tecnicos[0]);
                Equipo Inglaterra = new Equipo("Inglaterra", Cargar_jugadores("C:\\Users\\JESUS ALBERTO\\Desktop\\UNIVERSIDAD\\PROGRAMACION Y DISEÑO ORIENTADO\\ARCHIVOS_TXT\\jugador1.txt"), l_tecnicos[1]);
                Enfrentamiento Fecha1 = new Enfrentamiento(wembley, Colombia, Inglaterra, DateTime.Now.AddDays(1));


                Console.WriteLine("\n\n");
                Console.WriteLine(Fecha1.Eq_local.Nombre + " VS "+ Fecha1.Eq_visitante.Nombre);
                Console.WriteLine(Fecha1.Gol_local + " VS " + Fecha1.Gol_visitante);
                Fecha1.Anotar_gol_local();
                Fecha1.Anotar_gol_local();
                Fecha1.Anotar_gol_visitantes();
                Console.WriteLine(Fecha1.Gol_local + " VS " + Fecha1.Gol_visitante);
                Fecha1.Finalizar_partido();
                Fecha1.Elegir_destacado();
                Console.WriteLine("El jugador destacado es: "+Fecha1.Jugador_destacado.Nombre);
            }
            catch (Exception error)
            {

                throw new Exception ("");
            }
            
        }

        //funcion
        private static List<Jugador> Cargar_jugadores(string ruta) //Debe devolver la lista de jugadores
        {
            List<Jugador> l_aux_jug = new List<Jugador>();
            try
            {
                //Lee el archivo y lo carga al Buffer
                StreamReader arc_jug = new StreamReader(ruta); //ahi esta la ruta
                string linea = arc_jug.ReadLine();
                string[] arr_jug;
                //DEFINO AUXILIAR

                //Validar tryparse
                DateTime aux_fec;
                Jugador.l_posiciones aux_pos; //variable de tipo enum, por eso es publico
                ushort nro_aux;

                //Compruebo que no este vacia
                while (linea != null)
                {   
                    arr_jug = linea.Split('|');

                    //Funcion tryparse
                    //compruebo el auxiliar de fecha
                    //Trate de comprobar este string en un datetime, si sale bien, me lo envia para aca
                    if (arr_jug.Length == 5
                        && DateTime.TryParse(arr_jug[1], out aux_fec)
                        &&Enum.TryParse(arr_jug[2], out aux_pos)
                        && ushort.TryParse(arr_jug[4], out nro_aux))
                    {

                        //Si me sale verdadero, lo puedo convertir
                        //me crea un nuevo jugador y me lo agrega a la lista
                        l_aux_jug.Add(new Jugador(arr_jug[0], aux_fec, arr_jug[3], nro_aux, aux_pos));


                    }

                    linea = arc_jug.ReadLine();
                                        
                }
                arc_jug.Close();
                return l_aux_jug;
                
            }
            catch (FileNotFoundException) //catch no encontrado
            {

                return l_aux_jug; //Envio la lista vacia, verifico despues el tamaño
            }

            catch(Exception error) //Catch general
            {
                return l_aux_jug;
            }
        }


        //Funcion Torneo
        private static List<Torneo> Cargar_torneos (string ruta2)
        {
            List<Torneo> l_aux_torneo = new List<Torneo>();
            try
            {
                StreamReader arc_torneo = new StreamReader(ruta2);
                string linea = arc_torneo.ReadLine();
                string[] arr_torneo;

                while(linea != null)
                {
                    arr_torneo = linea.Split("|");
                    l_aux_torneo.Add(new Torneo(arr_torneo[0]));
                    linea = arc_torneo.ReadLine();
                }

                arc_torneo.Close();
                return l_aux_torneo;

            }
            catch (FileNotFoundException)
            {
                return l_aux_torneo;
                
            }
            catch(Exception error)
            {
                return l_aux_torneo;
            }
        }


        //Funcion de Tecnico
        private static List<Tecnico> Cargar_tecnicos(string ruta3, List<Torneo> l_torneos)
        {
            List<Tecnico> l_aux_tecnico = new List<Tecnico>();
            List<string> l_cursos = new List<string>();
            try
            {
                StreamReader arc_tecnico = new StreamReader(ruta3);
                string linea = arc_tecnico.ReadLine();
                string[] arr_tecnico;
                string[] arr_cursos;

                //Validar tryparse
                DateTime aux_fec;

                while (linea != null)
                {
                    arr_tecnico = linea.Split("|");
                    if (arr_tecnico.Length == 3 &&
                        !string.IsNullOrEmpty(arr_tecnico[0]) &&
                        DateTime.TryParse(arr_tecnico[1], out aux_fec) &&
                        !string.IsNullOrEmpty(arr_tecnico[2]))
                    {
                        arr_cursos = arr_tecnico[2].Split(";");

                        for (int i = 0; i < arr_cursos.Length; i++)
                        {
                            l_cursos.Add(arr_cursos[i]);
                        }

                        l_aux_tecnico.Add(new Tecnico(arr_tecnico[0], l_torneos, l_cursos));
                    }
                    linea = arc_tecnico.ReadLine();
                }

                arc_tecnico.Close();

                return l_aux_tecnico;

            }
            catch (FileNotFoundException)
            {

                return l_aux_tecnico;
            }
            catch (Exception)
            {
                return l_aux_tecnico;
            }
        }
        
    }   
}
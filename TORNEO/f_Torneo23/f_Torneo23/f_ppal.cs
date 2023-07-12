using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using b_Torneo23.Clases;

namespace f_Torneo23
{
    public partial class f_ppal : Form
    {
        private List<Jugador> l_jugadores, l_aux_jugadores;
        private List<Tecnico> l_tecnicos;
        private List<Equipo> l_equipos;
        private static  List<Torneo> l_torneo;
        private List<Escenario> l_escenarios;
        private List<Enfrentamiento> l_enfrentamientos;
        private static List<String> l_jugadores_str;
        private static List<String> l_equipos_str;
        private static List<Taquilla> l_taquillas;
        private static List<Boleta> l_aux_boletas;

        public f_ppal()
        {
            InitializeComponent();
            //se instancias las listas aca en el constructor

            l_jugadores_str = new List<String>();
            l_aux_boletas = new List<Boleta>();
            l_equipos_str = new List<String>();
            l_jugadores = new List<Jugador>();
            l_aux_jugadores = new List<Jugador>();
            l_tecnicos = new List<Tecnico>();
            l_equipos = new List<Equipo>();
            l_enfrentamientos = new List<Enfrentamiento>();
            l_torneo = new List<Torneo>();
            l_escenarios = new List<Escenario>();
            l_escenarios.Add(new Escenario("Estadio Atanasio Girardot", "Av 74, Medellín", 42000));
            l_escenarios.Add(new Escenario("Estadio el Campín", "Carrera 30, Bogotá", 45000));
            cb_Escenario.DataSource = l_escenarios;
            dt_Fecha.CustomFormat = "dd/MM/yyyy hh:mm:ss";
            dt_Fecha.Format = DateTimePickerFormat.Custom;
            l_taquillas = new List<Taquilla>();


            //cargar
            if (cb_Escenario.SelectedItem != null)
            {

                cb_l_taquillas.DataSource = ((Escenario)(cb_Escenario.SelectedItem)).L_taquillas;
            }
           
            
        }

        private void b_cargar_equipo_Click(object sender, EventArgs e)
        {
            try
            {
                //lb_Jugadores.DataSource = Cargar_jugadores(obtener_ruta());
                l_jugadores = Cargar_jugadores(obtener_ruta());
                


                //lb_Jugadores.DataSource = l_jugadores;

                
                

                /*        
                        
                foreach (Jugador objeto in l_jugadores)
                {
                    if (l_aux_jugadores.Contains(objeto))
                    {
                        encontrado = true;
                    }
                }

                if (encontrado)
                {
                    MessageBox.Show("un jugador no puede estar en dos equipos", "ERROR");
                }
                else
                {
                    foreach (Jugador objeto in l_jugadores)
                    {
                        l_aux_jugadores.Add(objeto);
                    }
                    lb_Jugadores.DataSource = l_jugadores;
                }

                */
                
                
                    lb_Jugadores.DataSource = l_jugadores;
                
            }
            catch(Exception)
            {

            }
        }

        private static List<Jugador> Cargar_jugadores(string ruta)
        {
            List<Jugador> l_aux_jug = new List<Jugador>();
            try
            {
                StreamReader arc_jugador = new StreamReader(ruta);
                string linea = arc_jugador.ReadLine();
                string[] arr_jug;
                DateTime aux_fec;
                //como enum lo pusimos publico en la biblioteca de clases, en la clase jugador, se puede llamar
                Jugador.l_posiciones aux_pos;
                ushort nro_dorsal;

                while (linea != null)
                {
                    arr_jug = linea.Split('|');
                    if (arr_jug.Length == 5 && DateTime.TryParse(arr_jug[1], out aux_fec) && Enum.TryParse(arr_jug[2], out aux_pos) && ushort.TryParse(arr_jug[4], out nro_dorsal))
                    {
                        l_aux_jug.Add(new Jugador(arr_jug[0], aux_fec, arr_jug[3], nro_dorsal, aux_pos));
                    }

                    linea = arc_jugador.ReadLine();
                }
                arc_jugador.Close();


                return l_aux_jug;

            }
            catch (FileNotFoundException)
            {
                return l_aux_jug;
            }
            catch
            {
                return l_aux_jug;
            }
        }

        private static List<Torneo> Cargar_torneo(string ruta)
        {
            List<Torneo> l_aux_torneo = new List<Torneo>();
            try
            {
                StreamReader arc_torneo = new StreamReader(ruta);
                string linea = arc_torneo.ReadLine();

                while (linea != null)
                {
                    l_aux_torneo.Add(new Torneo(linea));


                    linea = arc_torneo.ReadLine();
                }

                arc_torneo.Close();
                return l_aux_torneo;
            }
            catch (FileNotFoundException)
            {
                return l_aux_torneo;
            }
            catch
            {
                return l_aux_torneo;
            }

        }


        private static List<Tecnico> Cargar_tecnicos(string ruta)
        {
            List<Tecnico> l_aux_tec = new List<Tecnico>();
            try
            {
                Random aleatorio = new Random();
                List<Torneo> l_torneos_x_tec = new List<Torneo>();
                short pos_torneo = 0;
                StreamReader arc_tec = new StreamReader(ruta);
                string linea = arc_tec.ReadLine();
                string[] arr_tec;
                string[] arr_cursos;



                if (l_torneo.Count > 0)
                {
                    while (linea != null)
                    {
                        //para cada técnico
                        l_torneos_x_tec.Add(l_torneo[aleatorio.Next(0, l_torneo.Count())]);
                        l_torneos_x_tec.Add(l_torneo[aleatorio.Next(0, l_torneo.Count())]);



                        arr_tec = linea.Split("|");
                        if (arr_tec.Length > 0)
                        {
                            l_aux_tec.Add(new Tecnico(arr_tec[0],
                                l_torneos_x_tec,
                                //los spliteo y con .ToLust<string> lo convierto a lista de strings para ya tener mi lista de cursos de string.
                                arr_tec[1].Split(';').ToList<string>()));
                        }

                        linea = arc_tec.ReadLine();
                    }

                    arc_tec.Close();
                }
                return l_aux_tec;
            }
            catch (FileNotFoundException)
            {
                return l_aux_tec;
            }
            catch (Exception)
            {
                return l_aux_tec;
            }



        }

        private static string obtener_ruta()
        {
            try
            {
                OpenFileDialog ventanaArchivo;

                do
                {
                    ventanaArchivo = new OpenFileDialog();
                    ventanaArchivo.Filter = "TXT | *.txt";

                } while (ventanaArchivo.ShowDialog() != DialogResult.OK);

                return ventanaArchivo.FileName;


            }
            catch (Exception e)
            {
                throw new Exception("Ocurrió un error Obtieniendo la ruta \n "+ e);
            }
        }

        private void b_cargar_tecnicos_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Seleccione primero el archivo de torneos");
                l_torneo = Cargar_torneo(obtener_ruta());
                cb_Torneos.DataSource = l_torneo;
                if(l_torneo.Count > 0)
                {
                    MessageBox.Show("Ahora seleccione el archivo de tecnicos");
                    l_tecnicos = Cargar_tecnicos(obtener_ruta());
                    lb_Tecnicos.DataSource = l_tecnicos;
                    b_cargar_tecnicos.Enabled = false;
                }
                else
                {
                    throw new Exception("Hubo un error en el boton cargar tecnicos");
                }


                
            }
            catch(Exception error)
            {
                throw new Exception("Ocurrio un error en el boton cargar tecnicos " + error);
            }
        }

        private void b_crear_equipo_Click(object sender, EventArgs e)
        {
            //boton equipo
            //Equipo auxiliarEquipo;
            bool encontrado = false;
            try
            {
                if (lb_Jugadores.Items.Cast<Jugador>().ToList().Count() > 0 &&
                    lb_Tecnicos.SelectedItems.Count == 1 &&
                    tb_Nombre_eq.Text.Length > 0 &&
                    !string.IsNullOrEmpty(tb_Nombre_eq.Text) &&
                    !string.IsNullOrWhiteSpace(tb_Nombre_eq.Text))
                {
                    //l_equipos.Add(new Equipo(tb_Nombre_eq.Text, lb_Jugadores.Items.Cast<Jugador>().ToList(),
                        //(Tecnico)lb_Tecnicos.SelectedItem));

                    /*
                    foreach (Jugador jug in lb_Jugadores.Items.Cast<Jugador>().ToList())
                    {
                        if (l_jugadores_str.Contains(jug.ToString()))
                        {
                            encontrado = true;
                        }
                        else
                        {
                            l_jugadores_str.Add(jug.ToString());
                        }

                    }
                    if (l_equipos_str.Contains(tb_Nombre_eq.Text))
                    {
                        MessageBox.Show("El nombre de equipo " + tb_Nombre_eq.Text + " está en uso");
                    }
                    else
                    {
                        l_equipos_str.Add(tb_Nombre_eq.Text);
                    }

                    if (encontrado)
                    {
                        MessageBox.Show("No se creo el equipo, revise si no esta usando los mismos jugadores");
                    }
                    else
                    {
                        l_equipos.Add(new Equipo(tb_Nombre_eq.Text, lb_Jugadores.Items.Cast<Jugador>().ToList(), (Tecnico)lb_Tecnicos.SelectedItem));
                    }
                    */

                    foreach(Equipo eq in l_equipos)
                    {
                        foreach(Jugador jug1 in eq.L_jugadores)
                        {
                            foreach (Jugador jug2 in lb_Jugadores.Items.Cast<Jugador>().ToList())
                            {
                                if (jug2.Nombre.Equals(jug1.Nombre))
                                    encontrado = true;
                            }
                        }
                    }
                    if (encontrado)
                        MessageBox.Show("Por favor resvise la lista de jugadores");
                    else
                        l_equipos.Add(new Equipo(tb_Nombre_eq.Text, lb_Jugadores.Items.Cast<Jugador>().ToList(), (Tecnico)lb_Tecnicos.SelectedItem));


                    lb_Equipos.DataSource = null;
                    lb_Equipos.DataSource = l_equipos;


                    tb_Nombre_eq.ResetText();

                    l_tecnicos.RemoveAt(lb_Tecnicos.SelectedIndex);
                    lb_Tecnicos.DataSource = null;
                    lb_Tecnicos.DataSource = l_tecnicos;

                    l_jugadores.Clear();
                    lb_Jugadores.DataSource = l_jugadores;
                }

                
            }
            catch (Exception error)
            {
                throw new Exception("Hubo un error en el boton crear equipo" + error);
            }

        }

        private void b_crear_enf_Click(object sender, EventArgs e)
        {
            try
            {
                
                    tb_jug_destacado.Text = null;
                    b_fin_partido.Enabled = true;
                    b_anota_local.Enabled = true;
                    b_Anota_visitante.Enabled = true;
                    b_anula_local.Enabled = true;
                    b_Anula_visitante.Enabled = true;
                
                
                    

                List<Equipo> l_equipos_sel = new List<Equipo>();
                Enfrentamiento obj_enfren;
                DateTime Fecha_hora_enf;

                if (lb_Equipos.SelectedItems.Count != 2)
                    MessageBox.Show("Debe seleccionar dos equipos");
                else
                {

                    l_equipos_sel = lb_Equipos.SelectedItems.Cast<Equipo>().ToList();


                    obj_enfren = new Enfrentamiento(l_equipos_sel.ElementAt(0), l_equipos_sel.ElementAt(1), (Escenario)cb_Escenario.SelectedItem,
                        dt_Fecha.Value);

                    l_enfrentamientos.Add(obj_enfren);

                    tb_marc_local.Text = obj_enfren.Gol_local.ToString();
                    tb_marc_vis.Text = obj_enfren.Gol_visitante.ToString();

                    tb_nombre_local.Text = obj_enfren.Eq_local.Nombre;
                    tb_nombre_vis.Text = obj_enfren.Eq_visitante.Nombre;


                    cb_Enfrentamientos.DataSource = null;
                    cb_Enfrentamientos.DataSource = l_enfrentamientos;


                    if (cb_Escenario.SelectedItem != null)
                    {
                        cb_l_taquillas.DataSource = ((Escenario)(cb_Escenario.SelectedItem)).L_taquillas;
                    }

                }

            }
            catch (Exception error)
            {
                MessageBox.Show("Ocurrió un error cargando archivo de jugadores \n" + error + "\n");
            }
        }

        private void b_anota_local_Click(object sender, EventArgs e)
        {
            try
            {
                 
                 ((Enfrentamiento)cb_Enfrentamientos.SelectedItem).Anotar_gol_local();
                 tb_marc_local.Text = ((Enfrentamiento)cb_Enfrentamientos.SelectedItem).Gol_local.ToString();
                
                
            }

            catch (Exception error)
            {
                MessageBox.Show("Ocurrió un error anota local \n" + error + "\n");
            }
        }

        private void b_anula_local_Click(object sender, EventArgs e)
        {
            try
            {
                
                ((Enfrentamiento)cb_Enfrentamientos.SelectedItem).Anular_gol_local();
                tb_marc_local.Text = ((Enfrentamiento)cb_Enfrentamientos.SelectedItem).Gol_local.ToString();
                
            }

            catch (Exception error)
            {
                MessageBox.Show("Ocurrió un error anula local \n" + error + "\n");
            }
        }

        private void b_Anota_visitante_Click(object sender, EventArgs e)
        {
            try
            {
                ((Enfrentamiento)cb_Enfrentamientos.SelectedItem).Anotar_gol_vistantes();
                tb_marc_vis.Text = ((Enfrentamiento)cb_Enfrentamientos.SelectedItem).Gol_visitante.ToString();
            }

            catch (Exception error)
            {
                MessageBox.Show("Ocurrió un error anota visitante local \n" + error + "\n");
            }
        }

        private void b_Anula_visitante_Click(object sender, EventArgs e)
        {
            try
            {
                ((Enfrentamiento)cb_Enfrentamientos.SelectedItem).Anular_gol_vistantes();
                tb_marc_vis.Text = ((Enfrentamiento)cb_Enfrentamientos.SelectedItem).Gol_visitante.ToString();
            }

            catch (Exception error)
            {
                MessageBox.Show("Ocurrió un error anula visitante \n" + error + "\n");
            }
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void cb_Enfrentamientos_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                
                if(((Enfrentamiento)cb_Enfrentamientos.SelectedItem) != null){
                    tb_nombre_local.Text = ((Enfrentamiento)cb_Enfrentamientos.SelectedItem).Eq_local.Nombre.ToString();
                    tb_nombre_vis.Text = ((Enfrentamiento)cb_Enfrentamientos.SelectedItem).Eq_visitante.Nombre.ToString();
                    tb_marc_local.Text = ((Enfrentamiento)cb_Enfrentamientos.SelectedItem).Gol_local.ToString();
                    tb_marc_vis.Text = ((Enfrentamiento)cb_Enfrentamientos.SelectedItem).Gol_visitante.ToString();
                    if(((Enfrentamiento)cb_Enfrentamientos.SelectedItem).Finalizo)
                        tb_jug_destacado.Text = ((Enfrentamiento)cb_Enfrentamientos.SelectedItem).Jugador_destacado.ToString();
                }
              
                /*
                tb_nombre_local.Text = l_enfrentamientos[cb_Enfrentamientos.SelectedIndex].Eq_local.Nombre.ToString();
                tb_nombre_vis.Text = l_enfrentamientos[cb_Enfrentamientos.SelectedIndex].Eq_visitante.Nombre.ToString();
                tb_marc_local.Text = l_enfrentamientos[cb_Enfrentamientos.SelectedIndex].Gol_local.ToString();
                tb_marc_vis.Text = l_enfrentamientos[cb_Enfrentamientos.SelectedIndex].Gol_visitante.ToString();
                if (l_enfrentamientos[cb_Enfrentamientos.SelectedIndex].Finalizo)
                {
                    tb_jug_destacado.Text = l_enfrentamientos[cb_Enfrentamientos.SelectedIndex].Jugador_destacado.ToString();
                    
                    b_fin_partido.Enabled = false;
                    b_anota_local.Enabled = false;
                    b_Anota_visitante.Enabled = false;
                    b_anula_local.Enabled = false;
                    b_Anula_visitante.Enabled = false;
                    
                }
                else
                {
                    b_fin_partido.Enabled = true;
                    b_anota_local.Enabled = true;
                    b_Anota_visitante.Enabled = true;
                    b_anula_local.Enabled = true;
                    b_Anula_visitante.Enabled = true;
                }
                    
                */

            }
            catch(Exception error)
            {
                throw new Exception("hubo un error en el indice " + error);
            }
                
                
                
            
        }

        private void b_venderBoleta_Click(object sender, EventArgs e)
        {
            try
            {
                if(cb_l_taquillas.SelectedItem != null)
                {
                    if (((Taquilla)cb_l_taquillas.SelectedItem).Abierta == true)
                    {
                        ((Taquilla)(cb_l_taquillas.SelectedItem)).L_boletas_vender[0].Llenar_Boleta(((Torneo)cb_Torneos.SelectedItem), ((Enfrentamiento)cb_Enfrentamientos.SelectedItem),
                        ((Escenario)cb_Escenario.SelectedItem), ((DateTime)dt_Fecha.Value));
                        ((Taquilla)(cb_l_taquillas.SelectedItem)).L_boletas_vender[0].Llamar_Boleta();
                        ((Taquilla)(cb_l_taquillas.SelectedItem)).Vender_boleta();
                    }
                    else
                    {
                        MessageBox.Show("Taquilla cerrada");
                    }
                    
                }
            
            }
            catch(Exception qq)
            {
                throw new Exception("Hubo un error en vender boleta " + qq);
            }


        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (l_enfrentamientos[cb_Enfrentamientos.SelectedIndex].Finalizo)
                {
                    MessageBox.Show("No puede finalizar un partido que ya esta finalizado", "ERROR");
                }
                else
                {
                    l_enfrentamientos[cb_Enfrentamientos.SelectedIndex].Finalizar_partido();

                    //como se finalizó el partido podemos elegir el jg_destacado
                    l_enfrentamientos[cb_Enfrentamientos.SelectedIndex].Elegir_destacado();
                    tb_jug_destacado.Text = l_enfrentamientos[cb_Enfrentamientos.SelectedIndex].Jugador_destacado.ToString();
                    //desactivo el boton finalizar partido para que no finalice y desactivo los goles
                    b_fin_partido.Enabled = false;
                    b_anota_local.Enabled = false;
                    b_Anota_visitante.Enabled = false;
                    b_anula_local.Enabled = false;
                    b_Anula_visitante.Enabled = false;

                    //l_enfrentamientos.RemoveAt(cb_Enfrentamientos.SelectedIndex);
                    
                }

               l_enfrentamientos[cb_Enfrentamientos.SelectedIndex].Finalizar_partido();
            }
            catch(Exception error)
            {
                throw new Exception("Hubo un error en finalizar partido " +error);
            }
        }
    }
}

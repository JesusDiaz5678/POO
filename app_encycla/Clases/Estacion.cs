using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app_encycla.Clases
{
    internal class Estacion
    {
        //ATRIBUTOS
        private string nombre_estacion;
        private string direccion;
        private byte num_bic_total = 10;
        private byte num_serial = 1;
        //private List<Bicicleta> l_bicicletas;
        private List<Bicicleta> l_bicicletas_disponibles;
        private List<Bicicleta> l_bicicletas_prestadas;
        private List<Movimiento> l_movimientos;

        //CONSTRUCTOR
        public Estacion(string nombre_estacion, string direccion)
        {
            Nombre_estacion = nombre_estacion;
            Direccion = direccion;
            l_bicicletas_disponibles = new List<Bicicleta>();
            l_bicicletas_prestadas = new List<Bicicleta>();
            l_movimientos = new List<Movimiento>();


            for (int i = 1; i <= num_bic_total; i++)
            {
                L_bicicletas_disponibles.Add(new Bicicleta(num_serial));
                num_serial++;
            }
        }

        //ACCESORES
        public string Nombre_estacion
        {
            get => nombre_estacion;
            set
            {
                if (value.Length > 1 && !String.IsNullOrWhiteSpace(value)
                    && !String.IsNullOrEmpty(value))
                {
                    nombre_estacion = value;
                }
                else
                {
                    throw new Exception("El nombre de la estacion debe ser mayor a un digito, no puede tener espacios en blanco ni nulos");
                }
            }

        }
        public string Direccion
        {
            get => direccion;

            set
            {
                if (value.Length > 4 && !String.IsNullOrWhiteSpace(value)
                    && !String.IsNullOrEmpty(value))
                {
                    direccion = value;
                }
                else
                {
                    throw new Exception("La direccion de la estacion debe ser mayor a cuatro digito, no puede tener espacios en blanco ni nulos");
                }
            }

        }

        internal List<Bicicleta> L_bicicletas_disponibles { get => l_bicicletas_disponibles; }
        internal List<Bicicleta> L_bicicletas_prestadas { get => l_bicicletas_prestadas; }
        internal List<Movimiento> L_movimientos { get => l_movimientos; }

        //METODOS
        public string Prestar_bicicleta(Usuario usuario)
        {

            try
            {
                string text = "";

                if (l_bicicletas_disponibles.Count > 0)
                {
                    l_movimientos.Add(new Movimiento(l_bicicletas_disponibles[0], usuario));
                    l_bicicletas_prestadas.Add(l_bicicletas_disponibles[0]);
                    l_bicicletas_disponibles.RemoveAt(0);
                    text = "\n==========================\n"
                        + "PRESTAR BICICLETA:\n"
                       + "numero de serie: #"
                        + l_bicicletas_prestadas[0].Num_serie.ToString()
                        + "\nUSUARIO: " + usuario.Nombre.ToString() +
                        "\n==========================";

                }
                else
                {
                    text = "\nLo siento, no hay bicicletas disponibles en el momento\n";
                }
                return text;
            }
            catch (Exception error)
            {

                throw new Exception("Ocurrio un error en el metodo prestar_bicicleta " + error);
            }
        }
        public string Cons_bicicletas_prestadas()
        {
            try
            {
                string text = "";
                if (l_bicicletas_prestadas.Count > 0)
                {
                    text = text + ("\n==========================\n"
                        + "LISTA DE BICICLETAS PRESTADAS\n");
                    foreach (Bicicleta item in l_bicicletas_prestadas)
                    {
                        text = text + ("numero de serie: #" + item.Num_serie.ToString() + "\n");
                    }

                    text = text + ("LISTA DE MOVIMIENTOS:\n");
                    foreach (Movimiento item in l_movimientos)
                    {
                        text = text + ("numero de serie: #" + item.Bicicleta.Num_serie.ToString()
                            + "\nnombre del usuario: "
                            + item.Usuario.Nombre.ToString()
                            + "\n");
                    }

                    text = text + ("==========================\n");
                }
                else
                {
                    text = ("\nNo se ha prestado ninguna bicicleta a ningun usuario hasta el momento\n");
                }
                return text;
            }
            catch (Exception error)
            {

                throw new Exception("Ocurrio un error en el método Cons_bicicletas_prestadas");
            }
        }

        public string Cons_bicicletas_disponibles()
        {
            try
            {
                string text = "";
                if (l_bicicletas_disponibles.Count > 0)
                {
                    text = text + ("\n==========================\n"
                        + "LISTA DE BICICLETAS DISPONIBLES\n");
                    foreach (Bicicleta item in l_bicicletas_disponibles)
                    {
                        text = text + ("numero de serie: #" + item.Num_serie.ToString() + "\n");
                    }
                    text = text + ("==========================\n");
                }
                else
                {
                    text = ("\nNo hay bicicletas disponibles en la estacion " + nombre_estacion);
                }
                return text;
            }
            catch (Exception error)
            {
                throw new Exception("Ocurrio un error en el metodo Cons_bicicletas_disponibles " + error);
            }
        }

        public string Recibir_bicicleta_prestada(Usuario usuario)
        {
            try
            {
                string text = "";
                if (l_bicicletas_prestadas.Count == 0)
                {
                    text = "\nNo se ha prestado ninguna bicicleta a ningun usuario hasta el momento\n";
                }

                foreach (Movimiento item in l_movimientos.Reverse<Movimiento>())
                {
                    if (item.Usuario.Equals(usuario))
                    {
                        l_movimientos.Remove(item);

                        foreach (Bicicleta bici in l_bicicletas_prestadas.Reverse<Bicicleta>())
                        {
                            if (bici.Num_serie.Equals(item.Bicicleta.Num_serie))
                            {
                                l_bicicletas_disponibles.Add(bici);
                                l_bicicletas_prestadas.Remove(bici);
                                text = "\n==========================\n"
                                + "El usuario " + usuario.Nombre + " a devuelto la bicicleta\n"
                                + "==========================\n";
                            }

                        }
                    }
                    else
                    {
                        text = "\nEl usuario "+ usuario.Nombre +" NO TIENE BICICLETA";
                    }
                }
                    return text;
            }
            catch (Exception error)
            {

                throw new Exception("Ocurrio un error en Recibir_bicicleta_prestada " + error);
            }
        }
    }
}

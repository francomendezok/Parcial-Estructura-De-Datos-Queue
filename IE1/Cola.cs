using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IE1
{
    public class Cola
    {
        public Paciente inicio;
        public Paciente fin;

        public Cola()
        {
            inicio = null;
            fin = null;
        }
        public void Insertar(Paciente paciente)
        {
            if (inicio == null)
            {
                inicio = paciente;
                fin = paciente;
            }
            else
            {
                bool unico = ChequearDNIUnico(paciente.dni);
                if (!unico)
                {
                    MessageBox.Show("El DNI ya está registrado.");
                    return;
                }
                fin.siguiente = paciente;
                fin = paciente;
            }
        }
        public void Listar(ListBox lstEspera)
        {
            lstEspera.Items.Clear();
            if (inicio == null) lstEspera.Items.Add("No hay pacientes");
            else
            {
                Paciente aux = inicio;
                while (aux != null)
                {
                    lstEspera.Items.Add($"{aux.dni}, {aux.apellido}, {aux.nombre}");
                    aux = aux.siguiente;
                }
            }
        }

        public bool ChequearDNIUnico(string dni)
        {
            Paciente aux = inicio;
            bool unico = true;

            while (aux != null)
            {
                if (aux.dni == dni) unico = false;
                aux = aux.siguiente;
            }
            return unico;
        }

        public int Contar()
        {
            int contador = 0;
            Paciente aux = inicio;
            while (aux != null)
            {
                contador++;
                aux = aux.siguiente;
            }
            return contador;
        }

        public void ListarSoloSiguientes(ListBox lstEspera)
        {
            lstEspera.Items.Clear();
            if (inicio == null || inicio.siguiente == null) lstEspera.Items.Add("No hay pacientes");
            else
            {
                Paciente aux = inicio.siguiente;
                while (aux != null)
                {
                    lstEspera.Items.Add($"{aux.dni}, {aux.apellido}, {aux.nombre}");
                    aux = aux.siguiente;
                }
            }
        }

        public void Eliminar()
        {
            if (inicio != null)
            {
                Paciente aux = inicio;
                inicio = aux.siguiente;
                aux = null;

                if (inicio == null) fin = null;
            }
            else
            {
                MessageBox.Show("No hay pacientes en la cola.");
                return;
            }
        }

        public bool ModificarPaciente(string dni, string nuevoApellido, string nuevoNombre)
        {
            Paciente aux = inicio;
            while (aux != null)
            {
                if (aux.dni == dni)
                {
                    aux.apellido = nuevoApellido;
                    aux.nombre = nuevoNombre;
                    MessageBox.Show("Datos del paciente actualizados correctamente.");
                    return true;
                }
                aux = aux.siguiente;
            }
            MessageBox.Show("El paciente no está registrado.");
            return false;
        }

        public bool CancelarTurno(string dni)
        {
            if (inicio == null)
            {
                MessageBox.Show("No hay pacientes en la cola.");
                return false;
            }

            if (inicio == fin)
            {
                MessageBox.Show("No se puede cancelar el turno del paciente. Ya fue llamado.");
                return false;
            }

            Paciente actual = inicio;
            Paciente anterior = null;

            while (actual != null)
            {
                if (actual.dni == dni)
                {
                    if (anterior == null) // Eliminar el primer elemento
                    {
                        inicio = actual.siguiente;
                        if (inicio == null) fin = null; // Si la cola queda vacía
                    }
                    else
                    {
                        anterior.siguiente = actual.siguiente;
                        if (actual == fin) fin = anterior; // Si se elimina el último elemento
                    }

                    MessageBox.Show("Paciente eliminado de la cola.");
                    return true;
                }

                anterior = actual;
                actual = actual.siguiente;
            }

            MessageBox.Show("El paciente no está registrado en la cola.");
            return false;
        }

        public void Grabar(string nombreArchivo)
        {
            StreamWriter escribir = new StreamWriter(nombreArchivo, false);

            List<string> data = ObtenerDatosLista();

            if (data.Count > 0)
            {
                foreach (string item in data)
                {
                    escribir.WriteLine(item);
                }
            }
            else
            {
                MessageBox.Show("No hay Pacientes en espera");
            }

            escribir.Close();
        }

        public List<string> ObtenerDatosLista()
        {
            List<string> data = new List<string>();
            Paciente aux = inicio;
            while (aux != null)
            {
                data.Add($"{aux.dni}, {aux.apellido}, {aux.nombre}");
                aux = aux.siguiente;
            }
            return data;
        }

        public void Leer(string nombreArchivo)
        {
            if (File.Exists(nombreArchivo))
            {
                using (StreamReader reader = new StreamReader(nombreArchivo))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null) // streamreader avanza automaticamente en el while //
                    {
                        string[] partes = line.Split(",");
                        if (partes.Length == 3)
                        {
                            Paciente paciente = new Paciente(partes[0], partes[1], partes[2], ""); // DNI, Nombre, Apellido
                            Insertar(paciente);
                        }
                    }
                }
            }
        }


    }
}

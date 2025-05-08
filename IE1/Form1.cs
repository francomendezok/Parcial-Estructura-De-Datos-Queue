using System.Collections.Generic;

namespace IE1
{
    public partial class Form1 : Form
    {
        Cola colaClinica;
        Cola colaGuardia;
        Cola colaPediatria;
        frmClinica clinica;
        frmGuardia guardia;
        frmPediatría pediatría;

        public Form1()
        {
            InitializeComponent();

            colaClinica = new Cola();
            colaGuardia = new Cola();
            colaPediatria = new Cola();

            colaClinica.Leer("clinica.txt");
            colaGuardia.Leer("guardia.txt");
            colaPediatria.Leer("pediatria.txt");

            clinica = new frmClinica(colaClinica);
            guardia = new frmGuardia(colaGuardia);
            pediatría = new frmPediatría(colaPediatria);

            clinica.Show();
            guardia.Show();
            pediatría.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var pantalla = Screen.PrimaryScreen.WorkingArea;
            int halfWidth = pantalla.Width / 2;
            int halfHeight = pantalla.Height / 2;

            this.Size = new Size(halfWidth, halfHeight);
            this.Location = new Point(0, 0);

            clinica.Size = new Size(halfWidth, halfHeight);
            clinica.Location = new Point(halfWidth, 0);
            guardia.Size = new Size(halfWidth, halfHeight);
            guardia.Location = new Point(0, halfHeight);
            pediatría.Size = new Size(halfWidth, halfHeight);
            pediatría.Location = new Point(halfWidth, halfHeight);
            colaClinica.Listar(lstClinica);
            colaGuardia.Listar(lstGuardia);
            colaPediatria.Listar(lstPediatria);
        }

        private void cmdInsertar_Click(object sender, EventArgs e)
        {
            if (ValidarInformacion())
            {
                Paciente paciente = new Paciente(txtDNI.Text, txtApellido.Text, txtNombre.Text, cmbEspecialidad.Text);
                int cuenta;
                switch (paciente.especialidad)
                {
                    case "Clínica":
                        colaClinica.Insertar(paciente);
                        colaClinica.Grabar("clinica.txt");
                        clinica.mostrarConsultario();
                        cuenta = colaClinica.Contar();
                        if (cuenta == 1) clinica.ConsultorioRandom();
                        colaClinica.Listar(lstClinica);
                        break;
                    case "Guardia":
                        colaGuardia.Insertar(paciente);
                        colaGuardia.Grabar("guardia.txt");
                        guardia.mostrarConsultario();
                        cuenta = colaGuardia.Contar();
                        if (cuenta == 1) guardia.ConsultorioRandom();
                        colaGuardia.Listar(lstGuardia);
                        break;
                    case "Pediatría":
                        colaPediatria.Insertar(paciente);
                        colaPediatria.Grabar("pediatria.txt");
                        pediatría.mostrarConsultario();
                        cuenta = colaPediatria.Contar();
                        if (cuenta == 1) pediatría.ConsultorioRandom();
                        colaPediatria.Listar(lstPediatria);
                        break;
                    default:
                        MessageBox.Show("Especialidad no válida.");
                        break;
                }
                Limpiar();
            }
        }

        private void cmdLlamar_Click(object sender, EventArgs e)
        {
            if (optClinica.Checked || optGuardia.Checked || optPediatria.Checked)
            {
                if (optClinica.Checked)
                {
                    if (colaClinica.inicio == null)
                    {
                        MessageBox.Show("No hay pacientes en la cola de Clínica.");
                        return;
                    }
                    else
                    {
                        colaClinica.Eliminar();
                        colaClinica.Grabar("clinica.txt");
                        colaClinica.Listar(lstClinica);
                        clinica.mostrarConsultario();
                        clinica.ConsultorioRandom();
                    }
                }
                else if (optGuardia.Checked)
                {
                    if (colaGuardia.inicio == null)
                    {
                        MessageBox.Show("No hay pacientes en la cola de Guardia.");
                        return;
                    }
                    else
                    {
                        colaGuardia.Eliminar();
                        colaGuardia.Grabar("guardia.txt");
                        colaGuardia.Listar(lstGuardia);
                        guardia.mostrarConsultario();
                        guardia.ConsultorioRandom();
                    }
                }
                else if (optPediatria.Checked)
                {
                    if (colaPediatria.inicio == null)
                    {
                        MessageBox.Show("No hay pacientes en la cola de Pediatría.");
                        return;
                    }
                    else
                    {
                        colaPediatria.Eliminar();
                        colaPediatria.Grabar("pediatria.txt");
                        colaPediatria.Listar(lstPediatria);
                        pediatría.mostrarConsultario();
                        pediatría.ConsultorioRandom();
                    }
                }
                txtApellido.Clear();
                txtNombre.Clear();
                txtDNI.Clear();
                cmbEspecialidad.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("Seleccione una especialidad.");
                return;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (ValidarInformacion())
            {
                string dni = txtDNI.Text;
                string especialidad = cmbEspecialidad.Text;
                bool modificado = false;

                switch (especialidad)
                {
                    case "Clínica":
                        modificado = colaClinica.ModificarPaciente(dni,txtApellido.Text, txtNombre.Text);
                        colaClinica.Grabar("clinica.txt");
                        clinica.mostrarConsultario();
                        colaClinica.Listar(lstClinica);
                        break;
                    case "Guardia":
                        modificado = colaGuardia.ModificarPaciente(dni,txtApellido.Text, txtNombre.Text);
                        colaGuardia.Grabar("guardia.txt");
                        guardia.mostrarConsultario();
                        colaGuardia.Listar(lstGuardia);
                        break;
                    case "Pediatría":
                        modificado = colaPediatria.ModificarPaciente(dni, txtApellido.Text, txtNombre.Text);
                        colaPediatria.Grabar("pediatria.txt");
                        pediatría.mostrarConsultario();
                        colaPediatria.Listar(lstPediatria);
                        break;
                    default:
                        MessageBox.Show("Especialidad no válida.");
                        break;
                }
                if (modificado) Limpiar();
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (cmbEspecialidad.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, seleccione especialidad al cual cancelar el turno.");
                return;
            }


            else
            {
                string especialidad = cmbEspecialidad.Text;

                switch (especialidad)
                {
                    case "Clínica":
                        colaClinica.Eliminar();
                        colaClinica.Grabar("clinica.txt");
                        colaClinica.Listar(lstClinica);
                        break;
                    case "Guardia":
                        colaGuardia.Eliminar();
                        colaGuardia.Grabar("guardia.txt");
                        colaGuardia.Listar(lstGuardia);
                        break;
                    case "Pediatría":
                        colaPediatria.Eliminar();
                        colaPediatria.Grabar("pediatria.txt");
                        colaPediatria.Listar(lstPediatria);
                        break;
                    default:
                        MessageBox.Show("Especialidad no válida.");
                        break;
                }
            }
        }

        public void Limpiar()
        {
            txtApellido.Clear();
            txtNombre.Clear();
            txtDNI.Clear();
            cmbEspecialidad.SelectedIndex = -1;
        }

        public bool ValidarInformacion()
        {
            if (String.IsNullOrEmpty(txtApellido.Text) ||
                String.IsNullOrEmpty(txtNombre.Text) ||
                String.IsNullOrEmpty(txtDNI.Text) ||
                String.IsNullOrEmpty(cmbEspecialidad.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return false;
            }
            else if (txtDNI.Text.Length > 8)
            {
                MessageBox.Show("El DNI debe tener 8 dígitos máximo.");
                return false;
            }
            return true;
        }
    }
}
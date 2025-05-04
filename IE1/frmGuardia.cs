using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IE1
{
    public partial class frmGuardia : Form
    {
        private Cola cola;
        public frmGuardia(Cola cola)
        {
            InitializeComponent();
            this.cola = cola;
            this.cola.Listar(lstProximosGuardia);
            mostrarConsultario();
            ConsultorioRandom();
        }


        public void mostrarConsultario()
        {
            int cantidad = cola.Contar();

            cola.ListarSoloSiguientes(lstProximosGuardia);

            if (cola.inicio != null)
            {
                lblNombreGuardia.Text = $"{cola.inicio.apellido.ToUpper()}, {cola.inicio.nombre}";
                lblDNIGuardia.Text = $"{cola.inicio.dni}";
                lblCantidadGuardia.Text = cantidad == 1 ? $"Paciente en espera: {cantidad}" : $"Pacientes en espera: {cantidad}";
            }
            else
            {
                lblNombreGuardia.Text = "APELLIDO, Nombre ";
                lblDNIGuardia.Text = "XX.XXX.XXX ";
                lblCantidadGuardia.Text = "Pacientes en espera:";
            }
        }

        private void frmGuardia_Load(object sender, EventArgs e)
        {

        }

        public void ConsultorioRandom()
        {
            Random rnd = new Random();
            int consultorio = rnd.Next(1, 5);

            if (cola.inicio == null) lblConsultorioGuardia.Text = "-";
            else lblConsultorioGuardia.Text = "GUA" + consultorio.ToString("000#");
        }
    }
}

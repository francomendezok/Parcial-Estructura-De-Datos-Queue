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
    public partial class frmPediatría : Form
    {
        private Cola cola;
        public frmPediatría(Cola cola)
        {
            InitializeComponent();
            this.cola = cola;
            this.cola.Listar(lstProximosPediatria);
            mostrarConsultario();
            ConsultorioRandom();
        }

        public void mostrarConsultario()
        {
            int cantidad = cola.Contar();

            cola.ListarSoloSiguientes(lstProximosPediatria);

            if (cola.inicio != null)
            {
                lblNombrePediatria.Text = $"{cola.inicio.apellido.ToUpper()}, {cola.inicio.nombre}";
                lblDNIPediatria.Text = $"{cola.inicio.dni}";
                lblCantidadPediatria.Text = cantidad == 1 ? $"Paciente en espera: {cantidad}" : $"Pacientes en espera: {cantidad}";
            }
            else
            {
                lblNombrePediatria.Text = "APELLIDO, Nombre ";
                lblDNIPediatria.Text = "XX.XXX.XXX ";
                lblCantidadPediatria.Text = "Pacientes en espera:";
            }
        }

        private void frmPediatría_Load(object sender, EventArgs e)
        {

        }

        public void ConsultorioRandom()
        {
            Random rnd = new Random();
            int consultorio = rnd.Next(1, 5);

            if (cola.inicio == null) lblConsultorioPediatria.Text = "-";
            else lblConsultorioPediatria.Text = "PED" + consultorio.ToString("000#");
        }
    }
}

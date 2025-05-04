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
    public partial class frmClinica : Form
    {
        private Cola cola;
        public frmClinica(Cola cola)
        {
            InitializeComponent();
            this.cola = cola;
            this.cola.Listar(lstProximosClinica);
            mostrarConsultario();
            ConsultorioRandom();
        }


        public void mostrarConsultario()
        {
            int cantidad = cola.Contar();

            cola.ListarSoloSiguientes(lstProximosClinica);

            if (cola.inicio != null)
            {
                lblNombreClinica.Text = $"{cola.inicio.apellido.ToUpper()}, {cola.inicio.nombre}";
                lblDNIClinica.Text = $"{cola.inicio.dni}";
                lblCantidadClinica.Text = cantidad == 1 ? $"Paciente en espera: {cantidad}" : $"Pacientes en espera: {cantidad}";
            }
            else
            {
                lblNombreClinica.Text = "APELLIDO, Nombre ";
                lblDNIClinica.Text = "XX.XXX.XXX ";
                lblCantidadClinica.Text = "Pacientes en espera:";
            }
        }

        public void ConsultorioRandom()
        {
            Random rnd = new Random();
            int consultorio = rnd.Next(1, 5);

            if (cola.inicio == null) lblConsultorioClinica.Text = "-";
            else lblConsultorioClinica.Text = "CLI" + consultorio.ToString("000#");
        }

    }
}

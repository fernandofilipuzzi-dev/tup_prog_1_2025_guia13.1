
using Ejercicio4.Models;
using System.Numerics;

namespace Ejercicio4
{
    public partial class Principal : Form
    {
        Servicio servicio = new Servicio();

        public Principal()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Fdatos fdatos = new Fdatos();

            while (servicio.VerCantidadVehiculos() < 15 && fdatos.ShowDialog() == DialogResult.OK)
            {
                string p = fdatos.tbPatente.Text;
                double k = Convert.ToDouble(fdatos.tbKilometros.Text);

                servicio.CrearVehiculo(p, k);

                //para poder saber que vehiculos fueron cargados
                listBoxPatentes.Items.Add(p);

                fdatos.tbPatente.Clear();
                fdatos.tbKilometros.Clear();
            }
        }

        private void btnCargarViaje_Click(object sender, EventArgs e)
        {
            Fdatos fdatos = new Fdatos();

            if (fdatos.ShowDialog() == DialogResult.OK)
            {
                string p = fdatos.tbPatente.Text;
                double k = Convert.ToDouble(fdatos.tbKilometros.Text);

                servicio.CargarViaje(p, k);

                labelCantViajes.Text = servicio.VerCantidadViajes().ToString();
            }
            else 
            {
                MessageBox.Show("Canceló la carga del viaje");
            }
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            servicio.Ordenar();

            Fresumen fresumen = new Fresumen();
            fresumen.listbBoxPatentes.Items.Clear();
            double kms = 0;
            for (int n = 0; n < servicio.VerCantidadVehiculos(); n++)
            {
                Vehiculo ve = servicio.VerVehiculo(n);
                kms += ve.VerKilometraje();
                fresumen.listbBoxPatentes.Items.Add($"{ve.VerKilometraje(),10:f2} {ve.VerPatente(),-10}");
            }

            if (servicio.VerCantidadViajes() > 0 && servicio.VerCantidadVehiculos() > 0)
            {
                double promedio = kms / servicio.VerCantidadViajes();
                fresumen.listbBoxPatentes.Items.Add($"Promedio: {promedio:f2}");
                fresumen.listbBoxPatentes.Items.Add($"Viajes: {servicio.VerCantidadViajes()}");
            }
            else
            {
                fresumen.listbBoxPatentes.Items.Add($"No hay vehiculos o viajes realizados");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

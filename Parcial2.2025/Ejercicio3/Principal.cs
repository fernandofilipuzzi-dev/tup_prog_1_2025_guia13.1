using Ejercicio3.Models;
using System.Numerics;

namespace Ejercicio3
{
    public partial class Principal : Form
    {
        Vehiculo[] vehiculos = new Vehiculo[15];
        int cantVehiculos = 0;
        int viajes = 0;

        public void CrearVehiculo(string p, double k)
        {
            if (cantVehiculos < 15)
            {
                Vehiculo v = new Vehiculo();
                v.CrearVehiculo(p, k);

                vehiculos[cantVehiculos] = v;

                cantVehiculos++;
            }
        }

        public Vehiculo VerVehiculo(int idx)
        {
            Vehiculo ve = null;

            if (idx >= 0 && idx < cantVehiculos)
            {
                ve = vehiculos[idx];
            }

            return ve;
        }

        public void CargarViaje(string p, double k)
        {
            int idx = Buscar(p);

            if (idx > -1)
            {
                vehiculos[idx].CargarViaje(k);
                viajes++;
            }
        }

        int Buscar(string p)
        {
            int idx = -1;
            int n = 0;
            while (idx == -1 && n < cantVehiculos)
            {
                if (vehiculos[n].VerPatente() == p)
                {
                    idx = n;
                }
                n++;
            }
            return idx;
        }

        public void Ordenar()
        {
            for (int p = 0; p < cantVehiculos - 1; p++)
            {
                for (int c = p + 1; c < cantVehiculos; c++)
                {
                    if (vehiculos[c].VerKilometraje() < vehiculos[p].VerKilometraje())
                        Intercambiar(p, c);
                }
            }
        }

        void Intercambiar(int p, int c)
        {
            Vehiculo ve = vehiculos[p];
            vehiculos[p] = vehiculos[c];
            vehiculos[c] = ve;
        }

        public int VerCantidadVehiculos()
        {
            return cantVehiculos;
        }

        internal int VerCantidadViajes()
        {
            return viajes;
        }

        public Principal()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Fdatos fdatos = new Fdatos();

            while (cantVehiculos < 15 && fdatos.ShowDialog() == DialogResult.OK)
            {
                string p = fdatos.tbPatente.Text;
                double k = Convert.ToDouble(fdatos.tbKilometros.Text);

                CrearVehiculo(p, k);

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

                CargarViaje(p, k);

                labelCantViajes.Text = viajes.ToString();
            }
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            Ordenar();

            Fresumen fresumen = new Fresumen();
            fresumen.listbBoxPatentes.Items.Clear();
            double kms = 0;
            for (int n = 0; n < cantVehiculos; n++)
            {
                Vehiculo ve = vehiculos[n];
                fresumen.listbBoxPatentes.Items.Add($"{ve.VerKilometraje(),10:f2} {ve.VerPatente(),-10}");
            }

            if (viajes > 0 && cantVehiculos > 0)
            {
                double promedio = kms / viajes;
                fresumen.listbBoxPatentes.Items.Add($"Promedio: {promedio:f2}");
                fresumen.listbBoxPatentes.Items.Add($"Viajes: {viajes}");
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

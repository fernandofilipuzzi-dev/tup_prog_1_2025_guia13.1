using System.Numerics;

namespace Ejercicio1
{
    public partial class Principal : Form
    {
        string[] patentes = new string[15];
        double[] kilometros = new double[15];
        int vehiculos = 0;
        int viajes = 0;

        void CrearVehiculo(string p, double k)
        {
            if (vehiculos < 15)
            {
                patentes[vehiculos] = p;
                kilometros[vehiculos] = k;
                vehiculos++;
            }
        }

        void CargarViaje(string p, double k)
        {
            int idx = Buscar(p);

            if (idx > -1)
            {
                kilometros[vehiculos] += k;
                viajes++;
            }
        }

        int Buscar(string p)
        {
            int idx = -1;
            int n = 0;
            while (idx == -1 && n < vehiculos)
            {
                if (patentes[n] == p)
                {
                    idx = n;
                }
                n++;
            }
            return idx;
        }

        public void Ordenar()
        {
            for (int p = 0; p < vehiculos-1; p++)
            {
                for (int c = p+1; c < vehiculos; c++)
                {
                    if (kilometros[c] < kilometros[p])
                        Intercambiar(p, c);
                }
            }
        }

        void Intercambiar(int p, int c)
        {
            string patente = patentes[p];
            patentes[p] = patentes[c];
            patentes[c] = patente;

            double kms = kilometros[p];
            kilometros[p] = kilometros[c];
            kilometros[c] = kms;
        }

        public Principal()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Fdatos fdatos = new Fdatos();

            while (vehiculos < 15 && fdatos.ShowDialog() == DialogResult.OK)
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

                labelCantViajes.Text= viajes.ToString();
            }
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            Ordenar();

            Fresumen fresumen = new Fresumen();
            fresumen.listbBoxPatentes.Items.Clear();
            double kms = 0;
            for (int n = 0; n < vehiculos; n++)
            {
                kms += kilometros[n];
                fresumen.listbBoxPatentes.Items.Add($"{kilometros[n],10:f2} {patentes[n],-10}");
            }

            if (viajes > 0 && vehiculos > 0)
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
    }
}

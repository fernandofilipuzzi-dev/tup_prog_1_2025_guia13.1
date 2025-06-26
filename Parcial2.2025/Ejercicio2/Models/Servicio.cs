using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2.Models
{
    internal class Servicio
    {
        string[] patentes = new string[15];
        double[] kilometros = new double[15];
        int vehiculos = 0;
        int viajes = 0;

        public void CrearVehiculo(string p, double k)
        {
            if (vehiculos < 15)
            {
                patentes[vehiculos] = p;
                kilometros[vehiculos] = k;
                vehiculos++;
            }
        }

        public void VerVehiculo(int idx, out string p,out double k)
        {
            p = "";
            k = 0;
            if (idx >= 0 && idx < vehiculos)
            {
                p = patentes[idx];
                k = kilometros[idx];
            }
        }

        public void CargarViaje(string p, double k)
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
            for (int p = 0; p < vehiculos - 1; p++)
            {
                for (int c = p + 1; c < vehiculos; c++)
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

        public int VerCantidadVehiculos()
        {
            return vehiculos;
        }

        internal int VerCantidadViajes()
        {
            return viajes;
        }
    }
}

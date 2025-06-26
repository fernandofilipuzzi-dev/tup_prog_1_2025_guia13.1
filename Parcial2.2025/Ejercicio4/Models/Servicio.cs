using Ejercicio4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4.Models
{
    internal class Servicio
    {
        Vehiculo[] vehiculos = new Vehiculo[15];
        int cantVehiculos = 0;
        int viajes = 0;

        public void CrearVehiculo(string p, double k)
        {
            if (cantVehiculos < 15)
            {
                Vehiculo v = new Vehiculo();
                v.CrearVehiculo(p,k);

                vehiculos[cantVehiculos] = v;

                cantVehiculos++;
            }
        }

        public Vehiculo VerVehiculo(int idx)
        {
            Vehiculo ve = null;

            if (idx >= 0 && idx < cantVehiculos)
            {
                ve=vehiculos[idx];
            }

            return ve;
        }

        public void CargarViaje(string p, double k)
        {
            int idx = Buscar(p);

            if (idx > -1)
            {
                vehiculos[idx].CargarViaje( k);
                viajes++;
            }
        }

        int Buscar(string p)
        {
            int idx = -1;
            int n = 0;
            while (idx == -1 && n < cantVehiculos)
            {
                if (vehiculos[n].VerPatente()==p)
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
    }
}

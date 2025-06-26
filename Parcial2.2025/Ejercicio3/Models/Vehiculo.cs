using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3.Models
{
    public class Vehiculo
    {
        string patente;
        double kilometraje;

        public void CrearVehiculo(string pat, double km)
        {
            patente = pat;
            kilometraje = km;
        }

        public void CargarViaje(double kilometro)
        {
            kilometraje += kilometro;
        }

        public string VerPatente()
        {
            return patente;
        }

        internal  double VerKilometraje()
        {
            return kilometraje;
        }
    }
}

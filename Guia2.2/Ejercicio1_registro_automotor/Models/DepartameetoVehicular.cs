using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    public class DepartamentoVehicular
    {
        Random azar=new Random();
        int nroRegistro;
        int nroSerie;

        public int CantidadRegistros { get { return registros.Count; } }

        ArrayList registros = new ArrayList();

        public RegistroVehiculo RegistrarVehiculo(Persona propietario)
        {
            string patente=GenerarPatente();
            int serie = nroSerie++;
            RegistroVehiculo nuevo = new RegistroVehiculo(patente, propietario, serie);

            registros.Add(nuevo);

            return nuevo;
        }

        public string GenerarPatente()
        {
            int nroCarac = azar.Next(100);

            char C1 = (char)azar.Next((int)'A', (int)'Z' + 1);
            char C2 = (char)azar.Next((int)'A', (int)'Z' + 1);

            string patente = $"{C1}{C2}{nroRegistro++:000}";

            return patente;
        }

        public RegistroVehiculo VerRegistro(int idx)
        {
            if (idx >= 0 && idx < CantidadRegistros)
            { 
                return registros[idx] as RegistroVehiculo;
            }
            return null;
        }
    }
}

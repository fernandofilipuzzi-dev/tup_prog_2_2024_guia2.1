using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    public class RegistroVehiculo
    {
        public string Patente { get; private set; }
        public string Serie { get; private set; }

        public Persona Propietario { get; set; }
             


        public RegistroVehiculo(string patente,  Persona propietario, int serie) 
        {
            Patente = patente;
            Serie = serie.ToString("0000");
            Propietario = propietario;
        }

        public string VerDetalle()
        {
            return $" *{Patente}\r\n *{Serie}\r\n *{Propietario.Nombre}(dni:{Propietario.DNI})";
        }

    }
}

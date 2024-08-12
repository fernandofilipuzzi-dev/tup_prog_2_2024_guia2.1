using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2.Models
{
    public class Liquidacion
    {
        public int Año { get; private set; }
        public int Mes { get; private set; }
        public Empleado Empleado { get; private set; }

        public double MontoBase { get; set; }


        public double PorcAntiguedad
        {
            get
            {
                double porc = (Año - Empleado.AñoContrato) * 1.0 / 20 * 100;
                return porc;
            }
        }
        public double MontoAntiguedad
        {
            get
            {
                return MontoBase * PorcAntiguedad / 100d;
            }
        }

        public double HorasExtras50
        {
            get; private set;
        }

        public double MontoHorasExtras50
        {
            get
            {
                return MontoBase / 40d * HorasExtras50 ;
            }
        }

        public double HorasExtras100
        {
            get; private set;
        }

        public double MontoHorasExtras100
        {
            get
            {
                return MontoBase / 40d * HorasExtras100 ;
            }
        }

        public double Nominal
        {
            get
            {
                return MontoBase + MontoAntiguedad + MontoHorasExtras50 + MontoHorasExtras100;
            }
        }

        public double PorcObraSocial { get; set; }

        public double MontoObraSocial
        {
            get
            {
                return Nominal * 3d / 100;
            }
        }

        public double PorcJubilacion { get; set; }
        public double MontoJubilacion
        {
            get
            {
                return PorcJubilacion * 18d / 100;
            }
        }

        public double PorcGremial { get; set; }
        public double MontoGremial
        {
            get
            {
                return PorcGremial / 100d * Nominal;
            }
        }

        public double Neto
        {
            get
            {
                return Nominal - Neto;
            }
        }

        public double Productividad
        {
            get
            {
                return Neto * 30d / 100d;
            }
        }
        public double ACobrar
        {
            get
            {
                return Neto + Productividad;
            }
        }


        public Liquidacion(Empleado empleado, int año, int mes)
        {
            Empleado = empleado;
            Año = año;
            Mes = mes;
            MontoBase = empleado.MontoBasicoNominal;
            HorasExtras50=empleado.HorasExtras50;
            HorasExtras100 = empleado.HorasExtras100;
        }

        public string VerImpreso()
        {
            string ant = $"Antiguedad ({PorcAntiguedad})";
            string ex50 = $"Extras al 50%({HorasExtras50})";
            string ex100 = $"Extras al 50%({HorasExtras100})";

            string impreso = $@"
Empleado {Empleado.ApellidoNombre}
{"Concepto",30}{"Haberes",20}{"Descuentos",20}
{"Básico",30}{MontoBase,20:f2}{" ",20}
{ant,30}{MontoAntiguedad,20:f2}{" ",20}
{ex50,30}{MontoHorasExtras50,20:f2}{" ",20}
{ex100,30}{MontoHorasExtras100,20:f2}{" ",20}
";
            return impreso;
        }

    }
}

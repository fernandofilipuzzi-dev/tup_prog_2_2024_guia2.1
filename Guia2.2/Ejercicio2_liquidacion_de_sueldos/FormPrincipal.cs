﻿using Ejercicio2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2
{
    public partial class FormPrincipal : Form
    {
        Empresa empresa = new Empresa();

        public FormPrincipal()
        {
            InitializeComponent();

            empresa.AñoActual = 2024;

            
        }

        private void btnRegistrarEmpleado_Click(object sender, EventArgs e)
        {
            //1-caso registrar empleados
            FormRegistrarEmpleado formReg=new FormRegistrarEmpleado();

            if (formReg.ShowDialog() == DialogResult.OK)
            {
                string apellido = formReg.tbApellido.Text;
                string nombre = formReg.tbNombre.Text;

                //harcodeo
                int dni = 40176474;

                double montoBasico = 4000;
                int horaExt50 = 5;
                int horaExt100 = 4;

                Empleado em = empresa.RegistrarEmpleado(dni, apellido, nombre);
                em.MontoBasicoNominal = montoBasico;
                em.HorasExtras50 = horaExt50;
                em.HorasExtras100 = horaExt100;
            }
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            //2- Generar las liquidaciones en un determinado año y mes.

            //harcodeo
            int año = 2024;
            int mes = 8;
            empresa.GenerarLiquidacion(año, mes);
        }

        private void btnMostrarLiquidaciones_Click(object sender, EventArgs e)
        {
            // 3 - Mostrar liquidaciones según año y mes dados.
            tbMultilineauNReciboDeSueldo.Clear();

            int año = 2024;
            int mes = 8;
            int n = 1;
            foreach (Liquidacion liquidacion in empresa.ListarLiquidaciones(año, mes))
            {
                tbMultilineauNReciboDeSueldo.Text += $"---{n++}\r\n";
                tbMultilineauNReciboDeSueldo.Text += liquidacion.VerImpreso();
            }
        }

        //private void btnMostrarReciboSueldo_Click(object sender, EventArgs e)
        //{
        //    int año = 2024;
        //    int mes = 8;
        //    int dni = 40176474;
        //    tbMultilineauNReciboDeSueldo.Text= empresa.MostrarReciboSueldo(año, mes, dni);
        //}
    }
}

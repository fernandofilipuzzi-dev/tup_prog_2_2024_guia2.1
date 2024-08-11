using Ejercicio1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class FormPrincipal : Form
    {
        DepartamentoVehicular dpto = new DepartamentoVehicular();

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona(43402034,"Luisa");
            RegistroVehiculo reg=dpto.RegistrarVehiculo(persona);
                       
            tbImpresoRegistro.Text=reg.VerDetalle();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
         
            lbxRegistros.Items.Clear();
            for (int idx = 0; idx < dpto.CantidadRegistros; idx++)
            {
                RegistroVehiculo reg = dpto.VerRegistro(idx);                
                lbxRegistros.Items.Add(reg.VerDetalle());
            }
        }
    }
}

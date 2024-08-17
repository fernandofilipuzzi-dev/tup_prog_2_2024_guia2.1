namespace Ejercicio2
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnRegistrarEmpleado = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.btnMostrarLiquidaciones = new System.Windows.Forms.Button();
            this.btnMostrarReciboSueldo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(18, 92);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(640, 324);
            this.textBox1.TabIndex = 0;
            // 
            // btnRegistrarEmpleado
            // 
            this.btnRegistrarEmpleado.Location = new System.Drawing.Point(496, 6);
            this.btnRegistrarEmpleado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRegistrarEmpleado.Name = "btnRegistrarEmpleado";
            this.btnRegistrarEmpleado.Size = new System.Drawing.Size(131, 52);
            this.btnRegistrarEmpleado.TabIndex = 1;
            this.btnRegistrarEmpleado.Text = "Registrar Empleado(1)";
            this.btnRegistrarEmpleado.UseVisualStyleBackColor = true;
            this.btnRegistrarEmpleado.Click += new System.EventHandler(this.btnRegistrarEmpleado_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(666, 92);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(302, 324);
            this.listBox1.TabIndex = 2;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(635, 7);
            this.btnGenerar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(163, 51);
            this.btnGenerar.TabIndex = 3;
            this.btnGenerar.Text = "Generar Liquidaciones(2)";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // btnMostrarLiquidaciones
            // 
            this.btnMostrarLiquidaciones.Location = new System.Drawing.Point(806, 8);
            this.btnMostrarLiquidaciones.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMostrarLiquidaciones.Name = "btnMostrarLiquidaciones";
            this.btnMostrarLiquidaciones.Size = new System.Drawing.Size(155, 50);
            this.btnMostrarLiquidaciones.TabIndex = 4;
            this.btnMostrarLiquidaciones.Text = "Mostrar Liquidaciones(3a)";
            this.btnMostrarLiquidaciones.UseVisualStyleBackColor = true;
            this.btnMostrarLiquidaciones.Click += new System.EventHandler(this.btnMostrarLiquidaciones_Click);
            // 
            // btnMostrarReciboSueldo
            // 
            this.btnMostrarReciboSueldo.Location = new System.Drawing.Point(18, 7);
            this.btnMostrarReciboSueldo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMostrarReciboSueldo.Name = "btnMostrarReciboSueldo";
            this.btnMostrarReciboSueldo.Size = new System.Drawing.Size(131, 52);
            this.btnMostrarReciboSueldo.TabIndex = 5;
            this.btnMostrarReciboSueldo.Text = "Mostrar recibo sueldo(3b)";
            this.btnMostrarReciboSueldo.UseVisualStyleBackColor = true;
            this.btnMostrarReciboSueldo.Click += new System.EventHandler(this.btnMostrarReciboSueldo_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 424);
            this.Controls.Add(this.btnMostrarReciboSueldo);
            this.Controls.Add(this.btnMostrarLiquidaciones);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnRegistrarEmpleado);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormPrincipal";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnRegistrarEmpleado;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Button btnMostrarLiquidaciones;
        private System.Windows.Forms.Button btnMostrarReciboSueldo;
    }
}


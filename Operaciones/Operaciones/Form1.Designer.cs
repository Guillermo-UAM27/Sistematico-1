namespace Operaciones
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LblMostrarResultados = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TbNum1 = new System.Windows.Forms.TextBox();
            this.TbNum2 = new System.Windows.Forms.TextBox();
            this.BtnSuma = new System.Windows.Forms.Button();
            this.BtnResta = new System.Windows.Forms.Button();
            this.BtnDivision = new System.Windows.Forms.Button();
            this.BtnMultiplicacion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Programa de operaciones matematicas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese numero1 y numero 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(252, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "numero 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(520, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(230, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "El resultado de la operacion es:";
            // 
            // LblMostrarResultados
            // 
            this.LblMostrarResultados.AutoSize = true;
            this.LblMostrarResultados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMostrarResultados.ForeColor = System.Drawing.Color.OrangeRed;
            this.LblMostrarResultados.Location = new System.Drawing.Point(610, 180);
            this.LblMostrarResultados.Name = "LblMostrarResultados";
            this.LblMostrarResultados.Size = new System.Drawing.Size(85, 29);
            this.LblMostrarResultados.TabIndex = 4;
            this.LblMostrarResultados.Text = "label5";
            this.LblMostrarResultados.Click += new System.EventHandler(this.LblMostrarResultados_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Numero 1";
            // 
            // TbNum1
            // 
            this.TbNum1.Location = new System.Drawing.Point(122, 117);
            this.TbNum1.Name = "TbNum1";
            this.TbNum1.Size = new System.Drawing.Size(100, 26);
            this.TbNum1.TabIndex = 6;
            // 
            // TbNum2
            // 
            this.TbNum2.Location = new System.Drawing.Point(363, 117);
            this.TbNum2.Name = "TbNum2";
            this.TbNum2.Size = new System.Drawing.Size(100, 26);
            this.TbNum2.TabIndex = 7;
            // 
            // BtnSuma
            // 
            this.BtnSuma.Location = new System.Drawing.Point(99, 180);
            this.BtnSuma.Name = "BtnSuma";
            this.BtnSuma.Size = new System.Drawing.Size(87, 38);
            this.BtnSuma.TabIndex = 8;
            this.BtnSuma.Text = "Suma";
            this.BtnSuma.UseVisualStyleBackColor = true;
            this.BtnSuma.Click += new System.EventHandler(this.BtnSuma_Click);
            // 
            // BtnResta
            // 
            this.BtnResta.Location = new System.Drawing.Point(233, 180);
            this.BtnResta.Name = "BtnResta";
            this.BtnResta.Size = new System.Drawing.Size(95, 38);
            this.BtnResta.TabIndex = 9;
            this.BtnResta.Text = "Resta";
            this.BtnResta.UseVisualStyleBackColor = true;
            this.BtnResta.Click += new System.EventHandler(this.BtnResta_Click);
            // 
            // BtnDivision
            // 
            this.BtnDivision.Location = new System.Drawing.Point(233, 224);
            this.BtnDivision.Name = "BtnDivision";
            this.BtnDivision.Size = new System.Drawing.Size(95, 33);
            this.BtnDivision.TabIndex = 10;
            this.BtnDivision.Text = "Division";
            this.BtnDivision.UseVisualStyleBackColor = true;
            this.BtnDivision.Click += new System.EventHandler(this.BtnDivision_Click);
            // 
            // BtnMultiplicacion
            // 
            this.BtnMultiplicacion.Location = new System.Drawing.Point(96, 224);
            this.BtnMultiplicacion.Name = "BtnMultiplicacion";
            this.BtnMultiplicacion.Size = new System.Drawing.Size(126, 39);
            this.BtnMultiplicacion.TabIndex = 11;
            this.BtnMultiplicacion.Text = "Multiplicacion";
            this.BtnMultiplicacion.UseVisualStyleBackColor = true;
            this.BtnMultiplicacion.Click += new System.EventHandler(this.BtnMultiplicacion_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 311);
            this.Controls.Add(this.BtnMultiplicacion);
            this.Controls.Add(this.BtnDivision);
            this.Controls.Add(this.BtnResta);
            this.Controls.Add(this.BtnSuma);
            this.Controls.Add(this.TbNum2);
            this.Controls.Add(this.TbNum1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LblMostrarResultados);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblMostrarResultados;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TbNum1;
        private System.Windows.Forms.TextBox TbNum2;
        private System.Windows.Forms.Button BtnSuma;
        private System.Windows.Forms.Button BtnResta;
        private System.Windows.Forms.Button BtnDivision;
        private System.Windows.Forms.Button BtnMultiplicacion;
    }
}


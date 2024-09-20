namespace Ejercicio_1
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
            this.tbMatriz1 = new System.Windows.Forms.TextBox();
            this.tbMatriz2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lbSalida = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(167, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Suma y Multiplicacion de matrices";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese numero matriz 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ingrese Numero matriz 2";
            // 
            // tbMatriz1
            // 
            this.tbMatriz1.Location = new System.Drawing.Point(266, 97);
            this.tbMatriz1.Name = "tbMatriz1";
            this.tbMatriz1.Size = new System.Drawing.Size(258, 22);
            this.tbMatriz1.TabIndex = 3;
            // 
            // tbMatriz2
            // 
            this.tbMatriz2.Location = new System.Drawing.Point(256, 183);
            this.tbMatriz2.Name = "tbMatriz2";
            this.tbMatriz2.Size = new System.Drawing.Size(268, 22);
            this.tbMatriz2.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(587, 98);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 110);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbSalida
            // 
            this.lbSalida.FormattingEnabled = true;
            this.lbSalida.ItemHeight = 16;
            this.lbSalida.Location = new System.Drawing.Point(256, 275);
            this.lbSalida.Name = "lbSalida";
            this.lbSalida.Size = new System.Drawing.Size(230, 116);
            this.lbSalida.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbSalida);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbMatriz2);
            this.Controls.Add(this.tbMatriz1);
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
        private System.Windows.Forms.TextBox tbMatriz1;
        private System.Windows.Forms.TextBox tbMatriz2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lbSalida;
    }
}


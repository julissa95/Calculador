namespace Calculadora
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
            this.Num1 = new System.Windows.Forms.Button();
            this.Num2 = new System.Windows.Forms.Button();
            this.Num3 = new System.Windows.Forms.Button();
            this.Num4 = new System.Windows.Forms.Button();
            this.Num5 = new System.Windows.Forms.Button();
            this.Num6 = new System.Windows.Forms.Button();
            this.Num7 = new System.Windows.Forms.Button();
            this.Num8 = new System.Windows.Forms.Button();
            this.Num9 = new System.Windows.Forms.Button();
            this.Num0 = new System.Windows.Forms.Button();
            this.Suma = new System.Windows.Forms.Button();
            this.Resta = new System.Windows.Forms.Button();
            this.Multiplicacion = new System.Windows.Forms.Button();
            this.Division = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.Egual = new System.Windows.Forms.Button();
            this.txtOperacion = new System.Windows.Forms.TextBox();
            this.lblOperacion = new System.Windows.Forms.Label();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Num1
            // 
            this.Num1.Location = new System.Drawing.Point(12, 25);
            this.Num1.Name = "Num1";
            this.Num1.Size = new System.Drawing.Size(75, 23);
            this.Num1.TabIndex = 0;
            this.Num1.Text = "1";
            this.Num1.UseVisualStyleBackColor = true;
            this.Num1.Click += new System.EventHandler(this.Num1_Click);
            // 
            // Num2
            // 
            this.Num2.Location = new System.Drawing.Point(12, 119);
            this.Num2.Name = "Num2";
            this.Num2.Size = new System.Drawing.Size(75, 23);
            this.Num2.TabIndex = 1;
            this.Num2.Text = "2";
            this.Num2.UseVisualStyleBackColor = true;
            this.Num2.Click += new System.EventHandler(this.Num2_Click);
            // 
            // Num3
            // 
            this.Num3.Location = new System.Drawing.Point(12, 217);
            this.Num3.Name = "Num3";
            this.Num3.Size = new System.Drawing.Size(75, 23);
            this.Num3.TabIndex = 2;
            this.Num3.Text = "3";
            this.Num3.UseVisualStyleBackColor = true;
            this.Num3.Click += new System.EventHandler(this.Num3_Click);
            // 
            // Num4
            // 
            this.Num4.Location = new System.Drawing.Point(12, 317);
            this.Num4.Name = "Num4";
            this.Num4.Size = new System.Drawing.Size(75, 23);
            this.Num4.TabIndex = 3;
            this.Num4.Text = "4";
            this.Num4.UseVisualStyleBackColor = true;
            this.Num4.Click += new System.EventHandler(this.Num4_Click);
            // 
            // Num5
            // 
            this.Num5.Location = new System.Drawing.Point(12, 405);
            this.Num5.Name = "Num5";
            this.Num5.Size = new System.Drawing.Size(75, 23);
            this.Num5.TabIndex = 4;
            this.Num5.Text = "5";
            this.Num5.UseVisualStyleBackColor = true;
            this.Num5.Click += new System.EventHandler(this.Num5_Click);
            // 
            // Num6
            // 
            this.Num6.Location = new System.Drawing.Point(174, 25);
            this.Num6.Name = "Num6";
            this.Num6.Size = new System.Drawing.Size(75, 23);
            this.Num6.TabIndex = 5;
            this.Num6.Text = "6";
            this.Num6.UseVisualStyleBackColor = true;
            this.Num6.Click += new System.EventHandler(this.Num6_Click);
            // 
            // Num7
            // 
            this.Num7.Location = new System.Drawing.Point(174, 119);
            this.Num7.Name = "Num7";
            this.Num7.Size = new System.Drawing.Size(75, 23);
            this.Num7.TabIndex = 6;
            this.Num7.Text = "7";
            this.Num7.UseVisualStyleBackColor = true;
            this.Num7.Click += new System.EventHandler(this.Num7_Click);
            // 
            // Num8
            // 
            this.Num8.Location = new System.Drawing.Point(174, 217);
            this.Num8.Name = "Num8";
            this.Num8.Size = new System.Drawing.Size(75, 23);
            this.Num8.TabIndex = 7;
            this.Num8.Text = "8";
            this.Num8.UseVisualStyleBackColor = true;
            this.Num8.Click += new System.EventHandler(this.Num8_Click);
            // 
            // Num9
            // 
            this.Num9.Location = new System.Drawing.Point(174, 317);
            this.Num9.Name = "Num9";
            this.Num9.Size = new System.Drawing.Size(75, 23);
            this.Num9.TabIndex = 8;
            this.Num9.Text = "9";
            this.Num9.UseVisualStyleBackColor = true;
            this.Num9.Click += new System.EventHandler(this.Num9_Click);
            // 
            // Num0
            // 
            this.Num0.Location = new System.Drawing.Point(174, 405);
            this.Num0.Name = "Num0";
            this.Num0.Size = new System.Drawing.Size(75, 23);
            this.Num0.TabIndex = 9;
            this.Num0.Text = "0";
            this.Num0.UseVisualStyleBackColor = true;
            this.Num0.Click += new System.EventHandler(this.Num0_Click);
            // 
            // Suma
            // 
            this.Suma.Location = new System.Drawing.Point(319, 55);
            this.Suma.Name = "Suma";
            this.Suma.Size = new System.Drawing.Size(75, 23);
            this.Suma.TabIndex = 10;
            this.Suma.Text = "+";
            this.Suma.UseVisualStyleBackColor = true;
            this.Suma.Click += new System.EventHandler(this.Suma_Click);
            // 
            // Resta
            // 
            this.Resta.Location = new System.Drawing.Point(319, 146);
            this.Resta.Name = "Resta";
            this.Resta.Size = new System.Drawing.Size(75, 23);
            this.Resta.TabIndex = 11;
            this.Resta.Text = "-";
            this.Resta.UseVisualStyleBackColor = true;
            this.Resta.Click += new System.EventHandler(this.Resta_Click);
            // 
            // Multiplicacion
            // 
            this.Multiplicacion.Location = new System.Drawing.Point(319, 246);
            this.Multiplicacion.Name = "Multiplicacion";
            this.Multiplicacion.Size = new System.Drawing.Size(75, 23);
            this.Multiplicacion.TabIndex = 12;
            this.Multiplicacion.Text = "*";
            this.Multiplicacion.UseVisualStyleBackColor = true;
            this.Multiplicacion.Click += new System.EventHandler(this.Multiplicacion_Click);
            // 
            // Division
            // 
            this.Division.Location = new System.Drawing.Point(319, 340);
            this.Division.Name = "Division";
            this.Division.Size = new System.Drawing.Size(75, 23);
            this.Division.TabIndex = 13;
            this.Division.Text = "/";
            this.Division.UseVisualStyleBackColor = true;
            this.Division.Click += new System.EventHandler(this.Division_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblResultado.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(483, 368);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(29, 36);
            this.lblResultado.TabIndex = 15;
            this.lblResultado.Text = "0";
            // 
            // Egual
            // 
            this.Egual.Location = new System.Drawing.Point(489, 119);
            this.Egual.Name = "Egual";
            this.Egual.Size = new System.Drawing.Size(75, 23);
            this.Egual.TabIndex = 16;
            this.Egual.Text = "=";
            this.Egual.UseVisualStyleBackColor = true;
            this.Egual.Click += new System.EventHandler(this.Egual_Click);
            // 
            // txtOperacion
            // 
            this.txtOperacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtOperacion.Location = new System.Drawing.Point(643, 70);
            this.txtOperacion.Name = "txtOperacion";
            this.txtOperacion.Size = new System.Drawing.Size(132, 20);
            this.txtOperacion.TabIndex = 17;
            // 
            // lblOperacion
            // 
            this.lblOperacion.AutoSize = true;
            this.lblOperacion.Location = new System.Drawing.Point(702, 30);
            this.lblOperacion.Name = "lblOperacion";
            this.lblOperacion.Size = new System.Drawing.Size(0, 13);
            this.lblOperacion.TabIndex = 18;
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReiniciar.Location = new System.Drawing.Point(489, 261);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(97, 36);
            this.btnReiniciar.TabIndex = 19;
            this.btnReiniciar.Text = "ReIniciar";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.lblOperacion);
            this.Controls.Add(this.txtOperacion);
            this.Controls.Add(this.Egual);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.Division);
            this.Controls.Add(this.Multiplicacion);
            this.Controls.Add(this.Resta);
            this.Controls.Add(this.Suma);
            this.Controls.Add(this.Num0);
            this.Controls.Add(this.Num9);
            this.Controls.Add(this.Num8);
            this.Controls.Add(this.Num7);
            this.Controls.Add(this.Num6);
            this.Controls.Add(this.Num5);
            this.Controls.Add(this.Num4);
            this.Controls.Add(this.Num3);
            this.Controls.Add(this.Num2);
            this.Controls.Add(this.Num1);
            this.ForeColor = System.Drawing.Color.RosyBrown;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Num1;
        private System.Windows.Forms.Button Num2;
        private System.Windows.Forms.Button Num3;
        private System.Windows.Forms.Button Num4;
        private System.Windows.Forms.Button Num5;
        private System.Windows.Forms.Button Num6;
        private System.Windows.Forms.Button Num7;
        private System.Windows.Forms.Button Num8;
        private System.Windows.Forms.Button Num9;
        private System.Windows.Forms.Button Num0;
        private System.Windows.Forms.Button Suma;
        private System.Windows.Forms.Button Resta;
        private System.Windows.Forms.Button Multiplicacion;
        private System.Windows.Forms.Button Division;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button Egual;
        private System.Windows.Forms.TextBox txtOperacion;
        private System.Windows.Forms.Label lblOperacion;
        private System.Windows.Forms.Button btnReiniciar;
    }
}


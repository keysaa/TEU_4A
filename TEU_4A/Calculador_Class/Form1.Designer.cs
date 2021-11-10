
namespace Calculador_Class
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button15 = new System.Windows.Forms.Button();
            this.btmMultiplicación = new System.Windows.Forms.Button();
            this.btmDivision = new System.Windows.Forms.Button();
            this.btmSuma = new System.Windows.Forms.Button();
            this.btmResta = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button15);
            this.panel1.Controls.Add(this.btmMultiplicación);
            this.panel1.Controls.Add(this.btmDivision);
            this.panel1.Controls.Add(this.btmSuma);
            this.panel1.Controls.Add(this.btmResta);
            this.panel1.Controls.Add(this.btn0);
            this.panel1.Controls.Add(this.btn9);
            this.panel1.Controls.Add(this.btn8);
            this.panel1.Controls.Add(this.btn7);
            this.panel1.Controls.Add(this.btn6);
            this.panel1.Controls.Add(this.btn5);
            this.panel1.Controls.Add(this.btn4);
            this.panel1.Controls.Add(this.btn3);
            this.panel1.Controls.Add(this.btn2);
            this.panel1.Controls.Add(this.btn1);
            this.panel1.Location = new System.Drawing.Point(16, 140);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(523, 255);
            this.panel1.TabIndex = 0;
            // 
            // button15
            // 
            this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button15.Location = new System.Drawing.Point(355, 97);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(75, 23);
            this.button15.TabIndex = 14;
            this.button15.Text = "=";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // btmMultiplicación
            // 
            this.btmMultiplicación.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmMultiplicación.Location = new System.Drawing.Point(397, 68);
            this.btmMultiplicación.Name = "btmMultiplicación";
            this.btmMultiplicación.Size = new System.Drawing.Size(75, 23);
            this.btmMultiplicación.TabIndex = 13;
            this.btmMultiplicación.Text = "*";
            this.btmMultiplicación.UseVisualStyleBackColor = true;
            this.btmMultiplicación.Click += new System.EventHandler(this.btmMultiplicación_Click);
            // 
            // btmDivision
            // 
            this.btmDivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmDivision.Location = new System.Drawing.Point(318, 68);
            this.btmDivision.Name = "btmDivision";
            this.btmDivision.Size = new System.Drawing.Size(75, 23);
            this.btmDivision.TabIndex = 12;
            this.btmDivision.Text = "/";
            this.btmDivision.UseVisualStyleBackColor = true;
            this.btmDivision.Click += new System.EventHandler(this.btmDivision_Click);
            // 
            // btmSuma
            // 
            this.btmSuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmSuma.Location = new System.Drawing.Point(397, 35);
            this.btmSuma.Name = "btmSuma";
            this.btmSuma.Size = new System.Drawing.Size(71, 27);
            this.btmSuma.TabIndex = 11;
            this.btmSuma.Text = "+";
            this.btmSuma.UseVisualStyleBackColor = true;
            this.btmSuma.Click += new System.EventHandler(this.button12_Click);
            // 
            // btmResta
            // 
            this.btmResta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmResta.Location = new System.Drawing.Point(318, 35);
            this.btmResta.Name = "btmResta";
            this.btmResta.Size = new System.Drawing.Size(73, 27);
            this.btmResta.TabIndex = 10;
            this.btmResta.Text = "-";
            this.btmResta.UseVisualStyleBackColor = true;
            this.btmResta.Click += new System.EventHandler(this.btmResta_Click);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(101, 202);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(97, 40);
            this.btn0.TabIndex = 9;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(198, 142);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(82, 29);
            this.btn9.TabIndex = 8;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.button9_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(110, 140);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(80, 32);
            this.btn8.TabIndex = 7;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(20, 140);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(82, 33);
            this.btn7.TabIndex = 6;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.button7_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(198, 87);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(82, 31);
            this.btn6.TabIndex = 5;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(113, 87);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(78, 31);
            this.btn5.TabIndex = 4;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(20, 84);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(83, 35);
            this.btn4.TabIndex = 3;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(198, 31);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(83, 35);
            this.btn3.TabIndex = 2;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(109, 31);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(83, 35);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(20, 31);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(83, 35);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultado.Location = new System.Drawing.Point(20, 85);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(518, 29);
            this.txtResultado.TabIndex = 1;
            this.txtResultado.Text = "0";
            this.txtResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 401);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button btmMultiplicación;
        private System.Windows.Forms.Button btmDivision;
        private System.Windows.Forms.Button btmSuma;
        private System.Windows.Forms.Button btmResta;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.TextBox txtResultado;
    }
}



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
            this.pantalla = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn_Punto = new System.Windows.Forms.Button();
            this.btn_Igual = new System.Windows.Forms.Button();
            this.btn_Sumar = new System.Windows.Forms.Button();
            this.btn_Restar = new System.Windows.Forms.Button();
            this.btn_Multiplicar = new System.Windows.Forms.Button();
            this.btn_Dividir = new System.Windows.Forms.Button();
            this.btn_C = new System.Windows.Forms.Button();
            this.btn_Remover = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pantalla
            // 
            this.pantalla.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pantalla.Location = new System.Drawing.Point(12, 12);
            this.pantalla.Name = "pantalla";
            this.pantalla.ReadOnly = true;
            this.pantalla.Size = new System.Drawing.Size(408, 29);
            this.pantalla.TabIndex = 0;
            this.pantalla.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(12, 67);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 23);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(93, 67);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(75, 23);
            this.btn2.TabIndex = 2;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(174, 67);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(75, 23);
            this.btn3.TabIndex = 3;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(12, 109);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(75, 23);
            this.btn4.TabIndex = 4;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(93, 109);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(75, 23);
            this.btn5.TabIndex = 5;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(174, 109);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(75, 23);
            this.btn6.TabIndex = 6;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(12, 152);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(75, 23);
            this.btn7.TabIndex = 7;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(93, 152);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(75, 23);
            this.btn8.TabIndex = 8;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(174, 152);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(75, 23);
            this.btn9.TabIndex = 9;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(12, 194);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(75, 23);
            this.btn0.TabIndex = 10;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btn_Punto
            // 
            this.btn_Punto.Location = new System.Drawing.Point(93, 194);
            this.btn_Punto.Name = "btn_Punto";
            this.btn_Punto.Size = new System.Drawing.Size(75, 23);
            this.btn_Punto.TabIndex = 11;
            this.btn_Punto.Text = ".";
            this.btn_Punto.UseVisualStyleBackColor = true;
            this.btn_Punto.Click += new System.EventHandler(this.btn_Punto_Click);
            // 
            // btn_Igual
            // 
            this.btn_Igual.Location = new System.Drawing.Point(174, 194);
            this.btn_Igual.Name = "btn_Igual";
            this.btn_Igual.Size = new System.Drawing.Size(75, 23);
            this.btn_Igual.TabIndex = 12;
            this.btn_Igual.Text = "=";
            this.btn_Igual.UseVisualStyleBackColor = true;
            this.btn_Igual.Click += new System.EventHandler(this.btn_Igual_Click);
            // 
            // btn_Sumar
            // 
            this.btn_Sumar.Location = new System.Drawing.Point(273, 90);
            this.btn_Sumar.Name = "btn_Sumar";
            this.btn_Sumar.Size = new System.Drawing.Size(75, 23);
            this.btn_Sumar.TabIndex = 13;
            this.btn_Sumar.Text = "+";
            this.btn_Sumar.UseVisualStyleBackColor = true;
            this.btn_Sumar.Click += new System.EventHandler(this.btn_Sumar_Click);
            // 
            // btn_Restar
            // 
            this.btn_Restar.Location = new System.Drawing.Point(354, 90);
            this.btn_Restar.Name = "btn_Restar";
            this.btn_Restar.Size = new System.Drawing.Size(75, 23);
            this.btn_Restar.TabIndex = 14;
            this.btn_Restar.Text = "-";
            this.btn_Restar.UseVisualStyleBackColor = true;
            this.btn_Restar.Click += new System.EventHandler(this.btn_Restar_Click);
            // 
            // btn_Multiplicar
            // 
            this.btn_Multiplicar.Location = new System.Drawing.Point(273, 133);
            this.btn_Multiplicar.Name = "btn_Multiplicar";
            this.btn_Multiplicar.Size = new System.Drawing.Size(75, 23);
            this.btn_Multiplicar.TabIndex = 15;
            this.btn_Multiplicar.Text = "*";
            this.btn_Multiplicar.UseVisualStyleBackColor = true;
            this.btn_Multiplicar.Click += new System.EventHandler(this.btn_Multiplicar_Click);
            // 
            // btn_Dividir
            // 
            this.btn_Dividir.Location = new System.Drawing.Point(354, 133);
            this.btn_Dividir.Name = "btn_Dividir";
            this.btn_Dividir.Size = new System.Drawing.Size(75, 23);
            this.btn_Dividir.TabIndex = 16;
            this.btn_Dividir.Text = "/";
            this.btn_Dividir.UseVisualStyleBackColor = true;
            this.btn_Dividir.Click += new System.EventHandler(this.btn_Dividir_Click);
            // 
            // btn_C
            // 
            this.btn_C.Location = new System.Drawing.Point(273, 174);
            this.btn_C.Name = "btn_C";
            this.btn_C.Size = new System.Drawing.Size(75, 23);
            this.btn_C.TabIndex = 17;
            this.btn_C.Text = "C";
            this.btn_C.UseVisualStyleBackColor = true;
            this.btn_C.Click += new System.EventHandler(this.btn_C_Click);
            // 
            // btn_Remover
            // 
            this.btn_Remover.Location = new System.Drawing.Point(354, 174);
            this.btn_Remover.Name = "btn_Remover";
            this.btn_Remover.Size = new System.Drawing.Size(75, 23);
            this.btn_Remover.TabIndex = 18;
            this.btn_Remover.Text = "<=";
            this.btn_Remover.UseVisualStyleBackColor = true;
            this.btn_Remover.Click += new System.EventHandler(this.btn_Remover_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 256);
            this.Controls.Add(this.btn_Remover);
            this.Controls.Add(this.btn_C);
            this.Controls.Add(this.btn_Dividir);
            this.Controls.Add(this.btn_Multiplicar);
            this.Controls.Add(this.btn_Restar);
            this.Controls.Add(this.btn_Sumar);
            this.Controls.Add(this.btn_Igual);
            this.Controls.Add(this.btn_Punto);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.pantalla);
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pantalla;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn_Punto;
        private System.Windows.Forms.Button btn_Igual;
        private System.Windows.Forms.Button btn_Sumar;
        private System.Windows.Forms.Button btn_Restar;
        private System.Windows.Forms.Button btn_Multiplicar;
        private System.Windows.Forms.Button btn_Dividir;
        private System.Windows.Forms.Button btn_C;
        private System.Windows.Forms.Button btn_Remover;
    }
}


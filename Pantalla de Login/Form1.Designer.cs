
namespace Pantalla_de_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txbx2 = new System.Windows.Forms.TextBox();
            this.txbx1 = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.lbtx1 = new System.Windows.Forms.Label();
            this.pbx1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.txbx2);
            this.panel1.Controls.Add(this.txbx1);
            this.panel1.Controls.Add(this.btn1);
            this.panel1.Controls.Add(this.lbtx1);
            this.panel1.Location = new System.Drawing.Point(220, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(213, 203);
            this.panel1.TabIndex = 0;
            // 
            // txbx2
            // 
            this.txbx2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txbx2.Location = new System.Drawing.Point(3, 92);
            this.txbx2.Name = "txbx2";
            this.txbx2.Size = new System.Drawing.Size(207, 20);
            this.txbx2.TabIndex = 3;
            this.txbx2.Text = "Contraseña";
            // 
            // txbx1
            // 
            this.txbx1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txbx1.Location = new System.Drawing.Point(3, 57);
            this.txbx1.Name = "txbx1";
            this.txbx1.Size = new System.Drawing.Size(207, 20);
            this.txbx1.TabIndex = 2;
            this.txbx1.Text = "Usuario";
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.Transparent;
            this.btn1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn1.ForeColor = System.Drawing.Color.Black;
            this.btn1.Location = new System.Drawing.Point(73, 153);
            this.btn1.Name = "btn1";
            this.btn1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn1.Size = new System.Drawing.Size(75, 23);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "ACEPTAR";
            this.btn1.UseVisualStyleBackColor = false;
            // 
            // lbtx1
            // 
            this.lbtx1.AutoSize = true;
            this.lbtx1.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtx1.Location = new System.Drawing.Point(57, 0);
            this.lbtx1.Name = "lbtx1";
            this.lbtx1.Size = new System.Drawing.Size(105, 35);
            this.lbtx1.TabIndex = 0;
            this.lbtx1.Text = "LOGIN";
            // 
            // pbx1
            // 
            this.pbx1.BackColor = System.Drawing.Color.Transparent;
            this.pbx1.Image = ((System.Drawing.Image)(resources.GetObject("pbx1.Image")));
            this.pbx1.InitialImage = global::Pantalla_de_Login.Properties.Resources.descarga__1_;
            this.pbx1.Location = new System.Drawing.Point(12, 12);
            this.pbx1.Name = "pbx1";
            this.pbx1.Size = new System.Drawing.Size(202, 203);
            this.pbx1.TabIndex = 1;
            this.pbx1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(457, 227);
            this.Controls.Add(this.pbx1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Opacity = 0.95D;
            this.Text = "Login";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbtx1;
        private System.Windows.Forms.TextBox txbx2;
        private System.Windows.Forms.TextBox txbx1;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.PictureBox pbx1;
    }
}


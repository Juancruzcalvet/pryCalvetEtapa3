namespace pryCalvetEtapa3
{
    partial class frmEtapa3
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
            this.btnAuto = new System.Windows.Forms.Button();
            this.btnBarco = new System.Windows.Forms.Button();
            this.btnAvion = new System.Windows.Forms.Button();
            this.lblVehiculo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAuto
            // 
            this.btnAuto.Location = new System.Drawing.Point(12, 389);
            this.btnAuto.Name = "btnAuto";
            this.btnAuto.Size = new System.Drawing.Size(101, 49);
            this.btnAuto.TabIndex = 0;
            this.btnAuto.Text = "Auto";
            this.btnAuto.UseVisualStyleBackColor = true;
            this.btnAuto.Click += new System.EventHandler(this.btnAuto_Click);
            // 
            // btnBarco
            // 
            this.btnBarco.Location = new System.Drawing.Point(349, 389);
            this.btnBarco.Name = "btnBarco";
            this.btnBarco.Size = new System.Drawing.Size(101, 49);
            this.btnBarco.TabIndex = 1;
            this.btnBarco.Text = "Barco";
            this.btnBarco.UseVisualStyleBackColor = true;
            this.btnBarco.Click += new System.EventHandler(this.btnBarco_Click);
            // 
            // btnAvion
            // 
            this.btnAvion.Location = new System.Drawing.Point(686, 389);
            this.btnAvion.Name = "btnAvion";
            this.btnAvion.Size = new System.Drawing.Size(101, 49);
            this.btnAvion.TabIndex = 2;
            this.btnAvion.Text = "Avion";
            this.btnAvion.UseVisualStyleBackColor = true;
            this.btnAvion.Click += new System.EventHandler(this.btnAvion_Click);
            // 
            // lblVehiculo
            // 
            this.lblVehiculo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblVehiculo.Location = new System.Drawing.Point(302, 302);
            this.lblVehiculo.Name = "lblVehiculo";
            this.lblVehiculo.Size = new System.Drawing.Size(179, 84);
            this.lblVehiculo.TabIndex = 3;
            this.lblVehiculo.Text = "Aqui va el nombre del vehiculo";
            this.lblVehiculo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmEtapa3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblVehiculo);
            this.Controls.Add(this.btnAvion);
            this.Controls.Add(this.btnBarco);
            this.Controls.Add(this.btnAuto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEtapa3";
            this.Text = "Formulario etapa 3";
            this.Load += new System.EventHandler(this.frmEtapa3_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAuto;
        private System.Windows.Forms.Button btnBarco;
        private System.Windows.Forms.Button btnAvion;
        private System.Windows.Forms.Label lblVehiculo;
    }
}


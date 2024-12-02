namespace SISTEMAS_GESTION
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
            this.btnSubRubro = new System.Windows.Forms.Button();
            this.btnProveedores = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSubRubro
            // 
            this.btnSubRubro.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSubRubro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSubRubro.BackgroundImage")));
            this.btnSubRubro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSubRubro.Location = new System.Drawing.Point(46, 45);
            this.btnSubRubro.Name = "btnSubRubro";
            this.btnSubRubro.Size = new System.Drawing.Size(98, 95);
            this.btnSubRubro.TabIndex = 0;
            this.btnSubRubro.Text = "Sub-Rubro";
            this.btnSubRubro.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSubRubro.UseVisualStyleBackColor = false;
            this.btnSubRubro.Click += new System.EventHandler(this.btnSubRubro_Click);
            // 
            // btnProveedores
            // 
            this.btnProveedores.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnProveedores.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnProveedores.BackgroundImage")));
            this.btnProveedores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnProveedores.Location = new System.Drawing.Point(204, 45);
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.Size = new System.Drawing.Size(98, 95);
            this.btnProveedores.TabIndex = 1;
            this.btnProveedores.Text = "Proveedores";
            this.btnProveedores.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProveedores.UseVisualStyleBackColor = false;
            this.btnProveedores.Click += new System.EventHandler(this.btnProveedores_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1336, 703);
            this.Controls.Add(this.btnProveedores);
            this.Controls.Add(this.btnSubRubro);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "io";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSubRubro;
        private System.Windows.Forms.Button btnProveedores;
    }
}


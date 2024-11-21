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
            this.SuspendLayout();
            // 
            // btnSubRubro
            // 
            this.btnSubRubro.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSubRubro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSubRubro.BackgroundImage")));
            this.btnSubRubro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSubRubro.Location = new System.Drawing.Point(39, 36);
            this.btnSubRubro.Name = "btnSubRubro";
            this.btnSubRubro.Size = new System.Drawing.Size(98, 95);
            this.btnSubRubro.TabIndex = 0;
            this.btnSubRubro.Text = "Sub-Rubro";
            this.btnSubRubro.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSubRubro.UseVisualStyleBackColor = false;
            this.btnSubRubro.Click += new System.EventHandler(this.btnSubRubro_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1336, 703);
            this.Controls.Add(this.btnSubRubro);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SISTEMAS";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSubRubro;
    }
}


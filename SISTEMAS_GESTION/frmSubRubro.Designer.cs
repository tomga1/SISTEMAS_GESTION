namespace SISTEMAS_GESTION
{
    partial class frmSubRubro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSubRubro));
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnlimpiarcampo = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvSubRubro = new System.Windows.Forms.DataGridView();
            this.domSubRubroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idSubRubroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubRubro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.domSubRubroBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnVolver.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnVolver.Image = ((System.Drawing.Image)(resources.GetObject("btnVolver.Image")));
            this.btnVolver.Location = new System.Drawing.Point(2, 2);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(74, 66);
            this.btnVolver.TabIndex = 75;
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEliminar.BackColor = System.Drawing.Color.Firebrick;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminar.Location = new System.Drawing.Point(77, 552);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(131, 36);
            this.btnEliminar.TabIndex = 97;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnlimpiarcampo
            // 
            this.btnlimpiarcampo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnlimpiarcampo.BackColor = System.Drawing.Color.SteelBlue;
            this.btnlimpiarcampo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlimpiarcampo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnlimpiarcampo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlimpiarcampo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpiarcampo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnlimpiarcampo.Location = new System.Drawing.Point(146, 510);
            this.btnlimpiarcampo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnlimpiarcampo.Name = "btnlimpiarcampo";
            this.btnlimpiarcampo.Size = new System.Drawing.Size(131, 36);
            this.btnlimpiarcampo.TabIndex = 96;
            this.btnlimpiarcampo.Text = "Limpiar Campos";
            this.btnlimpiarcampo.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGuardar.BackColor = System.Drawing.Color.ForestGreen;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(7, 510);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(131, 36);
            this.btnGuardar.TabIndex = 95;
            this.btnGuardar.Text = "Guardar / Modificar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDireccion.Location = new System.Drawing.Point(17, 432);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(260, 20);
            this.txtDireccion.TabIndex = 99;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 416);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 101;
            this.label6.Text = "Sub rubro : ";
            // 
            // dgvSubRubro
            // 
            this.dgvSubRubro.AutoGenerateColumns = false;
            this.dgvSubRubro.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvSubRubro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubRubro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idSubRubroDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn});
            this.dgvSubRubro.DataSource = this.domSubRubroBindingSource;
            this.dgvSubRubro.Location = new System.Drawing.Point(293, 65);
            this.dgvSubRubro.Name = "dgvSubRubro";
            this.dgvSubRubro.Size = new System.Drawing.Size(885, 525);
            this.dgvSubRubro.TabIndex = 102;
            // 
            // domSubRubroBindingSource
            // 
            this.domSubRubroBindingSource.DataSource = typeof(dominio.Dom_SubRubro);
            // 
            // idSubRubroDataGridViewTextBoxColumn
            // 
            this.idSubRubroDataGridViewTextBoxColumn.DataPropertyName = "IdSubRubro";
            this.idSubRubroDataGridViewTextBoxColumn.HeaderText = "IdSubRubro";
            this.idSubRubroDataGridViewTextBoxColumn.Name = "idSubRubroDataGridViewTextBoxColumn";
            this.idSubRubroDataGridViewTextBoxColumn.Visible = false;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // frmSubRubro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1190, 622);
            this.Controls.Add(this.dgvSubRubro);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnlimpiarcampo);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnVolver);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSubRubro";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SUB-RUBROS";
            this.Load += new System.EventHandler(this.frmSubRubro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubRubro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.domSubRubroBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnlimpiarcampo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvSubRubro;
        private System.Windows.Forms.BindingSource domSubRubroBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSubRubroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
    }
}
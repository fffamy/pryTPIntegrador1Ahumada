namespace pryTPIntegrador1Ahumada
{
    partial class frmPrincipal
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
            this.lblTeatro = new System.Windows.Forms.Label();
            this.cmbTeatros = new System.Windows.Forms.ComboBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.btnReservar = new System.Windows.Forms.Button();
            this.dgvAsientosVerdes = new System.Windows.Forms.DataGridView();
            this.dgvAsientosAzules = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsientosVerdes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsientosAzules)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTeatro
            // 
            this.lblTeatro.AutoSize = true;
            this.lblTeatro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeatro.Location = new System.Drawing.Point(12, 14);
            this.lblTeatro.Name = "lblTeatro";
            this.lblTeatro.Size = new System.Drawing.Size(71, 20);
            this.lblTeatro.TabIndex = 0;
            this.lblTeatro.Text = "Teatro: ";
            // 
            // cmbTeatros
            // 
            this.cmbTeatros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTeatros.FormattingEnabled = true;
            this.cmbTeatros.Location = new System.Drawing.Point(79, 11);
            this.cmbTeatros.Name = "cmbTeatros";
            this.cmbTeatros.Size = new System.Drawing.Size(192, 28);
            this.cmbTeatros.TabIndex = 1;
            this.cmbTeatros.SelectedIndexChanged += new System.EventHandler(this.cmbTeatros_SelectedIndexChanged);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(293, 14);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(69, 20);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "Fecha: ";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Location = new System.Drawing.Point(357, 11);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(350, 26);
            this.dtpFecha.TabIndex = 3;
            // 
            // btnReservar
            // 
            this.btnReservar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservar.Location = new System.Drawing.Point(724, 11);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.Size = new System.Drawing.Size(96, 50);
            this.btnReservar.TabIndex = 4;
            this.btnReservar.Text = "Reservar";
            this.btnReservar.UseVisualStyleBackColor = true;
            this.btnReservar.Click += new System.EventHandler(this.btnReservar_Click);
            // 
            // dgvAsientosVerdes
            // 
            this.dgvAsientosVerdes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsientosVerdes.Location = new System.Drawing.Point(16, 79);
            this.dgvAsientosVerdes.Name = "dgvAsientosVerdes";
            this.dgvAsientosVerdes.Size = new System.Drawing.Size(804, 187);
            this.dgvAsientosVerdes.TabIndex = 5;
            // 
            // dgvAsientosAzules
            // 
            this.dgvAsientosAzules.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsientosAzules.Location = new System.Drawing.Point(16, 286);
            this.dgvAsientosAzules.Name = "dgvAsientosAzules";
            this.dgvAsientosAzules.Size = new System.Drawing.Size(804, 186);
            this.dgvAsientosAzules.TabIndex = 6;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(832, 494);
            this.Controls.Add(this.dgvAsientosAzules);
            this.Controls.Add(this.dgvAsientosVerdes);
            this.Controls.Add(this.btnReservar);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.cmbTeatros);
            this.Controls.Add(this.lblTeatro);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reservaciones Teatro";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsientosVerdes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsientosAzules)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTeatro;
        private System.Windows.Forms.ComboBox cmbTeatros;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Button btnReservar;
        private System.Windows.Forms.DataGridView dgvAsientosVerdes;
        private System.Windows.Forms.DataGridView dgvAsientosAzules;
    }
}


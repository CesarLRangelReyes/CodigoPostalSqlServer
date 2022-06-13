
namespace CodigoPostalSqlServer
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
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtAsentamiento = new System.Windows.Forms.TextBox();
            this.txtMunicipios = new System.Windows.Forms.ComboBox();
            this.txtEstados = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCodigoPostal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvCodigosPostales = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCodigosPostales)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(135, 108);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(378, 27);
            this.txtCodigo.TabIndex = 18;
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            // 
            // txtAsentamiento
            // 
            this.txtAsentamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAsentamiento.Location = new System.Drawing.Point(135, 75);
            this.txtAsentamiento.Name = "txtAsentamiento";
            this.txtAsentamiento.Size = new System.Drawing.Size(378, 27);
            this.txtAsentamiento.TabIndex = 17;
            this.txtAsentamiento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAsentamiento_KeyPress);
            // 
            // txtMunicipios
            // 
            this.txtMunicipios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMunicipios.FormattingEnabled = true;
            this.txtMunicipios.Location = new System.Drawing.Point(135, 41);
            this.txtMunicipios.Name = "txtMunicipios";
            this.txtMunicipios.Size = new System.Drawing.Size(378, 28);
            this.txtMunicipios.TabIndex = 16;
            this.txtMunicipios.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMunicipios_KeyPress);
            // 
            // txtEstados
            // 
            this.txtEstados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstados.FormattingEnabled = true;
            this.txtEstados.Location = new System.Drawing.Point(135, 7);
            this.txtEstados.Name = "txtEstados";
            this.txtEstados.Size = new System.Drawing.Size(378, 28);
            this.txtEstados.TabIndex = 15;
            this.txtEstados.SelectedIndexChanged += new System.EventHandler(this.txtEstados_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Codigos Postales";
            // 
            // txtCodigoPostal
            // 
            this.txtCodigoPostal.AutoSize = true;
            this.txtCodigoPostal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoPostal.Location = new System.Drawing.Point(15, 115);
            this.txtCodigoPostal.Name = "txtCodigoPostal";
            this.txtCodigoPostal.Size = new System.Drawing.Size(118, 20);
            this.txtCodigoPostal.TabIndex = 13;
            this.txtCodigoPostal.Text = "Codigo Postal:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Asentamiento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Municipio:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Estado:";
            // 
            // dgvCodigosPostales
            // 
            this.dgvCodigosPostales.BackgroundColor = System.Drawing.Color.White;
            this.dgvCodigosPostales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCodigosPostales.Location = new System.Drawing.Point(7, 173);
            this.dgvCodigosPostales.Name = "dgvCodigosPostales";
            this.dgvCodigosPostales.ReadOnly = true;
            this.dgvCodigosPostales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCodigosPostales.Size = new System.Drawing.Size(748, 271);
            this.dgvCodigosPostales.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(766, 450);
            this.Controls.Add(this.dgvCodigosPostales);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.txtAsentamiento);
            this.Controls.Add(this.txtMunicipios);
            this.Controls.Add(this.txtEstados);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCodigoPostal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "SERVICIO POSTAL MEXICANO";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCodigosPostales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtAsentamiento;
        private System.Windows.Forms.ComboBox txtMunicipios;
        private System.Windows.Forms.ComboBox txtEstados;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label txtCodigoPostal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvCodigosPostales;
    }
}


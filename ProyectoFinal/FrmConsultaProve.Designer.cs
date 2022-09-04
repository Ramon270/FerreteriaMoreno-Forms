namespace ProyectoFinal
{
    partial class FrmConsultaProve
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
            this.dtgProveedores = new System.Windows.Forms.DataGridView();
            this.lbRegistros = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgProveedores
            // 
            this.dtgProveedores.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProveedores.Location = new System.Drawing.Point(28, 73);
            this.dtgProveedores.Name = "dtgProveedores";
            this.dtgProveedores.Size = new System.Drawing.Size(631, 253);
            this.dtgProveedores.TabIndex = 0;
            this.dtgProveedores.DataSourceChanged += new System.EventHandler(this.dtgProveedores_DataSourceChanged);
            this.dtgProveedores.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgProveedores_CellDoubleClick);
            // 
            // lbRegistros
            // 
            this.lbRegistros.AutoSize = true;
            this.lbRegistros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRegistros.Location = new System.Drawing.Point(551, 331);
            this.lbRegistros.Name = "lbRegistros";
            this.lbRegistros.Size = new System.Drawing.Size(72, 15);
            this.lbRegistros.TabIndex = 1;
            this.lbRegistros.Text = "Registros: 0";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(99, 37);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(138, 21);
            this.txtCodigo.TabIndex = 2;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Código:";
            // 
            // FrmConsultaProve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 365);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lbRegistros);
            this.Controls.Add(this.dtgProveedores);
            this.Name = "FrmConsultaProve";
            this.Text = "Consulta de Proveedores";
            this.Load += new System.EventHandler(this.FrmConsultaProve_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgProveedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgProveedores;
        private System.Windows.Forms.Label lbRegistros;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label2;
    }
}
namespace ProyectoFinal
{
    partial class FrmConsultaFact
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lbRegistros = new System.Windows.Forms.Label();
            this.dtgFacturas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgFacturas)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Código:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(101, 35);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(138, 21);
            this.txtCodigo.TabIndex = 7;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            // 
            // lbRegistros
            // 
            this.lbRegistros.AutoSize = true;
            this.lbRegistros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRegistros.Location = new System.Drawing.Point(553, 329);
            this.lbRegistros.Name = "lbRegistros";
            this.lbRegistros.Size = new System.Drawing.Size(72, 15);
            this.lbRegistros.TabIndex = 6;
            this.lbRegistros.Text = "Registros: 0";
            // 
            // dtgFacturas
            // 
            this.dtgFacturas.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgFacturas.Location = new System.Drawing.Point(30, 71);
            this.dtgFacturas.Name = "dtgFacturas";
            this.dtgFacturas.Size = new System.Drawing.Size(631, 253);
            this.dtgFacturas.TabIndex = 5;
            this.dtgFacturas.DataSourceChanged += new System.EventHandler(this.dtgFacturas_DataSourceChanged);
            this.dtgFacturas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgFacturas_CellDoubleClick);
            // 
            // FrmConsultaFact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 365);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lbRegistros);
            this.Controls.Add(this.dtgFacturas);
            this.Name = "FrmConsultaFact";
            this.Text = "Consulta de Facturas";
            this.Load += new System.EventHandler(this.FrmConsultaFact_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgFacturas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lbRegistros;
        private System.Windows.Forms.DataGridView dtgFacturas;
    }
}
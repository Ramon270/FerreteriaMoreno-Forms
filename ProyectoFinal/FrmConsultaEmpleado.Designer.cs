namespace ProyectoFinal
{
    partial class FrmConsultaEmpleado
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lbRegistros = new System.Windows.Forms.Label();
            this.dtgEmpleados = new System.Windows.Forms.DataGridView();
            this.txtCedula = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(387, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 18);
            this.label1.TabIndex = 16;
            this.label1.Text = "Cédula:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 18);
            this.label2.TabIndex = 14;
            this.label2.Text = "Código:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(109, 33);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(138, 21);
            this.txtCodigo.TabIndex = 13;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            // 
            // lbRegistros
            // 
            this.lbRegistros.AutoSize = true;
            this.lbRegistros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRegistros.Location = new System.Drawing.Point(561, 341);
            this.lbRegistros.Name = "lbRegistros";
            this.lbRegistros.Size = new System.Drawing.Size(72, 15);
            this.lbRegistros.TabIndex = 12;
            this.lbRegistros.Text = "Registros: 0";
            // 
            // dtgEmpleados
            // 
            this.dtgEmpleados.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgEmpleados.Location = new System.Drawing.Point(38, 69);
            this.dtgEmpleados.Name = "dtgEmpleados";
            this.dtgEmpleados.Size = new System.Drawing.Size(631, 269);
            this.dtgEmpleados.TabIndex = 11;
            this.dtgEmpleados.DataSourceChanged += new System.EventHandler(this.dtgEmpleados_DataSourceChanged);
            this.dtgEmpleados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgEmpleados_CellDoubleClick);
            // 
            // txtCedula
            // 
            this.txtCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedula.Location = new System.Drawing.Point(458, 33);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(138, 21);
            this.txtCedula.TabIndex = 17;
            this.txtCedula.TextChanged += new System.EventHandler(this.txtCedula_TextChanged);
            // 
            // FrmConsultaEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 365);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lbRegistros);
            this.Controls.Add(this.dtgEmpleados);
            this.Name = "FrmConsultaEmpleado";
            this.Text = "Consulta de Empleados";
            this.Load += new System.EventHandler(this.FrmConsultaEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgEmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lbRegistros;
        private System.Windows.Forms.DataGridView dtgEmpleados;
        private System.Windows.Forms.TextBox txtCedula;
    }
}
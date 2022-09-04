namespace ProyectoFinal
{
    partial class FrmConsultaUsuario
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
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.dtgUsuarios = new System.Windows.Forms.DataGridView();
            this.lbRegistros = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 18);
            this.label1.TabIndex = 15;
            this.label1.Text = "Username:";
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(149, 27);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(189, 21);
            this.txtUsername.TabIndex = 14;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // dtgUsuarios
            // 
            this.dtgUsuarios.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgUsuarios.Location = new System.Drawing.Point(30, 75);
            this.dtgUsuarios.Name = "dtgUsuarios";
            this.dtgUsuarios.Size = new System.Drawing.Size(631, 253);
            this.dtgUsuarios.TabIndex = 16;
            this.dtgUsuarios.DataSourceChanged += new System.EventHandler(this.dtgUsuarios_DataSourceChanged);
            this.dtgUsuarios.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgUsuarios_CellDoubleClick);
            // 
            // lbRegistros
            // 
            this.lbRegistros.AutoSize = true;
            this.lbRegistros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRegistros.Location = new System.Drawing.Point(562, 341);
            this.lbRegistros.Name = "lbRegistros";
            this.lbRegistros.Size = new System.Drawing.Size(72, 15);
            this.lbRegistros.TabIndex = 17;
            this.lbRegistros.Text = "Registros: 0";
            // 
            // FrmConsultaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 365);
            this.Controls.Add(this.lbRegistros);
            this.Controls.Add(this.dtgUsuarios);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUsername);
            this.Name = "FrmConsultaUsuario";
            this.Text = "Consulta de usuarios";
            this.Load += new System.EventHandler(this.FrmConsultaUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.DataGridView dtgUsuarios;
        private System.Windows.Forms.Label lbRegistros;
    }
}
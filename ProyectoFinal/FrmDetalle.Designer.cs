namespace ProyectoFinal
{
    partial class FrmDetalle
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
            this.dtgDetalle = new System.Windows.Forms.DataGridView();
            this.btnAnular = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgDetalle
            // 
            this.dtgDetalle.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDetalle.Location = new System.Drawing.Point(35, 35);
            this.dtgDetalle.Name = "dtgDetalle";
            this.dtgDetalle.Size = new System.Drawing.Size(631, 263);
            this.dtgDetalle.TabIndex = 6;
            // 
            // btnAnular
            // 
            this.btnAnular.BackColor = System.Drawing.Color.IndianRed;
            this.btnAnular.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnular.Location = new System.Drawing.Point(35, 304);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(122, 37);
            this.btnAnular.TabIndex = 28;
            this.btnAnular.Text = "Anular";
            this.btnAnular.UseVisualStyleBackColor = false;
            this.btnAnular.Click += new System.EventHandler(this.btnAnular_Click);
            // 
            // FrmDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 353);
            this.Controls.Add(this.btnAnular);
            this.Controls.Add(this.dtgDetalle);
            this.Name = "FrmDetalle";
            this.Text = "Detalle Factura";
            this.Load += new System.EventHandler(this.FrmDetalle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDetalle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgDetalle;
        private System.Windows.Forms.Button btnAnular;
    }
}
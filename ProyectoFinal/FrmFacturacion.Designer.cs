namespace ProyectoFinal
{
    partial class FrmFacturacion
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
            this.label9 = new System.Windows.Forms.Label();
            this.cmbArticulo = new System.Windows.Forms.ComboBox();
            this.lbxDetalle = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnColocar = new System.Windows.Forms.Button();
            this.btnFacturar = new System.Windows.Forms.Button();
            this.lbTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(67, 98);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 18);
            this.label9.TabIndex = 57;
            this.label9.Text = "Artículo:";
            // 
            // cmbArticulo
            // 
            this.cmbArticulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbArticulo.FormattingEnabled = true;
            this.cmbArticulo.Location = new System.Drawing.Point(192, 97);
            this.cmbArticulo.Name = "cmbArticulo";
            this.cmbArticulo.Size = new System.Drawing.Size(175, 23);
            this.cmbArticulo.TabIndex = 56;
            // 
            // lbxDetalle
            // 
            this.lbxDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxDetalle.FormattingEnabled = true;
            this.lbxDetalle.ItemHeight = 18;
            this.lbxDetalle.Location = new System.Drawing.Point(70, 162);
            this.lbxDetalle.Name = "lbxDetalle";
            this.lbxDetalle.Size = new System.Drawing.Size(482, 256);
            this.lbxDetalle.TabIndex = 60;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(398, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 18);
            this.label2.TabIndex = 62;
            this.label2.Text = "Nombre Cliente:";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(580, 36);
            this.txtNombre.MaxLength = 200;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(175, 21);
            this.txtNombre.TabIndex = 61;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 18);
            this.label1.TabIndex = 64;
            this.label1.Text = "Código:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(192, 39);
            this.txtCodigo.MaxLength = 8;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 21);
            this.txtCodigo.TabIndex = 63;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(405, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 18);
            this.label3.TabIndex = 66;
            this.label3.Text = "Cantidad:";
            // 
            // nudCantidad
            // 
            this.nudCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCantidad.Location = new System.Drawing.Point(580, 99);
            this.nudCantidad.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(120, 21);
            this.nudCantidad.TabIndex = 65;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.IndianRed;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(637, 351);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(87, 51);
            this.btnCancelar.TabIndex = 69;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnColocar
            // 
            this.btnColocar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColocar.Location = new System.Drawing.Point(637, 162);
            this.btnColocar.Name = "btnColocar";
            this.btnColocar.Size = new System.Drawing.Size(87, 51);
            this.btnColocar.TabIndex = 68;
            this.btnColocar.Text = "Colocar";
            this.btnColocar.UseVisualStyleBackColor = true;
            this.btnColocar.Click += new System.EventHandler(this.btnColocar_Click);
            // 
            // btnFacturar
            // 
            this.btnFacturar.BackColor = System.Drawing.Color.PaleGreen;
            this.btnFacturar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacturar.Location = new System.Drawing.Point(637, 254);
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.Size = new System.Drawing.Size(87, 51);
            this.btnFacturar.TabIndex = 70;
            this.btnFacturar.Text = "Facturar";
            this.btnFacturar.UseVisualStyleBackColor = false;
            this.btnFacturar.Click += new System.EventHandler(this.btnFacturar_Click);
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.Location = new System.Drawing.Point(67, 426);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(45, 15);
            this.lbTotal.TabIndex = 71;
            this.lbTotal.Text = "RD$: 0";
            // 
            // FrmFacturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.btnFacturar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnColocar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudCantidad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lbxDetalle);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbArticulo);
            this.Name = "FrmFacturacion";
            this.Text = "Menú de Facturación";
            this.Load += new System.EventHandler(this.FrmFacturacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbArticulo;
        private System.Windows.Forms.ListBox lbxDetalle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnColocar;
        private System.Windows.Forms.Button btnFacturar;
        private System.Windows.Forms.Label lbTotal;
    }
}
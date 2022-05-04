namespace CalidadCoolecheraForms
{
    partial class BonificacionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BonificacionForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBorrarInfo = new System.Windows.Forms.Button();
            this.btnGuardarInfo = new System.Windows.Forms.Button();
            this.btnNuevoRegistro = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtValorFrio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPagoFrio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPagoBacterias = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRangoSuperior = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRangoInferior = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.btnBorrarInfo);
            this.groupBox1.Controls.Add(this.btnGuardarInfo);
            this.groupBox1.Controls.Add(this.btnNuevoRegistro);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.dgv);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 482);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bonificaciones";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(515, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(255, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btnBorrarInfo
            // 
            this.btnBorrarInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBorrarInfo.Location = new System.Drawing.Point(515, 445);
            this.btnBorrarInfo.Name = "btnBorrarInfo";
            this.btnBorrarInfo.Size = new System.Drawing.Size(255, 31);
            this.btnBorrarInfo.TabIndex = 4;
            this.btnBorrarInfo.Text = "Borrar Bonificación";
            this.btnBorrarInfo.UseVisualStyleBackColor = true;
            this.btnBorrarInfo.Click += new System.EventHandler(this.btnBorrarInfo_Click);
            // 
            // btnGuardarInfo
            // 
            this.btnGuardarInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardarInfo.Location = new System.Drawing.Point(515, 408);
            this.btnGuardarInfo.Name = "btnGuardarInfo";
            this.btnGuardarInfo.Size = new System.Drawing.Size(255, 31);
            this.btnGuardarInfo.TabIndex = 3;
            this.btnGuardarInfo.Text = "Guardar Bonificación";
            this.btnGuardarInfo.UseVisualStyleBackColor = true;
            this.btnGuardarInfo.Click += new System.EventHandler(this.btnGuardarInfo_Click);
            // 
            // btnNuevoRegistro
            // 
            this.btnNuevoRegistro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevoRegistro.Location = new System.Drawing.Point(515, 371);
            this.btnNuevoRegistro.Name = "btnNuevoRegistro";
            this.btnNuevoRegistro.Size = new System.Drawing.Size(255, 31);
            this.btnNuevoRegistro.TabIndex = 2;
            this.btnNuevoRegistro.Text = "Nueva Bonificación";
            this.btnNuevoRegistro.UseVisualStyleBackColor = true;
            this.btnNuevoRegistro.Click += new System.EventHandler(this.btnNuevoRegistro_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.txtValorFrio);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtPagoFrio);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtPagoBacterias);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtRangoSuperior);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtRangoInferior);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(515, 96);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(255, 269);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos";
            // 
            // txtValorFrio
            // 
            this.txtValorFrio.Location = new System.Drawing.Point(6, 211);
            this.txtValorFrio.Name = "txtValorFrio";
            this.txtValorFrio.Size = new System.Drawing.Size(243, 23);
            this.txtValorFrio.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Pago Voluntario Frio";
            // 
            // txtPagoFrio
            // 
            this.txtPagoFrio.Location = new System.Drawing.Point(6, 169);
            this.txtPagoFrio.Name = "txtPagoFrio";
            this.txtPagoFrio.Size = new System.Drawing.Size(243, 23);
            this.txtPagoFrio.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Pago Frio";
            // 
            // txtPagoBacterias
            // 
            this.txtPagoBacterias.Location = new System.Drawing.Point(6, 126);
            this.txtPagoBacterias.Name = "txtPagoBacterias";
            this.txtPagoBacterias.Size = new System.Drawing.Size(243, 23);
            this.txtPagoBacterias.TabIndex = 5;
            this.txtPagoBacterias.TextChanged += new System.EventHandler(this.txtPagoBacterias_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Pago Bacterias";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtRangoSuperior
            // 
            this.txtRangoSuperior.Location = new System.Drawing.Point(6, 84);
            this.txtRangoSuperior.Name = "txtRangoSuperior";
            this.txtRangoSuperior.Size = new System.Drawing.Size(243, 23);
            this.txtRangoSuperior.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Rango Superior";
            // 
            // txtRangoInferior
            // 
            this.txtRangoInferior.Location = new System.Drawing.Point(6, 42);
            this.txtRangoInferior.Name = "txtRangoInferior";
            this.txtRangoInferior.Size = new System.Drawing.Size(243, 23);
            this.txtRangoInferior.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rango Inferior";
            // 
            // dgv
            // 
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(6, 28);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.RowTemplate.Height = 25;
            this.dgv.Size = new System.Drawing.Size(503, 448);
            this.dgv.TabIndex = 0;
            // 
            // BonificacionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 507);
            this.Controls.Add(this.groupBox1);
            this.Name = "BonificacionForm";
            this.Text = "Bonificaciones";
            this.Load += new System.EventHandler(this.Bonificacion_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnBorrarInfo;
        private System.Windows.Forms.Button btnGuardarInfo;
        private System.Windows.Forms.Button btnNuevoRegistro;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtPagoFrio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPagoBacterias;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRangoSuperior;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRangoInferior;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.TextBox txtValorFrio;
        private System.Windows.Forms.Label label5;
    }
}
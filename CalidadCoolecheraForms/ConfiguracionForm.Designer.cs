namespace CalidadCoolecheraForms
{
    partial class ConfiguracionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfiguracionForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBorrarInfo = new System.Windows.Forms.Button();
            this.btnGuardarInfo = new System.Windows.Forms.Button();
            this.btnNuevoRegistro = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtDescripcionVariable = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtValorVariable = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTipoVariable = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigoVariable = new System.Windows.Forms.TextBox();
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
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.btnBorrarInfo);
            this.groupBox1.Controls.Add(this.btnGuardarInfo);
            this.groupBox1.Controls.Add(this.btnNuevoRegistro);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.dgv);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 437);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configuaración Variables";
            // 
            // pictureBox1
            // 
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
            this.btnBorrarInfo.Location = new System.Drawing.Point(515, 400);
            this.btnBorrarInfo.Name = "btnBorrarInfo";
            this.btnBorrarInfo.Size = new System.Drawing.Size(255, 31);
            this.btnBorrarInfo.TabIndex = 4;
            this.btnBorrarInfo.Text = "Borrar Variable";
            this.btnBorrarInfo.UseVisualStyleBackColor = true;
            this.btnBorrarInfo.Click += new System.EventHandler(this.btnBorrarInfo_Click);
            // 
            // btnGuardarInfo
            // 
            this.btnGuardarInfo.Location = new System.Drawing.Point(515, 363);
            this.btnGuardarInfo.Name = "btnGuardarInfo";
            this.btnGuardarInfo.Size = new System.Drawing.Size(255, 31);
            this.btnGuardarInfo.TabIndex = 3;
            this.btnGuardarInfo.Text = "Guardar Variable";
            this.btnGuardarInfo.UseVisualStyleBackColor = true;
            this.btnGuardarInfo.Click += new System.EventHandler(this.btnGuardarInfo_Click);
            // 
            // btnNuevoRegistro
            // 
            this.btnNuevoRegistro.Location = new System.Drawing.Point(515, 326);
            this.btnNuevoRegistro.Name = "btnNuevoRegistro";
            this.btnNuevoRegistro.Size = new System.Drawing.Size(255, 31);
            this.btnNuevoRegistro.TabIndex = 2;
            this.btnNuevoRegistro.Text = "Nueva Variable";
            this.btnNuevoRegistro.UseVisualStyleBackColor = true;
            this.btnNuevoRegistro.Click += new System.EventHandler(this.btnNuevoRegistro_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtDescripcionVariable);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtValorVariable);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtTipoVariable);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtCodigoVariable);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(515, 96);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(255, 224);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos";
            // 
            // txtDescripcionVariable
            // 
            this.txtDescripcionVariable.Location = new System.Drawing.Point(6, 188);
            this.txtDescripcionVariable.Name = "txtDescripcionVariable";
            this.txtDescripcionVariable.Size = new System.Drawing.Size(243, 23);
            this.txtDescripcionVariable.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Descripción Variable";
            // 
            // txtValorVariable
            // 
            this.txtValorVariable.Location = new System.Drawing.Point(6, 140);
            this.txtValorVariable.Name = "txtValorVariable";
            this.txtValorVariable.Size = new System.Drawing.Size(243, 23);
            this.txtValorVariable.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Valor Variable";
            // 
            // txtTipoVariable
            // 
            this.txtTipoVariable.Location = new System.Drawing.Point(6, 92);
            this.txtTipoVariable.Name = "txtTipoVariable";
            this.txtTipoVariable.Size = new System.Drawing.Size(243, 23);
            this.txtTipoVariable.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tipo Variable";
            // 
            // txtCodigoVariable
            // 
            this.txtCodigoVariable.Location = new System.Drawing.Point(6, 44);
            this.txtCodigoVariable.Name = "txtCodigoVariable";
            this.txtCodigoVariable.Size = new System.Drawing.Size(243, 23);
            this.txtCodigoVariable.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo Variable";
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(6, 28);
            this.dgv.Name = "dgv";
            this.dgv.RowTemplate.Height = 25;
            this.dgv.Size = new System.Drawing.Size(503, 403);
            this.dgv.TabIndex = 0;
            // 
            // ConfiguracionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 459);
            this.Controls.Add(this.groupBox1);
            this.Name = "ConfiguracionForm";
            this.Text = "Configuracion de Variables";
            this.Load += new System.EventHandler(this.ConfiguracionForm_Load);
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
        private System.Windows.Forms.TextBox txtTipoVariable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodigoVariable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.TextBox txtDescripcionVariable;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtValorVariable;
        private System.Windows.Forms.Label label3;
    }
}
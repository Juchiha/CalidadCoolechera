﻿namespace CalidadCoolecheraForms
{
    partial class ParametrosForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParametrosForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBorrarInfo = new System.Windows.Forms.Button();
            this.btnGuardarInfo = new System.Windows.Forms.Button();
            this.btnNuevoRegistro = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtEstadoPeriodoCda = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumeroPeriodo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPeriodoLiquidacion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.txtEstadoAsociado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
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
            this.groupBox1.Font = new System.Drawing.Font("Rockwell Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 482);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Periodos";
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
            this.btnBorrarInfo.Location = new System.Drawing.Point(515, 445);
            this.btnBorrarInfo.Name = "btnBorrarInfo";
            this.btnBorrarInfo.Size = new System.Drawing.Size(255, 31);
            this.btnBorrarInfo.TabIndex = 4;
            this.btnBorrarInfo.Text = "Borrar Periodo";
            this.btnBorrarInfo.UseVisualStyleBackColor = true;
            this.btnBorrarInfo.Click += new System.EventHandler(this.btnBorrarInfo_Click);
            // 
            // btnGuardarInfo
            // 
            this.btnGuardarInfo.Location = new System.Drawing.Point(515, 408);
            this.btnGuardarInfo.Name = "btnGuardarInfo";
            this.btnGuardarInfo.Size = new System.Drawing.Size(255, 31);
            this.btnGuardarInfo.TabIndex = 3;
            this.btnGuardarInfo.Text = "Guardar Periodo";
            this.btnGuardarInfo.UseVisualStyleBackColor = true;
            this.btnGuardarInfo.Click += new System.EventHandler(this.btnGuardarInfo_Click);
            // 
            // btnNuevoRegistro
            // 
            this.btnNuevoRegistro.Location = new System.Drawing.Point(515, 371);
            this.btnNuevoRegistro.Name = "btnNuevoRegistro";
            this.btnNuevoRegistro.Size = new System.Drawing.Size(255, 31);
            this.btnNuevoRegistro.TabIndex = 2;
            this.btnNuevoRegistro.Text = "Nuevo Periodo";
            this.btnNuevoRegistro.UseVisualStyleBackColor = true;
            this.btnNuevoRegistro.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtEstadoAsociado);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtEstadoPeriodoCda);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtNumeroPeriodo);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtPeriodoLiquidacion);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(515, 96);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(255, 269);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // txtEstadoPeriodoCda
            // 
            this.txtEstadoPeriodoCda.Location = new System.Drawing.Point(6, 163);
            this.txtEstadoPeriodoCda.Name = "txtEstadoPeriodoCda";
            this.txtEstadoPeriodoCda.Size = new System.Drawing.Size(243, 29);
            this.txtEstadoPeriodoCda.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Estado Periodo CDA";
            // 
            // txtNumeroPeriodo
            // 
            this.txtNumeroPeriodo.Location = new System.Drawing.Point(6, 106);
            this.txtNumeroPeriodo.Name = "txtNumeroPeriodo";
            this.txtNumeroPeriodo.Size = new System.Drawing.Size(243, 29);
            this.txtNumeroPeriodo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Numero de Liquidación";
            // 
            // txtPeriodoLiquidacion
            // 
            this.txtPeriodoLiquidacion.Location = new System.Drawing.Point(6, 49);
            this.txtPeriodoLiquidacion.Name = "txtPeriodoLiquidacion";
            this.txtPeriodoLiquidacion.Size = new System.Drawing.Size(243, 29);
            this.txtPeriodoLiquidacion.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Periodo Liquidación";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(6, 28);
            this.dgv.Name = "dgv";
            this.dgv.RowTemplate.Height = 25;
            this.dgv.Size = new System.Drawing.Size(503, 448);
            this.dgv.TabIndex = 0;
            // 
            // txtEstadoAsociado
            // 
            this.txtEstadoAsociado.Location = new System.Drawing.Point(6, 219);
            this.txtEstadoAsociado.Name = "txtEstadoAsociado";
            this.txtEstadoAsociado.Size = new System.Drawing.Size(243, 29);
            this.txtEstadoAsociado.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Estado Periodo Asociado";
            // 
            // ParametrosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 506);
            this.Controls.Add(this.groupBox1);
            this.Name = "ParametrosForm";
            this.Text = "ParametrosForm";
            this.Load += new System.EventHandler(this.ParametrosForm_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtPeriodoLiquidacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btnNuevoRegistro;
        private System.Windows.Forms.TextBox txtEstadoPeriodoCda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNumeroPeriodo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBorrarInfo;
        private System.Windows.Forms.Button btnGuardarInfo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtEstadoAsociado;
        private System.Windows.Forms.Label label4;
    }
}
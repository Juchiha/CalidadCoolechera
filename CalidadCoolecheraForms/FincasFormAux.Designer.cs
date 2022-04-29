namespace CalidadCoolecheraForms
{
    partial class FincasFormAux
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridFincas = new System.Windows.Forms.DataGridView();
            this.txtNombreConsignate = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFincas)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridFincas);
            this.groupBox1.Controls.Add(this.txtNombreConsignate);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(456, 263);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos De Las Fincas";
            // 
            // dataGridFincas
            // 
            this.dataGridFincas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFincas.Location = new System.Drawing.Point(6, 37);
            this.dataGridFincas.Name = "dataGridFincas";
            this.dataGridFincas.RowTemplate.Height = 25;
            this.dataGridFincas.Size = new System.Drawing.Size(444, 215);
            this.dataGridFincas.TabIndex = 1;
            this.dataGridFincas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridFincas_CellDoubleClick);
            // 
            // txtNombreConsignate
            // 
            this.txtNombreConsignate.AutoSize = true;
            this.txtNombreConsignate.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtNombreConsignate.Location = new System.Drawing.Point(130, 19);
            this.txtNombreConsignate.Name = "txtNombreConsignate";
            this.txtNombreConsignate.Size = new System.Drawing.Size(139, 15);
            this.txtNombreConsignate.TabIndex = 0;
            this.txtNombreConsignate.Text = "Nombre del Consignante";
            // 
            // FincasFormAux
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 280);
            this.Controls.Add(this.groupBox1);
            this.Name = "FincasFormAux";
            this.Text = "Fincas";
            this.Load += new System.EventHandler(this.FincasFormAux_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFincas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label txtNombreConsignate;
        private System.Windows.Forms.DataGridView dataGridFincas;
    }
}
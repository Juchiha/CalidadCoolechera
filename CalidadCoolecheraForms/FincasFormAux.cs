using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalidadCoolecheraAcceso;
using CalidadCoolecheraModelos.Modelos;
using CalidadModelos.Modelos;

namespace CalidadCoolecheraForms
{
    public partial class FincasFormAux : Form
    {
        private DaoFincas dFincas;
        private DaoConsignantes daoConsignante;
        private BindingSource bs = new BindingSource();
        public string codigoConsignante;
        public string codigoFincaSeleccionada;

        public FincasFormAux()
        {
            InitializeComponent();
        }

        private void FincasFormAux_Load(object sender, EventArgs e)
        {
            var cadenaconexion = Properties.Settings.Default.Properties["cadenaconexion"].DefaultValue.ToString();
            dFincas = new DaoFincas(cadenaconexion);
            daoConsignante = new DaoConsignantes(cadenaconexion);
            bs.DataSource = dFincas.buscar(codigoConsignante);
            Consignante cons = daoConsignante.buscar(codigoConsignante);
            txtNombreConsignate.Text = cons.nombre;
            enlazarControles();
        }

        private void enlazarControles()
        {
            dataGridFincas.DataSource = bs;
            dataGridFincas.AutoGenerateColumns = false;
            dataGridFincas.AllowUserToAddRows = false;

            DataGridViewColumn column0 = dataGridFincas.Columns[0];
            DataGridViewColumn column1 = dataGridFincas.Columns[1];
            DataGridViewColumn column2 = dataGridFincas.Columns[2];
            DataGridViewColumn column3 = dataGridFincas.Columns[3];
            DataGridViewColumn column4 = dataGridFincas.Columns[4];
            DataGridViewColumn column5 = dataGridFincas.Columns[5];
            DataGridViewColumn column6 = dataGridFincas.Columns[6];
            DataGridViewColumn column7 = dataGridFincas.Columns[7];
            DataGridViewColumn column8 = dataGridFincas.Columns[8];
            column2.Visible = false;
            column4.Visible = false;
            column5.Visible = false;
            column6.Visible = false;
            column7.Visible = false;
            column8.Visible = false;

            column0.HeaderText = "Codigo Finca";
            column1.HeaderText = "Nombre Finca";
            column2.HeaderText = "Planta";

            column0.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            column0.ReadOnly = true;
            column1.ReadOnly = true;
            column2.ReadOnly = true;

        }

        private void dataGridFincas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show(dataGridFincas.Rows[e.RowIndex].Cells[0].Value.ToString());
            this.codigoFincaSeleccionada = dataGridFincas.Rows[e.RowIndex].Cells[0].Value.ToString();
            this.Close();
        }
    }
}

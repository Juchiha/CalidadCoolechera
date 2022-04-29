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
    public partial class ConsignantesAuxForm : Form
    {
        private DaoFincas dFincas;
        private DaoConsignantes daoConsignante;
        private BindingSource bs = new BindingSource();
        public string codigoConsignanteSeleccionado;
        public string nombreConsignanteSeleccionado;
        public ConsignantesAuxForm()
        {
            InitializeComponent();
        }

        private void ConsignantesForm_Load(object sender, EventArgs e)
        {
            var cadenaconexion = Properties.Settings.Default.Properties["cadenaconexion"].DefaultValue.ToString();
            dFincas = new DaoFincas(cadenaconexion);
            daoConsignante = new DaoConsignantes(cadenaconexion);
            bs.DataSource = daoConsignante.Listar();
            enlazarControles();
        }

        private void enlazarControles()
        {
            dataGridView1.DataSource = bs;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AllowUserToAddRows = false;

            DataGridViewColumn column0 = dataGridView1.Columns[0];
            DataGridViewColumn column1 = dataGridView1.Columns[1];
            DataGridViewColumn column2 = dataGridView1.Columns[2];
            DataGridViewColumn column3 = dataGridView1.Columns[3];
            DataGridViewColumn column4 = dataGridView1.Columns[4];
            DataGridViewColumn column5 = dataGridView1.Columns[5];
            DataGridViewColumn column6 = dataGridView1.Columns[6];
           /* DataGridViewColumn column7 = dataGridView1.Columns[7];
            DataGridViewColumn column8 = dataGridView1.Columns[8];*/
            column2.Visible = false;
            column3.Visible = false;
            column4.Visible = false;
            column6.Visible = false;

            column0.HeaderText = "Codigo";
            column1.HeaderText = "Nombre";
            column5.HeaderText = "Estado";


            column0.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            column0.ReadOnly = true;
            column1.ReadOnly = true;
            column5.ReadOnly = true;

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.codigoConsignanteSeleccionado = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            this.nombreConsignanteSeleccionado = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bs.DataSource = daoConsignante.Listar(txtbusqueda.Text.ToUpper());
            enlazarControles();  
        }

        private void txtbusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtbusqueda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bs.DataSource = daoConsignante.Listar(txtbusqueda.Text.ToUpper());
                enlazarControles();
            }
        }
    }
}

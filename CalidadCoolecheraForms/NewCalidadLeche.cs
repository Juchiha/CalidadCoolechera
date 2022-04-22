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
    public partial class NewCalidadLeche : Form
    {
        private DaoCalidadLeche dCalidadLeche;
        private DaoPeriodo dPeriodo;
        private DaoFincas dFinca;
        private DaoConsignantes dConsignantes;
        private BindingSource bs = new BindingSource();
        private bool esNuevoRegistro = false;

        public NewCalidadLeche()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void NewCalidadLeche_Load(object sender, EventArgs e)
        {
            var cadenaconexion = Properties.Settings.Default.Properties["cadenaconexion"].DefaultValue.ToString();
            dCalidadLeche = new DaoCalidadLeche(cadenaconexion);
            dPeriodo = new DaoPeriodo(cadenaconexion);
            dConsignantes = new DaoConsignantes(cadenaconexion);
            dFinca = new DaoFincas(cadenaconexion);
            List<ComboPeriodo> listPe = dPeriodo.ListarParaCombox();
            cmbPeriodo.DataSource = listPe;
            cmbPeriodo.ValueMember = "Id";
            cmbPeriodo.DisplayMember = "Nombre";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cmbPeriodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPeriodo.SelectedItem == null) return;

            ComboPeriodo cmb = (ComboPeriodo)cmbPeriodo.SelectedItem;
            if (cmb != null)
            {
                if (cmb.ds_estadoperiodocda == "A") { 
                    textEstado.Text = "ABIERTO"; 
                    dataGridView1.AllowUserToAddRows = true;
                    btnGuardarDatos.Enabled = true;
                } else { 
                    textEstado.Text = "CERRADO";
                    dataGridView1.AllowUserToAddRows = false;
                    btnGuardarDatos.Enabled = false;
                }
                bs.DataSource = dCalidadLeche.buscar(cmb.Id, Int32.Parse(cmb.Liquidacion));
                enlazarControles();
            }

        }

        private void enlazarControles()
        {
            dataGridView1.DataSource = bs;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AllowUserToAddRows = true;

            DataGridViewColumn column0 = dataGridView1.Columns[0];
            DataGridViewColumn column1 = dataGridView1.Columns[1];
            DataGridViewColumn column2 = dataGridView1.Columns[2];
            DataGridViewColumn column3 = dataGridView1.Columns[3];
            DataGridViewColumn column4 = dataGridView1.Columns[4];
            DataGridViewColumn column5 = dataGridView1.Columns[5];
            DataGridViewColumn column6 = dataGridView1.Columns[6];
            column0.HeaderText = "Fecha Muestra";
            column1.HeaderText = "Código Consignante";
            column2.HeaderText = "Nombre Consignante";
            column3.HeaderText = "Código Finca";
            column4.HeaderText = "Valor Densidad";
            column5.HeaderText = "Valor Solidos T";
            column6.HeaderText = "Valor UFC/ML";

            column0.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
 
        }

        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == 1 || e.ColumnIndex == 3 || e.ColumnIndex == 4 || e.ColumnIndex == 5 || e.ColumnIndex == 6) // 1 should be your column index
            {
                int i;

                if (!int.TryParse(Convert.ToString(e.FormattedValue), out i))
                {
                    e.Cancel = true;
                    MessageBox.Show("Por Favor Digita un numero");
                }
            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                string codigo = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                Consignante cons = dConsignantes.buscar(codigo);
                dataGridView1.Rows[e.RowIndex].Cells[2].Value = cons.nombre;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            /*Lo primero el periodo*/
            ComboPeriodo cmb = (ComboPeriodo)cmbPeriodo.SelectedItem;
            int resgistrosExitosos = 0;
            if (cmb != null)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells["cd_codigofinca"].Value != null && row.Cells["cd_codigoconsignante"].Value != null)
                    {
                        CalidadLeche caLeche = new CalidadLeche();
                        caLeche.ds_periodoliquidacion = cmb.Id;
                        caLeche.am_numeroliquidacion = Int32.Parse(cmb.Liquidacion);
                        caLeche.cd_codigoconsignante = Convert.ToString(row.Cells["cd_codigoconsignante"].Value);
                        caLeche.cd_codigofinca = Convert.ToString(row.Cells["cd_codigofinca"].Value);
                        caLeche.dt_fechamuestra = Convert.ToDateTime(row.Cells["dt_fechamuestra"].Value);
                        caLeche.am_valorsolidostotales = Convert.ToInt32(row.Cells["am_valorsolidostotales"].Value);
                        caLeche.am_valordensidad = Convert.ToInt32(row.Cells["am_valordensidad"].Value);
                        caLeche.am_valorunidadformadoracolonias = Convert.ToInt32(row.Cells["am_valorunidadformadoracolonias"].Value);
                        caLeche.ds_equipocreacion = Users.EQUIPO___;
                        caLeche.ds_usuariocreacion = Users.USUARIO__;
                        caLeche.dt_fechacreacion = DateTime.Now;
                        caLeche.dt_fechamodificacion = DateTime.Now;
                        caLeche.ds_equipomodificacion = Users.EQUIPO___;
                        caLeche.ds_usuariomodificacion = Users.USUARIO__;
                        caLeche.ds_programacreacion = Users.PROGRAMA_;
                        caLeche.ds_programamodificacion = Users.PROGRAMA_;
                        /*Validamos  Promedio*/
                        List<CalidadLeche> promediar = dCalidadLeche.ListarLastThreeMonts(caLeche);
                        if(promediar != null && promediar.Count > 0)
                        {
                            int PromedioSolidosTotales = 0;
                            int PromedioDensidad = 0;
                            int PromedioUFC = 0;
                            foreach (CalidadLeche calidadLeche in promediar)
                            {
                                PromedioDensidad += calidadLeche.am_promediodensidad;
                                PromedioSolidosTotales += calidadLeche.am_promediosolidostotales;
                                PromedioUFC += calidadLeche.am_promediounidadformadoracolonias;
                            }
                            int valorPromedioSolidosTotales = PromedioSolidosTotales / 3;
                            int valorPromedioDensidad = PromedioDensidad / 3; 
                            int valorPromedioUFC = PromedioUFC / 3;
                            caLeche.am_promediodensidad = valorPromedioSolidosTotales;
                            caLeche.am_promediosolidostotales = valorPromedioDensidad;
                            caLeche.am_promediounidadformadoracolonias = valorPromedioUFC;
                        }
                        else
                        {
                            caLeche.am_promediodensidad = Convert.ToInt32(row.Cells["am_valordensidad"].Value);
                            caLeche.am_promediosolidostotales = Convert.ToInt32(row.Cells["am_valorsolidostotales"].Value);
                            caLeche.am_promediounidadformadoracolonias = Convert.ToInt32(row.Cells["am_valorunidadformadoracolonias"].Value);
                        }
                        int resultado = dCalidadLeche.Insertar(caLeche);
                        if(resultado == 1)
                        {
                            resgistrosExitosos++;
                        }
                    } 
                }
                MessageBox.Show("Se crearon "+ resgistrosExitosos+" Registros de Manera Exitosa!");
            }
            
        }
    }
}

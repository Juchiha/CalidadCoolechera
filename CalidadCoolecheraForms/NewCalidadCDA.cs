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
    public partial class newCalidadCDA : Form
    {
        public DaoCalidadCDA dCalidad;
        public DaoConfiguracionCalidad dControlCal;
        public DaoBonificacion dBonificacion;
        private BindingSource bs = new BindingSource();
        private DaoPeriodo dPeriodo;
        public newCalidadCDA()
        {
            InitializeComponent();
        }

        private void newCalidadCDA_Load(object sender, EventArgs e)
        {
            var cadenaconexion = Properties.Settings.Default.Properties["cadenaconexion"].DefaultValue.ToString();
            dCalidad = new DaoCalidadCDA(cadenaconexion);
            dPeriodo = new DaoPeriodo(cadenaconexion);
            dControlCal = new DaoConfiguracionCalidad(cadenaconexion);
            dBonificacion = new DaoBonificacion(cadenaconexion);
            List<ComboPeriodo> listPe = dPeriodo.ListarParaCombox();
            cmbPeriodo.DataSource = listPe;
            cmbPeriodo.ValueMember = "Id";
            cmbPeriodo.DisplayMember = "Nombre";

        }

        private void cmbPeriodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPeriodo.SelectedItem == null) return;

            ComboPeriodo cmb = (ComboPeriodo)cmbPeriodo.SelectedItem;
            if (cmb != null)
            {
                if (cmb.ds_estadoperiodocda == "A")
                {
                    textEstado.Text = "ABIERTO";
                    dataGridView1.AllowUserToAddRows = true;
                    btnGuardarDatos.Enabled = true;
                    button2.Enabled = true;
                }
                else
                {
                    textEstado.Text = "CERRADO";
                    dataGridView1.AllowUserToAddRows = false;
                    btnGuardarDatos.Enabled = false;
                    button2.Enabled = false;
                }
                bs.DataSource = dCalidad.ListarDataGrid(cmb.Id, Int32.Parse(cmb.Liquidacion));
                enlazarControles();
            }

        }

        private ComboPeriodo getLastPeriodo(ComboPeriodo cmBNew)
        {
            string liquidacion = cmBNew.Liquidacion;
            int periodoLiquidar = Int32.Parse(cmBNew.Id);
            if (liquidacion.Equals("1"))
            {
                periodoLiquidar = periodoLiquidar - 1;
                liquidacion = "2";
            }
            else
            {
                liquidacion = "1";
            }
            ComboPeriodo box = new ComboPeriodo();
            box.Id = Convert.ToString(periodoLiquidar);
            box.Liquidacion = liquidacion;
            return box;
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
            DataGridViewColumn column7 = dataGridView1.Columns[7];
            DataGridViewColumn column8 = dataGridView1.Columns[8];
            DataGridViewColumn column9 = dataGridView1.Columns[9];
            DataGridViewColumn column10 = dataGridView1.Columns[10];
            DataGridViewColumn column11 = dataGridView1.Columns[11];
            DataGridViewColumn column12 = dataGridView1.Columns[12];
            DataGridViewColumn column13 = dataGridView1.Columns[13];
            DataGridViewColumn column14 = dataGridView1.Columns[14];
            DataGridViewColumn column15 = dataGridView1.Columns[15];

            column0.HeaderText = "Codigo Planta";
            column1.HeaderText = "Nombre Planta";
            column2.HeaderText = "Medicion Sol. Totales Q1";
            column3.HeaderText = "Medicion Sol. Totales Q2";
            column4.HeaderText = "Medición Sol. Totales Q Actual";
            column5.HeaderText = "Promedio densidad";
            column6.HeaderText = "Promedio S.Totales";
            column7.HeaderText = "Precio Gramo";
            column8.HeaderText = "Medicion UFC/ml Q1";
            column9.HeaderText = "Medicion UFC/ml Q2";
            column10.HeaderText = "Medicion UFC/ml Q Actual";
            column11.HeaderText = "Higienica UFC/ml";
            column12.HeaderText = "Bonificacion UFC";
            column13.HeaderText = "Valor Litro Bruto";
            column14.HeaderText = "Bonificacion Voluntaria";
            column15.HeaderText = "Valor Litro Neto";

            column0.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            column1.Width = 180;
            column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            column7.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            column8.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            column9.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            column10.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            column11.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            column12.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            column13.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            column14.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            column15.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            column0.Visible = false;
            column5.Visible = false;
            column2.Visible = false;
            column3.Visible = false;
            column8.Visible = false;
            column9.Visible = false;
            column1.ReadOnly = true;
            column7.ReadOnly = true;
            column6.ReadOnly = true;
            column11.ReadOnly = true;
            column12.ReadOnly = true;
            column13.ReadOnly = true;
            column14.ReadOnly = true;
            column15.ReadOnly = true;

            ComboPeriodo cmb = (ComboPeriodo)cmbPeriodo.SelectedItem;
            if (cmb != null)
            {
                if (cmb.ds_estadoperiodocda.Equals("A"))
                {
                    column0.ReadOnly = false;
                    column2.ReadOnly = false;
                    column3.ReadOnly = false;
                    column4.ReadOnly = false;
                    column8.ReadOnly = false;
                    column9.ReadOnly = false;
                    column10.ReadOnly = false;
                }
                else
                {
                    column0.ReadOnly = true;
                    column2.ReadOnly = true;
                    column3.ReadOnly = true;
                    column4.ReadOnly = true;
                    column8.ReadOnly = true;
                    column9.ReadOnly = true;
                    column10.ReadOnly = true;
                    
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardarDatos_Click(object sender, EventArgs e)
        {
            ComboPeriodo cmb = (ComboPeriodo)cmbPeriodo.SelectedItem;
            int resgistrosExitosos = 0;
            if (cmb != null)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells["cd_codigoplanta"].Value != null && row.Cells["nombrePlanta"].Value != null)
                    {
                        CalidadCDA caLeche = new CalidadCDA();
                        caLeche.ds_periodoliquidacion = cmb.Id;
                        caLeche.am_numeroliquidacion = Int32.Parse(cmb.Liquidacion);
                        caLeche.am_promediodensidad = 10.32;
                        caLeche.am_promediosolidostotales = Convert.ToDouble(row.Cells["am_promediosolidostotales"].Value);
                        caLeche.am_valorgramo = Convert.ToDouble(row.Cells["am_valorgramo"].Value);
                        caLeche.am_higienicaufc = Convert.ToDouble(row.Cells["am_higienicaufc"].Value);
                        caLeche.am_bonificacionufc = Convert.ToDouble(row.Cells["am_bonificacionufc"].Value);
                        caLeche.am_valorlitro = Convert.ToDouble(row.Cells["am_valorlitro"].Value);
                        caLeche.am_bonificacionvoluntaria = Convert.ToDouble(row.Cells["am_bonificacionvoluntaria"].Value);
                        caLeche.am_valorlitroneto = Convert.ToDouble(row.Cells["am_valorlitroneto"].Value);
                        caLeche.cd_codigoplanta = Convert.ToInt32(row.Cells["cd_codigoplanta"].Value);
                        caLeche.am_promedioquincena1 = Convert.ToDouble(row.Cells["am_promedioquincena1"].Value);
                        caLeche.am_promedioquincena2 = Convert.ToDouble(row.Cells["am_promedioquincena2"].Value);
                        caLeche.am_promedioquincena3 = Convert.ToDouble(row.Cells["am_promedioquincena3"].Value);
                        caLeche.am_promedioquincenaufc1 = Convert.ToDouble(row.Cells["am_promedioquincenaufc1"].Value);
                        caLeche.am_promedioquincenaufc2 = Convert.ToDouble(row.Cells["am_promedioquincenaufc2"].Value);
                        caLeche.am_promedioquincenaufc3 = Convert.ToDouble(row.Cells["am_promedioquincenaufc3"].Value);
                        caLeche.ds_equipocreacion = Users.EQUIPO___;
                        caLeche.ds_usuariocreacion = Users.USUARIO__;
                        caLeche.dt_fechacreacion = DateTime.Now;
                        caLeche.dt_fechamodificacion = DateTime.Now;
                        caLeche.ds_equipomodificacion = Users.EQUIPO___;
                        caLeche.ds_usuariomodificacion = Users.USUARIO__;
                        caLeche.ds_programacreacion = Users.PROGRAMA_;
                        caLeche.ds_programamodificacion = Users.PROGRAMA_;
                        /*Validamos  Promedio*/
                        CalidadCDA test = null;
                        test = dCalidad.buscar(caLeche);
                        int resultado = 0;
                        if (test != null)
                        {
                            resultado = dCalidad.Actualizar(caLeche);
                        } else {
                            resultado = dCalidad.Insertar(caLeche);
                        }
                        
                        if (resultado == 1)
                        {
                            resgistrosExitosos++;
                        }
                    }
                }
                MessageBox.Show("Se crearon " + resgistrosExitosos + " Registros de Manera Exitosa!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ComboPeriodo cmb = (ComboPeriodo)cmbPeriodo.SelectedItem;
            int resgistrosExitosos = 0;
            if (cmb != null)
            {
                Periodo per = new Periodo();
                per.am_numeroliquidacion = Convert.ToInt32(cmb.Liquidacion);
                per.ds_periodoliquidacion = cmb.Id;
                per.ds_estadoperiodoasociado = cmb.ds_estadoperiodoasociado;
                per.ds_estadoperiodocda = "C";
                per.dt_fechamodificacion = DateTime.Now;
                per.ds_equipomodificacion = Users.EQUIPO___;
                per.ds_usuariomodificacion = Users.USUARIO__;
                per.ds_programamodificacion = Users.PROGRAMA_;
                int resul = dPeriodo.Actualizar(per);
                if (resul > 0)
                {
                    List<ComboPeriodo> listPe = dPeriodo.ListarParaCombox();
                    cmbPeriodo.DataSource = listPe;
                    cmbPeriodo.ValueMember = "Id";
                    cmbPeriodo.DisplayMember = "Nombre";
                }

                MessageBox.Show("Proceso terminado!");
            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2 || e.ColumnIndex == 3 || e.ColumnIndex == 4)
            {
                
                ComboPeriodo cmb = (ComboPeriodo)cmbPeriodo.SelectedItem;
                if (cmb != null)
                {
                    /*string codigoFinca = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();*/
                    ComboPeriodo cmbBusqueda = getLastPeriodo(cmb);
                    ComboPeriodo cmbBusquedaP2 = getLastPeriodo(cmbBusqueda);
                    double prom = 0;
                    double total = 1;
                    double quincena1 = 0;
                    double quincena2 = 0;
                    double quincena3 = Convert.ToDouble(dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());

                    /*Obtenemos la primera Quincena*/
                    CalidadCDA calid = new CalidadCDA();
                    calid.cd_codigoplanta = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                    calid.am_numeroliquidacion = Convert.ToInt32(cmbBusqueda.Liquidacion);
                    calid.ds_periodoliquidacion = cmbBusqueda.Id;
                    calid = dCalidad.buscar(calid);
                    
                    if (calid != null && calid.am_promediosolidostotales > 0)
                    {
                        quincena1 = calid.am_promediosolidostotales;
                        total++;
                    }
                    /*Obtenemos la segunda Quincena*/
                    calid = null;
                    calid = new CalidadCDA();
                    calid.cd_codigoplanta = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                    calid.am_numeroliquidacion = Convert.ToInt32(cmbBusquedaP2.Liquidacion);
                    calid.ds_periodoliquidacion = cmbBusquedaP2.Id;
                    calid = dCalidad.buscar(calid);

                    if (calid != null && calid.am_promediosolidostotales > 0)
                    {
                        quincena2 = calid.am_promediosolidostotales;
                        total++;
                    }
                    prom = (Convert.ToDouble(quincena1) + Convert.ToDouble(quincena2) + Convert.ToDouble(quincena3)) / total;
                    dataGridView1.Rows[e.RowIndex].Cells[6].Value = Truncate(prom, 2);
                    dataGridView1.Rows[e.RowIndex].Cells[2].Value = quincena1;
                    dataGridView1.Rows[e.RowIndex].Cells[3].Value = quincena2;
                    ConfiguracionCalidad Vdensidad = dControlCal.buscar("DLeche");
                    ConfiguracionCalidad Vgramo = dControlCal.buscar("VGramo");
                    double precioGramo = Convert.ToDouble(Vgramo.ds_valorvariable) * prom * Convert.ToDouble(Vdensidad.ds_valorvariable);
                    dataGridView1.Rows[e.RowIndex].Cells[7].Value = Truncate(precioGramo, 2);
                    double valid = Convert.ToDouble(dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString());
                    if(valid > 0)
                    {
                        liquidarUFC(e.RowIndex);
                    }
                }    
            }
            else if (e.ColumnIndex == 10)
            {
                liquidarUFC(e.RowIndex);
            }
        }

        public void liquidarUFC(int rowIndex)
        {
            ComboPeriodo cmb = (ComboPeriodo)cmbPeriodo.SelectedItem;
            if (cmb != null)
            {
                /*string codigoFinca = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();*/
                ComboPeriodo cmbBusqueda = getLastPeriodo(cmb);
                ComboPeriodo cmbBusquedaP2 = getLastPeriodo(cmbBusqueda);
                double prom = 0;
                double total = 1;
                double quincena1 = 0;
                double quincena2 = 0;
                double quincena3 = Convert.ToDouble(dataGridView1.Rows[rowIndex].Cells[10].Value.ToString());
                /*Obtenemos la primera Quincena*/
                CalidadCDA calid = new CalidadCDA();
                calid.cd_codigoplanta = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells[0].Value.ToString());
                calid.am_numeroliquidacion = Convert.ToInt32(cmbBusqueda.Liquidacion);
                calid.ds_periodoliquidacion = cmbBusqueda.Id;
                calid = dCalidad.buscar(calid);
                
                if (calid != null && calid.am_higienicaufc > 0)
                {
                    quincena1 = calid.am_higienicaufc;
                    total++;
                }
                /*Obtenemos la segunda Quincena*/
                calid = null;
                calid = new CalidadCDA();
                calid.cd_codigoplanta = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells[0].Value.ToString());
                calid.am_numeroliquidacion = Convert.ToInt32(cmbBusquedaP2.Liquidacion);
                calid.ds_periodoliquidacion = cmbBusquedaP2.Id;
                calid = dCalidad.buscar(calid);

                if (calid != null && calid.am_higienicaufc > 0)
                {
                    quincena2 = calid.am_higienicaufc;
                    total++;
                }
      
                prom = (Convert.ToDouble(quincena1) + Convert.ToDouble(quincena2) + Convert.ToDouble(quincena3)) / total;
                dataGridView1.Rows[rowIndex].Cells[11].Value = Truncate(prom, 2);
                ConfiguracionCalidad VprecioBase = dControlCal.buscar("VPrecioBase");
                List<Bonificacion> bonificaciones = dBonificacion.Listar();
                int valorUFC = 0;
                int valorFrio = 0;
                foreach (Bonificacion bon in bonificaciones)
                {
                    if (prom >= bon.am_rangoinferior && prom <= bon.am_rangosuperior)
                    {
                        /*Esta en este Rango*/
                        valorUFC = bon.am_pagobacterias;
                        valorFrio = bon.am_pagofrio;
                    }
                }
                double precioBruto = Convert.ToDouble(dataGridView1.Rows[rowIndex].Cells[7].Value.ToString()) + valorUFC;
                double BonificacionVol = Convert.ToDouble(VprecioBase.ds_valorvariable) - precioBruto;
                dataGridView1.Rows[rowIndex].Cells[14].Value = Truncate(BonificacionVol,2);
                dataGridView1.Rows[rowIndex].Cells[12].Value = Truncate(valorUFC, 2);
                dataGridView1.Rows[rowIndex].Cells[13].Value = Truncate(precioBruto, 2);
                dataGridView1.Rows[rowIndex].Cells[8].Value = quincena1;
                dataGridView1.Rows[rowIndex].Cells[9].Value = quincena2;
                double valorLitro = BonificacionVol + precioBruto;
                dataGridView1.Rows[rowIndex].Cells[15].Value = Truncate(valorLitro,2);

            }
        }

        public static double Truncate(double value, int decimales)
        {
            double aux_value = Math.Pow(10, decimales);
            return (Math.Truncate(value * aux_value) / aux_value);
        }

    }
}

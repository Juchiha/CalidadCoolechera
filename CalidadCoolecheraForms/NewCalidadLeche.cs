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
        private DaoConfiguracionCalidad dControlCal;
        private DaoBonificacion dBonificacion;
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
            dControlCal = new DaoConfiguracionCalidad(cadenaconexion);
            dBonificacion = new DaoBonificacion(cadenaconexion);
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
                if (cmb.ds_estadoperiodoasociado.Equals("A")) { 
                    textEstado.Text = "ABIERTO"; 
                    dataGridView1.AllowUserToAddRows = true;
                    btnGuardarDatos.Enabled = true;
                    button2.Enabled = true;
                } else { 
                    textEstado.Text = "CERRADO";
                    dataGridView1.AllowUserToAddRows = false;
                    btnGuardarDatos.Enabled = false;
                    button2.Enabled = false;
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
            column4.HeaderText = "Nombre Finca";
            column5.HeaderText = "Valor Solidos T";
            column6.HeaderText = "Valor UFC/ML";

            column0.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            column4.ReadOnly = true;
            column2.ReadOnly = true;
            column4.Width = 100;


            ComboPeriodo cmb = (ComboPeriodo)cmbPeriodo.SelectedItem;
            if (cmb != null)
            {
                if (cmb.ds_estadoperiodoasociado.Equals("A"))
                {
                    column0.ReadOnly = false;
                    column1.ReadOnly = false;
                    column3.ReadOnly = false;
                    column5.ReadOnly = false;
                    column6.ReadOnly = false;
                }
                else
                {
                    column0.ReadOnly = true;
                    column1.ReadOnly = true;
                    column3.ReadOnly = true;
                    column5.ReadOnly = true;
                    column6.ReadOnly = true;
                }
            }
        }

        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == 1 || e.ColumnIndex == 3 || e.ColumnIndex == 5 || e.ColumnIndex == 6) // 1 should be your column index
            {
                double i;
                if (!Double.TryParse(Convert.ToString(e.FormattedValue), out i))
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
                if(cons != null)
                {
                    if(cons.estado.Equals("X"))
                    {
                        MessageBox.Show("Productor Inactivo, por favor verifique NOMBRE: "+ cons.nombre+" MOTIVO: "+cons.comentario);
                    }
                    else
                    {
                        dataGridView1.Rows[e.RowIndex].Cells[2].Value = cons.nombre;
                    }
                    
                }
                else
                {
                    var frmAuxConsignantes = new ConsignantesAuxForm();
                    frmAuxConsignantes.ShowDialog();
                    dataGridView1.Rows[e.RowIndex].Cells[1].Value = frmAuxConsignantes.codigoConsignanteSeleccionado;
                    dataGridView1.Rows[e.RowIndex].Cells[2].Value = frmAuxConsignantes.nombreConsignanteSeleccionado;
                }
                

            }else if(e.ColumnIndex == 3)
            {
                string codigoFinca = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                string codigoConsignante = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                getPromediosParaText(codigoConsignante, codigoFinca);

            }
        }

        public List<ComboPeriodo> getLastTreePeriodos(ComboPeriodo cmBNew)
        {
            List<ComboPeriodo> cmbNPeriodos = new List<ComboPeriodo>();
            string liquidacion = cmBNew.Liquidacion;
            int periodoLiquidar = Int32.Parse(cmBNew.Id);
            for (int i = 1; i <= 3; i++)
            {
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
                cmbNPeriodos.Add(box);
            }
            return cmbNPeriodos;
        }

        public void getPromediosParaText(String codigoConsignante, string codigoFinca)
        {
            ComboPeriodo cmb = (ComboPeriodo)cmbPeriodo.SelectedItem;
            if (cmb != null)
            {
                List<ComboPeriodo> cmbNPeriodos = getLastTreePeriodos(cmb);
                CalidadLeche caLeche = new CalidadLeche();
                caLeche.cd_codigoconsignante = codigoConsignante;
                caLeche.cd_codigofinca = codigoFinca;
                List<CalidadLeche> promediar = dCalidadLeche.ListarLastThreeMonts(cmbNPeriodos, caLeche);
                if (promediar != null && promediar.Count > 0)
                {
                    double promSol1 = promediar[0].am_promediosolidostotales;
                    double promSol2 = 0;
                    double promSol3 = 0;


                    double promUfc1 = promediar[0].am_promediounidadformadoracolonias;
                    double promUfc2 = 0;
                    double promUfc3 = 0;

                    if (promediar.Count > 1)
                    {
                        promSol2 = promediar[1].am_promediosolidostotales;
                        promUfc2 = promediar[1].am_promediounidadformadoracolonias;

                    }
                    if (promediar.Count > 2)
                    {
                        promSol3 = promediar[2].am_promediosolidostotales;
                        promUfc3 = promediar[2].am_promediounidadformadoracolonias;
                    }
                    txtSolidos1.Text = promSol1.ToString();
                    
                    txtSolidos2.Text = promSol2.ToString();
                    txtSolidos3.Text = promSol3.ToString(); 
                    double promedioSolidos = promSol1 + promSol2 + promSol3 / promediar.Count;
                    txtPromedioSolidos.Text = promedioSolidos.ToString();

                    txtUfc1.Text = promUfc1.ToString();
                    txtUfc2.Text = promUfc2.ToString();
                    txtUfc3.Text = promUfc3.ToString();
                    double promedioUFC = promUfc1 + promUfc2 + promUfc3 / promediar.Count;
                    txtPromedioUfc.Text = promedioUFC.ToString();

                }
                else
                {
                    
                    txtSolidos1.Text = "0";
                    txtSolidos2.Text = "0";
                    txtSolidos3.Text = "0";
                    txtPromedioSolidos.Text = "0";

                    txtUfc1.Text = "0";
                    txtUfc2.Text = "0";
                    txtUfc3.Text = "0";
                    txtPromedioUfc.Text = "0";
                }
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
                        caLeche.am_valorsolidostotales = Convert.ToDouble(row.Cells["am_valorsolidostotales"].Value);
                        caLeche.am_valordensidad = 10.32;
                        caLeche.am_valorunidadformadoracolonias = Convert.ToDouble(row.Cells["am_valorunidadformadoracolonias"].Value);
                        caLeche.ds_equipocreacion = Users.EQUIPO___;
                        caLeche.ds_usuariocreacion = Users.USUARIO__;
                        caLeche.dt_fechacreacion = DateTime.Now;
                        caLeche.dt_fechamodificacion = DateTime.Now;
                        caLeche.ds_equipomodificacion = Users.EQUIPO___;
                        caLeche.ds_usuariomodificacion = Users.USUARIO__;
                        caLeche.ds_programacreacion = Users.PROGRAMA_;
                        caLeche.ds_programamodificacion = Users.PROGRAMA_;
                        /*Validamos  Promedio*/

                        List<ComboPeriodo> cmbNPeriodos = getLastTreePeriodos(cmb);
                        List<CalidadLeche> promediar = dCalidadLeche.ListarLastThreeMonts(cmbNPeriodos, caLeche);
                        if(promediar != null && promediar.Count > 0)
                        {
                            double PromedioSolidosTotales = 0;
                            double PromedioDensidad = 0;
                            double PromedioUFC = 0;
                            foreach (CalidadLeche calidadLeche in promediar)
                            {
                                PromedioDensidad += calidadLeche.am_promediodensidad;
                                PromedioSolidosTotales += calidadLeche.am_promediosolidostotales;
                                PromedioUFC += calidadLeche.am_promediounidadformadoracolonias;
                            }
                            double valorPromedioSolidosTotales = PromedioSolidosTotales + caLeche.am_valorsolidostotales / promediar.Count;
                            double valorPromedioDensidad = PromedioDensidad / promediar.Count;
                            double valorPromedioUFC = PromedioUFC + caLeche.am_valorunidadformadoracolonias / promediar.Count;

                            caLeche.am_promediodensidad = valorPromedioDensidad;
                            caLeche.am_promediosolidostotales = valorPromedioSolidosTotales;
                            caLeche.am_promediounidadformadoracolonias = valorPromedioUFC;
                        }
                        else
                        {
                            caLeche.am_promediodensidad = 10.32;
                            caLeche.am_promediosolidostotales = Convert.ToInt32(row.Cells["am_valorsolidostotales"].Value);
                            caLeche.am_promediounidadformadoracolonias = Convert.ToInt32(row.Cells["am_valorunidadformadoracolonias"].Value);
                        }

                        CalidadLeche test = null;
                        test = dCalidadLeche.getCalidadRow(caLeche);
                        int resultado = 0;
                        if (test != null)
                        {
                            resultado = dCalidadLeche.Actualizar(caLeche);
                        }
                        else
                        {
                            resultado = dCalidadLeche.Insertar(caLeche);
                        }
                        if(resultado == 1)
                        {
                            resgistrosExitosos++;
                        }
                    } 
                }
                MessageBox.Show("Se crearon "+ resgistrosExitosos+" Registros de Manera Exitosa!");
            }
            
        }
        private void cambioPosicion()
        {
            if (bs.Current != null)
            {
                var calidadLeche = (DataGridCalidaLeche)bs.Current;
                
            }
        }

        private void PositionChanged(object sender, System.EventArgs e)
        {
            try
            {
                cambioPosicion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error no controlado " + ex.Message);
            }
        }

        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                string codigoConsignante = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                var frmFincas = new FincasFormAux();
                frmFincas.codigoConsignante = codigoConsignante;
                frmFincas.ShowDialog();
                dataGridView1.Rows[e.RowIndex].Cells[3].Value = frmFincas.codigoFincaSeleccionada;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*Primero vamos a tener que obtener los valores para Obtener los promedios*/
            ConfiguracionCalidad Vdensidad = dControlCal.buscar("DLeche");
            ConfiguracionCalidad Vgramo = dControlCal.buscar("VGramo");
            List<Bonificacion> bonificaciones = dBonificacion.Listar();
            int resgistrosExitosos = 0;
            /*Ya tenemos los valores*/
            ComboPeriodo cmb = (ComboPeriodo)cmbPeriodo.SelectedItem;
            if (cmb != null)
            {
                
                List <CalidadLeche> listaRegistro = dCalidadLeche.Listar(cmb.Id, Int32.Parse(cmb.Liquidacion));
                foreach(CalidadLeche dat in listaRegistro)
                {
                    double precioGramo = Convert.ToDouble(Vdensidad.ds_valorvariable) * Convert.ToDouble(Vgramo.ds_valorvariable) * dat.am_promediosolidostotales;
                    int valorUFC = 0;
                    int valorFrio = 0;
                    int valorVolFrio = 0;
                    foreach(Bonificacion bon in bonificaciones)
                    {
                        if (dat.am_promediounidadformadoracolonias >= bon.am_rangoinferior && dat.am_promediounidadformadoracolonias <= bon.am_rangosuperior)
                        {
                            /*Esta en este Rango*/
                            valorUFC = bon.am_pagobacterias;
                            valorFrio = bon.am_pagofrio;
                            valorVolFrio = bon.am_valorfriovoluntario;
                        }
                    }
                    string codigoConsignante = dat.cd_codigoconsignante.Substring(0, 1);
                    if (codigoConsignante.Equals("0"))
                    {
                        /*Socio*/
                        valorVolFrio = 150 - valorFrio;
                    }
                    else if(codigoConsignante.Equals("6"))
                    {
                        /*Particular*/
                        valorVolFrio = 50 - valorFrio;
                    }//Falta para lo de las cooperativas

                    double valorPrecioFinal = precioGramo + valorVolFrio + valorUFC + valorFrio;
                    dat.am_valordensidad = Convert.ToDouble(Vdensidad.ds_valorvariable);
                    dat.am_bonificacionformadoracolonias = valorUFC;
                    dat.am_bonificacionformadoracoloniasfria = valorFrio;
                    dat.am_bonificacionvoluntariafria = valorVolFrio;
                    dat.am_valorlitro = valorPrecioFinal;
                    dat.am_valorgramo = precioGramo;
                    int resultado = dCalidadLeche.Actualizar(dat);


                    if (resultado == 1)
                    {
                        resgistrosExitosos++;
                    }
                }
                Periodo per = new Periodo();
                per.am_numeroliquidacion = Convert.ToInt32(cmb.Liquidacion);
                per.ds_periodoliquidacion = cmb.Id;
                per.ds_estadoperiodoasociado = "C";
                per.ds_estadoperiodocda = cmb.ds_estadoperiodocda;
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

                MessageBox.Show("Se crearon " + resgistrosExitosos + " Registros de Manera Exitosa!");
            }
               
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            /*foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                string codigoConsignante = Convert.ToString(row.Cells["cd_codigoconsignante"].Value);
                string codigoFinca = Convert.ToString(row.Cells["cd_codigofinca"].Value);
                etPromediosParaText(codigoConsignante, codigoFinca);
            }*/
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (bs.Current != null)
            {
                var calidadLeche = (DataGridCalidaLeche)bs.Current;
                getPromediosParaText(calidadLeche.cd_codigoconsignante, calidadLeche.cd_codigofinca);
            }
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

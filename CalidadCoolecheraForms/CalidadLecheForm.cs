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
using CalidadModelos.Modelos;

namespace CalidadCoolecheraForms
{
    public partial class CalidadLecheForm : Form
    {
        private DaoCalidadLeche dCalidadLeche;
        private BindingSource bs = new BindingSource();
        private bool esNuevoRegistro = false;

        public CalidadLecheForm()
        {
            InitializeComponent();
        }

        private void CalidadLecheForm_Load(object sender, EventArgs e)
        {
            var cadenaconexion = Properties.Settings.Default.Properties["cadenaconexion"].DefaultValue.ToString();
            dCalidadLeche = new DaoCalidadLeche(cadenaconexion);
            bs.DataSource = dCalidadLeche.Listar();
            datePickerFechaMuestra.CustomFormat = "yyyy-MM-dd";
            datePickerFechaMuestra.Format = DateTimePickerFormat.Custom;
            enlazarControles();
        }


        private void enlazarControles()
        {
            dgv.DataSource = bs;
            dgv.AutoGenerateColumns = false;
            DataGridViewColumn column23 = dgv.Columns[23];
            DataGridViewColumn column24 = dgv.Columns[24];
            DataGridViewColumn column25 = dgv.Columns[25];
            DataGridViewColumn column26 = dgv.Columns[26];
            DataGridViewColumn column27 = dgv.Columns[27];
            DataGridViewColumn column28 = dgv.Columns[28];
            DataGridViewColumn column29 = dgv.Columns[29];
            DataGridViewColumn column30 = dgv.Columns[30];
            column23.Visible = false;
            column24.Visible = false;
            column25.Visible = false;
            column26.Visible = false;
            column27.Visible = false;
            column28.Visible = false;
            column29.Visible = false;
            column30.Visible = false;

            DataGridViewColumn column0 = dgv.Columns[0];
            DataGridViewColumn column1 = dgv.Columns[1];
            DataGridViewColumn column2 = dgv.Columns[2];
            DataGridViewColumn column3 = dgv.Columns[3];
            DataGridViewColumn column4 = dgv.Columns[4];
            DataGridViewColumn column5 = dgv.Columns[5];
            DataGridViewColumn column6 = dgv.Columns[6];
            DataGridViewColumn column7 = dgv.Columns[7];
            DataGridViewColumn column8 = dgv.Columns[8];
            DataGridViewColumn column9 = dgv.Columns[9];
            DataGridViewColumn column10 = dgv.Columns[10];
            DataGridViewColumn column11 = dgv.Columns[11];
            DataGridViewColumn column12 = dgv.Columns[12];
            DataGridViewColumn column13 = dgv.Columns[13];
            DataGridViewColumn column14 = dgv.Columns[14];
            DataGridViewColumn column15 = dgv.Columns[15];
            DataGridViewColumn column16 = dgv.Columns[16];
            DataGridViewColumn column17 = dgv.Columns[17];
            DataGridViewColumn column18 = dgv.Columns[18];
            DataGridViewColumn column19 = dgv.Columns[19];
            DataGridViewColumn column20 = dgv.Columns[20];
            DataGridViewColumn column21 = dgv.Columns[21];
            DataGridViewColumn column22 = dgv.Columns[22];
            column0.HeaderText = "Periodo Liquidación";
            column1.HeaderText = "Numero Liquidación";
            column2.HeaderText = "Código Finca";
            column3.HeaderText = "Código Consignante";
            column4.HeaderText = "Fecha muestra";
            column5.HeaderText = "Valor Densidad";
            column6.HeaderText = "Promedio Densidad";
            column7.HeaderText = "Valor Solidos Totales";
            column8.HeaderText = "Promedio Solidos Totales";
            column9.HeaderText = "Bonificación Solidos Totales";
            column10.HeaderText = "Valor Grasa";
            column11.HeaderText = "Promedio Grasa";
            column12.HeaderText = "Bonificación Grasa";
            column13.HeaderText = "Valor Proteina";
            column14.HeaderText = "Promedio Proteina";
            column15.HeaderText = "Bonificación Proteina";
            column16.HeaderText = "Valor Unidad Formadora Colonia";
            column17.HeaderText = "Promedio Unidad Formadora Colonia";
            column18.HeaderText = "Bonificación Unidad Formadora Colonia";
            column19.HeaderText = "Bonificación Unidad Formadora Colonia Fria";
            column20.HeaderText = "Bonificacion Voluntaria";
            column21.HeaderText = "Bonificacion Voluntaria Calidad";
            column22.HeaderText = "Valor Litro";
            

           /* column0.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
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
            column16.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            column17.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            column18.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            column19.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            column20.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            column21.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            column22.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;*/

           
            txtPeriodoLiquidacion.DataBindings.Add("Text", bs, "ds_periodoliquidacion");
            txtNumeroLiquidacion.DataBindings.Add("Text", bs, "am_numeroliquidacion");
            txtCodigoFinca.DataBindings.Add("Text", bs, "cd_codigofinca");
            txtCodigoConsignante.DataBindings.Add("Text", bs, "cd_codigoconsignante");
            txtValorDensidad.DataBindings.Add("Text", bs, "am_valordensidad");
            txtPromedioDensidad.DataBindings.Add("Text", bs, "am_promediodensidad");
            txtSolidosTotales.DataBindings.Add("Text", bs, "am_valorsolidostotales");
            txtPromedioSolidosTotales.DataBindings.Add("Text", bs, "am_promediosolidostotales");
            txtBonificacionSolidosTotales.DataBindings.Add("Text", bs, "am_bonificacionsolidostotales");
            txtValorGrasa.DataBindings.Add("Text", bs, "am_valorgrasa");
            txtPromedioGrasa.DataBindings.Add("Text", bs, "am_promediograsa");
            txtBonificacionGrasa.DataBindings.Add("Text", bs, "am_bonificaciongrasa");
            txtValorProteina.DataBindings.Add("Text", bs, "am_valorproteina");
            txtPromedioProteina.DataBindings.Add("Text", bs, "am_promedioproteina");
            txtBonificacionProteina.DataBindings.Add("Text", bs, "am_bonificacionproteina");
            txtValorUnidadFormadora.DataBindings.Add("Text", bs, "am_valorunidadformadoracolonias");
            txtPromedioUnidadFormadora.DataBindings.Add("Text", bs, "am_promediounidadformadoracolonias");
            txtBonificacionUnidadFormadora.DataBindings.Add("Text", bs, "am_bonificacionformadoracolonias");
            txtBonificacionUnidadFormadoraFria.DataBindings.Add("Text", bs, "am_bonificacionformadoracoloniasfria");
            txtBonificacionVoluntariaCalidad.DataBindings.Add("Text", bs, "am_bonificacionvoluntariacalidad");
            txtBonificacionVoluntariaFria.DataBindings.Add("Text", bs, "am_bonificacionvoluntariafria");
            txtValorLitro.DataBindings.Add("Text", bs, "am_valorlitro");
            //datePickerFechaMuestra.DataBindings.Add("Value", bs, "dt_fechamuestra");
            dgv.AllowUserToAddRows = false;
        }

        private void Guardar()
        {
            if (bs.Current == null)
            {
                MessageBox.Show("Registro no existe");
            }
            else
            {
                var calidadLeche = (CalidadLeche)bs.Current;
                if (esNuevoRegistro)
                {
                    //se crea un nuevo registro
                    calidadLeche.ds_equipocreacion = Users.EQUIPO___;
                    calidadLeche.ds_usuariocreacion = Users.USUARIO__;
                    calidadLeche.dt_fechacreacion = DateTime.Now;
                    calidadLeche.dt_fechamodificacion = DateTime.Now;
                    calidadLeche.ds_equipomodificacion = Users.EQUIPO___;
                    calidadLeche.ds_usuariomodificacion = Users.USUARIO__;
                    calidadLeche.ds_programacreacion = Users.PROGRAMA_;
                    calidadLeche.ds_programamodificacion = Users.PROGRAMA_;
                    int resultado = dCalidadLeche.Insertar(calidadLeche);
                    MessageBox.Show("Nuevo registro creado");
                }
                else
                {
                    //se actualiza el registro actual
                    calidadLeche.dt_fechamodificacion = DateTime.Now;
                    calidadLeche.ds_equipomodificacion = Users.EQUIPO___;
                    calidadLeche.ds_usuariomodificacion = Users.USUARIO__;
                    calidadLeche.ds_programamodificacion = Users.PROGRAMA_;
                    dCalidadLeche.Actualizar(calidadLeche);
                    MessageBox.Show("registro actualizado");
                }
                esNuevoRegistro = false;
                bs.ResetCurrentItem();
            }
        }

        private void cambioPosicion()
        {
            if (esNuevoRegistro)
            {
                esNuevoRegistro = false;
                bs.MoveLast();

                if (bs.Current != null)
                {
                    var calidadLeche = (CalidadLeche)bs.Current;
                    if (calidadLeche.ds_periodoliquidacion.Equals("0"))
                    {
                        bs.RemoveCurrent();
                    }
                }

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

        private void Borrar()
        {
            if (bs.Current == null)
            {
                MessageBox.Show("Periodo no existe");
            }
            else
            {
                var calidadLeche = (CalidadLeche)bs.Current;
                dCalidadLeche.Borrar(calidadLeche);
                bs.RemoveCurrent();
            }

        }

        private void btnNuevoRegistro_Click(object sender, EventArgs e)
        {
            bs.EndEdit();
            bs.AddNew();
            esNuevoRegistro = true;
        }

        private void btnGuardarInfo_Click(object sender, EventArgs e)
        {
            try
            {
                Guardar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error no controlado " + ex.Message);
            }
        }

        private void btnBorrarInfo_Click(object sender, EventArgs e)
        {
            try
            {
                Borrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error no controlado " + ex.Message);
            }
        }
    }
}

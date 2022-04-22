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
    public partial class ParametrosForm : Form
    {
        private DaoPeriodo dperiodo;
        private BindingSource bs = new BindingSource();
        private bool esNuevoRegistro = false;

        public ParametrosForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bs.EndEdit();
            bs.AddNew();
            esNuevoRegistro = true;
        }

        private void ParametrosForm_Load(object sender, EventArgs e)
        {
            var cadenaconexion = Properties.Settings.Default.Properties["cadenaconexion"].DefaultValue.ToString();
            dperiodo = new DaoPeriodo(cadenaconexion);
            bs.DataSource = dperiodo.Listar();
            enlazarControles();
        }

        private void enlazarControles()
        {
            dgv.DataSource = bs;
            dgv.AutoGenerateColumns = false;
            DataGridViewColumn column3 = dgv.Columns[3];
            DataGridViewColumn column4 = dgv.Columns[4];
            DataGridViewColumn column5 = dgv.Columns[5];
            DataGridViewColumn column6 = dgv.Columns[6];
            DataGridViewColumn column7 = dgv.Columns[7];
            DataGridViewColumn column8 = dgv.Columns[8];
            DataGridViewColumn column9 = dgv.Columns[9];
            DataGridViewColumn column10 = dgv.Columns[10];
            column3.Visible = false;
            column4.Visible = false;
            column5.Visible = false;
            column6.Visible = false;
            column7.Visible = false;
            column8.Visible = false;
            column9.Visible = false;
            column10.Visible = false;

            DataGridViewColumn column0 = dgv.Columns[0];
            DataGridViewColumn column1 = dgv.Columns[1];
            DataGridViewColumn column2 = dgv.Columns[2];
            DataGridViewColumn column11 = dgv.Columns[11];
            column0.HeaderText = "Periodo Liquidación";
            column1.HeaderText = "Numero Liquidación";
            column2.HeaderText = "Estado Periodo CDA";
            column11.HeaderText = "Estado Periodo Asociado";
            column0.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; 
            column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            column11.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            txtPeriodoLiquidacion.DataBindings.Add("Text", bs, "ds_periodoliquidacion");
            txtNumeroPeriodo.DataBindings.Add("Text", bs, "am_numeroliquidacion");
            txtEstadoPeriodoCda.DataBindings.Add("Text", bs, "ds_estadoperiodocda");
            txtEstadoAsociado.DataBindings.Add("Text", bs, "ds_estadoperiodoasociado");
            dgv.AllowUserToAddRows = false;
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

        private void Guardar()
        {
            if (bs.Current == null)
            {
                MessageBox.Show("Periodo no existe");
            }
            else
            {
                var periodo = (Periodo)bs.Current;
                if (esNuevoRegistro)
                {
                    //se crea un nuevo registro
                    periodo.ds_equipocreacion = Users.EQUIPO___;
                    periodo.ds_usuariocreacion = Users.USUARIO__;
                    periodo.dt_fechacreacion = DateTime.Now;
                    periodo.dt_fechamodificacion = DateTime.Now;
                    periodo.ds_equipomodificacion = Users.EQUIPO___;
                    periodo.ds_usuariomodificacion = Users.USUARIO__;
                    periodo.ds_programacreacion = Users.PROGRAMA_;
                    periodo.ds_programamodificacion = Users.PROGRAMA_;
                    int resultado = dperiodo.Insertar(periodo);
                    MessageBox.Show("Nuevo registro creado");
                }
                else
                {
                    //se actualiza el registro actual
                    periodo.dt_fechamodificacion = DateTime.Now;
                    periodo.ds_equipomodificacion = Users.EQUIPO___;
                    periodo.ds_usuariomodificacion = Users.USUARIO__;
                    periodo.ds_programamodificacion = Users.PROGRAMA_;
                    dperiodo.Actualizar(periodo);
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
                    var periodo = (Periodo)bs.Current;
                    if (periodo.ds_periodoliquidacion.Equals("0"))
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
                var periodo = (Periodo)bs.Current;
                dperiodo.Borrar(periodo);
                bs.RemoveCurrent();
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

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }


}

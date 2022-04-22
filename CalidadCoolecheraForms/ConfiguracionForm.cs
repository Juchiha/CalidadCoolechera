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
    public partial class ConfiguracionForm : Form
    {
        private DaoConfiguracionCalidad dConfigCal;
        private BindingSource bs = new BindingSource();
        private bool esNuevoRegistro = false;

        public ConfiguracionForm()
        {
            InitializeComponent();
        }

        private void ConfiguracionForm_Load(object sender, EventArgs e)
        {
            var cadenaconexion = Properties.Settings.Default.Properties["cadenaconexion"].DefaultValue.ToString();
            dConfigCal = new DaoConfiguracionCalidad(cadenaconexion);
            bs.DataSource = dConfigCal.Listar();
            enlazarControles();
        }

        private void enlazarControles()
        {
            dgv.DataSource = bs;
            dgv.AutoGenerateColumns = false;
        
            DataGridViewColumn column4 = dgv.Columns[4];
            DataGridViewColumn column5 = dgv.Columns[5];
            DataGridViewColumn column6 = dgv.Columns[6];
            DataGridViewColumn column7 = dgv.Columns[7];
            DataGridViewColumn column8 = dgv.Columns[8];
            DataGridViewColumn column9 = dgv.Columns[9];
            DataGridViewColumn column10 = dgv.Columns[10];
            DataGridViewColumn column11 = dgv.Columns[11];
            column4.Visible = false;
            column5.Visible = false;
            column6.Visible = false;
            column7.Visible = false;
            column8.Visible = false;
            column9.Visible = false;
            column10.Visible = false;
            column11.Visible = false;
            DataGridViewColumn column0 = dgv.Columns[0];
            DataGridViewColumn column1 = dgv.Columns[1];
            DataGridViewColumn column2 = dgv.Columns[2];
            DataGridViewColumn column3 = dgv.Columns[3];
            column0.HeaderText = "Codigo Variable";
            column1.HeaderText = "Tipo Variable";
            column2.HeaderText = "Valor Variable";
            column3.HeaderText = "Descripción Variable";
            column0.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            txtCodigoVariable.DataBindings.Add("Text", bs, "cd_codigovariable");
            txtTipoVariable.DataBindings.Add("Text", bs, "ds_tipovariable");
            txtValorVariable.DataBindings.Add("Text", bs, "ds_valorvariable");
            txtDescripcionVariable.DataBindings.Add("Text", bs, "ds_descripcionvariable");
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
                var ControlCalidad = (ConfiguracionCalidad)bs.Current;
                if (esNuevoRegistro)
                {
                    //se crea un nuevo registro
                    ControlCalidad.ds_equipocreacion = Users.EQUIPO___;
                    ControlCalidad.ds_usuariocreacion = Users.USUARIO__;
                    ControlCalidad.dt_fechacreacion = DateTime.Now;
                    ControlCalidad.dt_fechamodificacion = DateTime.Now;
                    ControlCalidad.ds_equipomodificacion = Users.EQUIPO___;
                    ControlCalidad.ds_usuariomodificacion = Users.USUARIO__;
                    ControlCalidad.ds_programacreacion = Users.PROGRAMA_;
                    ControlCalidad.ds_programamodificacion = Users.PROGRAMA_;
                    int resultado = dConfigCal.Insertar(ControlCalidad);
                    MessageBox.Show("Nuevo registro creado");
                }
                else
                {
                    //se actualiza el registro actual
                    ControlCalidad.dt_fechamodificacion = DateTime.Now;
                    ControlCalidad.ds_equipomodificacion = Users.EQUIPO___;
                    ControlCalidad.ds_usuariomodificacion = Users.USUARIO__;
                    ControlCalidad.ds_programamodificacion = Users.PROGRAMA_;
                    dConfigCal.Actualizar(ControlCalidad);
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
                    var ControlCalidad = (ConfiguracionCalidad)bs.Current;
                    if (ControlCalidad.cd_codigovariable.Equals("0"))
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
                MessageBox.Show("Registro no existe");
            }
            else
            {
                var ControlCalidad = (ConfiguracionCalidad)bs.Current;
                dConfigCal.Borrar(ControlCalidad);
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

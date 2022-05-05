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
            bs.DataSource = dConfigCal.ListarVariables();
            enlazarControles();
        }

        private void enlazarControles()
        {
            dgv.DataSource = bs;
            dgv.AutoGenerateColumns = false;
        

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
            if (esNuevoRegistro == false)
            {
                bs.EndEdit();
                bs.AddNew();
                esNuevoRegistro = true;
            }
            else
            {
                MessageBox.Show("Ya se esta creando un nuevo registro");
            }
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
            DialogResult dr = MessageBox.Show("Esta seguro de esta acción", "Confirmación de borrado", MessageBoxButtons.YesNo,
               MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
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

        private void dgv_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                int iColumn = dgv.CurrentCell.ColumnIndex;
                int iRow = dgv.CurrentCell.RowIndex;
                if (iColumn == dgv.ColumnCount - 1)
                {
                    if (dgv.RowCount > (iRow + 1))
                    {
                        dgv.CurrentCell = dgv[0, iRow + 1];
                    }
                    else
                    {
                        //focus next control
                    }
                }
                else
                    dgv.CurrentCell = dgv[iColumn + 1, iRow];

            }
        }
    }
}

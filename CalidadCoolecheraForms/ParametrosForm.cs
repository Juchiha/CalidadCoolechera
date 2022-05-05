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

        private void ParametrosForm_Load(object sender, EventArgs e)
        {
            var cadenaconexion = Properties.Settings.Default.Properties["cadenaconexion"].DefaultValue.ToString();
            dperiodo = new DaoPeriodo(cadenaconexion);
            bs.DataSource = dperiodo.ListarDataGridview();
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
            column0.HeaderText = "Periodo Liquidación";
            column1.HeaderText = "Numero Liquidación";
            column2.HeaderText = "Estado Periodo CDA";
            column3.HeaderText = "Estado Periodo Asociado";
            column0.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; 
            column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
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

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dgv_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
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

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
    public partial class CalidadCDAForm : Form
    {
        private DaoCalidadCDA dCalidadCda;
        private BindingSource bs = new BindingSource();
        private bool esNuevoRegistro = false;

        public CalidadCDAForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CalidadCDAForm_Load(object sender, EventArgs e)
        {
            var cadenaconexion = Properties.Settings.Default.Properties["cadenaconexion"].DefaultValue.ToString();
            dCalidadCda = new DaoCalidadCDA(cadenaconexion);
            bs.DataSource = dCalidadCda.Listar();
            /*cmbPeriodoLiquidacion.DisplayMember = "ds_periodoliquidacion";
            cmbPeriodoLiquidacion.ValueMember = "ds_periodoliquidacion";
            cmbPeriodoLiquidacion.DataSource = dCalidadCda.Listar();*/
            enlazarControles();
        }

        private void enlazarControles()
        {
            dgv.DataSource = bs;
            dgv.AutoGenerateColumns = true;
            txtCodigoCalidad.DataBindings.Add("Text", bs, "cd_codigocda");
            txtPeriodoCalidad.DataBindings.Add("Text", bs, "ds_periodoliquidacion");
            txtNumeroLiquidacion.DataBindings.Add("Text", bs, "am_numeroliquidacion");
            txtValorSolidosTotales.DataBindings.Add("Text", bs, "am_valorsolidostotales");
            txtUnidadFormadoraCol.DataBindings.Add("Text", bs, "am_valorunidadformadoracolonias");
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
                var calidadCDA = (CalidadCDA)bs.Current;
                if (esNuevoRegistro)
                {
                    //se crea un nuevo registro
                    calidadCDA.ds_equipocreacion = Users.EQUIPO___;
                    calidadCDA.ds_usuariocreacion = Users.USUARIO__;
                    calidadCDA.dt_fechacreacion = DateTime.Now;
                    calidadCDA.dt_fechamodificacion = DateTime.Now;
                    calidadCDA.ds_equipomodificacion = Users.EQUIPO___;
                    calidadCDA.ds_usuariomodificacion = Users.USUARIO__;
                    calidadCDA.ds_programacreacion = Users.PROGRAMA_;
                    calidadCDA.ds_programamodificacion = Users.PROGRAMA_;
                    int resultado = dCalidadCda.Insertar(calidadCDA);
                    MessageBox.Show("Nuevo registro creado");
                }
                else
                {
                    //se actualiza el registro actual
                    calidadCDA.dt_fechamodificacion = DateTime.Now;
                    calidadCDA.ds_equipomodificacion = Users.EQUIPO___;
                    calidadCDA.ds_usuariomodificacion = Users.USUARIO__;
                    calidadCDA.ds_programamodificacion = Users.PROGRAMA_;
                    dCalidadCda.Actualizar(calidadCDA);
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
                    var calidadCDA = (CalidadCDA)bs.Current;
                    if (calidadCDA.cd_codigocda == 0)
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
                var calidadCDA = (CalidadCDA)bs.Current;
                dCalidadCda.Borrar(calidadCDA);
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

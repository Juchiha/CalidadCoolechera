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
    public partial class BonificacionForm : Form
    {
        private DaoBonificacion dBonificacion;
        private BindingSource bs = new BindingSource();
        private bool esNuevoRegistro = false;
        public BonificacionForm()
        {
            InitializeComponent();
        }

        private void Bonificacion_Load(object sender, EventArgs e)
        {
            var cadenaconexion = Properties.Settings.Default.Properties["cadenaconexion"].DefaultValue.ToString();
            dBonificacion = new DaoBonificacion(cadenaconexion);
            bs.DataSource = dBonificacion.Listar();
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
            DataGridViewColumn column12 = dgv.Columns[12];
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
            column0.HeaderText = "Rango Inferior";
            column1.HeaderText = "Rango Superior";
            column2.HeaderText = "Pago Bacterias";
            column3.HeaderText = "Pago Frio";
            column12.HeaderText = "Pago Frio Voluntario";

            column0.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            column12.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            txtRangoInferior.DataBindings.Add("Text", bs, "am_rangoinferior");
            txtRangoSuperior.DataBindings.Add("Text", bs, "am_rangosuperior");
            txtPagoBacterias.DataBindings.Add("Text", bs, "am_pagobacterias");
            txtPagoFrio.DataBindings.Add("Text", bs, "am_pagofrio");
            txtValorFrio.DataBindings.Add("Text", bs, "am_valorfriovoluntario");
            dgv.AllowUserToAddRows = false;
        }

        private void btnNuevoRegistro_Click(object sender, EventArgs e)
        {
            bs.EndEdit();
            bs.AddNew();
            esNuevoRegistro = true;
        }

        private void Guardar()
        {
            if (bs.Current == null)
            {
                MessageBox.Show("Bonificación no existe");
            }
            else
            {
                var bonificacion = (Bonificacion)bs.Current;
                if (esNuevoRegistro)
                {
                    //se crea un nuevo registro
                    bonificacion.ds_equipocreacion = Users.EQUIPO___;
                    bonificacion.ds_usuariocreacion = Users.USUARIO__;
                    bonificacion.dt_fechacreacion = DateTime.Now;
                    bonificacion.dt_fechamodificacion = DateTime.Now;
                    bonificacion.ds_equipomodificacion = Users.EQUIPO___;
                    bonificacion.ds_usuariomodificacion = Users.USUARIO__;
                    bonificacion.ds_programacreacion = Users.PROGRAMA_;
                    bonificacion.ds_programamodificacion = Users.PROGRAMA_;
                    int resultado = dBonificacion.Insertar(bonificacion);
                    MessageBox.Show("Nuevo registro creado");
                }
                else
                {
                    //se actualiza el registro actual
                    bonificacion.dt_fechamodificacion = DateTime.Now;
                    bonificacion.ds_equipomodificacion = Users.EQUIPO___;
                    bonificacion.ds_usuariomodificacion = Users.USUARIO__;
                    bonificacion.ds_programamodificacion = Users.PROGRAMA_;
                    dBonificacion.Actualizar(bonificacion);
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
                    var bonificacion = (Bonificacion)bs.Current;
                    if (bonificacion.am_rangoinferior == 0 )
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
                MessageBox.Show("Bonificación no existe");
            }
            else
            {
                var bonificacion = (Bonificacion)bs.Current;
                dBonificacion.Borrar(bonificacion);
                bs.RemoveCurrent();
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
            try
            {
                Borrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error no controlado " + ex.Message);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtPagoBacterias_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

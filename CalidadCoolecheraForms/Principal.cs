using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalidadCoolecheraForms
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterParent;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var frmPeriodos = new ParametrosForm();
            frmPeriodos.StartPosition = FormStartPosition.CenterParent;
            frmPeriodos.ShowDialog();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            var frmBonificacion = new BonificacionForm();
            frmBonificacion.StartPosition = FormStartPosition.CenterParent;
            frmBonificacion.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var frmCalidadCDA = new CalidadCDAForm();
            frmCalidadCDA.StartPosition = FormStartPosition.CenterParent;
            frmCalidadCDA.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var frmControlVariables = new ConfiguracionForm();
            frmControlVariables.StartPosition = FormStartPosition.CenterParent;
            frmControlVariables.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var frmControlCalidad = new ControlCalidadForm();
            frmControlCalidad.StartPosition = FormStartPosition.CenterParent;
            frmControlCalidad.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var frmCalidadLeche = new NewCalidadLeche();
            frmCalidadLeche.StartPosition = FormStartPosition.CenterParent;
            frmCalidadLeche.ShowDialog();
        }
    }
}

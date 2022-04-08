using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalidadModelos.Modelos
{
    public class ControlCalidad
    {
		public string ds_periodoliquidacion { get; set; }
		public int am_numeroliquidacion { get; set; }
		public string ds_estadoliquidacion { get; set; }
		public string ds_usuariocreacion { get; set; }
		public string ds_equipocreacion { get; set; }
		public string dt_fechacreacion { get; set; }
		public string ds_programacreacion { get; set; }
		public string ds_usuariomodificacion { get; set; }
		public string ds_equipomodificacion { get; set; }
		public string dt_fechamodificacion { get; set; }
		public string ds_programamodificacion { get; set; }

		public ControlCalidad()
        {

        }

        public ControlCalidad(string ds_periodoliquidacion, int am_numeroliquidacion, string ds_estadoliquidacion, string ds_usuariocreacion, string ds_equipocreacion, string dt_fechacreacion, string ds_programacreacion, string ds_usuariomodificacion, string ds_equipomodificacion, string dt_fechamodificacion, string ds_programamodificacion)
        {
            this.ds_periodoliquidacion = ds_periodoliquidacion;
            this.am_numeroliquidacion = am_numeroliquidacion;
            this.ds_estadoliquidacion = ds_estadoliquidacion;
            this.ds_usuariocreacion = ds_usuariocreacion;
            this.ds_equipocreacion = ds_equipocreacion;
            this.dt_fechacreacion = dt_fechacreacion;
            this.ds_programacreacion = ds_programacreacion;
            this.ds_usuariomodificacion = ds_usuariomodificacion;
            this.ds_equipomodificacion = ds_equipomodificacion;
            this.dt_fechamodificacion = dt_fechamodificacion;
            this.ds_programamodificacion = ds_programamodificacion;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalidadModelos.Modelos
{
	public class ConfiguracionCalidad
	{
		public string cd_codigovariable { get; set; }
		public string ds_tipovariable { get; set; }
		public string ds_valorvariable { get; set; }
		public string ds_descripcionvariable { get; set; }
		public string ds_usuariocreacion { get; set; }
		public string ds_equipocreacion { get; set; }
		public DateTime dt_fechacreacion { get; set; }
		public string ds_programacreacion { get; set; }
		public string ds_usuariomodificacion { get; set; }
		public string ds_equipomodificacion { get; set; }
		public DateTime dt_fechamodificacion { get; set; }
		public string ds_programamodificacion { get; set; }

		public ConfiguracionCalidad()
		{

		}

        public ConfiguracionCalidad(string cd_codigovariable, string ds_tipovariable, string ds_valorvariable, string ds_descripcionvariable, string ds_usuariocreacion, string ds_equipocreacion, DateTime dt_fechacreacion, string ds_programacreacion, string ds_usuariomodificacion, string ds_equipomodificacion, DateTime dt_fechamodificacion, string ds_programamodificacion)
        {
            this.cd_codigovariable = cd_codigovariable;
            this.ds_tipovariable = ds_tipovariable;
            this.ds_valorvariable = ds_valorvariable;
            this.ds_descripcionvariable = ds_descripcionvariable;
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

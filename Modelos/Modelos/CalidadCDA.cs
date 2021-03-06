using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalidadModelos.Modelos
{
    public class CalidadCDA
    {
		public int cd_codigoplanta { get; set; }
		public string ds_periodoliquidacion { get; set; }
		public int am_numeroliquidacion { get; set; }
		public double am_valorsolidostotales { get; set; }
		public double am_valorunidadformadoracolonias { get; set; }
		
        public double am_promediodensidad { get; set; }
        public double am_promedioquincena1 { get; set; }
        public double am_promedioquincena2 { get; set; }
        public double am_promedioquincena3 { get; set; }
        public double am_promediosolidostotales { get; set; }
        public double am_valorgramo { get; set; }
        public double am_promedioquincenaufc1 { get; set; }
        public double am_promedioquincenaufc2 { get; set; }
        public double am_promedioquincenaufc3 { get; set; }
        public double am_higienicaufc { get; set; }
        public double am_bonificacionufc { get; set; }
        public double am_valorlitro { get; set; }
        public double am_bonificacionvoluntaria { get; set; }
        public double am_valorlitroneto { get; set; }
        public string ds_usuariocreacion { get; set; }
        public string ds_equipocreacion { get; set; }
        public DateTime dt_fechacreacion { get; set; }
        public string ds_programacreacion { get; set; }
        public string ds_usuariomodificacion { get; set; }
        public string ds_equipomodificacion { get; set; }
        public DateTime dt_fechamodificacion { get; set; }
        public string ds_programamodificacion { get; set; }


        public CalidadCDA()
        {

        }
    }
}

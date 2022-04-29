using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalidadCoolecheraModelos.Modelos
{
    public class CalidadCDADataGrid
    {
        public int cd_codigoplanta { get; set; }
        public string nombrePlanta { get; set; }
        public double am_promedioquincena1 { get; set; }
        public double am_promedioquincena2 { get; set; }
        public double am_promedioquincena3 { get; set; }
        public double am_promediodensidad { get; set; }
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
        

        public CalidadCDADataGrid()
        {

        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalidadModelos.Modelos
{
    public class CalidadLeche
    {
		public string ds_periodoliquidacion { get; set; }
		public int am_numeroliquidacion { get; set; }
		public string cd_codigofinca { get; set; }
		public string cd_codigoconsignante { get; set; }
		public string dt_fechamuestra { get; set; }
		public string am_valordensidad { get; set; }
		public int am_promediodensidad { get; set; }
		public int am_valorsolidostotales { get; set; }
		public int am_promediosolidostotales { get; set; }
		public int am_bonificacionsolidostotales { get; set; }
		public int am_valorgrasa { get; set; }
		public int am_promediograsa { get; set; }
		public int am_bonificaciongrasa { get; set; }
		public int am_valorproteina { get; set; }
		public int am_promedioproteina { get; set; }
		public int am_bonificacionproteina { get; set; }
		public int am_valorunidadformadoracolonias { get; set; }
		public int am_promediounidadformadoracolonias { get; set; }
		public int am_bonificacionformadoracolonias { get; set; }
		public int am_bonificacionformadoracoloniasfria { get; set; }
		public int am_bonificacionvoluntariafria { get; set; }
		public int am_bonificacionvoluntariacalidad { get; set; }
		public int am_valorlitro { get; set; }
		public string ds_usuariocreacion { get; set; }
		public string ds_equipocreacion { get; set; }
		public string dt_fechacreacion { get; set; }
		public string ds_programacreacion { get; set; }
		public string ds_usuariomodificacion { get; set; }
		public string ds_equipomodificacion { get; set; }
		public string dt_fechamodificacion { get; set; }
		public string ds_programamodificacion { get; set; }

        public CalidadLeche()
        {

        }

        public CalidadLeche(string ds_periodoliquidacion, int am_numeroliquidacion, string cd_codigofinca, string cd_codigoconsignante, string dt_fechamuestra, string am_valordensidad, int am_promediodensidad, int am_valorsolidostotales, int am_promediosolidostotales, int am_bonificacionsolidostotales, int am_valorgrasa, int am_promediograsa, int am_bonificaciongrasa, int am_valorproteina, int am_promedioproteina, int am_bonificacionproteina, int am_valorunidadformadoracolonias, int am_promediounidadformadoracolonias, int am_bonificacionformadoracolonias, int am_bonificacionformadoracoloniasfria, int am_bonificacionvoluntariafria, int am_bonificacionvoluntariacalidad, int am_valorlitro, string ds_usuariocreacion, string ds_equipocreacion, string dt_fechacreacion, string ds_programacreacion, string ds_usuariomodificacion, string ds_equipomodificacion, string dt_fechamodificacion, string ds_programamodificacion)
        {
            this.ds_periodoliquidacion = ds_periodoliquidacion;
            this.am_numeroliquidacion = am_numeroliquidacion;
            this.cd_codigofinca = cd_codigofinca;
            this.cd_codigoconsignante = cd_codigoconsignante;
            this.dt_fechamuestra = dt_fechamuestra;
            this.am_valordensidad = am_valordensidad;
            this.am_promediodensidad = am_promediodensidad;
            this.am_valorsolidostotales = am_valorsolidostotales;
            this.am_promediosolidostotales = am_promediosolidostotales;
            this.am_bonificacionsolidostotales = am_bonificacionsolidostotales;
            this.am_valorgrasa = am_valorgrasa;
            this.am_promediograsa = am_promediograsa;
            this.am_bonificaciongrasa = am_bonificaciongrasa;
            this.am_valorproteina = am_valorproteina;
            this.am_promedioproteina = am_promedioproteina;
            this.am_bonificacionproteina = am_bonificacionproteina;
            this.am_valorunidadformadoracolonias = am_valorunidadformadoracolonias;
            this.am_promediounidadformadoracolonias = am_promediounidadformadoracolonias;
            this.am_bonificacionformadoracolonias = am_bonificacionformadoracolonias;
            this.am_bonificacionformadoracoloniasfria = am_bonificacionformadoracoloniasfria;
            this.am_bonificacionvoluntariafria = am_bonificacionvoluntariafria;
            this.am_bonificacionvoluntariacalidad = am_bonificacionvoluntariacalidad;
            this.am_valorlitro = am_valorlitro;
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

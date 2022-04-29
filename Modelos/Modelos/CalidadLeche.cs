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
		public DateTime dt_fechamuestra { get; set; }
		public double am_valordensidad { get; set; }
		public double am_promediodensidad { get; set; }
		public double am_valorsolidostotales { get; set; }
		public double am_promediosolidostotales { get; set; }
		public double am_bonificacionsolidostotales { get; set; }
		public double am_valorgrasa { get; set; }
		public double am_promediograsa { get; set; }
		public double am_bonificaciongrasa { get; set; }
		public double am_valorproteina { get; set; }
		public double am_promedioproteina { get; set; }
		public double am_bonificacionproteina { get; set; }
		public double am_valorunidadformadoracolonias { get; set; }
		public double am_promediounidadformadoracolonias { get; set; }
		public double am_bonificacionformadoracolonias { get; set; }
		public double am_bonificacionformadoracoloniasfria { get; set; }
		public double am_bonificacionvoluntariafria { get; set; }
		public double am_bonificacionvoluntariacalidad { get; set; }
		public double am_valorlitro { get; set; }
		public string ds_usuariocreacion { get; set; }
		public string ds_equipocreacion { get; set; }
		public DateTime dt_fechacreacion { get; set; }
		public string ds_programacreacion { get; set; }
		public string ds_usuariomodificacion { get; set; }
		public string ds_equipomodificacion { get; set; }
		public DateTime dt_fechamodificacion { get; set; }
		public string ds_programamodificacion { get; set; }

        public double am_valorgramo { get; set; }

        public CalidadLeche()
        {

        }

        public CalidadLeche(string ds_periodoliquidacion, int am_numeroliquidacion, string cd_codigofinca, string cd_codigoconsignante, DateTime dt_fechamuestra, double am_valordensidad, double am_promediodensidad, double am_valorsolidostotales, double am_promediosolidostotales, double am_bonificacionsolidostotales, double am_valorgrasa, double am_promediograsa, double am_bonificaciongrasa, double am_valorproteina, double am_promedioproteina, double am_bonificacionproteina, double am_valorunidadformadoracolonias, double am_promediounidadformadoracolonias, double am_bonificacionformadoracolonias, double am_bonificacionformadoracoloniasfria, double am_bonificacionvoluntariafria, double am_bonificacionvoluntariacalidad, double am_valorlitro, string ds_usuariocreacion, string ds_equipocreacion, DateTime dt_fechacreacion, string ds_programacreacion, string ds_usuariomodificacion, string ds_equipomodificacion, DateTime dt_fechamodificacion, string ds_programamodificacion, double am_valorgramo)
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
            this.am_valorgramo = am_valorgramo;
        }
    }
}

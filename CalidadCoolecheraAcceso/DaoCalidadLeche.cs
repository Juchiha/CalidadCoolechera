using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalidadModelos.Modelos;
using CalidadCoolecheraModelos.Modelos;
using Dapper;
using System.Data;

namespace CalidadCoolecheraAcceso
{
    public class DaoCalidadLeche
    {
        private ConexionBaseDatos pConexion;

        public ConexionBaseDatos Pconexion { get => pConexion; set => pConexion = value; }

        public DaoCalidadLeche(ConexionBaseDatos cn = null)
        {
            pConexion = cn;
        }

        public DaoCalidadLeche(string cadenaConexion)
        {
            pConexion = new ConexionBaseDatos(cadenaConexion);
        }

        public List<CalidadLeche> Listar(IDbTransaction transaction = null)
        {
            var Lsql = "SELECT * FROM calidad.calidad_leche";
            var calidad_cda = pConexion.Conexion.Query<CalidadLeche>(Lsql, transaction).ToList();
            return calidad_cda;
        }

        public List<DataGridCalidaLeche> buscar(string ds_periodoliquidacion, int am_numeroliquidacion,  IDbTransaction transaction = null)
        {
            var strSQl = "select dt_fechamuestra, cd_codigoconsignante, 1 as consignante,  cd_codigofinca, am_valordensidad, am_valorsolidostotales, am_valorunidadformadoracolonias from calidad.calidad_leche where ds_periodoliquidacion = @ds_periodoliquidacion AND am_numeroliquidacion = @am_numeroliquidacion ";
            var Calidad_Leche = pConexion.Conexion.Query<DataGridCalidaLeche>(strSQl, new { ds_periodoliquidacion = ds_periodoliquidacion, am_numeroliquidacion = am_numeroliquidacion}, transaction).ToList();
            return Calidad_Leche;
        }

        public List<CalidadLeche> ListarLastThreeMonts(CalidadLeche gridCalidad, IDbTransaction transaction = null)
        {
            var Lsql = "SELECT * FROM calidad.calidad_leche WHERE cd_codigofinca = @cd_codigofinca AND cd_codigoconsignante = @cd_codigoconsignante ORDER BY dt_fechamuestra DESC LIMIT 3";
            var calidad_cda = pConexion.Conexion.Query<CalidadLeche>(Lsql, new { cd_codigofinca = gridCalidad.cd_codigofinca, cd_codigoconsignante = gridCalidad.cd_codigoconsignante }, transaction).ToList();
            return calidad_cda;
        }

        public int Insertar(CalidadLeche Calidad_Leche, IDbTransaction transaction = null)
        {
            var strSQl = @"INSERT INTO calidad.calidad_leche(ds_periodoliquidacion, am_numeroliquidacion, cd_codigofinca, cd_codigoconsignante, dt_fechamuestra, am_valordensidad, am_promediodensidad, am_valorsolidostotales, am_promediosolidostotales, am_bonificacionsolidostotales ,am_valorgrasa, am_promediograsa, am_bonificaciongrasa, am_valorproteina, am_promedioproteina, am_bonificacionproteina, am_valorunidadformadoracolonias, am_promediounidadformadoracolonias, am_bonificacionformadoracolonias, am_bonificacionformadoracoloniasfria, am_bonificacionvoluntariafria, am_bonificacionvoluntariacalidad, am_valorlitro, ds_usuariocreacion, ds_equipocreacion, dt_fechacreacion, ds_programacreacion, ds_usuariomodificacion, ds_equipomodificacion, dt_fechamodificacion, ds_programamodificacion) 
                           VALUES (@ds_periodoliquidacion, @am_numeroliquidacion, @cd_codigofinca, @cd_codigoconsignante,@dt_fechamuestra, @am_valordensidad, @am_promediodensidad, @am_valorsolidostotales, @am_promediosolidostotales,@am_bonificacionsolidostotales ,@am_valorgrasa, @am_promediograsa, @am_bonificaciongrasa, @am_valorproteina, @am_promedioproteina, @am_bonificacionproteina, @am_valorunidadformadoracolonias, @am_promediounidadformadoracolonias, @am_bonificacionformadoracolonias, @am_bonificacionformadoracoloniasfria, @am_bonificacionvoluntariafria, @am_bonificacionvoluntariacalidad, @am_valorlitro, @ds_usuariocreacion, @ds_equipocreacion, @dt_fechacreacion, @ds_programacreacion, @ds_usuariomodificacion, @ds_equipomodificacion, @dt_fechamodificacion, @ds_programamodificacion)  ";
            var nroFilasAfectadas = pConexion.Conexion.Execute(strSQl, Calidad_Leche, transaction);
            return nroFilasAfectadas;
        }

        public int Actualizar(CalidadLeche Calidad_Leche, IDbTransaction transaction = null)
        {
            var strSQl = @"UPDATE calidad.calidad_leche SET ds_periodoliquidacion = @ds_periodoliquidacion, am_numeroliquidacion = @am_numeroliquidacion, cd_codigofinca = @cd_codigofinca, cd_codigoconsignante = @cd_codigoconsignante, dt_fechamuestra = @dt_fechamuestra, am_valordensidad = @am_valordensidad, am_promediodensidad = @am_promediodensidad, am_valorsolidostotales = @am_valorsolidostotales, am_promediosolidostotales = @am_promediosolidostotales, am_bonificacionsolidostotales  = @am_bonificacionsolidostotales, am_valorgrasa = @am_valorgrasa, am_promediograsa = @am_promediograsa, am_bonificaciongrasa = @am_bonificaciongrasa, am_valorproteina = @am_valorproteina, am_promedioproteina = @am_promedioproteina, am_bonificacionproteina = @am_bonificacionproteina, am_valorunidadformadoracolonias = @am_valorunidadformadoracolonias, am_promediounidadformadoracolonias = @am_promediounidadformadoracolonias, am_bonificacionformadoracolonias = @am_bonificacionformadoracolonias, am_bonificacionformadoracoloniasfria = @am_bonificacionformadoracoloniasfria, am_bonificacionvoluntariafria = @am_bonificacionvoluntariafria, am_bonificacionvoluntariacalidad = @am_bonificacionvoluntariacalidad, am_valorlitro = @am_valorlitro
                           WHERE ds_periodoliquidacion = @ds_periodoliquidacion AND am_numeroliquidacion = @am_numeroliquidacion AND cd_codigofinca = @cd_codigofinca AND cd_codigoconsignante = @cd_codigoconsignante";
            var nroFilasAfectadas = pConexion.Conexion.Execute(strSQl, Calidad_Leche, transaction);
            return nroFilasAfectadas;
        }

        public int Borrar(CalidadLeche Calidad_Leche, IDbTransaction transaction = null)
        {
            var strSQl = @"DELETE FROM calidad.calidad_leche WHERE ds_periodoliquidacion = @ds_periodoliquidacion AND am_numeroliquidacion = @am_numeroliquidacion AND cd_codigofinca = @cd_codigofinca AND cd_codigoconsignante = @cd_codigoconsignante";
            var nroFilasAfectadas = pConexion.Conexion.Execute(strSQl, Calidad_Leche, transaction);
            return nroFilasAfectadas;
        }
    }
}

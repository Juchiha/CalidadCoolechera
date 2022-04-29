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
    public class DaoCalidadCDA
    {
        private ConexionBaseDatos pConexion;

        public ConexionBaseDatos Pconexion { get => pConexion; set => pConexion = value; }

        public DaoCalidadCDA(ConexionBaseDatos cn = null)
        {
            pConexion = cn;
        }

        public DaoCalidadCDA(string cadenaConexion)
        {
            pConexion = new ConexionBaseDatos(cadenaConexion);
        }

        public List<CalidadCDA> Listar(IDbTransaction transaction = null)
        {
            var Lsql = "SELECT cd_codigocda, ds_periodoliquidacion, am_numeroliquidacion, am_valorsolidostotales, am_valorunidadformadoracolonias FROM calidad.calidad_cda";
            var calidad_cda = pConexion.Conexion.Query<CalidadCDA>(Lsql, transaction).ToList();
            return calidad_cda;
        }

        public List<CalidadCDADataGrid> ListarDataGrid(string ds_periodoliquidacion, int am_numeroliquidacion, IDbTransaction transaction = null)
        {
            var Lsql = "SELECT mtP.codplanta as cd_codigoplanta, mtP.nombre as nombrePlanta, cxda.am_promedioquincena1, cxda.am_promedioquincena2, cxda.am_promedioquincena3, cxda.am_promediodensidad, cxda.am_promediosolidostotales, cxda.am_valorgramo, cxda.am_promedioquincenaufc1, cxda.am_promedioquincenaufc2, cxda.am_promedioquincenaufc3, cxda.am_higienicaufc, cxda.am_bonificacionufc, cxda.am_valorlitro, cxda.am_bonificacionvoluntaria, cxda.am_valorlitroneto FROM calidad.mtplanta mtP LEFT JOIN calidad.calidad_cda cxda ON cxda.cd_codigoplanta = mtP.codplanta WHERE cxda.ds_periodoliquidacion = @ds_periodoliquidacion AND am_numeroliquidacion = @am_numeroliquidacion AND mtP.estado = true ORDER BY mtP.nombre";
            var calidad_cda = pConexion.Conexion.Query<CalidadCDADataGrid>(Lsql, new { ds_periodoliquidacion = ds_periodoliquidacion , am_numeroliquidacion = am_numeroliquidacion } ,transaction).ToList();
            if(calidad_cda.Count == 0)
            {
                Lsql = "SELECT mtP.codplanta as cd_codigoplanta, mtP.nombre as nombrePlanta,  0 as am_promedioquincena1, 0 as am_promedioquincena2, 0 as am_promedioquincena3, 0 as am_promediodensidad, 0 as am_promediosolidostotales, 0 as am_valorgramo, 0 as am_promedioquincenaufc1, 0 as am_promedioquincenaufc2, 0 as am_promedioquincenaufc3, 0 as am_higienicaufc, 0 as am_bonificacionufc, 0 as am_valorlitro, 0 as am_bonificacionvoluntaria, 0 as am_valorlitroneto  FROM calidad.mtplanta mtP WHERE mtP.estado = true ORDER BY mtP.nombre";
                calidad_cda = pConexion.Conexion.Query<CalidadCDADataGrid>(Lsql, transaction).ToList();
            }
            return calidad_cda;
        }

        public CalidadCDA buscar(CalidadCDA calidadCDA, IDbTransaction transaction = null)
        {
            var strSQl = "select * from calidad.calidad_cda where cd_codigoplanta = @cd_codigoplanta and ds_periodoliquidacion = @ds_periodoliquidacion and am_numeroliquidacion = @am_numeroliquidacion";
            var CalidadCDA = pConexion.Conexion.QueryFirstOrDefault<CalidadCDA>(strSQl, calidadCDA, transaction);
            return CalidadCDA;
        }

        public int Insertar(CalidadCDA CalidadCDA, IDbTransaction transaction = null)
        {
            var strSQl = @"INSERT INTO calidad.calidad_cda(cd_codigoplanta, ds_periodoliquidacion, am_numeroliquidacion, am_promedioquincena1, am_promedioquincena2, am_promedioquincena3, am_promediodensidad, am_promediosolidostotales, am_valorgramo, am_higienicaufc, am_bonificacionufc, am_valorlitro, am_bonificacionvoluntaria, am_valorlitroneto, ds_usuariocreacion, ds_equipocreacion, dt_fechacreacion, ds_programacreacion, ds_usuariomodificacion, ds_equipomodificacion, dt_fechamodificacion, ds_programamodificacion, am_promedioquincenaufc1, am_promedioquincenaufc2,am_promedioquincenaufc3) 
                           VALUES (@cd_codigoplanta,@ds_periodoliquidacion, @am_numeroliquidacion,  @am_promedioquincena1, @am_promedioquincena2, @am_promedioquincena3, @am_promediodensidad, @am_promediosolidostotales, @am_valorgramo, @am_higienicaufc, @am_bonificacionufc, @am_valorlitro, @am_bonificacionvoluntaria, @am_valorlitroneto, @ds_usuariocreacion, @ds_equipocreacion, @dt_fechacreacion, @ds_programacreacion, @ds_usuariomodificacion, @ds_equipomodificacion, @dt_fechamodificacion, @ds_programamodificacion, @am_promedioquincenaufc1, @am_promedioquincenaufc2, @am_promedioquincenaufc3)  ";
            var nroFilasAfectadas = pConexion.Conexion.Execute(strSQl, CalidadCDA, transaction);
            return nroFilasAfectadas;
        }

        public int Actualizar(CalidadCDA CalidadCDA, IDbTransaction transaction = null)
        {
            var strSQl = @"UPDATE calidad.calidad_cda SET ds_periodoliquidacion = @ds_periodoliquidacion, am_numeroliquidacion =@am_numeroliquidacion, cd_codigoplanta = @cd_codigoplanta, am_promedioquincena1 = @am_promedioquincena1, am_promedioquincena2 = @am_promedioquincena2, am_promedioquincena3 = @am_promedioquincena3, am_promediodensidad = @am_promediodensidad, am_promediosolidostotales = @am_promediosolidostotales, am_valorgramo = @am_valorgramo, am_higienicaufc = @am_higienicaufc, am_bonificacionufc = @am_bonificacionufc, am_valorlitro = @am_valorlitro, am_bonificacionvoluntaria = @am_bonificacionvoluntaria, am_valorlitroneto = @am_valorlitroneto, ds_usuariomodificacion= @ds_usuariomodificacion, ds_equipomodificacion = @ds_equipomodificacion, dt_fechamodificacion = @dt_fechamodificacion, ds_programamodificacion = @ds_programamodificacion, am_promedioquincenaufc1 = @am_promedioquincenaufc1, am_promedioquincenaufc2 = @am_promedioquincenaufc2, am_promedioquincenaufc3 = @am_promedioquincenaufc3
                           WHERE cd_codigoplanta= @cd_codigoplanta AND ds_periodoliquidacion = @ds_periodoliquidacion AND  am_numeroliquidacion =@am_numeroliquidacion";
            var nroFilasAfectadas = pConexion.Conexion.Execute(strSQl, CalidadCDA, transaction);
            return nroFilasAfectadas;
        }

        public int Borrar(CalidadCDA CalidadCDA, IDbTransaction transaction = null)
        {
            var strSQl = @"DELETE FROM calidad.calidad_cda WHERE cd_codigoplanta= @cd_codigoplanta AND ds_periodoliquidacion = @ds_periodoliquidacion AND  am_numeroliquidacion =@am_numeroliquidacion";
            var nroFilasAfectadas = pConexion.Conexion.Execute(strSQl, CalidadCDA, transaction);
            return nroFilasAfectadas;
        }
    }
}

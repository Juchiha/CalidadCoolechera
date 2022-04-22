using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalidadModelos.Modelos;
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

        public CalidadCDA buscar(string cd_codigocda, IDbTransaction transaction = null)
        {
            var strSQl = "select * from calidad.calidad_cda where cd_codigocda = @cd_codigocda";
            var CalidadCDA = pConexion.Conexion.QueryFirst<CalidadCDA>(strSQl, new { cd_codigocda = cd_codigocda }, transaction);
            return CalidadCDA;
        }

        public int Insertar(CalidadCDA CalidadCDA, IDbTransaction transaction = null)
        {
            var strSQl = @"INSERT INTO calidad.calidad_cda(cd_codigocda, ds_periodoliquidacion, am_numeroliquidacion, am_valorsolidostotales, am_valorunidadformadoracolonias, ds_usuariocreacion, ds_equipocreacion, dt_fechacreacion, ds_programacreacion, ds_usuariomodificacion, ds_equipomodificacion, dt_fechamodificacion, ds_programamodificacion) 
                           VALUES (@cd_codigocda,@ds_periodoliquidacion, @am_numeroliquidacion, @am_valorsolidostotales, @am_valorunidadformadoracolonias, @ds_usuariocreacion, @ds_equipocreacion, @dt_fechacreacion, @ds_programacreacion, @ds_usuariomodificacion, @ds_equipomodificacion, @dt_fechamodificacion, @ds_programamodificacion)  ";
            var nroFilasAfectadas = pConexion.Conexion.Execute(strSQl, CalidadCDA, transaction);
            return nroFilasAfectadas;
        }

        public int Actualizar(CalidadCDA CalidadCDA, IDbTransaction transaction = null)
        {
            var strSQl = @"UPDATE calidad.calidad_cda SET ds_periodoliquidacion = @ds_periodoliquidacion, am_numeroliquidacion =@am_numeroliquidacion, am_valorsolidostotales = @am_valorsolidostotales, am_valorunidadformadoracolonias  = @am_valorunidadformadoracolonias,ds_usuariomodificacion= @ds_usuariomodificacion, ds_equipomodificacion = @ds_equipomodificacion, dt_fechamodificacion = @dt_fechamodificacion, ds_programamodificacion = @ds_programamodificacion
                           WHERE cd_codigocda= @cd_codigocda";
            var nroFilasAfectadas = pConexion.Conexion.Execute(strSQl, CalidadCDA, transaction);
            return nroFilasAfectadas;
        }

        public int Borrar(CalidadCDA CalidadCDA, IDbTransaction transaction = null)
        {
            var strSQl = @"DELETE FROM calidad.calidad_cda WHERE cd_codigocda= @cd_codigocda";
            var nroFilasAfectadas = pConexion.Conexion.Execute(strSQl, CalidadCDA, transaction);
            return nroFilasAfectadas;
        }
    }
}

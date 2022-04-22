using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using CalidadModelos.Modelos;
using CalidadCoolecheraModelos.Modelos;
using Dapper;

namespace CalidadCoolecheraAcceso
{
    public class DaoPeriodo
    {
        private ConexionBaseDatos pConexion;

        public ConexionBaseDatos Pconexion { get => pConexion; set => pConexion = value; }

        public DaoPeriodo(ConexionBaseDatos cn = null)
        {
            pConexion = cn;
        }

        public DaoPeriodo(string cadenaConexion)
        {
            pConexion = new ConexionBaseDatos(cadenaConexion);
        }

        public List<Periodo> Listar(IDbTransaction transaction = null)
        {
            var Lsql = "SELECT ds_periodoliquidacion, am_numeroliquidacion, ds_estadoperiodocda, ds_estadoperiodoasociado  FROM calidad.periodos";
            var periodos = pConexion.Conexion.Query<Periodo>(Lsql, transaction).ToList();
            return periodos;
        }

        public List<ComboPeriodo> ListarParaCombox(IDbTransaction transaction = null)
        {
            var Lsql = "SELECT ds_periodoliquidacion as Id, CONCAT(ds_periodoliquidacion, '-', am_numeroliquidacion) as Nombre, am_numeroliquidacion as Liquidacion, ds_estadoperiodocda, ds_estadoperiodoasociado  FROM calidad.periodos";
            var ComboPeriodo = pConexion.Conexion.Query<ComboPeriodo>(Lsql, transaction).ToList();
            return ComboPeriodo;
        }

        public Periodo buscar(string ds_periodoliquidacion, IDbTransaction transaction = null)
        {
            var strSQl = "select * from calidad.periodos where ds_periodoliquidacion = @ds_periodoliquidacion";
            var Periodo = pConexion.Conexion.QueryFirst<Periodo>(strSQl, new { ds_periodoliquidacion = ds_periodoliquidacion }, transaction);
            return Periodo;
        }

        public Periodo buscar(ComboPeriodo cmb, IDbTransaction transaction = null)
        {
            var strSQl = "select * from calidad.periodos where ds_periodoliquidacion = @ds_periodoliquidacion and am_numeroliquidacion = @am_numeroliquidacion";
            var Periodo = pConexion.Conexion.QueryFirst<Periodo>(strSQl, new { ds_periodoliquidacion = cmb.Id, am_numeroliquidacion = cmb.Liquidacion }, transaction);
            return Periodo;
        }

        public int Insertar(Periodo periodo, IDbTransaction transaction = null)
        {
            var strSQl = @"INSERT INTO calidad.periodos(ds_periodoliquidacion, am_numeroliquidacion, ds_estadoperiodocda, ds_estadoperiodoasociado, ds_usuariocreacion, ds_equipocreacion, dt_fechacreacion, ds_programacreacion, ds_usuariomodificacion, ds_equipomodificacion, dt_fechamodificacion , ds_programamodificacion) 
                           VALUES (@ds_periodoliquidacion, @am_numeroliquidacion,  @ds_estadoperiodocda, @ds_estadoperiodoasociado, @ds_usuariocreacion, @ds_equipocreacion, @dt_fechacreacion, @ds_programacreacion, @ds_usuariomodificacion, @ds_equipomodificacion, @dt_fechamodificacion , @ds_programamodificacion)  ";
            var nroFilasAfectadas = pConexion.Conexion.Execute(strSQl, periodo, transaction);
            return nroFilasAfectadas;
        }

        public int Actualizar(Periodo periodo, IDbTransaction transaction = null)
        {
            var strSQl = @"UPDATE calidad.periodos SET am_numeroliquidacion = @am_numeroliquidacion,  ds_estadoperiodocda = @ds_estadoperiodocda, ds_estadoperiodoasociado = @ds_estadoperiodoasociado, ds_usuariomodificacion = @ds_usuariomodificacion, ds_equipomodificacion = @ds_equipomodificacion, dt_fechamodificacion = @dt_fechamodificacion, ds_programamodificacion = @ds_programamodificacion  
                           WHERE ds_periodoliquidacion = @ds_periodoliquidacion";
            var nroFilasAfectadas = pConexion.Conexion.Execute(strSQl, periodo, transaction);
            return nroFilasAfectadas;
        }

        public int Borrar(Periodo periodo, IDbTransaction transaction = null)
        {
            var strSQl = @"DELETE FROM calidad.periodos WHERE ds_periodoliquidacion= @ds_periodoliquidacion";
            var nroFilasAfectadas = pConexion.Conexion.Execute(strSQl, periodo, transaction);
            return nroFilasAfectadas;
        }
    }
}

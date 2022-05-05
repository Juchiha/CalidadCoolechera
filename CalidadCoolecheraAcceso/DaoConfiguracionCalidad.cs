using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalidadModelos.Modelos;
using Dapper;
using System.Data;
using CalidadCoolecheraModelos.Modelos;

namespace CalidadCoolecheraAcceso
{
    public class DaoConfiguracionCalidad
    {
        private ConexionBaseDatos pConexion;

        public ConexionBaseDatos Pconexion { get => pConexion; set => pConexion = value; }

        public DaoConfiguracionCalidad(ConexionBaseDatos cn = null)
        {
            pConexion = cn;
        }

        public DaoConfiguracionCalidad(string cadenaConexion)
        {
            pConexion = new ConexionBaseDatos(cadenaConexion);
        }

        public List<ConfiguracionCalidad> Listar(IDbTransaction transaction = null)
        {
            var Lsql = "SELECT * FROM calidad.configuracion_calidad";
            var calidad_cda = pConexion.Conexion.Query<ConfiguracionCalidad>(Lsql, transaction).ToList();
            return calidad_cda;
        }

        public List<DataGridConcfiguracion> ListarVariables(IDbTransaction transaction = null)
        {
            var Lsql = "SELECT cd_codigovariable, ds_tipovariable, ds_valorvariable, ds_descripcionvariable FROM calidad.configuracion_calidad";
            var calidad_cda = pConexion.Conexion.Query<DataGridConcfiguracion>(Lsql, transaction).ToList();
            return calidad_cda;
        }
        

        public ConfiguracionCalidad buscar(string ds_codigo, IDbTransaction transaction = null)
        {
            var strSQl = "select * from calidad.configuracion_calidad where cd_codigovariable = @cd_codigovariable";
            var Calidad_Leche = pConexion.Conexion.QueryFirst<ConfiguracionCalidad>(strSQl, new { cd_codigovariable = ds_codigo }, transaction);
            return Calidad_Leche;
        }

        public int Insertar(ConfiguracionCalidad Calidad_Leche, IDbTransaction transaction = null)
        {
            var strSQl = @"INSERT INTO calidad.configuracion_calidad(cd_codigovariable, ds_tipovariable, ds_valorvariable, ds_descripcionvariable, ds_usuariocreacion, ds_equipocreacion, dt_fechacreacion, ds_programacreacion, ds_usuariomodificacion, ds_equipomodificacion, dt_fechamodificacion, ds_programamodificacion ) 
                           VALUES (@cd_codigovariable, @ds_tipovariable, @ds_valorvariable, @ds_descripcionvariable, @ds_usuariocreacion, @ds_equipocreacion, @dt_fechacreacion, @ds_programacreacion, @ds_usuariomodificacion, @ds_equipomodificacion, @dt_fechamodificacion, @ds_programamodificacion)  ";
            var nroFilasAfectadas = pConexion.Conexion.Execute(strSQl, Calidad_Leche, transaction);
            return nroFilasAfectadas;
        }

        public int Actualizar(ConfiguracionCalidad Calidad_Leche, IDbTransaction transaction = null)
        {
            var strSQl = @"UPDATE calidad.configuracion_calidad SET ds_tipovariable = @ds_tipovariable, ds_valorvariable = @ds_valorvariable, ds_descripcionvariable = @ds_descripcionvariable, ds_usuariomodificacion = @ds_usuariomodificacion, ds_equipomodificacion = @ds_equipomodificacion, dt_fechamodificacion = @dt_fechamodificacion, ds_programamodificacion = @ds_programamodificacion
                           WHERE cd_codigovariable= @cd_codigovariable";
            var nroFilasAfectadas = pConexion.Conexion.Execute(strSQl, Calidad_Leche, transaction);
            return nroFilasAfectadas;
        }

        public int Borrar(ConfiguracionCalidad Calidad_Leche, IDbTransaction transaction = null)
        {
            var strSQl = @"DELETE FROM calidad.configuracion_calidad WHERE cd_codigovariable= @cd_codigovariable";
            var nroFilasAfectadas = pConexion.Conexion.Execute(strSQl, Calidad_Leche, transaction);
            return nroFilasAfectadas;
        }
    }
}

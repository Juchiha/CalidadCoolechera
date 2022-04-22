using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalidadCoolecheraModelos.Modelos
{
    public class ComboPeriodo
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string Liquidacion { get; set; }
        public string ds_estadoperiodocda { get; set; }
        public string ds_estadoperiodoasociado { get; set; }

        public ComboPeriodo()
        {

        }
        public ComboPeriodo(string Id, string Nombre, string Liquidacion, string ds_estadoperiodocda, string ds_estadoperiodoasociado)
        {
            this.Id = Id;
            this.Nombre = Nombre;
            this.Liquidacion = Liquidacion;
            this.ds_estadoperiodocda = ds_estadoperiodocda;
            this.ds_estadoperiodoasociado = ds_estadoperiodoasociado;
        }
    }
}

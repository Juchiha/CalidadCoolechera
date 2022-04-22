using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalidadCoolecheraModelos.Modelos
{
    public class DataGridCalidaLeche
    {
        public DateTime dt_fechamuestra { get; set; }
        public string cd_codigoconsignante { get; set; }
        public string consignante { get; set; }
        public string cd_codigofinca{ get; set; }
        public string am_valordensidad { get; set; }
        public string am_valorsolidostotales{ get; set; }
        public string am_valorunidadformadoracolonias{ get; set; }

        public DataGridCalidaLeche() { }
        public DataGridCalidaLeche(DateTime dt_fechamuestra, string cd_codigoconsignante, string consignante, string cd_codigofinca, string am_valordensidad, string am_valorsolidostotales, string am_valorunidadformadoracolonias)
        {
            this.dt_fechamuestra = dt_fechamuestra;
            this.cd_codigoconsignante = cd_codigoconsignante;
            this.consignante = consignante;
            this.cd_codigofinca = cd_codigofinca;
            this.am_valordensidad = am_valordensidad;
            this.am_valorsolidostotales = am_valorsolidostotales;
            this.am_valorunidadformadoracolonias = am_valorunidadformadoracolonias;
        }
    }
}

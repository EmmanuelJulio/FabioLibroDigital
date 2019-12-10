using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibroDeSueldosDigital
{
    class Registro3
    {
        string cadena3;
        string identificadorDeRegistro = "03";
        long Cuil3;
        string CodigoConcepto;
        float Cantidad;
        string unidiades;
        float importe;
        string DebitoCredito;
        string PeriodoAjuste;
        public Registro3(long _Cuil3, string _CodigoConcepto, float cantidad, string _unidades, float _Importe,string _debitoCredito ,string _PeriodoAjuste)
        {




        }

        public string Cadena3 { get => cadena3; set => cadena3 = value; }
    }
}

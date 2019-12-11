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
        public Registro3(long _Cuil3, string _CodigoConcepto, int cantidad, string _unidades, float _Importe,string _debitoCredito ,string _PeriodoAjuste)
        {
            this.Cuil3 = _Cuil3;
            this.CodigoConcepto = _CodigoConcepto;
            this.Cantidad = cantidad;
            switch (_unidades)
            {
                case "Moneda":
                    this.unidiades = "$";
                    break;
                case "Porcentuales":
                    this.unidiades = "%";
                    break;
                case "Año":
                    this.unidiades = "A";
                    break;
                case "Quincena":
                    this.unidiades = "Q";
                    break;
                case "Mes":
                    this.unidiades = "M";
                    break;
                case "Dias":
                    this.unidiades = "D";
                    break;
                case "Horas":
                    this.unidiades = "H";
                    break;
                    
            }
            this.importe = _Importe;
            switch (_debitoCredito)
            {
                case "Debito":
                    this.DebitoCredito = "D";
                    break;
                case "Credito":
                    this.DebitoCredito = "C";
                    break;
            }
            this.PeriodoAjuste = _PeriodoAjuste;

            cadena3 = identificadorDeRegistro + string.Format("{0:00000000000}", Convert.ToInt64(Cuil3)) + string.Format("{0:0000000000}", Convert.ToInt64(CodigoConcepto)) + string.Format("{0:00000}", Convert.ToInt32(cantidad)) + unidiades + string.Format("{0:000000000000000}", Convert.ToInt64(importe)) + DebitoCredito + PeriodoAjuste;

        }

        public string Cadena3 { get => cadena3; set => cadena3 = value; }
    }
}

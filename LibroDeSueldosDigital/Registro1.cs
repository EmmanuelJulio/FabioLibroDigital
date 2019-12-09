using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibroDeSueldosDigital
{
    class Registro1
    {
        int CantLogn = 35;
        string Cadena ="";

        string IdentificadorDeRegistro = "01";//2
        string Cuit;//11
        string IdentificadorDeEnvio;//2
        string Periodo;//6
        string TipoDeLiquidacion;//1
        string NumeroDeLiquidacion;//1
        int DiasBase = 30;//2
        int CantidadRegistros04=190;//6
        public Registro1(string _cuit,string _identificadorDeEnvio,string _periodo,string _tipoLiquidacion,int _NumeroLiquidacion)
        {
            this.Cuit = _cuit;
            this.IdentificadorDeEnvio = _identificadorDeEnvio;
            this.Periodo = _periodo;
            switch (_tipoLiquidacion)
            {
                case "Mensual":
                    this.TipoDeLiquidacion = "M";
                    break;
                case "Quincenal":
                    this.TipoDeLiquidacion = "Q";
                    break;
                case "Semanal":
                    this.TipoDeLiquidacion = "S";
                    break;

            }
            this.Cadena1 = this.VerCadena();


        }

        public string Cadena1 { get => Cadena; set => Cadena = value; }

        //  
        public string VerCadena()
        {
            //this.NumeroDeLiquidacion = String.Format("{0:00000000000}", _NumeroLiquidacion.ToString());
            String cade = string.Format("{0:00}",this.IdentificadorDeRegistro.ToString()) + this.Cuit + this.IdentificadorDeEnvio + this.Periodo + this.TipoDeLiquidacion + this.NumeroDeLiquidacion + this.DiasBase + this.CantidadRegistros04;
            return cade;
        }

        
    }
}

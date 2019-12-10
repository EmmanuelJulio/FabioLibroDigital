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
        public Registro1(string _cuit,string _identificadorDeEnvio,string _periodo,string _tipoLiquidacion,string _NumeroLiquidacion)
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
            this.NumeroDeLiquidacion = _NumeroLiquidacion;


        }

        public string Cadena1 { get => Cadena; set => Cadena = value; }

        //  
        public string VerCadena()
        {
            ///string format solo fuinciona cuando el campo value es un int o un puto float
            ///lrpmt como hago con los campos de texto??????????
            ///
            long cuit2 = Convert.ToInt64(Cuit);
            int cod3 = CantidadRegistros04;
            int Numliq = Convert.ToInt32(NumeroDeLiquidacion);
            string codigo2 = string.Format("{0:000000}", CantidadRegistros04);
            String cade = string.Format("{0:00}",this.IdentificadorDeRegistro) + string.Format("{0:00000000000}", cuit2) + this.IdentificadorDeEnvio + this.Periodo + this.TipoDeLiquidacion + string.Format("{0:00000}", Numliq) + this.DiasBase +  codigo2;
            return cade;
        }

        
    }
}

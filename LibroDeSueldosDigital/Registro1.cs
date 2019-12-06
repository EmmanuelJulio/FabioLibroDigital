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

        int IdentificadorDeRegistro = 01;//2
        int Cuit;//11
        string IdentificadorDeEnvio;//2
        string Periodo;//6
        string TipoDeLiquidacion;//1
        int NumeroDeLiquidacion;//1
        int DiasBase = 30;//2
        int CantidadRegistros04=190;//6
        public Registro1()
        { 

        }
        public void Crear()
        {
            this.Cadena2=this.IdentificadorDeRegistro+this.Cuit1+this.IdentificadorDeEnvio+this.Periodo1+this.TipoDeLiquidacion1+this.NumeroDeLiquidacion1+this.DiasBase1+this.CantidadRegistros041;
        }

         string Cadena1 { get => Cadena2; set => Cadena2 = String.Format("{0:00000000000}", value); }
   
            
    public int Cuit1 { get => Cuit;
            set => Cuit = value; }
        public string IdentificadorDeEnvio1 { get => IdentificadorDeEnvio2; set => IdentificadorDeEnvio2 = value; }
        public string Periodo1 { get => Periodo; set => Periodo = value; }
        public string TipoDeLiquidacion1
            {
            get
            {
                return TipoDeLiquidacion1;
            }
            set
            {
                    switch (value)
                    {
                        case "Mensual":
                            TipoDeLiquidacion = "M";
                            break;
                        case "Quincenal":
                            TipoDeLiquidacion = "Q";
                            break;
                        case "Semanal":
                            TipoDeLiquidacion = "S";
                            break;

                    }
            }
            }
        public int NumeroDeLiquidacion1 { get => NumeroDeLiquidacion; set => NumeroDeLiquidacion = value; }
        public int DiasBase1 { get => DiasBase; set => DiasBase = value; }
        public int CantidadRegistros041 { get => CantidadRegistros04; set => CantidadRegistros04 = Convert.ToInt32(string.Format("{0:000000}", value)); }
        public string IdentificadorDeEnvio2 { get => IdentificadorDeEnvio; set => IdentificadorDeEnvio = value; }
        public string Cadena2 { get => Cadena; set => Cadena = value; }
    }
}

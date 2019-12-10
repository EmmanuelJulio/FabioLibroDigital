using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibroDeSueldosDigital
{
    
    class Registro2
    {
        string cadena2;
        string IdentificadorDeRegistro = "02";
        long Cuil02;
        int Legajo;
        string DependenciaDeRevista = "Activo";
        long CBU=0;
        int DiasParaTope=0;
        string fechadePago;
        string FechaDeRubrica;
        int FormaDepago=1;

        public Registro2(long _Cuil2, int _Legajo,string _fechadePago ,string _FechaDeRubrica)
        {
            this.Cuil02 = _Cuil2;
            this.Legajo = _Legajo;
            
            this.fechadePago = _fechadePago;
            this.FechaDeRubrica = _FechaDeRubrica;
           

            Cadena2 = IdentificadorDeRegistro + string.Format("{0:00000000000}", Cuil02) + string.Format("{0:0000000000}", Legajo) + DependenciaDeRevista.PadLeft(50, ' ') + string.Format("{0:0000000000000000000000}", CBU) + string.Format("{0:000}", DiasParaTope) + string.Format("{0:00000000}", fechadePago) + string.Format("{0:00000000}", FechaDeRubrica) + FormaDepago+"\r\n";
        }

        public string Cadena2 { get => cadena2; set => cadena2 = value; }
    }
}

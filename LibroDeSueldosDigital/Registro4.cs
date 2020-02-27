using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibroDeSueldosDigital
{
    class Registro4
    {
        string cadena04; //2
        string identificadorderegistro = "04";//3
        string cuil;//4
        string conyugue;//5
        string cantHijos;//6
        string MarcaCCT;//7
        string MarcaSCVO;
        string MarcaCorrespondeReduccion;
        string TipoEmpresa;
        string TipoOperacion;
        string CodigoSituacion;
        string CodigoCondicion;
        string CodigoActividad;
        string CodigoModalidadDeContratacion;
        string CodigoSiniestrado;
        string CodigoDeLocalidad;
        string SituacionDeRevista1;
        string DiaInicioSituacionDeRevista1;
        string SituacionDeRevista2;
        string DiaInicioSituacionDeRevista2;
        string SituacionDeRevista3;
        string DiaInicioSituacionDeRevista3;
        string CantDiasTrabajados;
        string HorasTrabajadas;
        string DiasTrabajados;
        string porcentajeaporteadiccionalss;
        string contribuciondiferencial;
        string Codigoobrasocial;
        string cantidadahderentes;
        string aporteadicionalOs;
        string contribucionadicionalOS;
        string BasecalculodiferencialaportesOSyFSR;
        string BaseCalculoDiferencialOsyFSR;
        string BaseCalculoDiferencialLRT;
        string RemuneracionMaternidadANSES;
        string RemuneracionBruta;//13 enteros 2 decimales;
        string BaseImponible1;
        string BaseImponible2;
        string BaseImponible3;
        string BaseImponible4;
        string BaseImponible5;
        string BaseImponible6;
        string BaseImponible7;
        string BaseImponible8;
        string BaseImponible9;
        string BaseParaElcalculodifdeaportesDeSegSocial;
        string BaseParaElcalculodifDeContribucionesDeSegSocial;
        string BaseImponible10;
        string ImporteAdetraer;

        public Registro4()
        {

        }


        public Registro4(
            string cuil,
            string conyugue,
            string cantHijos,
            string marcaCCT,
            string marcaSCVO,
            string marcaCorrespondeReduccion,
            string tipoEmpresa, 
            string tipoOperacion,
            string codigoSituacion,
            string codigoCondicion,
            string codigoActividad,
            string codigoModalidadDeContratacion,
            string codigoSiniestrado,
            string codigoDeLocalidad, 
            string situacionDeRevista1,
            string diaInicioSituacionDeRevista1,
            string situacionDeRevista2,
            string diaInicioSituacionDeRevista2,
            string situacionDeRevista3,
            string diaInicioSituacionDeRevista3,
            string cantDiasTrabajados,
            string HorasTrabajadas,
            string porcentajeaporteadiccionalss,
            string contribuciondiferencial,
            string codigoobrasocial,
            string cantidadahderentes,
            string aporteadicionalOs,
            string contribucionadicionalOS,
            string basecalculodiferencialaportesOSyFSR,
            string baseCalculoDiferencialOsyFSR,
            string baseCalculoDiferencialLRT,
            string remuneracionMaternidadANSES,
            string remuneracionBruta,
            string baseImponible1,
            string baseImponible2,
            string baseImponible3,
            string baseImponible4,
            string baseImponible5,
            string baseImponible6,
            string baseImponible7,
            string baseImponible8,
            string baseImponible9,
            string baseParaElcalculodifdeaportesDeSegSocial,
            string baseParaElcalculodifDeContribucionesDeSegSocial,
            string baseImponible10,
            string importeAdetraer)
        {
            this.HorasTrabajadas1 = HorasTrabajadas;
            this.Cuil = cuil;
            this.Conyugue = conyugue;
            this.CantHijos = cantHijos;
            MarcaCCT1 = marcaCCT;
            MarcaSCVO1 = marcaSCVO;
            MarcaCorrespondeReduccion1 = marcaCorrespondeReduccion;
            TipoEmpresa1 = tipoEmpresa;
            TipoOperacion1 = tipoOperacion;
            CodigoSituacion1 = codigoSituacion;
            CodigoCondicion1 = codigoCondicion;
            CodigoActividad1 = codigoActividad;
            CodigoModalidadDeContratacion1 = codigoModalidadDeContratacion;
            CodigoSiniestrado1 = codigoSiniestrado;
            CodigoDeLocalidad1 = codigoDeLocalidad;
            SituacionDeRevista11 = situacionDeRevista1;
            DiaInicioSituacionDeRevista11 = diaInicioSituacionDeRevista1;
            SituacionDeRevista21 = situacionDeRevista2;
            DiaInicioSituacionDeRevista21 = diaInicioSituacionDeRevista2;
            SituacionDeRevista31 = situacionDeRevista3;
            DiaInicioSituacionDeRevista31 = diaInicioSituacionDeRevista3;
            CantDiasTrabajados1 = cantDiasTrabajados;
            
            this.Porcentajeaporteadiccionalss = porcentajeaporteadiccionalss;
            this.Contribuciondiferencial = contribuciondiferencial;
            Codigoobrasocial1 = codigoobrasocial;
            this.Cantidadahderentes = cantidadahderentes;
            this.AporteadicionalOs = aporteadicionalOs;
            this.ContribucionadicionalOS = contribucionadicionalOS;
            BasecalculodiferencialaportesOSyFSR1 = basecalculodiferencialaportesOSyFSR;
            BaseCalculoDiferencialOsyFSR1 = baseCalculoDiferencialOsyFSR;
            BaseCalculoDiferencialLRT1 = baseCalculoDiferencialLRT;
            RemuneracionMaternidadANSES1 = remuneracionMaternidadANSES;
            RemuneracionBruta1 = remuneracionBruta;
            BaseImponible11 = baseImponible1;
            BaseImponible21 = baseImponible2;
            BaseImponible31 = baseImponible3;
            BaseImponible41 = baseImponible4;
            BaseImponible51 = baseImponible5;
            BaseImponible61 = baseImponible6;
            BaseImponible71 = baseImponible7;
            BaseImponible81 = baseImponible8;
            BaseImponible91 = baseImponible9;
            BaseParaElcalculodifdeaportesDeSegSocial1 = baseParaElcalculodifdeaportesDeSegSocial;
            BaseParaElcalculodifDeContribucionesDeSegSocial1 = baseParaElcalculodifDeContribucionesDeSegSocial;
            BaseImponible101 = baseImponible10;
            ImporteAdetraer1 = importeAdetraer;
            ////// creacion de la cadena
           
        }

        public string Cadena04 { get => cadena04; set => cadena04 = value; }
        public string Identificadorderegistro { get => identificadorderegistro; set => identificadorderegistro = value; }
        public string Cuil { get => cuil; set => cuil = value; }
        public string Conyugue { get => conyugue; set => conyugue = value; }
        public string CantHijos { get => cantHijos; set => cantHijos = value; }
        public string MarcaCCT1 { get => MarcaCCT; set => MarcaCCT = value; }
        public string MarcaSCVO1 { get => MarcaSCVO; set => MarcaSCVO = value; }
        public string MarcaCorrespondeReduccion1 { get => MarcaCorrespondeReduccion; set => MarcaCorrespondeReduccion = value; }
        public string TipoEmpresa1 { get => TipoEmpresa; set => TipoEmpresa = value; }
        public string TipoOperacion1 { get => TipoOperacion; set => TipoOperacion = value; }
        public string CodigoSituacion1 { get => CodigoSituacion; set => CodigoSituacion = value; }
        public string CodigoCondicion1 { get => CodigoCondicion; set => CodigoCondicion = value; }
        public string CodigoActividad1 { get => CodigoActividad; set => CodigoActividad = value; }
        public string CodigoModalidadDeContratacion1 { get => CodigoModalidadDeContratacion; set => CodigoModalidadDeContratacion = value; }
        public string CodigoSiniestrado1 { get => CodigoSiniestrado; set => CodigoSiniestrado = value; }
        public string CodigoDeLocalidad1 { get => CodigoDeLocalidad; set => CodigoDeLocalidad = value; }
        public string SituacionDeRevista11 { get => SituacionDeRevista1; set => SituacionDeRevista1 = value; }
        public string DiaInicioSituacionDeRevista11 { get => DiaInicioSituacionDeRevista1; set => DiaInicioSituacionDeRevista1 = value; }
        public string SituacionDeRevista21 { get => SituacionDeRevista2; set => SituacionDeRevista2 = value; }
        public string DiaInicioSituacionDeRevista21 { get => DiaInicioSituacionDeRevista2; set => DiaInicioSituacionDeRevista2 = value; }
        public string SituacionDeRevista31 { get => SituacionDeRevista3; set => SituacionDeRevista3 = value; }
        public string DiaInicioSituacionDeRevista31 { get => DiaInicioSituacionDeRevista3; set => DiaInicioSituacionDeRevista3 = value; }
        public string CantDiasTrabajados1 { get => CantDiasTrabajados; set => CantDiasTrabajados = value; }
        public string HorasTrabajadas1 { get => HorasTrabajadas; set => HorasTrabajadas = value; }
        public string DiasTrabajados1 { get => DiasTrabajados; set => DiasTrabajados = value; }
        public string Porcentajeaporteadiccionalss { get => porcentajeaporteadiccionalss; set => porcentajeaporteadiccionalss = value; }
        public string Contribuciondiferencial { get => contribuciondiferencial; set => contribuciondiferencial = value; }
        public string Codigoobrasocial1 { get => Codigoobrasocial; set => Codigoobrasocial = value; }
        public string Cantidadahderentes { get => cantidadahderentes; set => cantidadahderentes = value; }
        public string AporteadicionalOs { get => aporteadicionalOs; set => aporteadicionalOs = value; }
        public string ContribucionadicionalOS { get => contribucionadicionalOS; set => contribucionadicionalOS = value; }
        public string BasecalculodiferencialaportesOSyFSR1 { get => BasecalculodiferencialaportesOSyFSR; set => BasecalculodiferencialaportesOSyFSR = value; }
        public string BaseCalculoDiferencialOsyFSR1 { get => BaseCalculoDiferencialOsyFSR; set => BaseCalculoDiferencialOsyFSR = value; }
        public string BaseCalculoDiferencialLRT1 { get => BaseCalculoDiferencialLRT; set => BaseCalculoDiferencialLRT = value; }
        public string RemuneracionMaternidadANSES1 { get => RemuneracionMaternidadANSES; set => RemuneracionMaternidadANSES = value; }
        public string RemuneracionBruta1 { get => RemuneracionBruta; set => RemuneracionBruta = value; }
        public string BaseImponible11 { get => BaseImponible1; set => BaseImponible1 = value; }
        public string BaseImponible21 { get => BaseImponible2; set => BaseImponible2 = value; }
        public string BaseImponible31 { get => BaseImponible3; set => BaseImponible3 = value; }
        public string BaseImponible41 { get => BaseImponible4; set => BaseImponible4 = value; }
        public string BaseImponible51 { get => BaseImponible5; set => BaseImponible5 = value; }
        public string BaseImponible61 { get => BaseImponible6; set => BaseImponible6 = value; }
        public string BaseImponible71 { get => BaseImponible7; set => BaseImponible7 = value; }
        public string BaseImponible81 { get => BaseImponible8; set => BaseImponible8 = value; }
        public string BaseImponible91 { get => BaseImponible9; set => BaseImponible9 = value; }
        public string BaseParaElcalculodifdeaportesDeSegSocial1 { get => BaseParaElcalculodifdeaportesDeSegSocial; set => BaseParaElcalculodifdeaportesDeSegSocial = value; }
        public string BaseParaElcalculodifDeContribucionesDeSegSocial1 { get => BaseParaElcalculodifDeContribucionesDeSegSocial; set => BaseParaElcalculodifDeContribucionesDeSegSocial = value; }
        public string BaseImponible101 { get => BaseImponible10; set => BaseImponible10 = value; }
        public string ImporteAdetraer1 { get => ImporteAdetraer; set => ImporteAdetraer = value; }

        public string CrearCadena()
        {

            Cadena04 = Identificadorderegistro
          + string.Format("{0:00000000000}", Convert.ToInt16(Cuil))
          + string.Format("{0:00}", Convert.ToInt16(conyugue))
          + cantHijos
          + MarcaCCT
          + MarcaSCVO
          + MarcaCorrespondeReduccion
          + TipoEmpresa 
          + TipoOperacion
          + string.Format("{0:00}", Convert.ToInt16(CodigoSituacion))
          + string.Format("{0:00}", Convert.ToInt16(CodigoCondicion))
          + string.Format("{0:000}", Convert.ToInt16(CodigoActividad))
          + string.Format("{0:000}", Convert.ToInt16(CodigoModalidadDeContratacion))
          + string.Format("{0:00}", Convert.ToInt16(CodigoSiniestrado))
          + string.Format("{0:00}", Convert.ToInt16(CodigoDeLocalidad)
          + SituacionDeRevista1
          + DiaInicioSituacionDeRevista1
          + SituacionDeRevista2
          + DiaInicioSituacionDeRevista2
          + SituacionDeRevista3
          + DiaInicioSituacionDeRevista3
          + CantDiasTrabajados
          + string.Format("{0:000}", Convert.ToInt16(HorasTrabajadas))
          + string.Format("{0:00000}", Convert.ToInt16(porcentajeaporteadiccionalss)) + string.Format("{0:00000}", Convert.ToInt16(contribuciondiferencial))
          + string.Format("{0:00000}", Convert.ToInt16(Codigoobrasocial)) + string.Format("{0:00}", Convert.ToInt16(cantidadahderentes))
          + string.Format("{0:000000000000000}", (aporteadicionalOs).ToString())
          + string.Format("{0:000000000000000}", (contribucionadicionalOS).ToString())
          + string.Format("{0:000000000000000}", (BasecalculodiferencialaportesOSyFSR).ToString())
          + string.Format("{0:000000000000000}", (BaseCalculoDiferencialLRT).ToString())
          + string.Format("{0:000000000000000}", (RemuneracionMaternidadANSES).ToString())
          + string.Format("{0:000000000000000}", (contribucionadicionalOS).ToString())
          + string.Format("{0:0000000000000,00}", (BaseImponible1).ToString())
          + string.Format("{0:0000000000000,00}", (BaseImponible2).ToString())
          + string.Format("{0:0000000000000,00}", (BaseImponible3).ToString())
          + string.Format("{0:0000000000000,00}", (BaseImponible4).ToString())
          + string.Format("{0:0000000000000,00}", (BaseImponible5).ToString())
          + string.Format("{0:0000000000000,00}", (BaseImponible6).ToString())
          + string.Format("{0:0000000000000,00}", (BaseImponible7).ToString())
          + string.Format("{0:0000000000000,00}", (BaseImponible8).ToString())
          + string.Format("{0:0000000000000,00}", (BaseImponible9).ToString())
          + string.Format("{0:0000000000000,00}", (BaseParaElcalculodifdeaportesDeSegSocial).ToString())
          + string.Format("{0:0000000000000,00}", (BaseParaElcalculodifDeContribucionesDeSegSocial).ToString())
          + string.Format("{0:0000000000000,00}", (BaseImponible10).ToString()))
          + string.Format("{0:0000000000000,00}", (ImporteAdetraer).ToString());
            return cadena04;
        }
    }
}

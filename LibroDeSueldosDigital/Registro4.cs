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
        long cuil;//4
        string conyugue;//5
        int cantHijos;//6
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
        int CantDiasTrabajados;
        int DiasTrabajados;
        float porcentajeaporteadiccionalss;
        float contribuciondiferencial;
        string Codigoobrasocial;
        int cantidadahderentes;
        float aporteadicionalOs;
        float contribucionadicionalOS;
        float BasecalculodiferencialaportesOSyFSR;
        float BaseCalculoDiferencialOsyFSR;
        float BaseCalculoDiferencialLRT;
        float RemuneracionMaternidadANSES;
        float RemuneracionBruta;//13 enteros 2 decimales;
        float BaseImponible1;
        float BaseImponible2;
        float BaseImponible3;
        float BaseImponible4;
        float BaseImponible5;
        float BaseImponible6;
        float BaseImponible7;
        float BaseImponible8;
        float BaseImponible9;
        float BaseParaElcalculodifdeaportesDeSegSocial;
        float BaseParaElcalculodifDeContribucionesDeSegSocial;
        float BaseImponible10;
        float ImporteAdetraer;

        //public cadena4(long _cuil, string _conyugue, int _cantHijos, string _MarcaCCT, string _MarcaSCVO, string _MarcaCorrespondeReduccion, string _TipoEmpresa, string _TipoOperacion,string _CodigoSituacion,string CodigoCondicion,
        //string _CodigoActividad,string _CodigoModalidadDeContratacion,string _CodigoSiniestrado,string _CodigoDeLocalidad,string _SituacionDeRevista1,string _DiaInicioSituacionDeRevista1,string _SituacionDeRevista2,
        //string _DiaInicioSituacionDeRevista2,string _SituacionDeRevista3,string _DiaInicioSituacionDeRevista3,int _CantDiasTrabajados,int _DiasTrabajados,float _porcentajeaporteadiccionalss,float _contribuciondiferencial,
        //string _Codigoobrasocial,int _cantidadahderentes,float _aporteadicionalOs,float _contribucionadicionalOS,float _BasecalculodiferencialaportesOSyFSR,float _BaseCalculoDiferencialOsyFSR,float _BaseCalculoDiferencialLRT,
        //float _RemuneracionMaternidadANSES,float _RemuneracionBruta,float _BaseImponible1,float _BaseImponible2,float _BaseImponible3,float _BaseImponible4,float _BaseImponible5,float _BaseImponible6,float _BaseImponible7,
        //float _BaseImponible8,float _BaseImponible9,float _BaseParaElcalculodifdeaportesDeSegSocial,float _BaseParaElcalculodifDeContribucionesDeSegSocial, float BaseImponible10,float ImporteAdetraer)
        //{
        //    return cadena4;
        //}

        public Registro4(string identificadorderegistro, long cuil, string conyugue, int cantHijos, string marcaCCT, string marcaSCVO, string marcaCorrespondeReduccion, string tipoEmpresa, 
            string tipoOperacion, string codigoSituacion, string codigoCondicion, string codigoActividad, string codigoModalidadDeContratacion, string codigoSiniestrado, string codigoDeLocalidad, 
            string situacionDeRevista1, string diaInicioSituacionDeRevista1, string situacionDeRevista2, string diaInicioSituacionDeRevista2, string situacionDeRevista3, string diaInicioSituacionDeRevista3, 
            int cantDiasTrabajados, int diasTrabajados, float porcentajeaporteadiccionalss, float contribuciondiferencial, string codigoobrasocial, int cantidadahderentes, float aporteadicionalOs, 
            float contribucionadicionalOS, float basecalculodiferencialaportesOSyFSR, float baseCalculoDiferencialOsyFSR, float baseCalculoDiferencialLRT, float remuneracionMaternidadANSES, 
            float remuneracionBruta, float baseImponible1, float baseImponible2, float baseImponible3, float baseImponible4, float baseImponible5, float baseImponible6, float baseImponible7, 
            float baseImponible8, float baseImponible9, float baseParaElcalculodifdeaportesDeSegSocial, float baseParaElcalculodifDeContribucionesDeSegSocial, float baseImponible10, float importeAdetraer)
        {
            
            this.identificadorderegistro = identificadorderegistro;
            this.cuil = cuil;
            this.conyugue = conyugue;
            this.cantHijos = cantHijos;
            MarcaCCT = marcaCCT;
            MarcaSCVO = marcaSCVO;
            MarcaCorrespondeReduccion = marcaCorrespondeReduccion;
            TipoEmpresa = tipoEmpresa;
            TipoOperacion = tipoOperacion;
            CodigoSituacion = codigoSituacion;
            CodigoCondicion = codigoCondicion;
            CodigoActividad = codigoActividad;
            CodigoModalidadDeContratacion = codigoModalidadDeContratacion;
            CodigoSiniestrado = codigoSiniestrado;
            CodigoDeLocalidad = codigoDeLocalidad;
            SituacionDeRevista1 = situacionDeRevista1;
            DiaInicioSituacionDeRevista1 = diaInicioSituacionDeRevista1;
            SituacionDeRevista2 = situacionDeRevista2;
            DiaInicioSituacionDeRevista2 = diaInicioSituacionDeRevista2;
            SituacionDeRevista3 = situacionDeRevista3;
            DiaInicioSituacionDeRevista3 = diaInicioSituacionDeRevista3;
            CantDiasTrabajados = cantDiasTrabajados;
            DiasTrabajados = diasTrabajados;
            this.porcentajeaporteadiccionalss = porcentajeaporteadiccionalss;
            this.contribuciondiferencial = contribuciondiferencial;
            Codigoobrasocial = codigoobrasocial;
            this.cantidadahderentes = cantidadahderentes;
            this.aporteadicionalOs = aporteadicionalOs;
            this.contribucionadicionalOS = contribucionadicionalOS;
            BasecalculodiferencialaportesOSyFSR = basecalculodiferencialaportesOSyFSR;
            BaseCalculoDiferencialOsyFSR = baseCalculoDiferencialOsyFSR;
            BaseCalculoDiferencialLRT = baseCalculoDiferencialLRT;
            RemuneracionMaternidadANSES = remuneracionMaternidadANSES;
            RemuneracionBruta = remuneracionBruta;
            BaseImponible1 = baseImponible1;
            BaseImponible2 = baseImponible2;
            BaseImponible3 = baseImponible3;
            BaseImponible4 = baseImponible4;
            BaseImponible5 = baseImponible5;
            BaseImponible6 = baseImponible6;
            BaseImponible7 = baseImponible7;
            BaseImponible8 = baseImponible8;
            BaseImponible9 = baseImponible9;
            BaseParaElcalculodifdeaportesDeSegSocial = baseParaElcalculodifdeaportesDeSegSocial;
            BaseParaElcalculodifDeContribucionesDeSegSocial = baseParaElcalculodifDeContribucionesDeSegSocial;
            BaseImponible10 = baseImponible10;
            ImporteAdetraer = importeAdetraer;
            cadena04 = string.Format("{0:00000000000}", Convert.ToInt64(cuil))+ string.Format("{0:00000000000}", Convert.ToInt64(Cuil3))
        }
     
    }
}

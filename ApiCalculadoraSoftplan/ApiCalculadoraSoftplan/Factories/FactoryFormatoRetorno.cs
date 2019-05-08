using ApiCalculadoraSoftplan.Interfaces;
using ApiCalculadoraSoftplan.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCalculadoraSoftplan.Factories
{
    public class FactoryFormatoRetorno
    {
        public enum E_formato
        {
            FormatoComVirgulaEDuasCasasDecimais = 1
        }

        public static IFormatoRetorno Criar(E_formato p_eFormato)
        {
            if (p_eFormato == E_formato.FormatoComVirgulaEDuasCasasDecimais)
                return new FormatoComVirgulaEDuasCasasDecimaisService();  
            return new FormatoComVirgulaEDuasCasasDecimaisService();
        }

    }
}

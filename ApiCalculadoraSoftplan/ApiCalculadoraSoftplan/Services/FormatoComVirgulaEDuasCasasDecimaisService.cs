using ApiCalculadoraSoftplan.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCalculadoraSoftplan.Services
{
    public class FormatoComVirgulaEDuasCasasDecimaisService : IFormatoRetorno
    {
        public string Formatar(double p_valor)
        {
            return String.Format("{0:n2}", p_valor); 
        }
    }
}

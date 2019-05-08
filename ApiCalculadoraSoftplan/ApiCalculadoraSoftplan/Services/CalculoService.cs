using ApiCalculadoraSoftplan.Interfaces;
using ApiCalculadoraSoftplan.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCalculadoraSoftplan.Services
{
    public class CalculoService
    {
        ICalculo _calculo;
        IFormatoRetorno _formatoRetorno;

        public CalculoService(IFormatoRetorno p_formatoRetorno, ICalculo p_calculo)
        {
            _calculo = p_calculo;
            _formatoRetorno = p_formatoRetorno;
        }

        public string Calcular(Calculo p_calculo)
        {
            try
            {
                return _formatoRetorno.Formatar(_calculo.Calcular(p_calculo)); 
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}

using ApiCalculadoraSoftplan.Interfaces;
using ApiCalculadoraSoftplan.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCalculadoraSoftplan.Factories
{
    public enum E_calculo
    {
        Juros = 1
    }
    public class FactoryCalculo
    {
        public static ICalculo Criar(E_calculo p_eCaulculo)
        {
            if (p_eCaulculo == E_calculo.Juros)
                return new CalculoJurosService(); 
            return new CalculoJurosService();
        }
    }
}

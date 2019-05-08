using ApiCalculadoraSoftplan.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCalculadoraSoftplan.Services
{
    public class ValorInicialService
    {
        public static bool IsValid(decimal p_valorInicial)
        {
            return (p_valorInicial > 0);
        }

        public static void Validate(decimal p_valorInicial)
        {
            if (p_valorInicial <= 0)
                throw new ValorInicialMenorIgualAZeroException(); 
        }
    }
}

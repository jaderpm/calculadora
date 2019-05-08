using ApiCalculadoraSoftplan.Interfaces;
using ApiCalculadoraSoftplan.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCalculadoraSoftplan.Services
{
    public class CalculoJurosService:ICalculo
    {
        const double JUROS = 0.01;

        double ICalculo.Calcular(Calculo p_calculo)
        {
            p_calculo.Validate();
            return (double)p_calculo.ValorInicial * (Math.Pow((1 + JUROS), p_calculo.Meses)); 
        }
    }
}

using ApiCalculadoraSoftplan.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCalculadoraSoftplan.Interfaces
{
    public interface ICalculo
    {
        double Calcular(Calculo p_calculo); 
    }
}

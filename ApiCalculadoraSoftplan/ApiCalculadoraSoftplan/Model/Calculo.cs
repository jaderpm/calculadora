using ApiCalculadoraSoftplan.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCalculadoraSoftplan.Model
{
    public class Calculo
    {
        public decimal ValorInicial { get; set; }
        public int Meses { get; set; }

        public void Validate()
        {
            ValorInicialService.Validate(ValorInicial);
            MesesService.Validate(Meses);

        }
        public bool IsValid()
        {
            return MesesService.IsValid(Meses) && ValorInicialService.IsValid(ValorInicial); 
        }
    }
}

using ApiCalculadoraSoftplan.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCalculadoraSoftplan.Services
{
    public class MesesService
    {
        public static bool IsValid(int meses)
        {
            return (meses > 0);
        }

        public static void Validate(int meses)
        {
            if (meses <= 0)
                throw new MesesMenorIgualAZeroException(); 
        }
    }
}

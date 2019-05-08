using ApiCalculadoraSoftplan.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCalculadoraSoftplan.Services
{
    public class GitCalculadoraUrlService : AGitUrl
    {
        public override string GetUrl()
        {
            return C_ENDERECO_URL_GIT + "calculadora";
        }
    }
}

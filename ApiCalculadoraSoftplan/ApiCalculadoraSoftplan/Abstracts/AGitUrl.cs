using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCalculadoraSoftplan.Abstracts
{
    public abstract class AGitUrl
    {
        public const string C_ENDERECO_URL_GIT = "https://github.com/jaderpm/";
        public abstract string GetUrl();
    }
}

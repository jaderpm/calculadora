using ApiCalculadoraSoftplan.Abstracts;
using ApiCalculadoraSoftplan.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCalculadoraSoftplan.Factories
{
    public class FactoryUrlGit
    {
        public enum E_gitRepository
        {
            Calculadora = 1
        }

        public static AGitUrl Criar(E_gitRepository p_eGitRepository)
        {
            if (p_eGitRepository == E_gitRepository.Calculadora)
                return new GitCalculadoraUrlService();
            return new GitCalculadoraUrlService();
        }
    }
}

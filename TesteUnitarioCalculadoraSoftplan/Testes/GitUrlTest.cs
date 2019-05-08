using ApiCalculadoraSoftplan.Abstracts;
using ApiCalculadoraSoftplan.Factories;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace TesteUnitarioCalculadoraSoftplan.Testes
{
    public class GitUrlTest
    {
        AGitUrl _UrlGit;

        [SetUp]
        public void SetUp()
        {
            _UrlGit = FactoryUrlGit.Criar(FactoryUrlGit.E_gitRepository.Calculadora);
        }

        [TestCase]
        public void TesteEntradaPadrao()
        {
            Assert.AreSame(_UrlGit.GetUrl(), AGitUrl.C_ENDERECO_URL_GIT + "calculadora");
        }
    }
}

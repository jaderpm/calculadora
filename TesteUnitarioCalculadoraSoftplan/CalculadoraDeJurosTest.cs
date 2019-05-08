using ApiCalculadoraSoftplan.Exceptions;
using ApiCalculadoraSoftplan.Factories;
using ApiCalculadoraSoftplan.Interfaces;
using ApiCalculadoraSoftplan.Model;
using ApiCalculadoraSoftplan.Services;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using static ApiCalculadoraSoftplan.Factories.FactoryFormatoRetorno;

namespace TesteUnitarioCalculadoraSoftplan
{
    public class CalculadoraDeJurosTest
    {
        private CalculoService _CalculoService;
        private ICalculo _CalculoJurosService;
        private IFormatoRetorno _FormatoRetorno;
        [SetUp]
        public void Setup()
        {
            _FormatoRetorno = FactoryFormatoRetorno.Criar(E_formato.FormatoComVirgulaEDuasCasasDecimais);
            _CalculoJurosService = FactoryCalculo.Criar(E_calculo.Juros);
            _CalculoService = new CalculoService(
                    _FormatoRetorno,
                    _CalculoJurosService
                    );
        }
        [TestCase(100, 5)]
        public void TesteDeEntradaMaiorQueZero(decimal valorInicial, int meses)
        {
            var retorno = _CalculoJurosService.Calcular(new Calculo() { ValorInicial = valorInicial, Meses = meses });
            Assert.AreEqual(retorno, 105.10100501000001);
        }

        [TestCase(100, 5)]
        public void TesteDeRetornoFormatado(decimal valorInicial, int meses)
        {
            var retorno = _CalculoService.Calcular(new Calculo() { ValorInicial = valorInicial, Meses = meses });
            Assert.AreEqual(retorno, "105,10");
        }

        [TestCase(100.50, 2)]
        public void TesteDeEntradaComDecimalQuebrado(decimal valorInicial, int meses)
        {
            var retorno = _CalculoJurosService.Calcular(new Calculo() { ValorInicial = valorInicial, Meses = meses });
            Assert.AreEqual(retorno, 102.52005);
        }

        [TestCase(-200, 9)]
        [TestCase(-101, 3)]
        [TestCase(-10, 100)]
        public void TesteDeValorInicialMenorQueZero(decimal valorInicial, int meses)
        {
            Assert.AreSame(_CalculoService.Calcular(new Calculo() { ValorInicial = valorInicial, Meses = meses }), new ValorInicialMenorIgualAZeroException().Message);
        }

        [TestCase(200, -9)]
        [TestCase(101, -3)]
        [TestCase(10, -100)]
        public void TesteDeEntradaMesesMenorQueZero(decimal valorInicial, int meses)
        {
            Assert.AreSame(_CalculoService.Calcular(new Calculo() { ValorInicial = valorInicial, Meses = meses }), new MesesMenorIgualAZeroException().Message);
        }


        [TestCase(1, 0)]
        public void TesteDeEntradaMesesIgualAZero(decimal valorInicial, int meses)
        {
            Assert.AreSame(_CalculoService.Calcular(new Calculo() { ValorInicial = valorInicial, Meses = meses }), new MesesMenorIgualAZeroException().Message);
        }

        [TestCase(0, 1)]
        public void TesteDeEntradaValorInicialIgualAZero(decimal valorInicial, int meses)
        {
            Assert.AreSame(_CalculoService.Calcular(new Calculo() { ValorInicial = valorInicial, Meses = meses }), new ValorInicialMenorIgualAZeroException().Message);
        }
    }
}

using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace TesteIntegracaoCalculadoraSoftplan.Testes
{
    public class CalculadoraDeJurosTest
    {
        private Contexto.Contexto _contexto;
        public CalculadoraDeJurosTest()
        {
            _contexto = new Contexto.Contexto();
        }

        [Fact]
        public async Task TestaFuncionamentoCalculaJuros()
        {
            var response = await _contexto.Client.GetAsync("/CalculaJuros?valorInicial=100&meses=5");
            response.EnsureSuccessStatusCode();
            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }

        [Fact]
        public async Task TestaFuncionamentoCalculaJurosLetrasMinusculas()
        {
            var response = await _contexto.Client.GetAsync("/calculajuros?valorInicial=100&meses=5");
            response.EnsureSuccessStatusCode();
            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }

        [Fact]
        public async Task TestaChamadaErrada()
        {
            var response = await _contexto.Client.GetAsync("/calculajuro");
            response.StatusCode.Should().Be(HttpStatusCode.NotFound);
        }

        [Fact]
        public async Task TestaEnvioFormatoIncorretoCaracteres()
        {
            var response = await _contexto.Client.GetAsync("/calculajuros?valorInicial=r&meses=5");
            response.StatusCode.Should().Be(HttpStatusCode.BadRequest);
        }

        [Fact]
        public async Task TestaEnvioFormatoIncorretoSemVariavelErroTratado()
        {
            var response = await _contexto.Client.GetAsync("/calculajuros?&meses=5");
            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }

        [Fact]
        public async Task TestaTipoRetorno()
        {
            var response = await _contexto.Client.GetAsync("/calculajuros?valorInicial=100&meses=5");
            response.EnsureSuccessStatusCode();
            response.Content.Headers.ContentType.ToString().Should().Be("text/plain; charset=utf-8");
        }

    }
}

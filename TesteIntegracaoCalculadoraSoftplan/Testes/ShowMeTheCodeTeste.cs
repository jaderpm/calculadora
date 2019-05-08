using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace TesteIntegracaoCalculadoraSoftplan.Testes
{
    public class ShowMeTheCodeTeste
    {
        private Contexto.Contexto _contexto;

        public ShowMeTheCodeTeste()
        {
            _contexto = new Contexto.Contexto();
        }

        [Fact]
        public async Task TestaFuncionamento()
        {
            var response = await _contexto.Client.GetAsync("/ShowMeTheCode");
            response.EnsureSuccessStatusCode();
            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }

        [Fact]
        public async Task TestaChamadaErrada()
        {
            var response = await _contexto.Client.GetAsync("/ShowMeTheCo");
            response.StatusCode.Should().Be(HttpStatusCode.NotFound);
        }

        [Fact]
        public async Task TestaTipoRetorno()
        {
            var response = await _contexto.Client.GetAsync("ShowMeTheCode");
            response.EnsureSuccessStatusCode();
            response.Content.Headers.ContentType.ToString().Should().Be("text/plain; charset=utf-8");
        }
        [Fact]
        public async Task TestaFuncionamentoChamadaLetrasMinusculas()
        {
            var response = await _contexto.Client.GetAsync("/showmethecode");
            response.EnsureSuccessStatusCode();
            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }

    }
}

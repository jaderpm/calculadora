using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiCalculadoraSoftplan.Factories;
using ApiCalculadoraSoftplan.Model;
using ApiCalculadoraSoftplan.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static ApiCalculadoraSoftplan.Factories.FactoryFormatoRetorno;

namespace ApiCalculadoraSoftplan.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CalculaJurosController : ControllerBase
    {
        /// <summary>
        /// Retorna o juros acúmulado com o valor inícial calculado com base na quantidade de meses informada
        /// </summary>
        /// <remarks>
        ///     
        ///     GET /Calculajuros
        ///         
        ///         Exemplo de Formato de parâmetros:
        ///         
        ///         valorInicial=100
        /// 
        ///         meses=5
        ///     
        ///
        /// </remarks>
        /// <param name="valorInicial">Valor inicial para o cálculo</param>
        /// <param name="meses">Quantidade de meses a ser calculado o juros</param>
        [HttpGet]
        public ActionResult<string> Get(decimal valorInicial, int meses)
        {
            return new CalculoService(
                FactoryFormatoRetorno.Criar(E_formato.FormatoComVirgulaEDuasCasasDecimais),
                FactoryCalculo.Criar(E_calculo.Juros)
                ).Calcular(new Calculo() { ValorInicial = valorInicial, Meses = meses });
        }
    }
}
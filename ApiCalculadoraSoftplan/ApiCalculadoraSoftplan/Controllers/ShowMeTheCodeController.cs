using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiCalculadoraSoftplan.Factories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiCalculadoraSoftplan.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ShowMeTheCodeController : ControllerBase
    {
        //  GET /ShowMeTheCode
        /// <summary>
        /// Retorna o endereço do repositório git onde se encontra o projeto.
        /// </summary>
        /// <remarks>
        /// Exemplo:
        ///
        ///     GET /ShowMeTheCode
        ///
        /// </remarks>
        [HttpGet]
        public ActionResult<string> Get()
        {
            return FactoryUrlGit.Criar(FactoryUrlGit.E_gitRepository.Calculadora).GetUrl();
        }
    }
}
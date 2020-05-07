using AplicacaoWebExemplo.Modelos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace AplicacaoWebExemplo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TesteController : ControllerBase
    {
        private ConfiguracaoConcreta _configuracao;
        public TesteController(IOptionsSnapshot<ConfiguracaoConcreta> configuracao)
        {
            _configuracao = configuracao.Value;
        }

        [HttpGet]
        public string Testar()
        {
            return _configuracao.Valor;
        }
    }
}
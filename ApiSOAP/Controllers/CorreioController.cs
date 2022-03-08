using ApiSOAP.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using static ApiSOAP.Models.Correio;

namespace ApiSOAP.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CorreioController : ControllerBase
    {
        private readonly ILogger<CorreioController> _logger;
        public CorreioController(ILogger<CorreioController> logger)
        {
            _logger = logger;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cep"></param>
        /// <returns></returns>
        [HttpPost]
        public Endereco Correio(string cep)
        {
            Correio correio = new();
            var client = new Correios.AtendeClienteClient();
            if (client.InnerChannel.State != System.ServiceModel.CommunicationState.Faulted)
            {

                var consulta = client.consultaCEPAsync(cep).Result;

                if (consulta != null)
                {
                    Endereco endereco = new()
                    {
                        Descricao = consulta.@return.end,
                        Bairro = consulta.@return.bairro,
                        Cidade = consulta.@return.cidade,
                        UF = consulta.@return.uf
                    };

                    return endereco;
                }
            }
            else
            {
                return null;
            }
            return null;
        }
    }
}

using ApiSOAP.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace ApiSOAP.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculadoraController : ControllerBase
    {
        private readonly ILogger<CalculadoraController> _logger;
        public double resultado;

        public CalculadoraController(ILogger<CalculadoraController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// </summary>
        /// <param name="calculadora">
        ///[
        //  {
        //    "numero": 1
        //  },
        //  {
        //    "numero": 2
        //  },
        //  {
        //    "numero": 4
        //  }
        //]
        //</param>
        /// <returns></returns>
        [HttpPost, Route("Soma")]
        public double Soma([Bind("Numero")] List<Calculadora> calculadora)
        {

            if (ModelState.IsValid)
            {
                foreach (var item in calculadora)
                {
                    resultado += item.Numero;
                }
            }
            return resultado;
        }

        [HttpPost, Route("Subtracao")]
        public double Subtracao([Bind("Numero")] List<Calculadora> calculadora)
        {

            if (ModelState.IsValid)
            {
                foreach (var item in calculadora)
                {
                    resultado -= item.Numero;
                }
            }
            return resultado;
        }

        [HttpPost, Route("Multiplicacao")]
        public double Multiplicacao([Bind("Numero")] List<Calculadora> calculadora)
        {

            if (ModelState.IsValid)
            {

                foreach (var item in calculadora)
                {
                    if (resultado == 0)
                    {
                        resultado = item.Numero;
                    }
                    else
                    {
                        resultado *= item.Numero;
                    }
                }
            }
            return resultado;
        }

        [HttpPost, Route("Divisao")]
        public double Divisao([Bind("Numero")] List<Calculadora> calculadora)
        {

            if (ModelState.IsValid)
            {
                foreach (var item in calculadora)
                {
                    if (resultado == 0)
                    {
                        resultado = item.Numero;
                    }
                    else
                    {
                        resultado /= item.Numero;
                    }
                }
            }
            return resultado;
        }
    }
}

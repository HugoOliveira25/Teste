using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesafioDevFull.Dominio;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DesafioDevFull.Controllers
{
    [Produces("application/json")]
    [ApiController]
    [Route("api/desafiodevfull")]
    public class DesafioDevFullController : ControllerBase
    {

        [HttpGet("obtertitulos")]
        public async Task<IEnumerable<TituloEmAtraso>> ObterDividas()
        {
            var titulos = new List<TituloEmAtraso>();

            titulos.Add(new TituloEmAtraso() { Numero = Guid.NewGuid(), NomeDevedor = "Hugo Oliveira", CPFDevedor = "416.225.658-60" });
            titulos.Add(new TituloEmAtraso() { Numero = Guid.NewGuid(), NomeDevedor = "Fernando Prado", CPFDevedor = "417.225.658-60" });
            titulos.Add(new TituloEmAtraso() { Numero = Guid.NewGuid(), NomeDevedor = "Adriel Torres", CPFDevedor = "418.225.658-60" });

            return await Task.FromResult(titulos);

        }
    }
}

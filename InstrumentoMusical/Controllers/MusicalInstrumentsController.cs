using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using Domain.Models;
using Service.Contracts;
using Swashbuckle.AspNetCore.Annotations;

namespace InstrumentoMusical.Controllers
{
    [RoutePrefix("api/instruments")]
    public class MusicalInstrumentsController : ApiController
    {
        private IMusicalInstrumentService musicalInstrumentService;

        public MusicalInstrumentsController(IMusicalInstrumentService musicalInstrumentService)
        {
            this.musicalInstrumentService = musicalInstrumentService;
        }

        // GET api/instruments/find
        [HttpGet]
        [Route("find")]
        [SwaggerResponse((int)HttpStatusCode.OK, "Retorna lista de instrumentos", Type = typeof(List<MusicalInstrument>))]
        public async Task<IHttpActionResult> GetInstruments()
        {
            var instruments = await this.musicalInstrumentService.GetAll();
            return Ok(instruments);
        }

        // Post api/instruments/add
        [HttpPost]
        [Route("add")]
        [SwaggerResponse((int)HttpStatusCode.OK, "Adiciona item à lista de instrumentos", Type = typeof(MusicalInstrument))]
        public async Task<IHttpActionResult> AddInstrument(MusicalInstrument musicalInstrument)
        {
            await this.musicalInstrumentService.Add(musicalInstrument);
            
            return Ok();
        }
    }
}

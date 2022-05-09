using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using Domain.Models;
using Service.Contracts;
using Service.Services.Validators;
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
        [Route("")]
        [SwaggerResponse((int)HttpStatusCode.OK, "Retorna lista de instrumentos", Type = typeof(List<Instrumento>))]
        public async Task<IHttpActionResult> GetInstruments()
        {
            var instruments = await musicalInstrumentService.GetAll();
            return Ok(instruments);
        }

        // GET api/instruments/{id}
        [HttpGet]
        [Route("{id}")]
        [SwaggerResponse((int)HttpStatusCode.OK, "Retorna instrumento de acordo com Id informado", Type = typeof(Instrumento))]
        public async Task<IHttpActionResult> GetInstrumentById(Guid id)
        {
            var instrument = await musicalInstrumentService.GetById(id);
            return Ok(instrument);
        }

        // Post api/instruments/add
        [HttpPost]
        [Route("")]
        [SwaggerResponse((int)HttpStatusCode.OK, "Adiciona item à lista de instrumentos", Type = typeof(Instrumento))]
        public async Task<IHttpActionResult> AddInstrument(Instrumento musicalInstrument)
        {
            await musicalInstrumentService.Add(musicalInstrument);
            
            return Ok();
        }


        // Post api/instruments/
        [HttpPut]
        [Route("")]
        [SwaggerResponse((int)HttpStatusCode.OK, "Edita item da lista de instrumentos", Type = typeof(Instrumento))]
        public async Task<IHttpActionResult> EditInstrument(Instrumento musicalInstrument)
        {
            await musicalInstrumentService.Edit(musicalInstrument);

            return Ok();
        }

        // PUT: api/instruments/
        [HttpDelete]
        [Route("{id}")]
        [SwaggerResponse((int)HttpStatusCode.OK, "Adiciona item à lista de instrumentos", Type = typeof(string))]
        public async Task<IHttpActionResult> RemoveInstrument(Guid id)
        {
            await musicalInstrumentService.Remove(id);

            return Ok();
        }
    }
}

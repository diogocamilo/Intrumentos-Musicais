using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using Service.Contracts;
using Swashbuckle.AspNetCore.Annotations;

namespace InstrumentoMusical.Controllers
{
    [RoutePrefix("api/instruments")]
    public class ValuesController : ApiController
    {
        private IMusicalInstrumentService musicalInstrumentService;


        public ValuesController(IMusicalInstrumentService musicalInstrumentService)
        {
            this.musicalInstrumentService = musicalInstrumentService;
        }

        // GET api/values
        [HttpGet]
        [Route("find")]
        public async Task<IHttpActionResult> GetInstruments()
        {
            var instruments = await this.musicalInstrumentService.GetAll();
            return Ok(instruments);
        }
    }
}

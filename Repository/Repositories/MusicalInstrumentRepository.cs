using Domain.Models;
using Repository.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public class MusicalInstrumentRepository : IMusicalInstrumentRepository
    {
        private List<MusicalInstrument> instruments;

        public MusicalInstrumentRepository()
        {
            this.instruments = new List<MusicalInstrument>();

            this.instruments.Add(new MusicalInstrument() { Id = 1, Description = "Fender Stratocaster", Name = "Guitarra", Price = 4000 });
            this.instruments.Add(new MusicalInstrument() { Id = 2, Description = "Fender Jazzmaster", Name = "Guitarra", Price = 5000 });
        }

        public async Task<List<MusicalInstrument>> GetAll()
        {
            return await Task.FromResult(instruments);
        }

        public async Task Add(MusicalInstrument musicalInstrument)
        {

        }

        public async Task Edit(MusicalInstrument musicalInstrument)
        {

        }

        public async Task Remove(int id)
        {

        }
    }
}

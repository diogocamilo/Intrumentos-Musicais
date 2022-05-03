using Domain.Models;
using Repository.Contracts;
using Repository.Repositories.Daos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public class MusicalInstrumentRepository : IMusicalInstrumentRepository
    {
        private readonly List<MusicalInstrument> instruments;

        public MusicalInstrumentRepository()
        {
            MusicalInstrumentDAO.Initialize();
            instruments = MusicalInstrumentDAO.GetAll();
        }

        public async Task<List<MusicalInstrument>> GetAll()
        {
            return await Task.FromResult(instruments);
        }

        public async Task Add(MusicalInstrument musicalInstrument)
        {
            instruments.Add(musicalInstrument);
        }

        public async Task Edit(MusicalInstrument musicalInstrument)
        {

        }

        public async Task Remove(int id)
        {

        }

        public Task<MusicalInstrument> GetId()
        {
            throw new NotImplementedException();
        }
    }
}

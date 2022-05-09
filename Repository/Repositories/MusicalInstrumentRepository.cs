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
        private readonly List<Instrumento> instruments;

        public MusicalInstrumentRepository()
        {
            MusicalInstrumentDAO.Initialize();
            instruments = MusicalInstrumentDAO.GetAll();
        }

        public async Task<List<Instrumento>> GetAll()
        {
            return await Task.FromResult(instruments);
        }

        public async Task Add(Instrumento musicalInstrument)
        {
            instruments.Add(musicalInstrument);
        }

        public async Task Edit(Instrumento musicalInstrument)
        {
            var index = instruments.FindIndex(m => m.Id == musicalInstrument.Id);

            if (index > -1)
            {
                instruments[index] = musicalInstrument;
            }
        }

        public async Task Remove(Guid id)
        {
            instruments.RemoveAll(instrument => instrument.Id == id);
        }

        public async Task<Instrumento> GetById(Guid Id)
        {
            return instruments.Single(m => m.Id == Id);
        }
    }
}

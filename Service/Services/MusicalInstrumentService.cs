using Domain.Models;
using Repository.Contracts;
using Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class MusicalInstrumentService : IMusicalInstrumentService
    {
        private readonly IMusicalInstrumentRepository musicalInstrumentRepository;

        public MusicalInstrumentService(IMusicalInstrumentRepository musicalInstrumentRepository)
        {
            this.musicalInstrumentRepository = musicalInstrumentRepository;
        }

        public async Task<List<MusicalInstrument>> GetAll()
        {
            return await musicalInstrumentRepository.GetAll();
        }

        public async Task Add(MusicalInstrument musicalInstrument)
        {
            await musicalInstrumentRepository.Add(musicalInstrument);
        }

        public Task Edit(MusicalInstrument musicalInstrument)
        {
            throw new NotImplementedException();
        }

        public Task Remove(int id)
        {
            throw new NotImplementedException();
        }
    }
}

using Domain.Models;
using Repository.Contracts;
using Service.Contracts;
using Service.Services.Validators;
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
            var validator = new MusicalInstrumentValidator(musicalInstrument);
         
            await musicalInstrumentRepository.Add(musicalInstrument);
        }

        public async Task Remove(Guid id)
        {
            await musicalInstrumentRepository.Remove(id);
        }

        public async Task Edit(MusicalInstrument musicalInstrument)
        {
            await musicalInstrumentRepository.Edit(musicalInstrument);
        }

        public async Task<MusicalInstrument> GetById(Guid Id)
        {
            return await musicalInstrumentRepository.GetById(Id);
        }
    }
}

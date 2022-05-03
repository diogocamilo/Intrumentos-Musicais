using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Contracts
{
    public interface IMusicalInstrumentRepository
    {
        Task<List<MusicalInstrument>> GetAll();
        Task<MusicalInstrument> GetId();
        Task Add(MusicalInstrument musicalInstrument);
        Task Edit(MusicalInstrument musicalInstrument);
        Task Remove(int id);
    }
}

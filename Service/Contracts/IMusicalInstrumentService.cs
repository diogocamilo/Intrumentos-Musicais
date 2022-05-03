using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Contracts
{
    public interface IMusicalInstrumentService
    {
        Task<List<MusicalInstrument>> GetAll();
        Task Add(MusicalInstrument musicalInstrument);
        Task Edit(MusicalInstrument musicalInstrument);
        Task Remove(int id);
    }
}

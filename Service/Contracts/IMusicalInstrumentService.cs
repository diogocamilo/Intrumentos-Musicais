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
        Task<List<Instrumento>> GetAll();
        Task<Instrumento> GetById(Guid Id);
        Task Add(Instrumento musicalInstrument);
        Task Edit(Instrumento musicalInstrument);
        Task Remove(Guid id);
    }
}

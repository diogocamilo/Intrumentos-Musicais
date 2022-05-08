using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class MusicalInstrument
    {
        public MusicalInstrument()
        {
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string informations { get; set; }
        public InstrumentType instrumentType { get; set; }
    }
}

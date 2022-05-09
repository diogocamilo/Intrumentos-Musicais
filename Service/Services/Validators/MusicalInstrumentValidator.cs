using Domain.Enums;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services.Validators
{
    public class MusicalInstrumentValidator
    {
        private ValidationResult validationResult;

        public MusicalInstrumentValidator(Instrumento candidate)
        {
            var validatorResult = Validate(candidate);

            if (!validatorResult.IsValid())
            {
                throw new ArgumentException(validatorResult.GetErrors());
            }
        }

        private ValidationResult Validate(Instrumento candidate)
        {
            validationResult = new ValidationResult();

            if (candidate == null)
            {
                validationResult.AddReason("Objeto 'MusicalInstrument' não declarado.");
            }
            if (string.IsNullOrWhiteSpace(candidate.Name))
            {
                validationResult.AddReason("Nome do instrumento musical não informado.");
            }
            if (string.IsNullOrWhiteSpace(candidate.Description))
            {
                validationResult.AddReason("Descrição do instrumento musical não informada.");
            }
            if (Enum.IsDefined(typeof(InstrumentEnum), candidate.instrumentType) == false)
            {
                validationResult.AddReason("Tipo de instrumento musical informado não disponível.");
            }

            return validationResult;
        }
    }
}

using Domain.Enums;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories.Daos
{
    internal static class MusicalInstrumentDAO
    {
        private static List<Instrumento> instruments;
                
        internal static void Initialize()
        {
            if(instruments == null) 
            {
                instruments = new List<Instrumento>();

                var instrument = new Instrumento();


                instruments.Add(new Instrumento()
                {
                    Id = Guid.NewGuid(),
                    Description = "Bateria Mapex Mars MA528SF GW Mapex",
                    Name = "Bateria Mapex Mars",
                    instrumentType = InstrumentEnum.Drums,
                    informations = "Mars Crossover – Shell Pack 5 peças (kit de tambores), Bumbo 22X18, Surdo de chão 14X12, Surdo de chão 16X14, Tom 12X8, e Caixa 14 x 6.5."
                });

                instruments.Add(new Instrumento()
                {
                    Id = Guid.NewGuid(),
                    Description = "Violão Flat Cutaway Nylon Gnf-3 Ceq Ws Giannini - Marrom (Walnut Satin) (WS)",
                    Name = "Violão Flat Cutaway Nylon",
                    instrumentType = InstrumentEnum.Guitar,
                    informations = "Violão Flat Cutaway Nylon - Tampo em Sapele, Faixa e fundo em Sapele, Escala em Rosewood, Tarraxas  Pino Grosso Dourada, 3+3 com botões plásticos pretos, Braço em Okoume. Equalizador 3 Bandas com afinador  cromático. Controles: Middle, Tuner, Treble, Bass, Phase e Volume. Acabamento: Verniz Fosco. Cor: Walnut Satin (WS) GNF-3 CEQ WS"
                });
            }
        }

        internal static List<Instrumento> GetAll()
        {
            return instruments;
        }
    }
}

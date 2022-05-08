using System;

namespace Domain.Models
{
    public class Percussao : TipoInstrumento
    {
        public override string Selecionar(int valor, string nomeProduto)
        {
            return FormatarSelecao();
        }
    }
}

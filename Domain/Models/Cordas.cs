using System;

namespace Domain.Models
{
    public class Cordas : TipoInstrumento
    {
        public override string Selecionar(int valor, string nomeProduto)
        {
            return FormatarSelecao();
        }
    }
}

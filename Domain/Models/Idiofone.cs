using System;

namespace Domain.Models
{
    public class Idiofone
    {
        public override string Selecionar(int valor, string nomeProduto)
        {
            return FormatarSelecao();
        }
    }
}

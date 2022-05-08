using System;

namespace Domain.Models
{
    public class Sopro
    {
        public override string Selecionar(int valor, string nomeProduto)
        {
            return FormatarSelecao();
        }
    }
}

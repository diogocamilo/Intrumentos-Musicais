using System;

namespace Domain.Models
{
    public abstract class TipoInstrumento
    {
        public string NomeProduto { get; set; }
        public abstract string NumeroProduto(int valor, string nomeProduto);

        public string FormatarSelecao()
        {
            const string chars = "ABCasDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            NumeroProduto = new string(Enumerable.Repeat(chars, 15)
              .Select(s => s[random.Next(s.Length)]).ToArray());

            return NomeProduto;
        }
    }
}

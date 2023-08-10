using FactoryMethod.Abstract;

namespace FactoryMethod.Models
{
    public class PessoaJuridica : IPessoa
    {
        public int Id { get; init; }
        public string Nome { get; set; } = default!;
        public int Idade { get; set; }
        public string NomeFantasia { get; set; } = default!;

        public void Respirar()
        {
            Console.WriteLine($"{Nome.Trim()} respirou em {NomeFantasia}");
        }
    }
}

using FactoryMethod.Abstract;

namespace FactoryMethod.Models
{
    public class PessoaFisica : IPessoa
    {
        public int Id { get; init; }
        public string Nome { get; set; } = default!;
        public int Idade { get; set; }
        public string Genero { get; set; } = default!;

        public void Respirar()
        {
            Console.WriteLine($"{Nome.Trim()} respirou tranquilamente");
        }
    }
}

using FactoryMethod.Abstract;
using FactoryMethod.Models;

namespace FactoryMethod.Repositories
{
    public class PessoaRepository
    {
        private List<IPessoa> Pessoas { get; init; } = new();

        public List<IPessoa> GetPessoas() => Pessoas;
        public List<PessoaFisica> GetPessoasFisica() => Pessoas.Where(p => p is PessoaFisica).Select(p => (PessoaFisica)p).ToList() ?? new();
        public List<PessoaJuridica> GetPessoasJuridica() => Pessoas.Where(p => p is PessoaJuridica).Select(p => (PessoaJuridica)p).ToList() ?? new();

        public void Add(IPessoa pessoa) => Pessoas.Add(pessoa);
        public void Delete(IPessoa pessoa) => Pessoas.Remove(pessoa);
    }
}

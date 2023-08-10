using FactoryMethod.Abstract;
using FactoryMethod.Models;
using FactoryMethod.Repositories;

namespace FactoryMethod.Services
{
    public class PessoaFisicaService : PessoaService
    {
        public PessoaFisicaService(PessoaRepository pessoaRepository) : base(pessoaRepository)
        {
        }

        public override IPessoa Create()
        {
            var id = GetRandomId();
            var pessoa = new PessoaFisica
            {
                Id = id,
                Idade = GetRandomAge(),
                Nome = GetRandomName(),
                Genero = id % 2 == 0 ? "Masculino" : "Feminino"
            };

            _pessoaRepository.Add(pessoa);
            return pessoa;
        }
    }
}

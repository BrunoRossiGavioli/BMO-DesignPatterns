using FactoryMethod.Repositories;

namespace FactoryMethod.Abstract
{
    public abstract class PessoaService
    {
        private readonly string[] Nomes = { "João Silva", "Maria Santos", "Pedro Oliveira", "Ana Pereira", "Carlos Almeida", "Sofia Rodrigues", "Fernando Costa", "Lúcia Fernandes", "Rafael Sousa", "Mariana Cardoso", "André Santos", "Beatriz Martins", "Gustavo Ferreira", "Laura Pereira", "Ricardo Gonçalves", "Catarina Lopes", "Diogo Barbosa", "Inês Ribeiro", "Miguel Carvalho", "Camila Vieira", "Tiago Mendes", "Isabel Silva", "Leonardo Santos", "Vitória Costa", "Hugo Rodrigues", "Eduarda Oliveira", "Luís Pereira", "Júlia Almeida", "Paulo Rocha", "Cláudia Sousa", "Alexandre Fernandes", "Carolina Neves", "Daniel Marques", "Sara Silva", "Eduardo Castro", "Ingrid Gomes", "Rui Barbosa", "Renata Andrade", "Nuno Martins", "Helena Ferreira" };
        protected readonly PessoaRepository _pessoaRepository;

        public PessoaService(PessoaRepository pessoaRepository)
        {
            _pessoaRepository = pessoaRepository;
        }

        public abstract IPessoa Create();

        protected string GetRandomName() => Nomes[Random.Shared.Next(0, Nomes.Length - 1)];
        protected int GetRandomAge() => Random.Shared.Next(0, 105);
        protected int GetRandomId() => Random.Shared.Next(10000, 99999);
    }
}

using FactoryMethod.Abstract;
using FactoryMethod.Models;
using FactoryMethod.Repositories;

namespace FactoryMethod.Services
{
    public class PessoaJuridicaService : PessoaService
    {
        private readonly string[] CommercialNames = { "TechSol", "InovaTech", "EcoGreen", "GlobalSys", "WebWave", "PrimeTech", "AgroTech", "DataCore", "SmartServe", "SwiftSync", "NexaSoft", "MegaCorp", "BrightByte", "ProGenius", "AlphaFusion", "Soluções360", "InfoTechNow", "WaveConnect", "SkylineSolutions", "InfiniteIdeas", "FutureEdge", "EcoVision", "PowerTech", "OptimaSys", "QuantumTech", "InnoWave", "NexTech", "PentaSoft", "EcoSolutions", "AlphaTech", "SmartInnovate", "TechVantage", "NovusSys", "DigitalFusion", "VisionaryTech", "AgileWave", "StratoSys", "WebGenius", "TruSync", "CloudHorizon" };

        public PessoaJuridicaService(PessoaRepository pessoaRepository) : base(pessoaRepository)
        {
        }

        public override IPessoa Create()
        {
            var pessoa = new PessoaJuridica
            {
                Id = GetRandomId(),
                Idade = GetRandomAge(),
                Nome = GetRandomName(),
                NomeFantasia = GetRandomCommercialName()
            };
            _pessoaRepository.Add(pessoa);
            return pessoa;
        }

        protected string GetRandomCommercialName() => CommercialNames[Random.Shared.Next(0, CommercialNames.Length - 1)];
    }
}

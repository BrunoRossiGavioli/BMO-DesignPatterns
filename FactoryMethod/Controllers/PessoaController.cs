using FactoryMethod.Abstract;
using FactoryMethod.Repositories;
using FactoryMethod.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FactoryMethod.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PessoaController : ControllerBase
    {
        private readonly PessoaRepository _pessoaRepository;

        public PessoaController(PessoaRepository pessoaRepository)
        {
            _pessoaRepository = pessoaRepository;
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var pessoas = _pessoaRepository.GetPessoas();

            if (pessoas.Count <= 0)
                return NotFound("Não há nenhuma pessoa cadastrada no momento");

            return Ok(pessoas);
        }

        [HttpGet("GetPessoasFisica")]
        public IActionResult GetPessoasFisica()
        {
            var pessoas = _pessoaRepository.GetPessoasFisica();

            if (pessoas.Count <= 0)
                return NotFound("Não há nenhuma pessoa física cadastrada no momento");

            return Ok(pessoas);
        }

        [HttpGet("GetPessoasJuridica")]
        public IActionResult GetPessoasJuridica()
        {
            var pessoas = _pessoaRepository.GetPessoasJuridica();

            if (pessoas.Count <= 0)
                return NotFound("Não há nenhuma pessoa jurídico cadastrada no momento");

            return Ok(pessoas);
        }

        [HttpPost("Create")]
        public IActionResult Create(bool pessoaFisica = true)
        {
            PessoaService service = pessoaFisica ? new PessoaFisicaService(_pessoaRepository) : new PessoaJuridicaService(_pessoaRepository);
            var pessoa = service.Create();
            return Ok(pessoa);
        }
    }
}

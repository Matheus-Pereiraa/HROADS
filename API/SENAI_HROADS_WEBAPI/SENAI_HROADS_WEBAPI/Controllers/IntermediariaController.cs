using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using senai_hroads_webAPI.Domains;
using senai_hroads_webAPI.Interfaces;
using senai_hroads_webAPI.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_hroads_webAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class IntermediariaController : ControllerBase
    {
        private IIntermediariaRepository _IntermediariaRepository { get; set; }

        public IntermediariaController()
        {
            _IntermediariaRepository = new ClasseHabilidadeRepository();
        }

        [HttpGet]
        public IActionResult Listar()
        {
            return Ok(_IntermediariaRepository.Listar());
        }

        [HttpGet("{idIntermediaria}")]
        public IActionResult BuscarPorId(int Intermediaria)
        {
            return Ok(_IntermediariaRepository.BuscarPorId(idIntermediaria));
        }

        [HttpPost]
        public IActionResult Cadastrar(Intermediaria Intermediaria)
        {
            _IntermediariaRepository.Cadastrar(Intermediaria);

            return StatusCode(201);
        }

        [HttpPut("{idIntermediaria}")]
        public IActionResult Atualizar(int idIntermediaria, intermediaria Intermediaria)
        {
            _IntermediriaRepository.AtualizarIdUrl(idIntermediaria, Intermediaria);

            return StatusCode(204);
        }

        [HttpDelete("{idIntermediaria}")]
        public IActionResult Deletar(int idIntermediaria)
        {
            _Intermediaria.Deletar(idIntermediaria);

            return StatusCode(204);
        }
    }
}
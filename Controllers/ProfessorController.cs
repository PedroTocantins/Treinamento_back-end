using Microsoft.AspNetCore.Mvc;
using SmartSchool_WebApi.Data;
using System;
using System.Threading.Tasks;
using SmartSchool_WebApi.Models;

namespace SmartSchool_WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProfessorController : ControllerBase
    {
        private readonly IRepository _repo;
        public ProfessorController(IRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]

        public async Task<IActionResult> get()
        {
            try
            {
                var result = await _repo.GetAllProfessoresAsync(true);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex.Message}");
            }
        }

        [HttpGet("{professorId}")]

        public async Task<IActionResult> get( int professorId)
        {
            try
            {
                var result = await _repo.GetProfessorAsyncById(professorId, true);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex.Message}");
            }
        }

        [HttpGet("ByAlunoId/{alunoId}")]
        public async Task<IActionResult> GetByDisciplinaId(int alunoId)
        {
            try
            {
                 var result = await _repo.GetProfessoresAsyncByAlunoId(alunoId, false);
                 return Ok(result);
            }
            catch (Exception ex)
            {
                
                return BadRequest($"Erro: {ex.Message}");
            }
        }

        [HttpPost]
        public async Task<IActionResult> Post(Professor model)
        {
            try
            {
                _repo.Add(model);

                if (await _repo.SaveChangesAsync())
                {
                    return Ok(model);
                }

            }
            catch (Exception ex)
            {
                
                return BadRequest($"Erro: {ex.Message}");
            }

            return BadRequest();
        }


        [HttpPut("{professorId}")]
        public async Task<IActionResult> put(int professorId, Professor model)
        {
            try
            {
                var professor = await _repo.GetProfessorAsyncById(professorId, false);
                if(professor == null) return NotFound();

                _repo.Update(model);

                if(await _repo.SaveChangesAsync())
                {
                    return Ok(model);
                }                
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex.Message}");
            }

            return BadRequest();
        }

        [HttpDelete("{professorId}")]
        public async Task<IActionResult> delete(int professorId)
        {
            try
            {
                var professor = await _repo.GetProfessorAsyncById(professorId, false);
                if(professor == null) return NotFound();

                _repo.Delete(professor);

                if(await _repo.SaveChangesAsync())
                {
                    return Ok("Deletado");
                }                
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex.Message}");
            }

            return BadRequest();
        }
    }
}
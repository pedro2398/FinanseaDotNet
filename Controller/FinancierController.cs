using FinanseaAPI.Model;
using FinanseaAPI.Service;
using Microsoft.AspNetCore.Mvc;

namespace FinanseaAPI.Controller
{
    [Route("/financier")]
    [ApiController]
    public class FinancierController : ControllerBase
    {
        private readonly FinancierService _service;

        public FinancierController(FinancierService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Financier>>> FindAll()
        {
            var list = await _service.FindAll();
            return Ok(list);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Financier>> FindById(long id)
        {
            try
            {
                var entity = await _service.FindById(id);
                return Ok(entity);
            }
            catch (KeyNotFoundException)
            {
                return NotFound();
            }
        }

        [HttpPost]
        public async Task<ActionResult<Financier>> Create([FromBody] Financier entity)
        {
            try
            {
                var created = await _service.Create(entity);
                return CreatedAtAction(nameof(FindById), new { id = created.id }, created);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Financier>> Update(long id, [FromBody] Financier updatedEntity)
        {
            try
            {
                var updated = await _service.Update(id, updatedEntity);
                return Ok(updated);
            }
            catch (KeyNotFoundException)
            {
                return NotFound();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(long id)
        {
            try
            {
                await _service.Delete(id);
                return NoContent();
            }
            catch (KeyNotFoundException)
            {
                return NotFound();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
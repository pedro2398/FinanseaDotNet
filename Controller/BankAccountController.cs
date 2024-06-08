using FinanseaAPI.Model;
using FinanseaAPI.Service;
using Microsoft.AspNetCore.Mvc;

namespace FinanseaAPI.Controller
{
    [Route("/bank_account")]
    [ApiController]
    public class BankAccountController : ControllerBase
    {
        private readonly BankAccountService _service;

        public BankAccountController(BankAccountService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<BankAccount>>> FindAll()
        {
            var list = await _service.FindAll();
            return Ok(list);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<BankAccount>> FindById(long id)
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
        public async Task<ActionResult<BankAccount>> Create([FromBody] BankAccount entity)
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
        public async Task<ActionResult<BankAccount>> Update(long id, [FromBody] BankAccount updatedEntity)
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
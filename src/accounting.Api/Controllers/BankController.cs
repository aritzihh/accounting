using accounting.Dto.Response;
using Accounting.Entities;
using Accounting.Repositories.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Accounting.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BankController : ControllerBase
    {

        private readonly IBankRepository repository;
        private readonly ILogger<BankController> logger;

        public BankController(IBankRepository repository, ILogger<BankController> logger)
        {
            this.repository = repository;
            this.logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var response = new BaseResponseGeneric<ICollection<Bank>>();

            try
            {
                response.Data = await repository.GetAsync();
                response.Success = true;
                logger.LogInformation($"Obteniendo todos los bancos.");
                return Ok(response);

            }
            catch (Exception ex)
            {
                response.ErrorMessage = "Error al obtener la información.";
                logger.LogError(ex, $"{response.ErrorMessage} {ex.Message}");
                return BadRequest(response);
            }
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> Get(int id)
        {
            var bank = await repository.GetByIdAsync(id);
            if (bank is null) return NotFound();
            return Ok(bank);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Bank model)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var newId = await repository.AddAsync(model);
            var created = await repository.GetByIdAsync(newId);

            return CreatedAtAction(nameof(Get), new { id = newId }, created);
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> Put(int id, [FromBody] Bank model)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            if (model.Id != id) return BadRequest("Id mismatch.");

            var existing = await repository.GetByIdAsync(id);
            if (existing is null) return NotFound();

            await repository.UpdateAsync(existing);
            return NoContent();
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            var existing = await repository.GetByIdAsync(id);
            if (existing is null) return NotFound();

            await repository.DeleteAsync(id);
            return NoContent();
        }

    }
}

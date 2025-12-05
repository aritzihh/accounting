using accounting.Dto.Response;
using Accounting.Dto.Request;
using Accounting.Dto.Response;
using Accounting.Entities;
using Accounting.Repositories.Interfaces;
using Accounting.Services.Interfaces;
using Azure.Core;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Accounting.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BankController : ControllerBase
    {

        private readonly IBankService service;

        public BankController(IBankService service)
        {
            this.service = service;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var response = await service.GetAsync();
            return Ok(response);
        }


        [HttpGet("{id:int}")]
        public async Task<IActionResult> Get(int id)
        {
            var response = await service.GetAsync(id);
            return response.Success ? Ok(response) : NotFound(response);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromForm]BankRequestDto request)
        {
            var response = await service.AddAsync(request);
            return response.Success ? Ok(response) : BadRequest(response);
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> Put(int id, [FromForm]BankRequestDto request)
        {
            var response = await service.UpdateAsync(id, request);
            return response.Success ? Ok(response) : BadRequest(response);

        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            var response = await service.DeleteAsync(id);
            return Ok(response);
        }
    }
}

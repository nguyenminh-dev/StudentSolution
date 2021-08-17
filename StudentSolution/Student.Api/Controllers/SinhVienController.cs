using Microsoft.AspNetCore.Mvc;
using Student.Application.MSinhVien;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Student.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SinhVienController : ControllerBase
    {
        private readonly ISinhVienService _sinhVienService;
        public SinhVienController(ISinhVienService sinhVienService)
        {
            _sinhVienService = sinhVienService;
        }

        // GET: api/<SinhVienController>
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return Ok(await _sinhVienService.GetAll());
        }
        [HttpPost("Create")]
        public async Task<IActionResult> Create([FromBody] SinhVienDto request)
        {
            var status = await _sinhVienService.Create(request);
            return Ok(status);
        }
        [HttpPost("Update")]
        public async Task<IActionResult> Update([FromBody] SinhVienDto request)
        {
            var status = await _sinhVienService.Update(request);
            return Ok(status);
        }
        [HttpPost("Delete")]
        public async Task<IActionResult> Delete([FromBody] SinhVienDto request)
        {
            var status = await _sinhVienService.Delete(request);
            return Ok(status);
        }

    }
}

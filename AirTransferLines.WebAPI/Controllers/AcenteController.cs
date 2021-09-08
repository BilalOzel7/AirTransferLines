using AirTransferLines.Business.Abstract;
using AirTransferLines.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AirTransferLines.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AcenteController : ControllerBase
    {
        IAcenteService _acenteService;

        public AcenteController(IAcenteService acenteService)
        {
            _acenteService = acenteService;
        }

        [HttpGet("getall")]

        public IActionResult Get()
        {
            

            var result = _acenteService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpGet("getbyıd")]

        public IActionResult GetById(int id)
        {
            var result = _acenteService.GetByID(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Acente acente)
        {

            var result = _acenteService.Add(acente);
            var a = result;
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
            [HttpPost("update")]
            public IActionResult Update(Acente acente)
            {

                var result = _acenteService.Add(acente);
                var a = result;
                if (result.Success)
                {
                    return Ok(result);
                }
                return BadRequest(result);
            }

        [HttpPost("delete")]
        public IActionResult Delete(Acente acente)
        {

            var result = _acenteService.Add(acente);
            var a = result;
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}

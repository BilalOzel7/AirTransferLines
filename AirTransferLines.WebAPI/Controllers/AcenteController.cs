using AirTransferLines.Business.Abstract;
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
    }
}

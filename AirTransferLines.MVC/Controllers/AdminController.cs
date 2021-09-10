using AirTransferLines.Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AirTransferLines.MVC.Controllers
{
    public class AdminController : Controller
    {
        IAcenteService _acenteService;

        public AdminController(IAcenteService acenteService)
        {
            _acenteService = acenteService;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AcenteList()
        {

            return View(_acenteService.GetAcenteDetails());
        }
    }
}

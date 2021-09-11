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
        IRezervasyonService _rezervasyonService;
        ITransferService _transferService;
        ISurucuService _surucuService;
        IUyeService _uyeService;

        public AdminController(IAcenteService acenteService,IRezervasyonService rezervasyonService,
            ITransferService transferService,ISurucuService surucuService,IUyeService uyeService)
        {
            _acenteService = acenteService;
            _rezervasyonService = rezervasyonService;
            _transferService = transferService;
            _surucuService = surucuService;
            _uyeService = uyeService;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AcenteList()
        {

            return View(_acenteService.GetAcenteDetails());
        }

        public IActionResult RezervasyonList()
        {

            return View(_rezervasyonService.GetRezervasyonDetails());
        }
        public IActionResult TransferList()
        {

            return View(_transferService.GetTransferDetails());
        }

        public IActionResult SurucuList()
        {

            return View(_surucuService.GetSurucuDetails());
        }
        public IActionResult UyeList()
        {

            return View(_uyeService.GetUyeDetails());
        }
    }
}

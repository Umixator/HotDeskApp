using HotDeskApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using HotDeskApp.Services;
using HotDeskApp.Repo;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace HotDeskApp.Controllers
{
    public class DeskController : Controller
    {
        private readonly HotDeskDbContext _db;
        private readonly LoginModel log;
        private readonly DeskViewService _service;
        private readonly UserService _user;

        public DeskController(HotDeskDbContext db, DeskViewService dv)
        {
            _db = db;
            _service = dv;
        }
        [Authorize(Roles = "admin, user")]
        public IActionResult Index()
        {
            IndexViewModel mymodel = new();
            mymodel.Desks = _service.GetDeskList();
            mymodel.Devices = _service.GetDeviceList();
            return View(mymodel);
        }

        public IActionResult UserDesk()
        {
            IndexViewModel mymodel = new();
            mymodel.Desks = _service.GetDeskList();
            mymodel.Devices = _service.GetDeviceList();
            return View(mymodel);
        }

        public IActionResult Admin()
        {
                return View();
        }

    [HttpPost]
        public IActionResult Admin(IndexViewModel obj)
        {
            _service.CreateDesk(obj.NewDesk);
            return RedirectToAction("Index");
        }

    [HttpGet]
        public IActionResult Delete(int Id)
        {
            _service.DeleteDesk(Id);
            return RedirectToAction("Index");
        }

        public IActionResult UpdateGet(int Id)
        {
            return View(_service.FindDesk(Id));
        }

    [HttpPost]
        public IActionResult Update(int Id, Desk obj)
        {
            _service.UpdateDesk(obj);
            return RedirectToAction("Index");
        }
    }
}

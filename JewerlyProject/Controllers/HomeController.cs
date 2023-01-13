using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using JewerlyProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace JewerlyProject.Controllers
{
    public class HomeController : Controller
    {
        HomeManager hm = new HomeManager(new EfHomeRepository());

        public IActionResult Index()
        {
            var values = hm.TGetList();
            return View(values);
        }
    }
}

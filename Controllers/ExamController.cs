using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using KnowItAlls.Models;

namespace KnowItAlls.Controllers
{
    public class ExamController : Controller
    {
        private readonly AppDbContext _abd;

        public ExamController(AppDbContext abd)
        {
            _abd = abd;
        }
        public IActionResult Index()
        {
            var results = _abd.onlineexam.ToList();
            return View(results);
        }
    }
}

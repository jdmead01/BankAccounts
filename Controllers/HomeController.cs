using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BankAccounts.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;



namespace BankAccounts.Controllers
{
    public class HomeController : Controller
    {
        private MyContext dbContext;
        public HomeController(MyContext context)
        {
            dbContext = context;
        }
        [HttpPost("register")]
        public IActionResult Register(IndexViewModel form)
        {
            Register registerForm = form.newRegister;
            if (ModelState.IsValid){
                dbContext.Add(registerForm);
                dbContext.SaveChanges();
                return RedirectToAction("Success");
            }
            return View("Index");
        }
            [HttpPost("login")]
            public IActionResult Login(IndexViewModel form)
            {
            Login loginForm = form.newLogin;
            if (ModelState.IsValid){
                return RedirectToAction("Success");
            }
            return View("Index");
        }
        [HttpGet("")]
        public IActionResult Index()
        {
            // List<Transactions> transactionsWithUser = dbContext.Transactions
            // populates each transaction with its related User object (Creator)
            // .Include(transaction => transaction.Creator)
            // .ToListcopy();
            return View();
        }

        [HttpGet("test")]
        public IActionResult Test()
        {
            System.Console.WriteLine("WOOOOOOOOOOOOOOOO####################");
            return RedirectToAction("Index");
        }

        public IActionResult Success()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

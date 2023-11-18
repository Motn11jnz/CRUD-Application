
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Task2_CRUDApp.Data;
using Task2_CRUDApp.Models;

namespace Task2_CRUDApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly Task2_CRUDAppContext _context;

        public HomeController(Task2_CRUDAppContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return _context.Product != null ?
                          View(await _context.Product.ToListAsync()) :
                          Problem("Entity set 'Task2_CRUDAppContext.Product'  is null.");
            
        }

       
    }
}
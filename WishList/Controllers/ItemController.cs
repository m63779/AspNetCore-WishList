using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WishList.Data;

namespace WishList.Controllers
{
    public class ItemController : Controller
    {
        

        private readonly ApplicationDbContext _context { get; set; }

        public ItemController(ApplicationDbContext applicationDbContext) {
            _context = applicationDbContext;
        }

        public IActionResult Index()
        {
            return View(List<_context.Items>);
        }
    }
}

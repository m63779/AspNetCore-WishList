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
        public IActionResult Index()
        {
            return View();
        }

        private ApplicationDbContext Context { get; set; }

        public ItemController(ApplicationDbContext applicationDbContext) {
            Context = applicationDbContext;
        }
    }
}

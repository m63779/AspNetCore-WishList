using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WishList.Models;

namespace WishList.Data
{
    public class ApplicationDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public ApplicationDbContext( Microsoft.EntityFrameworkCore.DbContextOptions options) : base(options)
        { }
    }
}

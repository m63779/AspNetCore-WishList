using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WishList.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Description { get; set; }
        [Required, MaxLength(50)]
    }
}

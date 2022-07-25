using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ZigWheels.Models
{
    public class CarShop
    {
        [Key]
        public int CarShopId { get; set; }
        public string CarShopName { get; set; }
        public string Country { get; set; }
        public string Address { get; set; }
    }
}

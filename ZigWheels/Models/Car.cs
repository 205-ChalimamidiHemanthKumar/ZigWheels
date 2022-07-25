using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ZigWheels.Models
{
    public class Car
    {
        [Key]
        public int CarId { get; set; }
        public string CarName { get; set; }
        public Decimal Price { get; set; }
        public string CarModel { get; set; }
        public ICollection<CarShop> CarShopId { get; set; }
    }
}

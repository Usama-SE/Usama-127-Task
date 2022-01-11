using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Usama_127_Task.Models
{
    public class OrderModel
    {
        [Key]
        public int id { get; set; }

        [Required]
        public string name { get; set; }

        [Required]
        public int description_quantity { get; set; }

        [Required]
        public int item_price { get; set;}
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using static ItemManagementSystem.Models.Enums;

namespace ItemManagementSystem.Models
{
    public class Item
    {
        [Key]
        public int Code { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
    }
}

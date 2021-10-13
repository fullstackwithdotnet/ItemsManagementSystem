using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ItemManagementSystem.Models
{
    public class ItemsViewModel
    {
       
        public int Code { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public List<SelectListItem> Categories { get; set; }
    }
}

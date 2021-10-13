using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ItemManagementSystem.Models
{
    public class UploadModel
    {
        public IFormFile File { get; set; }
    }
}

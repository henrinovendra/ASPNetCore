using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetCore.Models
{
    public class Employe
    {
        [Key]
        public int id { get; set; }
        public string nama { get; set; }
        public string email { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UserApi.Models
{
    public class User
    {
        public long Id { get; set; }
        [Required]
        [MinLength(2)]
        public string Name { get; set; }
        [Range(18, 90)]
        public int Age { get; set; }
        [Required]
        public string Address { get; set; }
        public bool Active { get; set; }
        

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Snake.Models
{
    public class PlayerViewModel
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 10, ErrorMessage = "Длина строки должна быть от 10 до 100 символов")]
        public string Description { get; set; }
    }
}

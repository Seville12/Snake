using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Snake.Models
{
    public class Player
    {
        public int Id { get; set; }
        [Required]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Длина строки должна быть от 3 до 20 символов")]
        public string Name { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 10, ErrorMessage = "Длина строки должна быть от 10 до 100 символов")]
        public string Description { get; set; }
    }
}

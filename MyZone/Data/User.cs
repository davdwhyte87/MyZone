using System;
using System.ComponentModel.DataAnnotations;

namespace MyZone.Data
{
    public class User
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        public string Image { get; set; }
        public string Bio { get; set; }
        public string Location { get; set; }
    }
}

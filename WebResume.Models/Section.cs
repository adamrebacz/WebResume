using System;
using System.ComponentModel.DataAnnotations;

namespace WebResume.Models
{
    public class Section
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public bool Visible { get; set; }
    }
}

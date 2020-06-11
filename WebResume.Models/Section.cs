using System;
using System.Collections.Generic;
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
        public SectionDescription sectionDescription { get; set; }
        public IEnumerable<DateItem> dateTimes { get; set; }
        public IEnumerable<StringItem> stringTimes { get; set; }
    }
}

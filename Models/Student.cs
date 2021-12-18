using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorUAS.Models
{
    public class Student
    {
        public string StudentId { get; set; }

        [Required(ErrorMessage ="First Name is required")]
        [StringLength(100,MinimumLength =2)]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
    }
}
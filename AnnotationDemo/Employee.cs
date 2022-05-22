using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnotationDemo
{
    public class Employee
    {
        [Required(ErrorMessage = "Employee {0} is Required")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Name Should be above 3 Char")]
        [DataType(DataType.Text)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email should be Required")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Range(18, 99, ErrorMessage = "Age Should Be Above 18")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Mobile should be Required")]
        [DataType(DataType.PhoneNumber)]
        public long MobileNumber { get; set; }
    }
}

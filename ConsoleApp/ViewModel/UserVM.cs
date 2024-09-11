using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_API.ViewModel
{
    internal class UserVM
    {
        [Required]
        [MaxLength(100)]
        public string FName { get; set; }

        [Required]
        [MaxLength(100)]
        public string LName { get; set; } = string.Empty;

        [Required]
        [MaxLength(100)]
        [RegularExpression(@"^((?!\.)[\w-_.]*[^.])(@\w+)(\.\w+(\.\w+)?[^.\W]{1,})$")]
        public string Email { get; set; } = string.Empty;

        [Required]
        [MaxLength(50)]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[\W_]).{8,}$")]
        public string Password { get; set; } = string.Empty;

        public string FullName => $"{FName} {LName}";
    }
}

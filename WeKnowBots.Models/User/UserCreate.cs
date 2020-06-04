using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeKnowBots.Models
{
    public class UserCreate
    {
        public int OwnerId { get; set; }

        [MinLength(6, ErrorMessage = "Longer Username required")]
        public string UserName { get; set; }

        [MinLength(2, ErrorMessage = "First name must be longer.")]
        [MaxLength(20, ErrorMessage = "First name must be shorter.")]
        public string FirstName { get; set; }

        [MinLength(2, ErrorMessage = "Last name must be longer.")]
        [MaxLength(20, ErrorMessage = "Last name must be shorter.")]
        public string LastName { get; set; }

        [Required]
        public string Email { get; set; }
    }
}

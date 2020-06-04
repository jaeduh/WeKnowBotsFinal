using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeKnowBots.Data;

namespace WeKnowBots.Models
{
    public class BotCreate
    {
        [Display(Name = "Bot Id")]
        public int BotId { get; set; }

        [Required]
        [MinLength(6, ErrorMessage = "Please Enter at least 6 characters.")]
        [MaxLength(100, ErrorMessage = "Bot name too long, please shorten then continue")]
        public string BotName { get; set; }

        public BotType TypeOfBot { get; set; }

        [MinLength(8, ErrorMessage = "Please enter the date in format of 'XX/XX/XX'.")]
        public string DateBotUsed { get; set; }
    }
}

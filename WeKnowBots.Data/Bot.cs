using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeKnowBots.Data
{
    public enum BotType { MultiEntry = 1, IncreasePurchaseQuantity, SkipLine }
    public class Bot
    {
        [Key]
        [Display(Name = "Bot ID")]
        public int BotId { get; set; }

        [Required]
        public Guid OwnerId { get; set; }

        [Required]
        [Display(Name = "Name of Bot")]
        public string BotName { get; set; }

        [Required]
        [Display(Name = "Type of Bot")]
        public BotType TypeOfBot { get; set; }

        [Required]
        [Display(Name = "Date Bot Used")]
        public string DateBotUsed { get; set; }


    }
}

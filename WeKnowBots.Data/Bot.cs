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
        public int BotId { get; set; }

        [Required]
        public Guid OwnerId { get; set; }

        [Required]
        public string BotName { get; set; }

        [Required]
        public BotType TypeOfBot { get; set; }

        [Required]
        public DateTimeOffset CreatedUtc { get; set; }


    }
}

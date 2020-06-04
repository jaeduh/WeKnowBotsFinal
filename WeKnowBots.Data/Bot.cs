using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeKnowBots.Data
{
    public class Bot
    {
        [Key]
        public int BotId { get; set; }

        [Required]
        public Guid OwnerId { get; set; }

        [Required]
        public string BotName { get; set; }

        [Required]
        public DateTimeOffset CreatedUtc { get; set; }


    }
}

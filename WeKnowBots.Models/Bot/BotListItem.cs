using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeKnowBots.Data;

namespace WeKnowBots.Models
{
    public class BotListItem
    {
        public int BotId { get; set; }

        [Display(Name = "Bot Name")]
        public string BotName { get; set; }

        [Display(Name = "Date Bot Used")]
        public string DateBotUsed { get; set; }
        public BotType TypeOfBot { get; set; }
    }
}

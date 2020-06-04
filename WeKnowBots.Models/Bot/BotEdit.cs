using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeKnowBots.Data;

namespace WeKnowBots.Models
{
    public class BotEdit
    {
        public int BotId { get; set; }

        public Guid OwnerId { get; set; }

        public string BotName { get; set; }

        public BotType TypeOfBot { get; set; }

        public string DateBotUsed { get; set; }
    }
}

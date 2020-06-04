using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeKnowBots.Data;
using WeKnowBots.Models;

namespace WeKnowBots.Services
{
    public class BotServices
    {
        private readonly Guid _userId;

        public BotServices(Guid userId)
        {
            _userId = userId;
        }

        public bool CreateBot(BotCreate model)
        {
            var entity = new Bot()
            {
                BotId = model.BotId,
                BotName = model.BotName,
                TypeOfBot = model.TypeOfBot,
                DateBotUsed = model.DateBotUsed
            };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Bots.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<BotListItem> GetAllBotss()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                        .Bots
                        .Where(e => e.BotId == e.BotId)
                        .Select(
                            e =>
                                new BotListItem
                                {
                                    BotId = e.BotId,
                                    BotName = e.BotName,
                                    DateBotUsed = e.DateBotUsed,
                                    TypeOfBot = e.TypeOfBot,
                                }
                        );

                return query.ToArray();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeKnowBots.Data;
using WeKnowBots.Models;

namespace WeKnowBots.Services
{
    public class UserServices
    {
        private readonly Guid _userId;

        public UserServices(Guid userId)
        {
            _userId = userId;
        }

        public bool CreateUser(UserCreate model)
        {
            var entity =
                new User()
                {
                    OwnerId = model.OwnerId,
                    UserName = model.UserName,
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Email = model.Email
                };
            using (var ctx = new ApplicationDbContext())
            {
                ctx.Users.Add(entity);

                return ctx.SaveChanges() == 1;
            }
        }
    }
}

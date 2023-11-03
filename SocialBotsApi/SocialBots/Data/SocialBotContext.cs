using Microsoft.EntityFrameworkCore;
using SocialBots.Models;

namespace SocialBots.Data
{
    public class SocialBotContext : DbContext
    {
        public SocialBotContext(DbContextOptions<SocialBotContext> options) : base(options)
        {
            
        }

        public DbSet<User> Users { get; set; }
    }
}

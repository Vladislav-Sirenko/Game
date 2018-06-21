using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;

namespace DAL
{
    public class GameContext : DbContext
    {
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<PlatformType> PlatformTypes { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        static GameContext()
        {
            Database.SetInitializer<GameContext>(new StoreDbInitializer());
        }
        public GameContext()
            : base("GameConnection")
        {
        }
    }

    public class StoreDbInitializer : DropCreateDatabaseIfModelChanges<GameContext>
    {
        protected override void Seed(GameContext db)
        {
            db.Games.Add(new Game { Name = "Dota 2", Description = "Defence of the Ancients" });
            db.SaveChanges();
        }
    }
}


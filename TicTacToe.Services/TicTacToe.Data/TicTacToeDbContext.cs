namespace TicTacToe.Data
{
    using System.Data.Entity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using TicTacToe.Common;
    using TicTacToe.Data.Contracts;
    using TicTacToe.Data.Migrations;
    using TicTacToe.Models;

    public class TicTacToeDbContext : IdentityDbContext<User>, ITicTacToeDbContext
    {
        public TicTacToeDbContext()
            : base("Server=59fa39e2-6cd6-426a-baee-a3b400cfe53b.sqlserver.sequelizer.com;Database=db59fa39e26cd6426abaeea3b400cfe53b;User ID=whysallhzndsicmm;Password=25qETCyFa2XR6a2ANckxJNznX2GaxZkCfXJNwYKy2ARhLSu6MPer4e4nDdQ24xih;", throwIfV1Schema: false)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<TicTacToeDbContext, Configuration>());
        }

        public IDbSet<Game> Games { get; set; }

        public IDbSet<Score> Scores { get; set; }

        public static TicTacToeDbContext Create()
        {
            return new TicTacToeDbContext();
        }

        public IDbSet<T> Set<T>() where T : class
        {
            return base.Set<T>();
        }

        public void SaveChanges()
        {
            base.SaveChanges();
        }
    }
}
using BusinessLogic.DatabaseModels;
using Microsoft.EntityFrameworkCore;

namespace BusinessLogic
{
    public class Database : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured == false)
            {
                optionsBuilder.UseSqlServer(@"Data Source=VIKA\SQLEXPRESS;Initial Catalog=COP;Integrated Security=True;MultipleActiveResultSets=True;");
            }
            base.OnConfiguring(optionsBuilder);
        }

        public virtual DbSet<StudentDatabaseModel> StudentsDatabaseModel { set; get; }
    }
}

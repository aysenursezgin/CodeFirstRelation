using CodeFirstRelation.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstRelation.Data.Context
{
    public class PatikaSecondDbContext : DbContext
    {

        public PatikaSecondDbContext(DbContextOptions<PatikaSecondDbContext>options) : base(options)
        {
            
        }







        public DbSet<UserEntity> Users => Set<UserEntity>();
        public DbSet<PostEntity> Posts => Set<PostEntity>();
    }
}

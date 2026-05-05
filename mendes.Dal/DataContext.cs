using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using mendes.Domain.Aggregates.PostAggregate;
using mendes.Domain.Aggregates.UserProfileAggregate;
using mendes.Dal.Configuration;


namespace mendes.Dal
{
    public class DataContext : IdentityDbContext
    {
        // Use DbContextOptions<DataContext> para eliminar ambiguidade ao configurar o contexto
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {   
        }

        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<Post> Posts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PostCommentConfig());
            modelBuilder.ApplyConfiguration(new PostInteractionConfig());
            modelBuilder.ApplyConfiguration(new UserProfileConfig());
            modelBuilder.ApplyConfiguration(new IdentityUserLoginConfig());
            modelBuilder.ApplyConfiguration(new IdentityUserRoleConfig());
            modelBuilder.ApplyConfiguration(new IdentityUserTokenConfig());

        }
    }
}

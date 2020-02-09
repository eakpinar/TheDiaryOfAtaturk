using Microsoft.EntityFrameworkCore;
namespace DoAtaApi.Models{
    public class DoAtaContext: DbContext{
        public DoAtaContext(DbContextOptions<DoAtaContext> options)
        :base(options)
        {
        }
        public DbSet<DoAtaItem> DoAtaItems { get; set; }
        public DbSet<Type> Types { get; set; }
    }
    
}
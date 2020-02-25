using Microsoft.EntityFrameworkCore;
using TalentApp.API.Models;

namespace TalentApp.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options){}
    
        public DbSet<Value> Values {get; set;}
    }
}
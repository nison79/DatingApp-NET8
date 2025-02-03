using Microsoft.EntityFrameworkCore;
using API.Entities;

namespace API.Data;

public class DataContext(DbContextOptions options): DbContext(options)
{
   public DbSet<AppUser> Users {get; set;}
  
}

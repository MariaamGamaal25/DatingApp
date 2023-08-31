using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<AppUser> Users { get; set; } //talamat samena elproperty de Users yb2a da lazem ykon esm eltable f eldb
}                                             //<AppUser>:ma3mola belshakl da 3shan felclass da hykon feh el columns

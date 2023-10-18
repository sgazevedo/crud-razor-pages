using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OnlineCoursePlatform.Web.Models;

namespace OnlineCoursePlatform.Web.Data;

public class ApplicationDbContext : IdentityDbContext
{
  public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
      : base(options)
  {
  }

  public DbSet<Student> Students { get; set; } = default!;
  public DbSet<Subscription> Subscriptions { get; set; } = default!;

}

using Microsoft.EntityFrameworkCore;

public class TodoDbContext : DbContext{
    public TodoDbContext(DbContextOptions<TodoDbContext> options) : base(options) { }

    public DbSet<TodoItem> TodoItems{ get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder){
        modelBuilder.Entity<TodoItem>()
            .Property(b => b.IsCompleted)
            .HasDefaultValue(false); // Set default value for IsCompleted

    }
}
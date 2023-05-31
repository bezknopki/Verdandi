using Microsoft.EntityFrameworkCore;
using Verdandi.Models;

namespace DataAccess
{
    public class DataContext : DbContext
    {
        public DbSet<TaskModel> Tasks { get; set; }
    }
}
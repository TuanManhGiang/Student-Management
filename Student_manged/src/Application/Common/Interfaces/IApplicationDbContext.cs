using Microsoft.EntityFrameworkCore;
using Student_manged.Domain.Entities;

namespace Student_manged.Application.Common.Interfaces;
public interface IApplicationDbContext
{
    DbSet<TodoList> TodoLists { get; }

    DbSet<TodoItem> TodoItems { get; }
    DbSet<Student> Students { get; }    

    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}

using Student_manged.Application.TodoLists.Queries.ExportTodos;

namespace Student_manged.Application.Common.Interfaces;
public interface ICsvFileBuilder
{
    byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
}

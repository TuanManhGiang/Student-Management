using System.Globalization;
using CsvHelper.Configuration;
using Student_manged.Application.TodoLists.Queries.ExportTodos;

namespace Student_manged.Infrastructure.Files.Maps;
public class TodoItemRecordMap : ClassMap<TodoItemRecord>
{
    public TodoItemRecordMap()
    {
        AutoMap(CultureInfo.InvariantCulture);

        Map(m => m.Done).Convert(c => c.Value.Done ? "Yes" : "No");
    }
}

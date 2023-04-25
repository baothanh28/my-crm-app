using CRM.Application.TodoLists.Queries.ExportTodos;

namespace CRM.Application.Common.Interfaces;

public interface ICsvFileBuilder
{
    byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
}

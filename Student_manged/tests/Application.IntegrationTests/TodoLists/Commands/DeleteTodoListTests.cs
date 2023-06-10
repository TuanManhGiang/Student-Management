using FluentAssertions;
using NUnit.Framework;
using Student_manged.Application.Common.Exceptions;
using Student_manged.Application.TodoLists.Commands.CreateTodoList;
using Student_manged.Application.TodoLists.Commands.DeleteTodoList;
using Student_manged.Domain.Entities;

using static Testing;

namespace Student_manged.Application.IntegrationTests.TodoLists.Commands;
public class DeleteTodoListTests : BaseTestFixture
{
    [Test]
    public async Task ShouldRequireValidTodoListId()
    {
        var command = new DeleteTodoListCommand(99);
        await FluentActions.Invoking(() => SendAsync(command)).Should().ThrowAsync<NotFoundException>();
    }

    [Test]
    public async Task ShouldDeleteTodoList()
    {
        var listId = await SendAsync(new CreateTodoListCommand
        {
            Title = "New List"
        });

        await SendAsync(new DeleteTodoListCommand(listId));

        var list = await FindAsync<TodoList>(listId);

        list.Should().BeNull();
    }
}

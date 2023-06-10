using MediatR;
using Microsoft.Extensions.Logging;
using Student_manged.Domain.Events;

namespace Student_manged.Application.TodoItems.EventHandlers;
public class TodoItemCreatedEventHandler : INotificationHandler<TodoItemCreatedEvent>
{
    private readonly ILogger<TodoItemCreatedEventHandler> _logger;

    public TodoItemCreatedEventHandler(ILogger<TodoItemCreatedEventHandler> logger)
    {
        _logger = logger;
    }

    public Task Handle(TodoItemCreatedEvent notification, CancellationToken cancellationToken)
    {
        _logger.LogInformation("Student_manged Domain Event: {DomainEvent}", notification.GetType().Name);

        return Task.CompletedTask;
    }
}

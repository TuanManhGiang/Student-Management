using MediatR;
using Microsoft.Extensions.Logging;
using Student_manged.Domain.Events;

namespace Student_manged.Application.TodoItems.EventHandlers;
public class TodoItemCompletedEventHandler : INotificationHandler<TodoItemCompletedEvent>
{
    private readonly ILogger<TodoItemCompletedEventHandler> _logger;

    public TodoItemCompletedEventHandler(ILogger<TodoItemCompletedEventHandler> logger)
    {
        _logger = logger;
    }

    public Task Handle(TodoItemCompletedEvent notification, CancellationToken cancellationToken)
    {
        _logger.LogInformation("Student_manged Domain Event: {DomainEvent}", notification.GetType().Name);

        return Task.CompletedTask;
    }
}

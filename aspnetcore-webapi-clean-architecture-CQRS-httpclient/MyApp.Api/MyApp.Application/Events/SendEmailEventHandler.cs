using MediatR;
using Microsoft.Extensions.Logging;
namespace MyApp.Application.Events;

public class SendEmailEventHandler
    (ILogger<SendEmailEventHandler> logger)  // New way to write the constructor.
    : INotificationHandler<UserCreatedEvent>
{
    public async Task Handle(UserCreatedEvent notification, CancellationToken cancellationToken)
    {
        logger.LogInformation("User created: Send mail start {UserId}", notification.userId);

        await Task.Delay(2000, cancellationToken);

        logger.LogInformation("User created: Send mail done {UserId}", notification.userId);
    }
}

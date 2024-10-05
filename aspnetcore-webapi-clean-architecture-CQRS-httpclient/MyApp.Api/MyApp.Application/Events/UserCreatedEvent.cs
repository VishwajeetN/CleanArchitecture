using MediatR;

namespace MyApp.Application.Events;

public record UserCreatedEvent(Guid userId) : INotification;

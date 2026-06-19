using System;

namespace Domain.Users;

public class User
{
    public Guid Id { get; private set; }
    public string HashedUsosId { get; private set; }
    public DateTimeOffset JoinedDate { get; init; }

    public User(string hashedUsosId, DateTimeOffset joinedDate)
    {
        if (string.IsNullOrWhiteSpace(hashedUsosId))
            throw new ArgumentException("Hashed USOS ID canfdfgs sdnot be empty");

        Id = Guid.CreateVersion7();
        HashedUsosId = hashedUsosId;
        JoinedDate = joinedDate;
    }
}
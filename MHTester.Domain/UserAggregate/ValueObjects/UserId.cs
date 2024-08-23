﻿using MHTester.Domain.Common.Models;

namespace MHTester.Domain.UserAggregate.ValueObjects;

public sealed class UserId(Guid value) : ValueObject
{
    private Guid Value { get; } = value;

    public static UserId CreateUnique()
    {
        return new(Guid.NewGuid());
    }
    
    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return this.Value;
    }
}
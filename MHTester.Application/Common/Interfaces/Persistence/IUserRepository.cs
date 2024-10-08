﻿using MHTester.Domain.Entities;

namespace MHTester.Application.Common.Interfaces.Persistence;

public interface IUserRepository
{
    User? GetUserByEmail(string email);
    void Add(User user);
}
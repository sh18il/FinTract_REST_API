﻿using FinTract_REST_API.Models;

namespace FinTract_REST_API.Interfaces
{
    public interface IUserServices
    {
        Task<bool> RegisterUser(Users user);
    }
}

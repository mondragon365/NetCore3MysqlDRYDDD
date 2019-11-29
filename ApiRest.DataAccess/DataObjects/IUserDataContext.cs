using System;
using System.Collections.Generic;
using ApiRest.Entities.Models;

namespace ApiRest.DataAccess.DataObjects
{
    public interface IUserDataContext
    {
        List<User> Get();
    }
}
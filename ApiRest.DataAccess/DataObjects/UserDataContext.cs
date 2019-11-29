using System;
using System.Collections.Generic;
using System.Linq;
using ApiRest.DataAccess.Utility;
using ApiRest.Entities.Models;
using Microsoft.Extensions.Options;
using MySql.Data.MySqlClient;

namespace ApiRest.DataAccess.DataObjects
{
    public class UserDataContext:IUserDataContext
    {
        public AppDb Db { get; }
        public UserDataContext(AppDb db)
        {
            Db = db;
        }
        public List<User> Get()
        {
            List<User> list = new List<User>();
            Db.Connection.Open();
            var cmd = Db.Connection.CreateCommand();
            cmd.CommandText = @"SELECT * FROM `User` ORDER BY `Id` DESC LIMIT 10;";
            MySqlDataReader myReader;
            myReader = cmd.ExecuteReader();
            list = myReader.HydrateRows<User>().ToList();            
            return list;
        }
    }
}
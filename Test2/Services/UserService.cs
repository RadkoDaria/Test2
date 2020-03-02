using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Test2.ViewModels;
using Test2.Models;
using AutoMapper;

namespace Test2.Services
{
    public class UserService
    {
        public static List<ViewModelUser> UsersMapping()

        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<User, ViewModelUser>());
            var mapper = new Mapper(config);
            var users = mapper.Map<List<ViewModelUser>>(UserRepo.GetUsers());
            return users;
        }
        public static void Display(ViewModelUser user)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<ViewModelUser, User>());
            var mapper = new Mapper(config);
            UserRepo.AddUser(mapper.Map<User>(user));
        }
    }
}